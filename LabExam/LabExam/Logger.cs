using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam
{
    public class Logger : ILogger
    {
        public void Log(string str)
        {
                using (var stream = File.AppendText("log.txt"))
                {
                    stream.Write(str);
                }    
        }
    }
}
