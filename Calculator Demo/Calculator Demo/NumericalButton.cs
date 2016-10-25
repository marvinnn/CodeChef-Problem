using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Demo
{
    class NumericalButton : System.Web.UI.WebControls.Button
    {
        private System.Web.UI.WebControls.TextBox textBox;
        private char text;
        private void printText(char text)
        {
            textBox.Text += text;
        }
        private NumericalButton(System.Web.UI.WebControls.TextBox tb, char txt)
        {
            this.textBox = tb;
            this.text = txt;
        }
    }
}
