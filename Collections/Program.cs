using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            twoMax();
            Avg();
        }

        public static Random rnd = new Random();
        public static void twoMax()
        {
            int x = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                x = rnd.Next(1, 20);
                list.Add(x);
            }
            var tmp = list.Where(c => c != list.Max()).ToList();
            int twoMax = tmp.Max();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine("\ntwo max {0} {1}", twoMax, list.IndexOf(twoMax));


            var even = list.Where(e => e % 2 == 0).ToList();
            Console.WriteLine("Без нечетных:");
            for (int i = 0; i < even.Count; i++)
            {
                Console.Write(even[i] + " ");
            }
        }

            public static void Avg()
            {
                double x = 0;
                List<double> list = new List<double>();
                for (int i = 0; i < 10; i++)
                {
                    x = rnd.Next(1, 30);
                    list.Add(x);
                }
                double avg = list.Average();
                Console.WriteLine("Изначальный список");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i] + " ");

                }

                Console.WriteLine("\nБольше среднего арифметического {0}", avg);
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > avg)
                    {
                        Console.Write(list[i] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

