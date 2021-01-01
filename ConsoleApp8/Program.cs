using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize = Convert.ToDouble(Console.ReadLine());
            double final = Convert.ToDouble(Console.ReadLine());
            double ortalama = vize * 0.4 + final * 0.6;
            if (ortalama >= 50 && final >= 50)
                Console.WriteLine("Geçtiniz,ortalama puan = " + ortalama);
            else if (ortalama < 50)
                Console.WriteLine("Kaldınız" + ortalama);
            else if (ortalama >= 50 && final < 50)
                Console.WriteLine("final notunuz 50'den küçük,Kaldınız" + ortalama);

        }
    }
}
