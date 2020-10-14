using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleBasharov
{
    public partial class Form2 : Form
    {
        Button btn = new Button();
        public Form2()
        {
            {
                this.Height = 600;
                this.Width = 700;
                InitializeComponent();
                this.BackgroundImage = Image.FromFile("kletka.jpg");
                btn = new Button();
                btn.Text = "Решить";
                btn.Location = new Point(10, 150);
                btn.Height = 40;
                btn.Width = 120;
                btn.Click += Btn_Click;
                this.Controls.Add(btn);
                ListView listView1 = new ListView();
                listView1.Location = new Point(0, 0);
                listView1.View = View.Details;
                listView1.Columns.Add("Найти", 20, HorizontalAlignment.Left);
                listView1.Columns.Add("Решение", 20, HorizontalAlignment.Left);
                this.Controls.Add(listView1);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

        }
    }
    
}
