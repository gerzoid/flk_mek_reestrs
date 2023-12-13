using mek.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using mek.Flk;

namespace MekTest
{
    public static class Reestr
    {
        public static TreatmentCase OpenXmlSample(TYPE_REESTR type)
        {            
            string fileNameHm = "Sample/hm20208p1623092t9.xml";
            string fileNameLm = "Sample/lm20208p1623092t9.xml";
            //Подготовленные образцы файлов реестров по типам реестров
            switch (type)
            {
                case TYPE_REESTR.X:
                    fileNameHm = "Sample/hm20208p1623092t9.xml";
                    fileNameLm = "Sample/lm20208p1623092t9.xml";
                    break;
                case TYPE_REESTR.H:
                    fileNameHm = "Sample/hm29908p012306437.xml";
                    fileNameLm = "Sample/lm29908p012306437.xml";
                    break;
                /*case TYPE_REESTR.L:
                    fileNameHm = "Sample/hm29908p012306437.xml";
                    fileNameLm = "Sample/lm29908p012306437.xml";
                    break;*/
                case TYPE_REESTR.C:
                    fileNameHm = "Sample/hm32210h44231013b.xml";
                    fileNameLm = "Sample/lm32210h44231013b.xml";
                    break;
                case TYPE_REESTR.R:
                    fileNameHm = "Sample/hm32007p01231012b.xml";
                    fileNameLm = "Sample/lm32007p01231012b.xml";
                    break;

            }


            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using XmlReader readerLm = XmlReader.Create(fileNameLm);
            //Решение в лоб
            readerLm.ReadToFollowing("PERS_LIST");
            var lm = (XElement)XNode.ReadFrom(readerLm);

            using XmlReader readerHm = XmlReader.Create(fileNameHm);
            TreatmentCase treatmentCase = new TreatmentCase() { Lm = null, Data = null, Result = new List<FlkError>() };

            //Парсим и сохраняем тэги ZGLV и SCHET            
            readerHm.ReadToFollowing("ZGLV");
            treatmentCase.Zglv = (XElement)XNode.ReadFrom(readerHm);
            readerHm.ReadToFollowing("SCHET");
            treatmentCase.Schet = (XElement)XNode.ReadFrom(readerHm);
            readerHm.ReadToFollowing("ZAP");
            treatmentCase.Data = (XElement)XNode.ReadFrom(readerHm);

            var id_pac = treatmentCase.Data.Element("PACIENT")?.Element("ID_PAC")?.Value;
            if (id_pac != null)
                treatmentCase.Lm = lm.Elements("PERS").Where(d => d.Element("ID_PAC")?.Value == id_pac).FirstOrDefault();


            readerLm.Close();
            readerHm.Close();
            readerHm.Dispose();
            return treatmentCase;
        }
    }
}
