using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ltwnc
{
    public partial class Buoi1_5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSolve_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtCoefficientA.Text);
            double b = double.Parse(txtCoefficientB.Text);
            double c = double.Parse(txtCoefficientC.Text);

            double delta = b * b - 4 * a * c;
            if (a == 0)
            {
                lblResult.Text = "Đây không phải là phương trình bậc 2";
            }
            else
            {
                if (delta < 0)
                {
                    lblResult.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    lblResult.Text = "Phương trình có nghiệm kép: x = " + x.ToString();
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    lblResult.Text = "Phương trình có hai nghiệm phân biệt: x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                }
            }
        }
    }
}