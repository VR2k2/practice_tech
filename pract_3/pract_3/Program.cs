using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            char[] arr;
            char[] inputarr;
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
                    Array.Reverse(arr);
                    string output = new string(arr);
                    string sum1;
                    sum1 = output + str;
                    Console.WriteLine(sum1);
                    StringBuilder t = new StringBuilder(sum1);
                    for (int i = 0; i < t.Length; i++)
                    {
                        char c = t[i];
                        int count = 1;
                        for (int j = i + 1; j < t.Length; j++)
                        {
                            if (c == t[j])
                            {
                                count++;
                                t.Remove(j, 1);
                                j--;
                            }
                        }
                        Console.WriteLine($"символ {c} повторяется - {count} раз(а)");
                    }
                }
                else
                {
                    string str1 = str.Substring(0, str.Length / 2);
                    string str2 = str.Substring(str.Length / 2, str.Length / 2);

                    string sum2;
                    sum2 = str1 + str2;
                    inputarr = sum2.ToCharArray();
                    Array.Reverse(inputarr);
                    string output2 = new string(inputarr);
                    Console.WriteLine(output2);
                    StringBuilder t = new StringBuilder(output2);
                    for (int i = 0; i < t.Length; i++)
                    {
                        char c = t[i];
                        int count = 1;
                        for (int j = i + 1; j < t.Length; j++)
                        {
                            if (c == t[j])
                            {
                                count++;
                                t.Remove(j, 1);
                                j--;
                            }
                        }
                        Console.WriteLine($"символ {c} повторяется - {count} раз(а)");

                    }

                }

            }

        }
    }
}
