using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsAppReadWriteFile
{
    public partial class FormReadWriteFileText : Form
    {
        public FormReadWriteFileText()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string path = @"E:\LuyentapC#\WindowsFormsAppReadWriteFile\fileText.txt";
            string msg = "";
            if (!File.Exists(path)) // If file does not exists
            {
                File.Create(path).Close(); // Create file
                using (StreamWriter sw = File.AppendText(path))
                {
                    msg = "Tạo file text thành công";
                    sw.WriteLine(txtDetail.Text); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                //File.WriteAllText(path, String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(path))
                {
                    msg = "Cập nhật file text thành công";
                    sw.WriteLine(txtDetail.Text); // Write text to .txt file
                }
            }
            MessageBox.Show(msg);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string path = @"E:\LuyentapC#\WindowsFormsAppReadWriteFile\fileText.txt";
            string msg = "";
            if (File.Exists(path))
            {
                //var a = File.ReadAllLines(path);
                using (StreamReader sr = File.OpenText(path))
                {
                    msg = "Đọc file text thành công";
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (txtDetail.Text != "")
                        {
                            txtDetail.Text += "\r\n" + line;
                        }
                        else
                        {
                            txtDetail.Text = line;
                        }

                    }
                    //txtDetail = sr.Read(); // Write text to .txt file
                }
                MessageBox.Show(msg);
            }
        }

        private void btnWriteJson_Click(object sender, EventArgs e)
        {
            string path = @"E:\LuyentapC#\WindowsFormsAppReadWriteFile\JsonFile.txt";
            string msg = "";

            User user = new User();
            user.Id = int.Parse(txtId.Text);
            user.Name = txtName.Text;
            user.Age = int.Parse(txtAge.Text);
            string jsonStr = JsonConvert.SerializeObject(user);
            if (!File.Exists(path)) // If file does not exists
            {

                File.Create(path).Close(); // Create file
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(jsonStr); // Write text to .txt file
                    msg = "Tạo file Json thành công";
                }
            }
            else // If file already exists
            {
                File.WriteAllText(path, String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(jsonStr); // Write text to .txt file
                    msg = "Cập nhật Json text thành công";
                }
            }
            MessageBox.Show(msg);
        }

        private void btnReadJson_Click(object sender, EventArgs e)
        {
            string path = @"E:\LuyentapC#\WindowsFormsAppReadWriteFile\JsonFile.txt";
            string msg = "";
            User user = new User();
            if (File.Exists(path))
            {
                //var a = File.ReadAllLines(path);
                using (StreamReader sr = File.OpenText(path))
                {

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        user = JsonConvert.DeserializeObject<User>(line);
                        txtId.Text = user.Id.ToString();
                        txtName.Text = user.Name.ToString();
                        txtAge.Text = user.Age.ToString();
                        msg = "Đọc file Json thành công";
                    }

                }
                MessageBox.Show(msg);
            }
        }

        private void btnWriteXml_Click(object sender, EventArgs e)
        {
            string path = @"E:\LuyentapC#\WindowsFormsAppReadWriteFile\XmlFile.xml";
            string msg = "";
            XmlSerializer xsSubmit = new XmlSerializer(typeof(User));
            User user = new User();
            user.Id = int.Parse(txtId.Text);
            user.Name = txtName.Text;
            user.Age = int.Parse(txtAge.Text);
            var xml = "";

            if (!File.Exists(path))
            {

                File.Create(path).Close();
                using (StreamWriter sw = File.AppendText(path))
                {
                    using (XmlWriter writer = XmlWriter.Create(sw))
                    {
                        xsSubmit.Serialize(writer, user);
                        xml = sw.ToString();
                    }
                    msg = "Tạo file Xml thành công";
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
                        xml = sw.ToString();
                    }
                    msg = "Cập nhật Xml file thành công";
                }
            }
            MessageBox.Show(msg);
        }

        private void btnReadXml_Click(object sender, EventArgs e)
        {
            string path = @"E:\LuyentapC#\WindowsFormsAppReadWriteFile\XmlFile.xml";
            string msg = "";
            XmlSerializer xsSubmit = new XmlSerializer(typeof(User));
            User user = new User();
            if (File.Exists(path))
            {
                //var a = File.ReadAllLines(path);
                using (StreamReader sr = File.OpenText(path))
                {
                    //Cach 1
                    using (XmlReader reader = XmlReader.Create(path))
                    {
                        user = (User)xsSubmit.Deserialize(reader);
                        txtId.Text = user.Id.ToString();
                        txtName.Text = user.Name.ToString();
                        txtAge.Text = user.Age.ToString();
                        msg = "Đọc file Xml thành công";
                    }

                    //Cach 2
                    //string line;
                    //while ((line = sr.ReadLine()) != null)
                    //{
                    //    using (StringReader reader = new StringReader(line))
                    //    {
                    //        user = (User)xsSubmit.Deserialize(reader);
                    //        txtId.Text = user.Id.ToString();
                    //        txtName.Text = user.Name.ToString();
                    //        txtAge.Text = user.Age.ToString();
                    //        msg = "Đọc file Xml thành công";
                    //    }
                    //}

                    //Cach 3
                    //using (StreamReader reader = new StreamReader(path))
                    //{
                    //    user = (User)xsSubmit.Deserialize(reader);
                    //    txtId.Text = user.Id.ToString();
                    //    txtName.Text = user.Name.ToString();
                    //    txtAge.Text = user.Age.ToString();
                    //    msg = "Đọc file Xml thành công";
                    //}
                }
                MessageBox.Show(msg);
            }
        }

        private void btnWriteCsv_Click(object sender, EventArgs e)
        {
            string path = @"E:\LuyentapC#\WindowsFormsAppReadWriteFile\ListUser.csv";
            string msg = "";
            List<User> users = new List<User>();
            users.Add(new User { Id = 4, Name = "Huy", Age = 20 });
            users.Add(new User { Id = 5, Name = "Minh", Age = 21 });
            users.Add(new User { Id = 6, Name = "Long", Age = 22 });
            if (!File.Exists(path))
            {
                File.Create(path).Close();

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Id" + ", " + "Name" + ", " + "Age");
                    foreach (var user in users)
                    {
                        sw.WriteLine(user.Id.ToString() + ", " + user.Name + ", " + user.Age.ToString());
                    }

                    msg = "Tạo file csv thành công";
                }
            }
            else // If file already exists
            {
                //File.WriteAllText(path, String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(path))
                {
                    msg = "Cập nhật file csv thành công";
                    foreach (var user in users)
                    {
                        sw.WriteLine(user.Id.ToString() + ", " + user.Name + ", " + user.Age.ToString());
                    }
                }
            }
            MessageBox.Show(msg);
        }

        private void btnReadCsv_Click(object sender, EventArgs e)
        {
            string path = @"E:\LuyentapC#\WindowsFormsAppReadWriteFile\ListUser.csv";
            string line;
            List<User> users = new List<User>();

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string headerLine = sr.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        var splline = line.Split(',');
                        User user = new User();
                        user.Id = int.Parse(splline[0]);
                        user.Name = splline[1].ToString();
                        user.Age = int.Parse(splline[2]);
                        users.Add(user);
                    }
                }
                grdFileCsvXlsXlxs.DataSource = users;
            }
        }

        private void BtnWriteXls_Click(object sender, EventArgs e)
        {
            string path = @"E:\LuyentapC#\WindowsFormsAppReadWriteFile\ListUser1.xlsx";
            List<User> users = new List<User>();
            users.Add(new User { Id = 4, Name = "Huy", Age = 20 });
            users.Add(new User { Id = 5, Name = "Minh", Age = 21 });
            users.Add(new User { Id = 6, Name = "Long", Age = 22 });
            GenerateExcel(ConvertToDataTable(users), path);
        }
        // T is a generic class  
        static DataTable ConvertToDataTable<T>(List<T> models)
        {
            // creating a data table instance and typed it as our incoming model   
            // as I make it generic, if you want, you can make it the model typed you want.  
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties of that model  
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Loop through all the properties              
            // Adding Column name to our datatable  
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names    
                dataTable.Columns.Add(prop.Name);
            }
            // Adding Row and its value to our dataTable  
            foreach (T item in models)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows    
                    values[i] = Props[i].GetValue(item, null);
                }
                // Finally add value to datatable    
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        public static void GenerateExcel(DataTable table, string path)
        {

            //DataSet dataSet = new DataSet();
            //dataSet.Tables.Add(table);
            // create a excel app along side with workbook and worksheet and give a name to it  
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkBook = excelApp.Workbooks.Add();
            Excel._Worksheet xlWorksheet = excelWorkBook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            //foreach (DataTable table in dataSet.Tables)
            //{
            //Add a new worksheet to workbook with the Datatable name  
            Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
            excelWorkSheet.Name = table.TableName;
            // add all the columns  
            for (int i = 1; i < table.Columns.Count + 1; i++)
            {
                excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
            }

            // add all the rows  
            for (int j = 0; j < table.Rows.Count; j++)
            {
                for (int k = 0; k < table.Columns.Count; k++)
                {
                    excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                }
            }
            //}
            // excelWorkBook.Save(); -> this is save to its default location
            if (!File.Exists(path))
            {
                excelWorkBook.SaveAs(path); // -> this will do the custom  
                excelWorkBook.Close();
                excelApp.Quit();
            }
        }
        public void GenerateExcelToObjects(string path)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkBook = excelApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = excelWorkBook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            Dictionary<string, string> dic = new Dictionary<string, string>();

            int rw = xlRange.Rows.Count;
            int cl = xlRange.Columns.Count;
            List<User> users = new List<User>();
            DataTable dt = new DataTable();

            for (int j = 0; j < rw; j++)
            {
                dt.Rows.Add();
                for (int k = 0; k < cl; k++)
                {
                    if(!dic.ContainsKey(xlRange.Cells[1, k + 1].Value2))
                    {
                        dic.Add(xlRange.Cells[1, k + 1].Value2, xlRange.Cells[1, k + 1].Value2);
                        dt.Columns.Add(xlRange.Cells[1, k + 1].Value2);
                    }
                    dt.Rows[j][k] = xlRange.Cells[j + 2, k + 1].Value2;
                }
            }


            //for (int j = 1; j < 2; j++)
            //{
            //    for (int k = 0; k < cl; k++)
            //    {
            //        dt.Columns.Add(xlRange.Cells[j, k + 1].Value);
            //    }
            //}

            //for (int j = 0; j < rw; j++)
            //{
            //    dt.Rows.Add();
            //    for (int k = 0; k < cl; k++)
            //    {
            //        dt.Rows[j][k] = xlRange.Cells[j + 2, k + 1].Value2;
            //    }
            //}

            //for (int j = 2; j <= rw; j++)
            //{
            //    dt.Rows.Add(xlRange.Cells[j, 1].Value2, xlRange.Cells[j, 2].Value2, xlRange.Cells[j, 3].Value2);
            //}
            //dt.Rows.RemoveAt(dt.Rows.Count-1);

            grdFileCsvXlsXlxs.DataSource = dt;
            grdFileCsvXlsXlxs.AllowUserToAddRows = false;
        }
        private void btnReadExcel_Click(object sender, EventArgs e)
        {
            string path = @"E:\LuyentapC#\WindowsFormsAppReadWriteFile\ListUser1.xlsx";
            GenerateExcelToObjects(path);
        }
    }
}

