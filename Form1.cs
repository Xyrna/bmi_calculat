using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi_calculat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double height = double.Parse(textBoxHeight.Text)/100;
                double weight = double.Parse(textBoxWeight.Text);

                double bmi = (double)((int)(weight / Math.Pow(height, 2)*100))/100;
                BMI.Text = bmi.ToString();
            }
            catch
            {
                if(textBoxHeight.TextLength == 0 || textBoxWeight.TextLength == 0)
                {
                    MessageBox.Show("Fill in both fields!", "Calculation error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Enter numbers only, please!", "Calculation error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
