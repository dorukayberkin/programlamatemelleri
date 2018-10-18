using System;


namespace Temel_Kodlama_Örnekleri
{
    public class SayiSistemDonusumleri
    {
        public static void IkilikSayiyiOnlugaCevir()
        {
        tekrar:
            Console.WriteLine("İkilik sayı sisteminde bir sayı girin");
            string sayi = Console.ReadLine();
            char[] ikilik = sayi.ToCharArray();           
            Array.Reverse(ikilik);
            foreach (char basamak in ikilik)
            {
                if ((basamak != '0') && (basamak != '1'))
                {
                    Console.WriteLine("Yanlış giriş yaptınız");
                    goto tekrar;
                }
            }
            double onluk = 0;
            int sira = 0;

            foreach (var basamak in ikilik)
            {
                onluk += Math.Pow(2, sira) * Convert.ToInt32(basamak.ToString());
                sira++;
            }
            
            Console.WriteLine("Girilen İkilik Sistemdeki Sayının Onluk Sistemdeki Kaşılığı ={0}", onluk);
            Console.ReadKey();
        }

        public static void OnlukSayiyiIkiligeCevir()
        {
            Console.WriteLine("Onluk sayı sisteminde bir sayı girin");

        }
       
    }
}