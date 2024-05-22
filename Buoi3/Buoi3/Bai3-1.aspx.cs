using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Buoi3
{
    public partial class Bai3_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNap_Click(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kecprovip\Downloads\DataKTHT (2).mdb";
            conn.Open();

            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM MON_HOC", conn);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();

            conn.Close();

        }




    }
}

