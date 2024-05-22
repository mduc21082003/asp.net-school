using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Buoi2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh0_Click(object sender, EventArgs e)
        {
            double N = int.Parse(txtN.Text);
            double sum = N * (N + 1) / 2;
            txtkq0.Text = sum.ToString();
        }
    }
}