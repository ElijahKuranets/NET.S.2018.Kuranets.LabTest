using System.IO;

namespace LabExam
{
    /// <summary>
    /// interface IPrinter 
    /// </summary>
    public interface IPrinter
    {
        void Print(FileStream fs);

        string Name { get; set; }

        string Model { get; set; }


    }
}
