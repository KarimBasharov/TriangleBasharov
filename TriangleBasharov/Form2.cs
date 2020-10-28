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
        Button btn, btn2;
        ListView listView1 = new ListView();
        RadioButton r1;
        TextBox txtbox2, txtbox3, txtbox4, txtbox5;
        Label lbl;
        Graphics gp;
        Panel panel1;
        Pen p = new Pen(Brushes.Black, 2);
        //CheckBox c1;
        public Form2()
        {
            {
                this.Height = 834;
                this.Width = 410;
                InitializeComponent();
                panel1 = new Panel()
                {
                    Location = new Point(400, 100),
                    Width = 200,
                    Height = 200
                };

                gp = panel1.CreateGraphics();
                this.BackgroundImage = Image.FromFile("kletka.jpg");

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
                //listView1.BackgroundImage = Image.FromFile("kletka.jpg");
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
                    Text = "Сторона а",
                    Location = new Point(91, 216),
                    Width = 76,
                    Height = 20
                };
                txtbox2.MouseClick += Txtbox2_MouseClick;
                this.Controls.Add(txtbox2);

                /*c1 = new CheckBox
                {
                    Text = "Нарисовать треугольник",
                    Location = new Point(470, 345),
                    Width = 200,
                    Height = 20
                };
                this.Controls.Add(c1);*/

                txtbox3 = new TextBox
                {
                    Text = "Сторона b",
                    Location = new Point(171, 216),
                    Width = 76,
                    Height = 20
                };
                txtbox3.MouseClick += Txtbox2_MouseClick;
                this.Controls.Add(txtbox3);

                txtbox4 = new TextBox
                {
                    Text = "Сторона c",
                    Location = new Point(251, 216),
                    Width = 76,
                    Height = 20
                };
                txtbox4.MouseClick += Txtbox2_MouseClick;
                this.Controls.Add(txtbox4);

                txtbox5 = new TextBox
                {
                    Text = "Радиус r",
                    Location = new Point(331, 216),
                    Width = 50,
                    Height = 20
                };
                txtbox5.MouseClick += Txtbox2_MouseClick;
                this.Controls.Add(txtbox5);

                lbl = new Label
                {
                    Location = new Point(460, 9),
                    Text = "Треугольник",
                    Width = 72,
                    Height = 13
                };

                this.Controls.Add(lbl);
                btn2 = new Button
                {
                    Text = "Нарисовать треугольник",
                    Location = new Point(470, 345),
                    Width = 150
                };
                btn2.Click += Btn2_Click;
                this.Controls.Add(btn2);
                this.Controls.Add(panel1);
                MainMenu menu = new MainMenu();
                MenuItem menuitem1 = new MenuItem("File");
                menuitem1.MenuItems.Add("Restart", new EventHandler(menuitem1_Restart));
                menu.MenuItems.Add(menuitem1);
                this.Menu = menu;

            }
        }

        private void Txtbox2_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = String.Empty;
        }

        private void menuitem1_Restart(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void Btn2_Click(object sender, EventArgs e)
        {

            Point p1 = new Point(5, 90);
            Point p2 = new Point(150, 90);
            Point p3 = new Point(75, 1);

            gp.DrawLine(p ,p1, p2);
            gp.DrawLine(p, p2, p3);
            gp.DrawLine(p, p3, p1);
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
            listView1.Items.Add("альфа");
            listView1.Items.Add("бета");
            listView1.Items.Add("гамма");
            listView1.Items.Add("Найти c");
            listView1.Items.Add("Найти a");
            listView1.Items.Add("Найти b");
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
                listView1.Items[7].SubItems.Add(Convert.ToString(triangle.alpha()));
                listView1.Items[8].SubItems.Add(Convert.ToString(triangle.beta()));
                listView1.Items[9].SubItems.Add(Convert.ToString(triangle.gamma()));
                listView1.Items[10].SubItems.Add(Convert.ToString(triangle.Pif1()));
                listView1.Items[11].SubItems.Add(Convert.ToString(triangle.Pif2()));
                listView1.Items[12].SubItems.Add(Convert.ToString(triangle.Pif3()));
                //listView1.Items[10].SubItems.Add(Convert.ToString(triangle.Sin()));
            }
            catch (FormatException)
            {
                MessageBox.Show("Напишите число", "Ошибка");
            }

        }
    }
    
}
