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
    public partial class convertingExample : Form
    {
        public convertingExample()
        {
            InitializeComponent();
            /*TextBox textbox = new TextBox();
            textbox.Location = new Point(Width / 2 - 50, Height / 2 - 50);
            Controls.Add(textbox);

            Button b1 = new Button();
            b1.Text = "inch to cm";
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = (Convert.ToDouble(textBox1.Text) * 2.54).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToDouble(textBox3.Text) * 2.20462).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = (Convert.ToDouble(textBox5.Text) * 2 * 3.14159265358979).ToString();
            textBox7.Text = (Convert.ToDouble(textBox5.Text) * (Convert.ToDouble(textBox5.Text) * 3.14159265358979)).ToString();
        }
    }
}
