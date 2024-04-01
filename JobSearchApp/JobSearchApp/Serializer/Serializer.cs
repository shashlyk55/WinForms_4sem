using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchApp.Serializer
{
    public class Serializer
    {
        /*public static void Serialization(Vacancy obj, string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(obj);

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(jsonData);
            }
        }
        public static void SerializationList(List<Vacancy> list, string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        public static List<Vacancy> DeserializationList(string filePath)
        {
            List<Vacancy> list = null;
            string json = File.ReadAllText(filePath);
            list = System.Text.Json.JsonSerializer.Deserialize<List<Vacancy>>(json);
            return list;
        }*/
    }
}
