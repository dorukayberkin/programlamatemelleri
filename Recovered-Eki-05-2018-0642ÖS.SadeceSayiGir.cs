using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temel_Kodlama_Örnekleri
{
    public class SadeceSayiGir
    {
        public static void SayiKontrol(string sayi)
        {
            double val = 0;
            string num = "";
            Console.Write(sayi);
            ConsoleKeyInfo chr;
           
                chr = Console.ReadKey(true);
                if (chr.Key != ConsoleKey.Backspace)
                {
                    bool control = double.TryParse(chr.KeyChar.ToString(), out val);
                    if (control)
                    {
                        num += chr.KeyChar;
                        Console.Write(chr.KeyChar);
                    }
                }
                else

                {
                    if (chr.Key == ConsoleKey.Backspace && num.Length > 0)
                    {
                        num = num.Substring(0, (num.Length - 1));
                        Console.Write("\b \b");
                    }
                }
           
        }
    }  
}
