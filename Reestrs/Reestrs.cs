using Microsoft.EntityFrameworkCore;
using Reestrs.Database;
using Reestrs.Database.Models;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Reestrs
{
    public class Reestrs
    {
        public void LoadLm(string fileName)
        {
            var xmlSerializer = new XmlSerializer(typeof(PersList));

            using (var reader = new StreamReader(fileName, Encoding.GetEncoding(1251)))
            {                
                var aaa =  (PersList)xmlSerializer.Deserialize(reader);
                using (var context = new ReestrsDbContext()) { 
                    context.Add(aaa);
                    context.SaveChanges();
                }
                Console.WriteLine(aaa.ToString());
            }           
        }

        public void LoadHm(string fileName)
        {
            var xmlSerializer = new XmlSerializer(typeof(ZL_LIST));

            using (var reader = new StreamReader(fileName, Encoding.GetEncoding(1251)))
            {
                var aaa = (ZL_LIST)xmlSerializer.Deserialize(reader);
                using (var context = new ReestrsDbContext())
                {
                    context.Add(aaa);
                    context.SaveChanges();
                }
                Console.WriteLine(aaa.ToString());
            }
        }



        public void LoadLmDataSet(string fileName)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            DataSet ds = new DataSet();

            
            ds.ReadXml(fileName);
            var sh = ds.GetXmlSchema();
            foreach ( DataTable table in ds.Tables)
            {
                Console.WriteLine(table.Rows.Count);
            }

        }

        public T MapXmlToModel<T>(XElement xmlElement) where T : new()
        {
            T model = new T();

            foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
            {
                // Находит соответствующий XML элемент с тем же именем, что и свойство модели
                XElement childElement = xmlElement.Element(propertyInfo.Name.ToUpper());

                if (childElement != null)
                {
                    object value;

                    // Если свойство Nullable<T>, используйте TypeDescriptor для преобразования
                    if (Nullable.GetUnderlyingType(propertyInfo.PropertyType) != null)
                    {
                        Type underlyingType = Nullable.GetUnderlyingType(propertyInfo.PropertyType);
                        var converter = TypeDescriptor.GetConverter(underlyingType);
                        value = converter.ConvertFromString(childElement.Value);
                    }
                    else
                    {
                        // Иначе, используйте Convert.ChangeType
                        value = Convert.ChangeType(childElement.Value, propertyInfo.PropertyType);
                    }

                    propertyInfo.SetValue(model, value);
                }
            }
            return model;
        }

    }
}
