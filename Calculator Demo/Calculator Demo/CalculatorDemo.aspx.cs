using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator_Demo
{
    public partial class CalculatorDemo : System.Web.UI.Page
    {
        int result = 0;
        static char state = ' ';
        static int temp1, temp2;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxResult.Attributes.Add("readonly", "readonly");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text += '1';
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text += '2';
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text += '3';
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (state != ' ')
            {
                ExecuteState(state);
                state = ' ';
            }
            state = '+';
            temp1 = Convert.ToInt32(TextBoxResult.Text.Trim());
            TextBoxResult.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text += '4';
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text += '5';
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text += '6';
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (state != ' ')
            {
                ExecuteState(state);
                state = ' ';
            }
            state = '-';
            temp1 = Convert.ToInt32(TextBoxResult.Text.Trim());
            TextBoxResult.Text = "";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text += '7';
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text += '8';
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text += '9';
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (state != ' ')
            {
                ExecuteState(state);
                state = ' ';
            }
            state = '*';
            temp1 = Convert.ToInt32(TextBoxResult.Text.Trim());
            TextBoxResult.Text = "";
        }

        protected void ButtonPoint_Click(object sender, EventArgs e)
        {
            ExecuteState(state);
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text += '0';
        }

        protected void ButtonEqual_Click(object sender, EventArgs e)
        {
            ExecuteState(state);
            state = ' ';
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (state != ' ')
            {
                ExecuteState(state);
                state = ' ';
            }
            state = '/';
            temp1 = Convert.ToInt32(TextBoxResult.Text.Trim());
            TextBoxResult.Text = "";
        }
        
        protected void ExecuteState(char stat)
        {
            if(stat == '+')
            {
                temp1 += Convert.ToInt32(TextBoxResult.Text.Trim());
                TextBoxResult.Text = temp1.ToString();
            }
            else if (stat == '-')
            {
                temp1 -= Convert.ToInt32(TextBoxResult.Text.Trim());
                TextBoxResult.Text = temp1.ToString();
            }
            else if (stat == '*')
            {
                temp1 *= Convert.ToInt32(TextBoxResult.Text.Trim());
                TextBoxResult.Text = temp1.ToString();
            }
            else if (stat == '/')
            {
                temp1 /= Convert.ToInt32(TextBoxResult.Text.Trim());
                TextBoxResult.Text = temp1.ToString();
            }
        }
    }
}