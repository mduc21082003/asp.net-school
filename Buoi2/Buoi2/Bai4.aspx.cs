using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Buoi2
{
    public partial class Bai4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh0_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu đầu vào là một số nguyên hợp lệ
            if (int.TryParse(txtN1.Text, out int N))
            {
                // Kiểm tra N có lớn hơn 0 không
                if (N > 0)
                {
                    List<int> primes = GetPrimes(N);
                    txtkq2.Text = string.Join(", ", primes);
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

        // Hàm kiểm tra số nguyên tố
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

        // Hàm lấy danh sách các số nguyên tố từ 1 đến N
        private List<int> GetPrimes(int N)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i <= N; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
    }
}