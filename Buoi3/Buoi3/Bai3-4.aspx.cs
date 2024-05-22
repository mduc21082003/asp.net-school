using System;
using System.Data;
using System.Data.OleDb;
using System.Web.UI.WebControls;

namespace Buoi3
{
    public partial class Bai3_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTable();
            }
        }

        private void LoadTable()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kecprovip\Downloads\DataKTHT (2).mdb";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM LOP", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                ddlMaLop.DataSource = reader;
                ddlMaLop.DataTextField = "MaLop";
                ddlMaLop.DataValueField = "MaLop";
                ddlMaLop.DataBind();
            }

            ddlMaLop.Items.Insert(0, new ListItem("Chọn lớp", "0"));
        }

        private void LoadClass(string MaLop)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kecprovip\Downloads\DataKTHT (2).mdb";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM SINH_VIEN WHERE MaLop = @MaLop", con);
                cmd.Parameters.AddWithValue("@MaLop", MaLop);
                con.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void ddlMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chonMaLop = ddlMaLop.SelectedValue;
            if (chonMaLop != "0")
            {
                LoadClass(chonMaLop);
            }
        }
    }
}