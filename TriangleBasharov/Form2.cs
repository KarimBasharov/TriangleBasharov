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
        Label lbl;
        //CheckBox c1, c2, c3;
        public Form2()
        {
            {
                this.Height = 834;
                this.Width = 410;
                InitializeComponent();
                //this.BackgroundImage = Image.FromFile("kletka.jpg");

                btn = new Button
                {
                    Text = "Решить",
                    Location = new Point(11, 240),
                    Height = 94,
                    Width = 176
                };
                btn.Click += Btn_Click;
                this.Controls.Add(btn);

                listView1 = new ListView
                {
                    Location = new Point(10, 10),
                    View = View.Details
                };
                listView1.Columns.Add("Значения", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Решение", -2, HorizontalAlignment.Left);
                listView1.Height = 201;
                listView1.Width = 370;
                listView1.BackgroundImage = Image.FromFile("kletka.jpg");
                this.Controls.Add(listView1);

                r1 = new RadioButton
                {
                    Text = "Значения",
                    Location = new Point(11, 216),
                    Width = 80
                };
                r1.CheckedChanged += R1_CheckedChanged;
                this.Controls.Add(r1);

                txtbox2 = new TextBox
                {
                    Location = new Point(91, 216),
                    Width = 76,
                    Height = 20
                };
                this.Controls.Add(txtbox2);

                /*c2 = new CheckBox();
                c2.Text = "b";
                c2.Location = new Point(171, 216);
                c2.Width = 76;
                c2.Height = 20;

                c3 = new CheckBox();
                c3.Text = "c";
                c3.Location = new Point(251, 216);
                c3.Width = 76;
                c3.Height = 20;*/

                txtbox3 = new TextBox
                {
                    Location = new Point(171, 216),
                    Width = 76,
                    Height = 20
                };
                this.Controls.Add(txtbox3);

                txtbox4 = new TextBox
                {
                    Location = new Point(251, 216),
                    Width = 76,
                    Height = 20
                };
                this.Controls.Add(txtbox4);

                txtbox5 = new TextBox
                {
                    Location = new Point(331, 216),
                    Width = 50,
                    Height = 20
                };
                this.Controls.Add(txtbox5);

                lbl = new Label
                {
                    Location = new Point(460, 9),
                    Text = "Треугольник",
                    Width = 72,
                    Height = 13
                };
                this.Controls.Add(lbl);
            }
        }

        private void R1_CheckedChanged(object sender, EventArgs e)
        {
            /*this.Controls.Add(c1);
            this.Controls.Add(c2);
            this.Controls.Add(c3);*/
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Радиус r");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Высота");
            listView1.Items.Add("Найти c");
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
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Surface()));
                listView1.Items[6].SubItems.Add(Convert.ToString(triangle.Height()));
                listView1.Items[7].SubItems.Add(Convert.ToString(triangle.Pif1()));
            }
            catch (FormatException)
            {
                MessageBox.Show("Напишите число", "Ошибка");
            }

        }
    }
    
}
