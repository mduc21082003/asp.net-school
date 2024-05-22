using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Buoi3
{
    public partial class Bai3_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNap_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kecprovip\Downloads\DataKTHT (2).mdb";
            conn.Open();

            OleDbDataAdapter sql1 = new OleDbDataAdapter("SELECT * FROM SINH_VIEN", conn);
            OleDbDataAdapter sql2 = new OleDbDataAdapter("SELECT * FROM LOP", conn);

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();


            sql1.Fill(dt1);

            GridView1.DataSource = dt1;
            GridView1.DataBind();

            sql2.Fill(dt2);

            GridView2.DataSource = dt2;
            GridView2.DataBind();

            conn.Close();
        }
    }
}