using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ltwnc
{
    public partial class Buoi1_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculateRectangleArea_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(txtLengthRectangle.Text);
            double width = Convert.ToDouble(txtWidthRectangle.Text);

            double area = length * width;

            lblRectangleAreaResult.Text = "Diện tích hình chữ nhật: " + area.ToString();
        }

        protected void btnCalculateSquareArea_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(txtSideSquare.Text);

            double area = side * side;

            lblSquareAreaResult.Text = "Diện tích hình vuông: " + area.ToString();
        }

        protected void btnCalculateCircleArea_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);

            double area = Math.PI * radius * radius;

            lblCircleAreaResult.Text = "Diện tích hình tròn: " + area.ToString();
        }
    }
}