using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning.Pages
{
    public partial class ExcelEPPlus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = "201909", d= "201912", b = "201920", c = "256209",f="20191";
            Regex rDirName2 = new Regex("^20[0-9]{2}(0[1-9]|1[012])$");
            bool aIsMatch = rDirName2.IsMatch(a);
            bool dIsMatch = rDirName2.IsMatch(d);
            bool bIsMatch = rDirName2.IsMatch(b);
            bool cIsMatch = rDirName2.IsMatch(c);
            bool fIsMatch = rDirName2.IsMatch(f);
        }

        protected void btnImport_Click(object sender, EventArgs e)
        {
            List<Tree> tree = new List<Tree>();

            using (ExcelPackage excelPackage = new ExcelPackage(fuExcel.PostedFile.InputStream))
            {
                //loop all worksheets
                foreach (ExcelWorksheet worksheet in excelPackage.Workbook.Worksheets)
                {
                    int startRow = cbFristRowIsColumnName.Checked ? 2 : worksheet.Dimension.Start.Row;
                    for (int i = startRow; i <= worksheet.Dimension.End.Row; i++)
                    {
                        tree.Add(new Tree()
                        {
                            Id = int.Parse(worksheet.Cells[i, 1].Value.ToString()),
                            Name = worksheet.Cells[i, 2].Value.ToString(),
                            ParentId = int.Parse(worksheet.Cells[i, 3].Value.ToString())
                        });
                        //loop all columns in a row
                        //for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++)
                        //{
                        //    //add the cell data to the List
                        //    if (worksheet.Cells[i, j].Value != null)
                        //    {
                        //        excelData.Add(worksheet.Cells[i, j].Value.ToString());
                        //    }
                        //}
                    }
                }

                gvTree.DataSource = tree;
                gvTree.DataBind();
            }
        }

        protected void btnImportOledb_Click(object sender, EventArgs e)
        {
            DataSet excel = ExcelToDataSet(@"D:\test.xlsx","xlsx","Sheet1",cbFristRowIsColumnName.Checked);
            gvTree.DataSource = excel;
            gvTree.DataBind();
        }

        protected DataSet ExcelToDataSet(string path,string excelType,string sheetname,bool haveHeader)
        {
            string excelConn ="";
            string header = haveHeader ? @"HDR=YES;" : @"HDR=NO;";
            if (excelType == "xls")
            {
                excelConn =  string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;{1}'",path, header);
            }
            else if(excelType == "xlsx")
            {
                excelConn = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;{1}'", path, header);
            }
            
            using (OleDbConnection conn = new OleDbConnection(excelConn))
            {
                conn.Open();
                string strExcel = "select * from [" + sheetname + "$]";
                OleDbDataAdapter oledbda = new OleDbDataAdapter(strExcel, excelConn);
                DataSet ds = new DataSet();
                oledbda.Fill(ds, sheetname);
                conn.Close();
                return ds;
            }
        }
    }
}