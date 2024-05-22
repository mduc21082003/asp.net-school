using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Buoi2
{
    public partial class Bai5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh0_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txta.Text, out int a) && int.TryParse(txtb.Text, out int b))
            {
                if (a > 0 && b > 0)
                {
                    int uscln = GCD(a, b);
                    txtkq0.Text = $"USCLN của {a} và {b} là {uscln}.";
                }
                else
                {
                    txtkq0.Text = "Vui lòng nhập hai số nguyên dương.";
                }
            }
            else
            {
                txtkq0.Text = "Vui lòng nhập hai số nguyên hợp lệ.";
            }
        }

        // Hàm tìm USCLN sử dụng thuật toán Euclid
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}