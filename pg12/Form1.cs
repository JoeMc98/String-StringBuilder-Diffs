using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stringButton_Click(object sender, EventArgs e)
        {
            /*
             when working with strings you must remeber that strings are
             constants. They cannot be changed and in order to manipulate
             them you must tell the computer what to do to that string
             and assign it to a new instance of a string
             */
            string myString = labelString.Text;
            string newString = myString.Insert(myString.Length, "\r\nHello World! I am a string!!!");
            labelString.Text = newString;
        }

        private void sBuilderButton_Click(object sender, EventArgs e)
        {
            /*
             StringBuilder's are similar to strings but you may perform
             actions directly on the StringBuilder object. Unlike a
             string you do not have to create a new instance of a 
             StringBuilder if you want to manipulate the text. The
             StringBuilder class has built in functionality that allows 
             developers to manipulate the text directly.
             */
            StringBuilder sb = new StringBuilder();
            sb.Insert(0, labelStringBuilder.Text, 1);
            sb.Insert(sb.Length, "\r\nHello World! I am a StringBuilder!!!");
            labelStringBuilder.Text = sb.ToString();
        }
    }
}
