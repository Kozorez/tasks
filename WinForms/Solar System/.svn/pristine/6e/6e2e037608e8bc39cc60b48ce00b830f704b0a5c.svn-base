using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cannon_Battle
{
    public partial class MainForm : Form
    {
        LeftCannon left_cannon_1 = new LeftCannon();
        LeftCannon left_cannon_2 = new LeftCannon();
        LeftCannon left_cannon_3 = new LeftCannon();
        LeftCannon left_cannon_4 = new LeftCannon();

        RightCannon right_cannon_1 = new RightCannon();
        RightCannon right_cannon_2 = new RightCannon();
        RightCannon right_cannon_3 = new RightCannon();
        RightCannon right_cannon_4 = new RightCannon();

        Core core = new Core();
        
        public MainForm()
        {
            InitializeComponent();

            leftcannons.Add(left_cannon_1);
            leftcannons.Add(left_cannon_2);
            leftcannons.Add(left_cannon_3);
            leftcannons.Add(left_cannon_4);
            
            rightcannons.Add(right_cannon_1);
            rightcannons.Add(right_cannon_2);
            rightcannons.Add(right_cannon_3);
            rightcannons.Add(right_cannon_4);
        }

        bool speedisEnabled = false;
        bool angleisEnabled = false;

        Cannon choicedCannon;

        List<LeftCannon> leftcannons = new List<LeftCannon>();
        List<RightCannon> rightcannons = new List<RightCannon>();
        
        const double g = 30;

        Timer timer = new Timer();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black);
            
            e.Graphics.DrawLine(blackPen, 900, 0, 900, 688);
            
            this.Controls.Add(left_cannon_1.leftpictureBox);
            this.Controls.Add(left_cannon_2.leftpictureBox);
            this.Controls.Add(left_cannon_3.leftpictureBox);
            this.Controls.Add(left_cannon_4.leftpictureBox);

            this.Controls.Add(right_cannon_1.rightpictureBox);
            this.Controls.Add(right_cannon_2.rightpictureBox);
            this.Controls.Add(right_cannon_3.rightpictureBox);
            this.Controls.Add(right_cannon_4.rightpictureBox);

            this.Controls.Add(core.corepictureBox);
        }

        private void number_textbox_TextChanged(object sender, EventArgs e)
        {
            if (number_textbox.Text == "1" || number_textbox.Text == "2" || number_textbox.Text == "3" || number_textbox.Text == "4" || number_textbox.Text == "5" || number_textbox.Text == "6" || number_textbox.Text == "7" || number_textbox.Text == "8")
            {
                speed_textbox.Enabled = true;
            }
            else
            {
                speed_textbox.Enabled = false;
            }

            if (number_textbox.Text == "1" || number_textbox.Text == "2" || number_textbox.Text == "3" || number_textbox.Text == "4" || number_textbox.Text == "5" || number_textbox.Text == "6" || number_textbox.Text == "7" || number_textbox.Text == "8")
            {
                angle_textbox.Enabled = true;
            }
            else
            {
                angle_textbox.Enabled = false;
            }
        }

        private void speed_textbox_TextChanged(object sender, EventArgs e)
        {
            if (speed_textbox.Text != "")
            {
                if (Convert.ToDouble(speed_textbox.Text) >= 0 && Convert.ToDouble(speed_textbox.Text) <= 1000)
                {
                    speedisEnabled = true;
                }
                else
                {
                    speedisEnabled = false;
                }
            }

            if (speedisEnabled && angleisEnabled)
            {
                fire_button.Enabled = true;
            }
            else
            {
                fire_button.Enabled = false;
            }
        }

        private void angle_textbox_TextChanged(object sender, EventArgs e)
        {
            if (angle_textbox.Text != "")
            {
                if (Convert.ToDouble(angle_textbox.Text) >= -90 && Convert.ToDouble(angle_textbox.Text) <= 90)
                {
                    angleisEnabled = true;
                }
                else
                {
                    angleisEnabled = false;
                }
            }

            if (speedisEnabled && angleisEnabled)
            {
                fire_button.Enabled = true;
            }
            else
            {
                fire_button.Enabled = false;
            }
        }

        static int intervalAmount = 0;

        private void fire_button_Click(object sender, EventArgs e)
        {
            intervalAmount = 0;

            if (leftcannons.Count > 0 && rightcannons.Count > 0)
            {
                timer.Interval = 2000;
                timer.Tick += timer_Tick;
                timer.Enabled = false;

                if (Convert.ToInt32(number_textbox.Text) == 1 && leftcannons.Contains(left_cannon_1))
                {
                    choicedCannon = left_cannon_1;
                    core.corepictureBox.Location = new Point(120, 85);
                    timer.Enabled = true;
                }
                else if (Convert.ToInt32(number_textbox.Text) == 2 && leftcannons.Contains(left_cannon_2))
                {
                    choicedCannon = left_cannon_2;
                    core.corepictureBox.Location = new Point(120, 260);
                    timer.Enabled = true;
                }
                else if (Convert.ToInt32(number_textbox.Text) == 3 && leftcannons.Contains(left_cannon_3))
                {
                    choicedCannon = left_cannon_3;
                    core.corepictureBox.Location = new Point(120, 435);
                    timer.Enabled = true;
                }
                else if (Convert.ToInt32(number_textbox.Text) == 4 && leftcannons.Contains(left_cannon_4))
                {
                    choicedCannon = left_cannon_4;
                    core.corepictureBox.Location = new Point(120, 610);
                    timer.Enabled = true;
                }
                else if (Convert.ToInt32(number_textbox.Text) == 5 && rightcannons.Contains(right_cannon_1))
                {
                    choicedCannon = right_cannon_1;
                    core.corepictureBox.Location = new Point(785, 85);
                    timer.Enabled = true;
                }
                else if (Convert.ToInt32(number_textbox.Text) == 6 && rightcannons.Contains(right_cannon_2))
                {
                    choicedCannon = right_cannon_2;
                    core.corepictureBox.Location = new Point(785, 260);
                    timer.Enabled = true;
                }
                else if (Convert.ToInt32(number_textbox.Text) == 7 && rightcannons.Contains(right_cannon_3))
                {
                    choicedCannon = right_cannon_3;
                    core.corepictureBox.Location = new Point(785, 435);
                    timer.Enabled = true;
                }
                else if (Convert.ToInt32(number_textbox.Text) == 8 && rightcannons.Contains(right_cannon_4))
                {
                    choicedCannon = right_cannon_4;
                    core.corepictureBox.Location = new Point(785, 610);
                    timer.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please, choose existing cannon!");
                }
            }
            else
            {
                MessageBox.Show("Game Over!");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;

            intervalAmount++;
            
            if (choicedCannon == left_cannon_1 || choicedCannon == left_cannon_2 || choicedCannon == left_cannon_3 || choicedCannon == left_cannon_4)
            {
                x = core.corepictureBox.Location.X + (Convert.ToDouble(speed_textbox.Text) * intervalAmount * Math.Cos(Convert.ToDouble(angle_textbox.Text) * Math.PI / 180));
                y = core.corepictureBox.Location.Y - (Convert.ToDouble(speed_textbox.Text) * intervalAmount * Math.Sin(Convert.ToDouble(angle_textbox.Text) * Math.PI / 180)) + (g * Math.Pow(intervalAmount, 2) / 2);

                if (x < 0)
                {
                    x *= -1;
                }

                if (x >= 900)
                {
                    timer.Enabled = false;
                    core.corepictureBox.Visible = false;
                }
                else
                {
                    core.corepictureBox.Visible = true;
                    core.corepictureBox.Location = new Point((int)x, (int)y);
                }

                if (y < 0)
                {
                    y *= -1;
                }
            }

            else if (choicedCannon == right_cannon_1 || choicedCannon == right_cannon_2 || choicedCannon == right_cannon_3 || choicedCannon == right_cannon_4)
            {
                x = core.corepictureBox.Location.X - (Convert.ToDouble(speed_textbox.Text) * intervalAmount * Math.Cos(Convert.ToDouble(angle_textbox.Text) * Math.PI / 180));
                y = core.corepictureBox.Location.Y + (Convert.ToDouble(speed_textbox.Text) * intervalAmount * Math.Sin(Convert.ToDouble(angle_textbox.Text) * Math.PI / 180)) - (g * Math.Pow(intervalAmount, 2) / 2);

                if (x < 0)
                {
                    x *= -1;
                }

                if (x <= 0)
                {
                    timer.Enabled = false;
                    core.corepictureBox.Visible = false;
                }
                else
                {
                    core.corepictureBox.Visible = true;
                    core.corepictureBox.Location = new Point((int)x, -(int)y);
                }

                if (y < 0)
                {
                    y *= -1;
                }
            }

            if (choicedCannon == left_cannon_1 || choicedCannon == left_cannon_2 || choicedCannon == left_cannon_3 || choicedCannon == left_cannon_4)
            {
                foreach (RightCannon rightcannon in rightcannons)
                {
                    if ((x >= rightcannon.rightpictureBox.Location.X && x <= rightcannon.rightpictureBox.Location.X + rightcannon.rightpictureBox.Size.Width) && (y >= rightcannon.rightpictureBox.Location.Y && y <= rightcannon.rightpictureBox.Location.Y + rightcannon.rightpictureBox.Size.Height))
                    {
                        rightcannon.rightpictureBox.Visible = false;
                        rightcannons.Remove(rightcannon);
                        core.corepictureBox.Visible = false;
                        timer.Enabled = false;
                        break;
                    }
                }
            }
            else if (choicedCannon == right_cannon_1 || choicedCannon == right_cannon_2 || choicedCannon == right_cannon_3 || choicedCannon == right_cannon_4)
            {
                foreach (LeftCannon leftcannon in leftcannons)
                {
                    if ((x >= leftcannon.leftpictureBox.Location.X && x <= leftcannon.leftpictureBox.Location.X + leftcannon.leftpictureBox.Size.Width) && (y >= leftcannon.leftpictureBox.Location.Y && y <= leftcannon.leftpictureBox.Location.Y + leftcannon.leftpictureBox.Size.Height))
                    {
                        leftcannon.leftpictureBox.Visible = false;
                        leftcannons.Remove(leftcannon);
                        core.corepictureBox.Visible = false;
                        timer.Enabled = false;
                        break;
                    }
                }
            }
        }
    }

    public abstract class Cannon
    { }

    public class LeftCannon : Cannon
    {
        static int leftcannonCounter = 0;
        const int leftdifference = 175;

        public PictureBox leftpictureBox;

        public LeftCannon()
        {
            leftpictureBox = new PictureBox();
            leftpictureBox.Size = Cannons.Properties.Resources.left_cannon.Size;
            leftpictureBox.Image = Cannons.Properties.Resources.left_cannon;
            leftpictureBox.Location = new Point(40, 75 + leftcannonCounter * leftdifference);
            leftcannonCounter++;
        }
    }

    public class RightCannon : Cannon
    {
        static int rightcannonCounter = 0;
        const int rightdifference = 175;

        public PictureBox rightpictureBox;

        public RightCannon()
        {
            rightpictureBox = new PictureBox();
            rightpictureBox.Size = Cannons.Properties.Resources.right_cannon.Size;
            rightpictureBox.Image = Cannons.Properties.Resources.right_cannon;
            rightpictureBox.Location = new Point(800, 75 + rightcannonCounter * rightdifference);
            rightcannonCounter++;
        }
    }

    public class Core
    {
        public PictureBox corepictureBox;

        public double speed;
        public double angle;

        public Core()
        {
            corepictureBox = new PictureBox();
            corepictureBox.Size = Cannons.Properties.Resources.core.Size;
            corepictureBox.Image = Cannons.Properties.Resources.core;
            corepictureBox.Visible = false;
        }
    }
}
