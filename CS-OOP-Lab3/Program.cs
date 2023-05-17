using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CS_OOP_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass(10, "Object 1");
            obj1.Display();
            string filePath = "F://data.json";
            obj1.SaveToJsonFile(filePath);
            Console.WriteLine("Object saved to JSON file");

            MyClass obj2 = MyClass.LoadFromJsonFile(filePath);
            if (obj2 != null)
            {
                Console.WriteLine("Object loaded from JSON file:");
                obj2.Display();
            }

            Console.ReadKey();
        }
    }
}
