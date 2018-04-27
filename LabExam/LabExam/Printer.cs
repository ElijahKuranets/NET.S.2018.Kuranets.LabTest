using System;
using System.IO;

namespace LabExam
{   /// <summary>
    /// 1.Change from Printer struct to class;
    /// 2.Add method Print;
    /// </summary>
    internal class Printer : IPrinter
    {

        public void Print(FileStream fs)
        {
            for (int i = 0; i < fs.Length; i++)
            {
                // simulate printing
                Console.WriteLine(fs.ReadByte());
            }
        }

        public string Name { get; set; }

        public string Model { get; set; }

       
    }
}