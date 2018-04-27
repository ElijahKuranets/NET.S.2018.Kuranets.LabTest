using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LabExam
{
    internal class PrinterManager
    {
        public delegate void PrinterDelegate(string arg);
        public static event PrinterDelegate OnPrinted;
        private readonly ILogger _logger;
        public PrinterManager(ILogger logger)
        {
            _logger = logger??throw new ArgumentException(nameof(logger));
            Printers = new List<Printer>() { new CanonPrinter(), new EpsonPrinter() };
        }

        public List<Printer> Printers { get; set; }

        public void Show()
        {
            Console.Clear();            
            Console.WriteLine("Select your choice:");
            Console.WriteLine("1. Add new printer");
            for (int i = 0; i < Printers.Count; ++i)
            {
                Console.WriteLine($"{i + 2}. Print on {Printers[i].Name}");
            }
        }

        public void Print(IPrinter p1)
        {
            _logger.Log("Print started");
            var o = new OpenFileDialog();
            o.ShowDialog();

            using ( var f = File.OpenRead(o.FileName))
            {
                p1.Print(f);
                _logger.Log("Print finished");
                OnPrinted("Printed!");
            }

            _logger.Log($"Printed on {p1.Name}");
        }
        
        public void CreatePrinter()
        {
            Add(new Printer());
        }

        private void Add(Printer p1)
        {
            Console.WriteLine(" Enter printer name");
            p1.Name = Console.ReadLine();
            Console.WriteLine(" Enter printer model");
            p1.Model = Console.ReadLine();

            if (!Printers.Contains(p1))
            {
                Printers.Add(p1);
            }
        }
    }
}