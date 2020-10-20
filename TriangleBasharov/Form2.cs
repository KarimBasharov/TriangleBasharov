using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleBasharov
{
    public partial class Form2 : Form
    {
        Button btn = new Button();
        ListView listView1 = new ListView();
        RadioButton r1;
        TextBox txtbox2, txtbox3, txtbox4, txtbox5;
        public Form2()
        {
            {
                this.Height = 834;
                this.Width = 410;
                InitializeComponent();
                this.BackgroundImage = Image.FromFile("kletka.jpg");

                btn = new Button();
                btn.Text = "Решить";
                btn.Location = new Point(11, 240);
                btn.Height = 94;
                btn.Width = 176;
                btn.Click += Btn_Click;
                this.Controls.Add(btn);

                listView1 = new ListView();
                listView1.Location = new Point(10, 10);
                listView1.View = View.Details;
                listView1.Columns.Add("Найти", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Решение", -2, HorizontalAlignment.Left);
                listView1.Height = 201;
                listView1.Width = 370;
                this.Controls.Add(listView1);

                r1 = new RadioButton();
                r1.Text = "Что Найти";
                r1.Location = new Point(11, 216);
                r1.Width = 80;
                r1.CheckedChanged += R1_CheckedChanged;
                this.Controls.Add(r1);

                txtbox2 = new TextBox();
                txtbox2.Location = new Point(91, 216);
                txtbox2.Width = 76;
                txtbox2.Height = 20;
                this.Controls.Add(txtbox2);

                txtbox3 = new TextBox();
                txtbox3.Location = new Point(171, 216);
                txtbox3.Width = 76;
                txtbox3.Height = 20;
                this.Controls.Add(txtbox3);

                txtbox4 = new TextBox();
                txtbox4.Location = new Point(251, 216);
                txtbox4.Width = 76;
                txtbox4.Height = 20;
                this.Controls.Add(txtbox4);

                txtbox5 = new TextBox();
                txtbox5.Location = new Point(331, 216);
                txtbox5.Width = 50;
                txtbox5.Height = 20;
                this.Controls.Add(txtbox5);
            }
        }

        private void R1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Add("Сторону a");
            listView1.Items.Add("Сторону b");
            listView1.Items.Add("Сторону c");
            listView1.Items.Add("Радиус r");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Высоту");
            //listView1.Items.Add("Существует?");
            //listView1.Items.Add("Спецификатор");
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            double a, b, c, r;
            try
            {
                int result = Int32.Parse(txtbox2.Text);
                a = Convert.ToDouble(txtbox2.Text);
                b = Convert.ToDouble(txtbox3.Text);
                c = Convert.ToDouble(txtbox4.Text);
                r = Convert.ToDouble(txtbox5.Text);
                Triangle triangle = new Triangle(a, b, c, r);
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(triangle.outputR());
            }
            catch (FormatException)
            {
                MessageBox.Show("Напишите число", "Ошибка");
            }

        }
    }
    
}
