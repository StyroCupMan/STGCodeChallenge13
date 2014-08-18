using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STGCodeChallenge13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Input;

            if (int.TryParse(txtInput.Text, out Input))
            {
                long? Result = Factorial(Input);
                MessageBox.Show(string.Format("{0}! = {1}", Input, Result.HasValue ? Result.ToString() : "null"));
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private long? Factorial(int Input)
        {
            if (Input < 0)
            {
                return null;
            }
            else if (Input == 0 || Input == 1)
            {
                return 1;
            }
            else
            {
                return Input * Factorial(Input - 1);
            }
        }
    }
}
