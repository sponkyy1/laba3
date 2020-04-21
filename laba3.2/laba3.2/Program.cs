using System;
using System.IO;
using System.Text;
namespace laba3._2
{
    class Test
    {
        public static void Main()
        {
            string path = @"C:\Users\yuras\Desktop\2-Семестр\oop\laba3\laba3.2\out.txt";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }

            string str;
            string text = ""; //Рядки для розбору виразу      
            string[] arrStr = new string[2];
            Console.WriteLine("input string");
            str = Console.ReadLine() + Environment.NewLine;
            string[] split = str.Split(new Char[] { '!' });
            int i = 0;
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {

                    Console.WriteLine(s);
                    arrStr[i] = s;
                    i++;
                    text = s;
                }
            }
            File.AppendAllText(path, text);
            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}