using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class _180802_1 : Form
    {
        class CustomForm : Form
        {

        }
        public _180802_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.Show();

            MessageBox.Show("subject");
            MessageBox.Show("subject", "title");
            //MessageBox.Show("subject", "title", MessageBoxButtons.RetryCancel);
            DialogResult result;
            do
            {
                result = MessageBox.Show("subject", "title", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);
        }
    }
}