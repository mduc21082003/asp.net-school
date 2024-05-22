using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Buoi2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh0_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN0.Text, out int N))
            {
                // Kiểm tra N có lớn hơn hoặc bằng 2 không
                if (N >= 2)
                {
                    double product = 1;
                    for (int i = 2; i <= N; i++)
                    {
                        product *= i;
                    }
                    txtkq1.Text = product.ToString();
                }
                else
                {
                    txtkq1.Text = "Vui lòng nhập số N lớn hơn hoặc bằng 2.";
                }
            }
            else
            {
                txtkq1.Text = "Vui lòng nhập một số nguyên hợp lệ.";
            }
        }
    }
}