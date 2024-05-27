using System;
using System.Data;
using System.Data.OleDb;

namespace Buoi5
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

        private OleDbConnection connectDataBase()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kecprovip\OneDrive\Documents\DataOnTap.accdb";
            return new OleDbConnection(connectionString);
        }

        private void LoadTable()
        {
            using (OleDbConnection conn = connectDataBase())
            {
                string query = "SELECT * FROM Hang";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                ddlMaHang.DataSource = reader;
                ddlMaHang.DataTextField = "MaHang";
                ddlMaHang.DataValueField = "MaHang";
                ddlMaHang.DataBind();
            }
            ddlMaHang.Items.Insert(0, "Chọn mã hàng");

        }

        //Load data từ dropdownlist
        private void LoadData(string MaHang)
        {
            using (OleDbConnection conn = connectDataBase())
            {
                string query = "SELECT * FROM Hang WHERE MaHang = @MaHang";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", MaHang);
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gvTatCa.DataSource = dt;
                gvTatCa.DataBind();
                if (dt.Rows.Count > 0)
                {
                    txtTenHang.Text = dt.Rows[0]["TenHang"].ToString();
                    txtDonGia.Text = dt.Rows[0]["DonGia"].ToString();
                    txtDonViTinh.Text = dt.Rows[0]["DonViTinh"].ToString();
                    conn.Close();
                }
            }
        }

        protected void ddlMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chonMaHang = ddlMaHang.SelectedValue;
            if (chonMaHang != "0")
            {
                LoadData(chonMaHang);
            }
        }

        protected void btnHienThi_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = connectDataBase())
            {
                string query1 = "SELECT * FROM Hang INNER JOIN PhieuXuat ON Hang.MaHang = PhieuXuat.MaHang";
                OleDbCommand cmd1 = new OleDbCommand(query1, conn);

                conn.Open();

                OleDbDataAdapter adapter1 = new OleDbDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                gvTatCa.DataSource = dt1;
                gvTatCa.DataBind();
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;
            string tenHang = txtTenHang.Text;
            string donGia = txtDonGia.Text;
            string donViTinh = txtDonViTinh.Text;

            using (OleDbConnection conn = connectDataBase())
            {
                string query = "INSERT INTO Hang (maHang, tenHang, donGia, donViTinh) VALUES (@MaHang, @TenHang, @DonGia, @DonViTinh)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", maHang);
                cmd.Parameters.AddWithValue("@TenHang", tenHang);
                cmd.Parameters.AddWithValue("@DonGia", donGia);
                cmd.Parameters.AddWithValue("@DonViTinh", donViTinh);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            txtMaHang.Text = String.Empty;
            txtTenHang.Text = String.Empty;
            txtDonGia.Text = String.Empty;
            txtDonViTinh.Text = String.Empty;

            LoadTable();
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            string maHang = ddlMaHang.SelectedValue;
            string tenHang = txtTenHang.Text;
            string donGia = txtDonGia.Text;
            string donViTinh = txtDonViTinh.Text;

            using (OleDbConnection conn = connectDataBase())
            {
                string query = "UPDATE Hang SET TenHang = @TenHang, DonGia = @DonGia, DonViTinh = @DonViTinh WHERE MaHang = @MaHang";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenHang", tenHang);
                cmd.Parameters.AddWithValue("@DonGia", donGia);
                cmd.Parameters.AddWithValue("@DonViTinh", donViTinh);
                cmd.Parameters.AddWithValue("@MaHang", maHang);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadTable();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            string maHang = ddlMaHang.SelectedValue;
            string tenHang = txtTenHang.Text;
            string donGia = txtDonGia.Text;
            string donViTinh = txtDonViTinh.Text;

            using (OleDbConnection conn = connectDataBase())
            {
                string query = "DELETE FROM Hang WHERE MaHang = @MaHang";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", maHang);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            txtTenHang.Text = String.Empty;
            txtDonGia.Text = String.Empty;
            txtDonViTinh.Text = String.Empty;
            LoadTable();
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim();

            using (OleDbConnection conn = connectDataBase())
            {
                string query = "SELECT * FROM Hang WHERE MaHang LIKE @SearchText OR TenHang LIKE @SearchText";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gvTatCa.DataSource = dt;
                gvTatCa.DataBind();
            }
        }
    }
}