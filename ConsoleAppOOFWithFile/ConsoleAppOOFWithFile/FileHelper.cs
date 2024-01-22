using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOFWithFile
{
    public abstract class FileHelper :IPropertiesHelper
    {
        public string? Path { get; set; }
        public abstract void ReadFileHelper();
        public abstract void WriteFileHelper();
    }
}
