using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOFWithFile
{
    public class JsonFileHelper : TextFileHelper
    {
        public List<User> Users { get; set; }
        public override void ReadFileHelper()
        {
            string? path = "";
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

        public override void WriteFileHelper()
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
