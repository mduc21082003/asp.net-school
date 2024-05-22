using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Buoi2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh0_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN1.Text, out int N))
            {
                if (N > 0)
                {
                    bool isPrime = IsPrime(N);
                    if (isPrime)
                    {
                        txtkq2.Text = $"{N} là số nguyên tố.";
                    }
                    else
                    {
                        txtkq2.Text = $"{N} không phải là số nguyên tố.";
                    }
                }
                else
                {
                    txtkq2.Text = "Vui lòng nhập một số nguyên dương.";
                }
            }
            else
            {
                txtkq2.Text = "Vui lòng nhập một số nguyên hợp lệ.";
            }
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}