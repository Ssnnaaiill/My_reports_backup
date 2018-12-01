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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyButton.Text = "코드에서 변경";
            MyButton.Width = 100;
            /* Button button = new Button();
            Controls.Add(button);
            button.Location = new Point(13, 13 + 23 + 3);
            button.Text = "동적생성";
            */
            List<Button> buttons = new List<Button>();
            for(int i = 0; i < 5; i++)
            {
                buttons.Add(new Button());
                Controls.Add(buttons[i]);
                buttons[i].Location = new Point(13, 50 + (i * 30));
                buttons[i].Text = "동적생성 " + i;
            }
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            TextBox text = new TextBox();
            text.Text = "**********";
            Controls.Add(text);
            text.Location = new Point(120, 14);
        }
        private int elapsedtime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedtime++;
            textBox1.Text = elapsedtime + "초 경과";
            label1.Text = elapsedtime + "초 경과";
        }
    }
}