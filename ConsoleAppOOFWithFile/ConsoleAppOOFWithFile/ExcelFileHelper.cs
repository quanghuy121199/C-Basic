using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOFWithFile
{
    public static class ExcelFileHelper
    {
        public static DataSet GetDataSetFromExcelFile(byte[] file, bool includeHeader, string extension)
        {
            DataSet dsexcelRecords = new DataSet();
            IExcelDataReader reader = null;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (Stream FileStream = new MemoryStream(file))
            {
                if (file != null && FileStream != null)
                {
                    if (extension.Trim().ToLower() == ".xls")
                    {
                        reader = ExcelReaderFactory.CreateBinaryReader(FileStream);
                    }
                    else if (extension.Trim().ToLower() == ".xlsx")
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(FileStream);
                    }
                    else if (extension.Trim().ToLower() == ".csv")
                    {
                        reader = ExcelReaderFactory.CreateCsvReader(FileStream);
                    }
                }
                if (reader != null)
                {
                    dsexcelRecords = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = includeHeader,
                        }
                    });
                    reader.Close();
                }
            }
            return dsexcelRecords;
        }
        public static List<string> GetDataFromDataset(DataSet ds)
        {
            List<string> ls = new List<string>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataTable dtb in ds.Tables)
                {
                    ls.AddRange(GetDataFromDataTable(dtb));
                }
            }
            return ls;
        }
        public static IEnumerable<string> GetDataFromDataTable(DataTable dtb)
        {
            foreach (DataRow oRow in dtb.Rows)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                foreach (DataColumn oCol in dtb.Columns)
                {
                    dic[oCol.ColumnName] = $"{oRow[oCol]}";
                }
                yield return System.Text.Json.JsonSerializer.Serialize(dic);
            }
        }
    }
}
