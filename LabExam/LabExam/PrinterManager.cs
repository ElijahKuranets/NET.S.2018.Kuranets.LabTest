using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LabExam
{
    internal static class PrinterManager
    {
        public delegate void PrinterDelegate(string arg);
        public static event PrinterDelegate OnPrinted;

        static PrinterManager()
        {
            Printers = new List<object>();
        }

        public static List<object> Printers { get; set; }

        public static void Add(Printer p1)
        {
            Console.WriteLine("Enter printer name");
            p1.Name = Console.ReadLine();
            Console.WriteLine("Enter printer model");
            p1.Model = Console.ReadLine();

            if (!Printers.Contains(p1))
            {
                Printers.Add(p1);
                Console.WriteLine("Printer added");
            }
        }
        /// <summary>
        /// method print for printers.
        /// </summary>
        /// <param name="p1"></param>
        public static void Print(Printer p1)
        {
            Log("Print started");
            var o = new OpenFileDialog();
            o.ShowDialog();
            var f = File.OpenRead(o.FileName);
            p1.Print(f);
            Log("Print finished");
            f.Close();
            OnPrinted("Printed!"); 
        }

        public static void Log(string s)
        {
            File.AppendText("log.txt").Write(s);
        }     
    }
}