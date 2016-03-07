using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void conditions_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (battery_progressBar.Value > 0)
            {
                switch (conditions_comboBox.Text)
                {
                    case "Antenna_On":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.antenna_on)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        antenna_pictureBox.Image = Robot.Properties.Resources.antenna_on;
                        break;

                    case "Antenna_Off":
                        if (antenna_pictureBox.Image != null)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        antenna_pictureBox.Image = null;
                        break;

                    case "RightEye_On":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.open_eye)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        right_eye_pictureBox.Image = Robot.Properties.Resources.open_eye;
                        break;

                    case "RightEye_Off":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.close_eye)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        right_eye_pictureBox.Image = Robot.Properties.Resources.close_eye;
                        break;

                    case "LeftEye_On":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.open_eye)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        left_eye_pictureBox.Image = Robot.Properties.Resources.open_eye;
                        break;

                    case "LeftEye_Off":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.close_eye)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        left_eye_pictureBox.Image = Robot.Properties.Resources.close_eye;
                        break;

                    case "RightArm_Up":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.right_arm_up)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        right_arm_pictureBox.Image = Robot.Properties.Resources.right_arm_up;
                        break;

                    case "RightArm_Down":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.right_arm_down)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        right_arm_pictureBox.Image = Robot.Properties.Resources.right_arm_down;
                        break;

                    case "LeftArm_Up":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.left_arm_up)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        left_arm_pictureBox.Image = Robot.Properties.Resources.left_arm_up;
                        break;

                    case "LeftArm_Down":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.left_arm_down)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        left_arm_pictureBox.Image = Robot.Properties.Resources.left_arm_down;
                        break;

                    case "RightLeg_Up":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.right_leg_up)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        right_leg_pictureBox.Image = Robot.Properties.Resources.right_leg_up;
                        break;

                    case "RightLeg_Down":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.right_leg_down)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        right_leg_pictureBox.Image = Robot.Properties.Resources.right_leg_down;
                        break;

                    case "LeftLeg_Up":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.left_leg_up)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        left_leg_pictureBox.Image = Robot.Properties.Resources.left_leg_up;
                        break;

                    case "LeftLeg_Down":
                        if (antenna_pictureBox.Image != Robot.Properties.Resources.left_leg_down)
                        {
                            battery_progressBar.Increment(-10);
                        }
                        left_leg_pictureBox.Image = Robot.Properties.Resources.left_leg_down;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Unfortunately, Bender has passed away:(\nNext time feed him more, please!");
            }
        }
    }
}
