using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ltwnc
{
    public partial class Buoi1_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSolveLinear_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            if (a != 0)
            {
                double x = -b / a;
                lblLinearResult.Text = "Nghiệm của phương trình: x = " + x.ToString();
            }
            else
            {
                lblLinearResult.Text = "Phương trình vô nghiệm hoặc vô số nghiệm.";
            }
        }
    }
}