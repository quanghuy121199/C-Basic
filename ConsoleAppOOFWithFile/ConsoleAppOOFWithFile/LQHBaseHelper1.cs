using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace ConsoleAppOOFWithFile
{
    public class LQHBaseHelper1 : JsonFileHelper
    {
        public void ReadFileText()
        {
            TextFileHelper a = new TextFileHelper();

            a.ReadFileHelper();
        }
        public void ReadFileJson()
        {
            base.ReadFileHelper();
        }
    }
}
