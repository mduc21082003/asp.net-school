using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ltwnc
{
    public partial class Bai1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtNumber1.Text);
            double number2 = Convert.ToDouble(txtNumber2.Text);
            double number3 = Convert.ToDouble(txtNumber3.Text);

            double average = (number1 + number2 + number3) / 3;

            lblResult.Text = "Trung bình cộng: " + average.ToString();
        }
    }
}