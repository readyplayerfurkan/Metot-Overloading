using System;

namespace MetotOverloading
{
    class Solution
    {
        static void Main(string[] args)
        {
            //out parametler

            string sayi = "Başarılı";

            bool sonuc = int.TryParse(sayi, out int outSayi);

            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(sayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar ornekMetot = new Metotlar();
            ornekMetot.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            int veri = 999;
            ornekMetot.EkranaYazdir(veri);
            ornekMetot.EkranaYazdir("Furkan", "Yılmaz");
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int sonuc)
        {
            sonuc = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }

    }
}