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
    public partial class _180803_1 : Form
    {
        public _180803_1()
        {
            InitializeComponent();
            Button button = new Button();
            button.Text = "ex";
            button.Click += delegate (object sender, EventArgs args) { MessageBox.Show("delegater"); };
            button.Click += (sender, args) => { MessageBox.Show("lambda"); };
            Controls.Add(button);
        }
    }
}