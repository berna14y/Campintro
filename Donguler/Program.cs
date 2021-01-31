using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelistirici Yetistirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            // bu kursları teker teker yazmak çok mantıklı değil o yüzden döngü kullanmak daha mantıklı ve tek tek yazmamak için arraylarde kursları tutucaz

            // array - dizi 

            string[] kurslar = new string[] { "Yazılım Gelistirici Yetistirme Kampı", "Programlamaya başlangıç için temel kurs", "java" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) //dizileri tek tek kolay dolaşmak için
            {
                Console.WriteLine(kurs);
            }

                Console.WriteLine("sayfa sonu");
        }

	
    }
}
