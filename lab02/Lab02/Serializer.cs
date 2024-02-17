using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Collections;

namespace Lab02
{
    internal class Serializer
    {
        public static void Serialization(Discipline obj, string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(obj);
            
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(jsonData);
            }
        }
        public static void SerializationList(List<Discipline> list, string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        public static List<Discipline> DeserializationList(string filePath)
        {
            List<Discipline> list = null;
            string json = File.ReadAllText(filePath);
            list = System.Text.Json.JsonSerializer.Deserialize<List<Discipline>>(json);
            return list;
        }
    }
}
