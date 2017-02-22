using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            string firstStr = firstValue.Text;
            string secondStr = secondValue.Text;
            int firstNum = int.Parse(firstStr);
            int secondNum = int.Parse(secondStr);

            int resultNumber;

            checked
            {
                resultNumber = firstNum + secondNum;
            }

            result.Text = resultNumber.ToString();
        }

        protected void subtract_Click(object sender, EventArgs e)
        {
            string firstStr = firstValue.Text;
            string secondStr = secondValue.Text;
            int firstNum = int.Parse(firstStr);
            int secondNum = int.Parse(secondStr);

            int resultNumber;

            checked
            {
                resultNumber = firstNum - secondNum;
            }

            result.Text = resultNumber.ToString();
        }

        protected void mult_Click(object sender, EventArgs e)
        {
            string firstStr = firstValue.Text;
            string secondStr = secondValue.Text;
            int firstNum = int.Parse(firstStr);
            int secondNum = int.Parse(secondStr);

            int resultNumber;

            checked
            {
                resultNumber = firstNum * secondNum;
            }

            result.Text = resultNumber.ToString();
        }

        protected void divide_Click(object sender, EventArgs e)
        {
            string firstStr = firstValue.Text;
            string secondStr = secondValue.Text;
            double firstNum = double.Parse(firstStr);
            double secondNum = double.Parse(secondStr);

            double resultNumber;

            checked
            {
                resultNumber = firstNum / secondNum;
            }

            result.Text = resultNumber.ToString();
        }
    }
}