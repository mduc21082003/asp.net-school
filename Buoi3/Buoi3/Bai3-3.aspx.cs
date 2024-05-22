using System;
using System.Data;
using System.Data.OleDb;

namespace Buoi3
{
    public partial class Bai3_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                int soDVHT;
                if (!int.TryParse(TextBox1.Text, out soDVHT))
                {
                    return;
                }

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kecprovip\Downloads\DataKTHT (2).mdb";
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {

                    string query = "SELECT * FROM MON_HOC WHERE SoDVHT > ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@SoDVHT", soDVHT);

                        conn.Open();
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }
    }
}