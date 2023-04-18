using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            char[] arr;
            arr = str.ToCharArray();
            bool f = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'a' || str[i] > 'z')
                {
                    Console.Write(str[i]);
                    f = true;
                }

            }

            if (f == true)
            {
                Console.WriteLine("\nОшибка! Введены вышеперечисленные не подходящие символы");
            }
            else
            {
                Console.WriteLine("Результат: ");

                if (arr.Length % 2 != 0)
                {
                    Console.Write(str.Reverse().ToArray());
                    Console.WriteLine(str);
                }

                else
                {
                    string str1 = str.Substring(0, str.Length / 2);
                    string str2 = str.Substring(str.Length / 2, str.Length / 2);

                    Console.Write(str1.Reverse().ToArray());
                    Console.WriteLine(str2.Reverse().ToArray());
                }
            }
        }
    }
}

