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
    public partial class _180802_2 : Form
    {
        public _180802_2()
        {
            InitializeComponent();
            Label label = new Label();
            label.Text = "Label";
            label.Location = new Point(10, 20);
            LinkLabel linklabel = new LinkLabel();
            linklabel.Text = "LinkLabel";
            linklabel.Location = new Point(10, 50);
            
            linklabel.Click += LabelClick;
            Controls.Add(label);
            Controls.Add(linklabel);
        }
        private void LabelClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}