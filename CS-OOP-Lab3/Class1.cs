using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOP_Lab3
{
    public class MyClass
    {
        public int number;
        public string name;

        public MyClass(int number, string name)
        {
            this.number = number;
            this.name = name;
        }

        public MyClass()
        {
            number = 0;
            name = "Default";
        }

        ~MyClass()
        {
            Console.WriteLine("Об'єкт видалено");
        }

        public void Display()
        {
            Console.WriteLine($"Номер: {number}, Назва: {name}");
        }
        public void SaveToJsonFile(string filePath)
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(filePath, json);
        }
        public static MyClass LoadFromJsonFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist");
                return null;
            }

            try
            {
                string json = File.ReadAllText(filePath);
                MyClass obj = JsonConvert.DeserializeObject<MyClass>(json);
                return obj;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to deserialize JSON: {ex.Message}");
                return null;
            }
        }
    }
}
