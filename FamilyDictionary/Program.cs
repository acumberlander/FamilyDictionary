using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });



            foreach(var member in myFamily)
            {
                var name = member.Value["name"];
                var sister = member.Key;
                var age = member.Value["age"];

                Console.WriteLine($"{name} is my {sister} and is {age} years old.");
                Console.ReadLine();
            }
        }
    }
}
