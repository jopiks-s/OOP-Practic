using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        public static List<int> Sort(List<int> list, bool asc = true)
        {
            bool change = false;
            do
            {
                change = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    Predicate<int> compare = asc ?
                    (left) => list[i] > left :
                    (left) => list[i] < left;
                    if (compare(list[i+1]))
                    {
                        int a = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = a;
                        change = true;
                    }
                }
            } while (change);
            return list;
        }

        public static List<T> Sort<T>(List<T> list, bool asc = true) where T: IComparable
        {
            bool change = false;
            do
            {
                change = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    bool ifi = (Convert.ToInt32(asc) * 2 - 1) * list[i].CompareTo(list[i + 1]) > 0;
                    if (ifi)
                    {
                        T a = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = a;
                        change = true;
                    }
                }
            } while (change);
            return list;
        }    
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 2, 3, 423, -1, 14 };
            List<string> strings = new List<string>() { "ab", "aa", "1c" };
            List<double> f = new List<double>() { 1.1, -7.8, 99.99, 13.45};

            num = Sort(num);
            strings = Sort<string>(strings);
            f = Sort<double>(f, false);

            num.ForEach((a) => { Console.Write($"{a} "); });
            Console.WriteLine();
            strings.ForEach((a) => { Console.Write($"{a} "); });
            Console.WriteLine();
            f.ForEach((a) => { Console.Write($"{a} "); });
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
