using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите документ: HML, DOC, TXT");
            string format = Console.ReadLine();
            AbstractHandler handler = null;

            switch (format.ToUpper())
            {
                case "XML":
                    handler = new HMLHandler();
                    break;
                case "DOC":
                    handler = new DOCHandler();
                    break;
                case "TXT":
                    handler = new TXTHandler();
                    break;
                default:
                    Console.WriteLine("Неподерж. формат документа");
                    return;
            }
            handler.Open();
            handler.Change();
            handler.Create();
            handler.Save();
            Console.ReadLine();

            
        }
    }
}
