using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um novo Nokia
            Nokia nokia = new Nokia("1234567890", "Nokia X20", "1234567890123456", 128);
            Iphone i1 = new Iphone("156455949", "Iphone 10", "15464941321326", 64);

            // Instala um aplicativo
            Console.WriteLine("Smartphone Nokia: ");
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");

            Console.WriteLine("\n");
            i1.ReceberLigacao();
            i1.InstalarAplicativo("Telegram");


        }
    }
}