using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var printerManager = new PrinterManager(new Logger());
            PrinterManager.OnPrinted += PrinterManager_OnPrinted;
            while (true)
            {
                printerManager.Show();
                Process(printerManager);    
            }
        }
        #region Private methods
        private static void Process(PrinterManager printerManager)
        { 
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.D1)
            {
                printerManager.CreatePrinter();
            }
            else
            {
                int choice = Convert.ToInt32(key.KeyChar.ToString()) - 2;
 
                
                printerManager.Print(printerManager.Printers[choice]);
            }
        }

        private static void PrinterManager_OnPrinted(string arg)
        {
            Console.WriteLine($"Message:{arg}");
            Console.ReadLine();
        }
        #endregion
    }
}
