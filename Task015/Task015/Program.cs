using System;
using Task015.Models;

namespace Task015
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ListInt listInt = new ListInt()
           {
               Arrey = new int[] { 1,2,3,4,5,6,7}
           };

            foreach (int i in listInt.Arrey)
            {
                Console.WriteLine(i);
            }

            listInt.Remove(1);

            Console.WriteLine("------------------");
            foreach (int i in listInt.Arrey)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------");


            listInt.RemoveRange(2, 3, 5);

            foreach (int i in listInt.Arrey)
            {
                Console.WriteLine(i);
            }
            listInt.ToString();
            Console.WriteLine("------------------------");
            listInt.Add(110);
            foreach (int i in listInt.Arrey)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------");

            listInt.AddRange(12,14,18);
            foreach(int i in listInt.Arrey)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------");
            Console.WriteLine(listInt.Contains(110));
            Console.WriteLine(listInt.Contains(111));
            Console.WriteLine(listInt.Sum());

            Console.WriteLine(listInt.ToString());
        }
    }
}
