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
    public class LQHBaseHelper
    {
        public string? Path { get; set; }
        public List<User> Users { get; set; }
        public string TableName { get; set; }
        public void ReadFileExcel()
        {
            string path = "";
            if (!string.IsNullOrEmpty(this.Path)) path = this.Path;
            FileInfo file = new FileInfo(path);
            byte[] bFile = File.ReadAllBytes(path);
            DataSet dts = ExcelFileHelper.GetDataSetFromExcelFile(bFile, true, file.Extension);
            string tableName = "";
            if (!string.IsNullOrEmpty(this.TableName))
            {
                tableName = this.TableName;
                DataTable dt = dts.Tables[this.TableName];
                if (dt != null)
                {
                    Console.WriteLine($"File excel có {dt.Rows.Count} user");
                    foreach (DataRow row in dt.Rows)
                    {
                        Dictionary<string, string> dic = new Dictionary<string, string>();
                        foreach (DataColumn col in dt.Columns)
                        {
                            dic[col.ColumnName] = $"{row[col]}";
                        }
                        var data = System.Text.Json.JsonSerializer.Serialize(dic);
                        Console.WriteLine(data);
                    }
                }
                else
                {
                    Console.WriteLine("File not exist user");
                }
            }
            else
            {
                Console.WriteLine("Please Choose Table Name");
            }
        }
        public void ReadFileJson()
        {
            string path = "";
            if (!string.IsNullOrEmpty(this.Path)) path = this.Path;
            if (File.Exists(path))
            {
                var text = File.ReadAllText(path).Trim().Replace(" ", "").Replace("\r\n", "").Replace("\t", "");
                List<User>? users = new List<User>();
                if (users != null)
                {
                    users = JsonConvert.DeserializeObject<List<User>>(text);
                    Console.WriteLine("-------------------");
                    Console.WriteLine("| Id | Name | Age |");
                    foreach (var user in users)
                    {
                        int.TryParse(user.Id.ToString(), out int rs);
                        int.TryParse(user.Age.ToString(), out int rs1);

                        var strId = "";
                        var strName = "";
                        var strAge = "";

                        if (rs.ToString().Length < nameof(user.Id).Length)
                        {
                            strId = "| " + rs.ToString() + string.Format($"{{0,{nameof(user.Id).Length + 1}}}", "|");
                        }
                        else if (rs.ToString().Length == nameof(user.Id).Length)
                        {
                            strId = "| " + rs.ToString() + " |";
                        }

                        if (user.Name.Length < nameof(user.Name).Length)
                        {
                            strName = " " + user.Name + "  |";
                        }
                        else if (user.Name.Length == nameof(user.Name).Length)
                        {
                            strName = " " + user.Name + " |";
                        }

                        if (rs1.ToString().Length < nameof(user.Age).Length)
                        {
                            strAge = " " + rs1.ToString() + "  |";
                        }
                        else if (rs1.ToString().Length == nameof(user.Age).Length)
                        {
                            strAge = " " + rs1.ToString() + " |";
                        }

                        Console.WriteLine(strId + strName + strAge);
                    }
                    Console.WriteLine($"----------Total:{users.Count}-|");
                }
            }
        }

        public void ReadFileText()
        {
            string path = "";
            if (!string.IsNullOrEmpty(this.Path)) path = this.Path;

            if (File.Exists(path))
            {
                //var a = File.ReadAllLines(path);
                using (StreamReader sr = File.OpenText(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }

        public void ReadFileXml()
        {
            string path = "";
            if (!string.IsNullOrEmpty(this.Path)) path = this.Path;
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    using (XmlReader reader = XmlReader.Create(path))
                    {
                        while (reader.Read())
                        {
                            switch (reader.NodeType)
                            {
                                case XmlNodeType.Whitespace:
                                    if (reader.Value.ToString() == "\n")
                                        Console.WriteLine();
                                    if (reader.Value.ToString() == "\n\t")
                                    {
                                        Console.Write("\n\t");
                                    }
                                    if (reader.Value.ToString() == "\n\t\t")
                                    {
                                        Console.Write("\n\t\t");
                                    }
                                    break;
                                case XmlNodeType.Element: // The node is an element.
                                    Console.Write("<" + reader.Name);
                                    while (reader.MoveToNextAttribute()) // Read the attributes.
                                    {
                                        Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                                    }
                                    Console.Write(">");
                                    //Console.WriteLine(">");

                                    break;
                                case XmlNodeType.Text: //Display the text in each element.
                                    Console.Write(reader.Value);
                                    break;
                                case XmlNodeType.EndElement: //Display the end of the element.
                                    Console.Write("</" + reader.Name);
                                    Console.WriteLine(">");
                                    break;
                            }
                        }
                    }
                }
                Console.ReadLine();
            }
        }

        public void WriteFileExcel()
        {
            throw new NotImplementedException();
        }

        public void WriteFileJson()
        {
            string path = "";
            if (!string.IsNullOrEmpty(this.Path)) path = this.Path;
            List<User> users = new List<User>();
            users = this.Users;
            string jsonStr = JsonConvert.SerializeObject(users);
            if (!File.Exists(path)) // If file does not exists
            {

                File.Create(path).Close(); // Create file
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(jsonStr); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                File.WriteAllText(path, String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(jsonStr); // Write text to .txt file
                }
            }
        }

        public void WriteFileText()
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

        public void WriteFileXml()
        {
            string path = "";
            if (!string.IsNullOrEmpty(this.Path)) path = this.Path;
            XmlSerializer xsSubmit = new XmlSerializer(typeof(User));
            User user = new User();
            user.Id = int.Parse("1");
            user.Name = "Huy2";
            user.Age = int.Parse("25");
            var xml = "";

            if (!File.Exists(path))
            {

                File.Create(path).Close();
                using (StreamWriter sw = File.AppendText(path))
                {
                    using (XmlWriter writer = XmlWriter.Create(sw))
                    {
                        xsSubmit.Serialize(writer, user);
                        //xml = sw.ToString();
                    }
                }
            }
            else // If file already exists
            {
                File.WriteAllText(path, String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(path))
                {
                    using (XmlWriter writer = XmlWriter.Create(sw))
                    {
                        xsSubmit.Serialize(writer, user);
                        //xml = sw.ToString();
                    }
                }
            }
        }

        public static void StringReadLine(StreamWriter sw, string text)
        {
            string line = "";
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
