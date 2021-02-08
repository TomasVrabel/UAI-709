using System;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNumber1.Text);
            var b = int.Parse(txtNumber2.Text);

            txtResult.Text = (a + b).ToString();
        }
    }
}
