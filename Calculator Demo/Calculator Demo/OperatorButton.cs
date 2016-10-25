using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator_Demo
{
    public class OperatorButton : System.Web.UI.WebControls.Button
    {
        private System.Web.UI.WebControls.TextBox textBox;
        private char text;
        private void printText(char text)
        {
            textBox.Text += text;
        }
        private OperatorButton(System.Web.UI.WebControls.TextBox tb, char txt)
        {
            this.textBox = tb;
            this.text = txt;
        }
    }
}