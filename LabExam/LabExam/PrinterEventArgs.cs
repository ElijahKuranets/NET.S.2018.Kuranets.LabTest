using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam
{
    public class PrinterEventArgs : EventArgs
    {
        public readonly string msg;
        public PrinterEventArgs(string message)
        {
            msg = message;
        }
    }
}
