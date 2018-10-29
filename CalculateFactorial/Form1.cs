using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateFactorial
{
    public partial class FactorialCalculator : Form
    {
        public FactorialCalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            long number = Convert.ToInt64(NumberTextBox.Text);
            long factorial = number;

            if (IsLong(NumberTextBox.Text))
            {
                const byte minNum = 1;
                const byte maxNum = 20;


            }

            for (int i = 1; i < number; i++)
            {
                factorial = factorial * i;
            }

            FactorialTextBox.Text = factorial.ToString("N0");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
