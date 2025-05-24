using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int sonuc;
            string cevap;

            Console.WriteLine("Hesap makinesine hoş geldiniz!");
            Console.WriteLine("İlk numaranızı giriniz:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci numaranızı giriniz:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ne tarz bir işlem yapmak istersiniz?");
            Console.WriteLine("Toplama için: t | Çıkarma için: ç | Çarpma için: x | Bölme için: b");

            cevap = Console.ReadLine();

            if (cevap == "t")
            {
                sonuc = num1 + num2;
            }
            else if (cevap == "ç")
            {
                sonuc = num1 - num2;
            }
            else if (cevap == "x")
            {
                sonuc = num1 * num2;
            }
            else if (cevap == "b")
            {
                if (num2 != 0)
                {
                    sonuc = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Sıfıra bölme hatası!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz işlem seçildi.");
                return;
            }

            Console.WriteLine("Cevap: " + sonuc);
            Console.ReadKey();
        }
    }
}
