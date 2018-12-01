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
    public partial class _180802_3 : Form
    {
        public _180802_3()
        {
            InitializeComponent();
            productBindingSource.Add(new Product() { name = "a", Price = 10 });
            productBindingSource.Add(new Product() { name = "b", Price = 11 });
            productBindingSource.Add(new Product() { name = "c", Price = 12 });
            productBindingSource.Add(new Product() { name = "d", Price = 13 });
            productBindingSource.Add(new Product() { name = "e", Price = 14 });
        }
        
        private void _180802_3_Load(object sender, EventArgs e)
        {

        }
    }
}