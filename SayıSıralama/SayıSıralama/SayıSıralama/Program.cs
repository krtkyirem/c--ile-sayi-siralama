using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıSıralama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            int ara;
            Console.Write("Sıralanacak sayıları giriniz :\n");
            for (int i = 0; i < 5; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int t = 0; t < 5; t++)
                {
                    if (sayilar[t]>sayilar[i])
                    {
                        ara = sayilar[i];
                        sayilar[i] = sayilar[t];
                        sayilar[t] = ara;
                    }
                }
            }
            foreach (int t in sayilar)
            {
                Console.Write(" - {0} - ",t );
            }
            Console.ReadKey();
        }
    }
}
