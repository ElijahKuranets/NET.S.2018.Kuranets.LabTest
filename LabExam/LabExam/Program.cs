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
            Console.WriteLine("Select your choice: \n1:Add new printer\n2:Print on Canon\n3:Print on Epson\n");
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.D1)
            {
                CreatePrinter();
            }

            if (key.Key == ConsoleKey.D2)
            {
                Print(new CanonPrinter());
            }

            if (key.Key == ConsoleKey.D3)
            {
                Print(new EpsonPrinter());
            }

            while (true)
            {
                // waiting
            }
        }

        private static void Print(EpsonPrinter epsonPrinter)
        {
            PrinterManager.Print(epsonPrinter);
            PrinterManager.Log("Printed on Epson");
        }

        private static void Print(CanonPrinter canonPrinter)
        {
            PrinterManager.Print(canonPrinter);
            PrinterManager.Log("Printed on Canon");
        }

        private static void CreatePrinter()
        {
            PrinterManager.Add(new Printer());
        }
    }
}
