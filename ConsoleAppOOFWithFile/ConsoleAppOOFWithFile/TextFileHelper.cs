using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOFWithFile
{
    public class TextFileHelper : FileHelper
    {
        public override void ReadFileHelper()
        {
            string? path = "";
            if (!string.IsNullOrEmpty(this.Path)) path = this.Path;

            if (File.Exists(path))
            {
                //var a = File.ReadAllLines(path);
                using (StreamReader sr = File.OpenText(path))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }

        public override void WriteFileHelper()
        {
            string path = "";
            if (!string.IsNullOrEmpty(this.Path)) path = this.Path;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Điền đoạn text cần ghi: ");
            string? textStr = "";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                using (StreamWriter sw = File.AppendText(path))
                {
                    StringReadLine(sw, textStr);
                }
            }
            else
            {
                //File.WriteAllText(path, String.Empty);
                using (StreamWriter sw = File.AppendText(path))
                {
                    StringReadLine(sw, textStr);
                }
            }
        }

        public static void StringReadLine(StreamWriter sw, string text)
        {
            string? line = "";
            if ((line = Console.ReadLine()) == "~")
            {
                sw.WriteLine(text);
            }
            else
            {
                if (text == "")
                {
                    text = line;
                }
                else
                {
                    text += "\r\n" + line;
                }
                StringReadLine(sw, text);
            }
        }
    }
}
