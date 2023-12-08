using mek.Rules;
using mek.Utils;
using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace mek.Flk
{
    internal partial class Flk
    {
        string pathExtractDirectory = "c:\\!mek\\tmp";
        string _hmFileName = "";
        string _lmFileName = "";


        FlkRules? rules;        //Правила проверки каждого случая в реестре
        FlkRules? globalRules;  //Глобальные проверки файла XML на один раз


        /// <summary>
        /// Регистрация правил подходящих под проверку типа реестра
        /// </summary>
        /// <param name="typeFile">Тип реестра</param>
        void RegisterChains(Type typeFile)
        {
            rules = new FlkRules();
            globalRules = new FlkRules();

            // Получаем все сборки в текущем домене приложения
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            // Ищем все унаследованные типы
            var derivedTypes = assemblies.SelectMany(a => a.GetTypes())
                                         .Where(t => typeFile.IsAssignableFrom(t) && t != typeFile)
                                         .ToList();

            //Создаем цепочку проверок для нашего типа реестра
            foreach (var derivedType in derivedTypes)
            {
                if (typeof(IGlobalRule).IsAssignableFrom(derivedType))
                    globalRules.AddHandler((IHandler)Activator.CreateInstance(derivedType));
                else
                    rules.AddHandler((IHandler)Activator.CreateInstance(derivedType));
            }
        }

        /// <summary>
        /// Обработка цепочки правил
        /// </summary>
        /// <returns>TreatmentCase</returns>
        public TreatmentCase ProcessRules(string path, string hmFileName, string lmFileName)
        {

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            //Файл пасопртных данных
            using XmlReader readerLm = XmlReader.Create(@$"{path}\{lmFileName}");
            readerLm.ReadToFollowing("PERS_LIST");
            var lm = (XElement)XElement.ReadFrom(readerLm);

            TreatmentCase treatmentCase = new TreatmentCase() { Lm = null, Data = null, Result = new List<FlkError>() };

            using XmlReader readerHm = XmlReader.Create(@$"{pathExtractDirectory}\{_hmFileName}");            

            //Парсим и сохраняем тэги ZGLV и SCHET для передачи в процедуру проверки для каждого случая
            readerHm.ReadToFollowing("ZGLV");
            treatmentCase.Zglv = (XElement)XElement.ReadFrom(readerHm);
            readerHm.ReadToFollowing("SCHET");
            treatmentCase.Schet = (XElement)XElement.ReadFrom(readerHm);

            int cnt = 0;

            while (!readerHm.EOF)
            {
                if (readerHm.Name != "ZAP")
                    readerHm.ReadToFollowing("ZAP");
                if (!readerHm.EOF)
                {
                    XElement zap = (XElement)XElement.ReadFrom(readerHm);

                    var id_pac = zap.Element("PACIENT")?.Element("ID_PAC")?.Value;
                    if (id_pac != null)
                        treatmentCase.Lm = lm.Elements("PERS").Where(d => d.Element("ID_PAC")?.Value == id_pac).FirstOrDefault();

                    treatmentCase.Data = zap;
                    cnt++;
                    rules?.Start(treatmentCase);
                }
            }            

            globalRules?.Start(treatmentCase);
            lm = null;

            return treatmentCase;

        }
    }
}
