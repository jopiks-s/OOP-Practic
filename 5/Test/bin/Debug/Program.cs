using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
          
            Console.WriteLine("Ім'я файлу:");
            string filename = Console.ReadLine();

            FileInfo fileInfo = new FileInfo(filename);

            if (!fileInfo.Exists)
            {
                Console.WriteLine("Файл не знайдено");
                return;
            }
            string code;
            using (StreamReader reader = fileInfo.OpenText())
            {
                code = reader.ReadToEnd();
            }

            //Console.WriteLine("Код у файлі: \n");

            //Console.WriteLine(code);

            Regex regex = new Regex(@"/\*(.|[\r\n])*?\*/|(//.*)", RegexOptions.Multiline);
            MatchCollection matches = regex.Matches(code);

            Console.WriteLine($"\nКількість знайдених коментарів : {matches.Count}");

            foreach (Match match in matches)
            {
                Console.WriteLine($"{match}");
            }

            Console.ReadLine();
        }

    }
}
