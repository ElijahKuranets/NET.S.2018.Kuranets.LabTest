using System;
using System.IO;

namespace LabExam
{
    /// <summary>
    /// Printer Epson
    /// </summary>
    internal class EpsonPrinter : Printer
    {
        public EpsonPrinter()
        {
            Model = "231";
            Name = "Epson";
        }
    }
}