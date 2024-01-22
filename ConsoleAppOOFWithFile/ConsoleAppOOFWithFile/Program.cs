using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOFWithFile
{
    public class Program
    {
        public static void Main()
        {
            RunHelper run = new RunHelper();
            //run.Path = "E:\\GitCSharpBasic\\File\\fileText1.txt";
            //run.ReadFileText();
            //run.WriteFileText();

            //run.Path = "E:\\GitCSharpBasic\\File\\fileTextJson.txt";
            //User user = new User();
            //user.Id = 1;
            //user.Name = "Huy";
            //user.Age = 20;
            //List<User> users = new List<User>();
            //users.Add(user);
            //run.Users = users;
            //run.WriteFileJson();
            //run.ReadFileJson();

            //run.Path = "E:\\GitCSharpBasic\\File\\filexml3.xml";
            //run.ReadFileXml();
            //run.WriteFileXml();

            run.Path = "E:\\GitCSharpBasic\\File\\ListUser1.xlsx";
            run.TableName = "User";
            run.ReadFileExcel();


        }
    }
}
