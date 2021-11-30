using System;

namespace _4._1massivodnomer4varvisoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] m1 = new int[7];
            int[] m2 = new int[9];
            int[] m3 = new int[16];
            Console.WriteLine("Введите область массива от 1 до ");
            int ob = int.Parse(Console.ReadLine());
            for (int i = 0; i < m1.Length; i++)
                m1[i] = r.Next(1, ob);
            for (int i = 0; i < m2.Length; i++)
                m2[i] = r.Next(1, ob);
            Console.WriteLine("массив 1 ");
            foreach (int digit in m1)
                Console.WriteLine("{0,3}", digit);
            Console.WriteLine("массив 2 ");
            foreach (int digit in m2)
                Console.WriteLine("{0,3}", digit);
            Array.Copy(m1, 0, m3, 0, 7);
            Array.Copy(m2, 0, m3, 7, 9);
            Array.Sort(m3);
            Array.Reverse(m3);
            Console.WriteLine("1 и 2 массив убывание");
            foreach (int digit in m3)
                Console.Write("{0,3}", digit);
            
        }
    }
}
