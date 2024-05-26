using System;
using System.Data;
using System.Data.OleDb;

namespace Buoi4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTable();
            }
        }

        private OleDbConnection GetDatabaseConnection()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kecprovip\Downloads\DataKTHT (2).mdb";
            return new OleDbConnection(connectionString);
        }


        private void LoadTable()
        {
            using (OleDbConnection conn = GetDatabaseConnection())
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM MON_HOC", conn);
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                DropDownList1.DataSource = reader;
                DropDownList1.DataTextField = "MaMon";
                DropDownList1.DataValueField = "MaMon";
                DropDownList1.DataBind();
            }
            DropDownList1.Items.Insert(0, "Chọn mã môn");
        }

        private void LoadClass(string MaMon)
        {
            using (OleDbConnection conn = GetDatabaseConnection())
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM MON_HOC WHERE MaMon = @MaMon", conn);
                cmd.Parameters.AddWithValue("@MaMon", MaMon);
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if (dt.Rows.Count > 0)
                {
                    TextBox2.Text = dt.Rows[0]["TenMon"].ToString();
                    TextBox3.Text = dt.Rows[0]["SoDVHT"].ToString();
                    conn.Close();
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chonMaMon = DropDownList1.SelectedValue;
            if (chonMaMon != "0")
            {
                LoadClass(chonMaMon);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string maMon = TextBox4.Text;
            string tenMon = TextBox2.Text;
            string soDVHT = TextBox3.Text;

            using (OleDbConnection conn = GetDatabaseConnection())
            {
                OleDbCommand cmd = new OleDbCommand("INSERT INTO MON_HOC (MaMon, TenMon, SoDVHT) VALUES (@MaMon, @TenMon, @SoDVHT)", conn);
                cmd.Parameters.AddWithValue("@MaMon", maMon);
                cmd.Parameters.AddWithValue("@TenMon", tenMon);
                cmd.Parameters.AddWithValue("@SoDVHT", soDVHT);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            TextBox4.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;

            LoadTable();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string maMon = DropDownList1.SelectedValue;
            string tenMon = TextBox2.Text;
            string soDVHT = TextBox3.Text;

            using (OleDbConnection conn = GetDatabaseConnection())
            {
                OleDbCommand cmd = new OleDbCommand("UPDATE MON_HOC SET TenMon = @TenMon, SoDVHT = @SoDVHT WHERE MaMon = @MaMon", conn);
                cmd.Parameters.AddWithValue("@TenMon", tenMon);
                cmd.Parameters.AddWithValue("@SoDVHT", soDVHT);
                cmd.Parameters.AddWithValue("@MaMon", maMon);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            LoadTable();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string maMon = DropDownList1.SelectedValue;
            string tenMon = TextBox2.Text;
            string soDVHT = TextBox3.Text;

            using (OleDbConnection conn = GetDatabaseConnection())
            {
                OleDbCommand cmd = new OleDbCommand("DELETE FROM MON_HOC WHERE MaMon = @MaMon", conn);
                cmd.Parameters.AddWithValue("@MaMon", maMon);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;

            LoadTable();
        }
    }
}