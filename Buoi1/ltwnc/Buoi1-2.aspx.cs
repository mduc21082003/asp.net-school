using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ltwnc
{
    public partial class Buoi1_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculateTriangle_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtSideA.Text);
            double b = Convert.ToDouble(txtSideB.Text);
            double c = Convert.ToDouble(txtSideC.Text);

            double perimeter = a + b + c;

            lblTriangleResult.Text = "Chu vi tam giác: " + perimeter.ToString();
        }

        protected void btnCalculateRectangle_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(txtLength.Text);
            double width = Convert.ToDouble(txtWidth.Text);

            double perimeter = 2 * (length + width);

            lblRectangleResult.Text = "Chu vi hình chữ nhật: " + perimeter.ToString();
        }

        protected void btnCalculateSquare_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(txtSideSquare.Text);

            double perimeter = 4 * side;

            lblSquareResult.Text = "Chu vi hình vuông: " + perimeter.ToString();
        }
    }
}