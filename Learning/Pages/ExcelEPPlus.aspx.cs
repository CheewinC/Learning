using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning.Pages
{
    public partial class ExcelEPPlus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            DataSet excel = ExcelToDataSet(@"D:\test.xls","xls","Tree",cbFristRowIsColumnName.Checked);
            gvTree.DataSource = excel;
            gvTree.DataBind();
        }

        protected DataSet ExcelToDataSet(string path,string excelType,string sheetname,bool haveHeader)
        {
            string excelConn ="";
            if (excelType == "xls")
            {
                excelConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=Excel 8.0;";
            }
            else if(excelType == "xlsx")
            {
                excelConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;";
            }
            //excelConn += haveHeader ? @"HDR=YES;" : "HDR=NO;";
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