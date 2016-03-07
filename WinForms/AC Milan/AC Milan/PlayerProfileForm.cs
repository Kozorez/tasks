using System;
using System.Drawing;
using System.Windows.Forms;

namespace AC_Milan
{
    public partial class PlayerProfileForm : Form
    {
        public PlayerProfileForm()
        {
            InitializeComponent();
        }

        private void PlayerProfileForm_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen1 = new Pen(Color.Black);
            Pen blackPen2 = new Pen(Color.Black, 2);

            e.Graphics.DrawLine(blackPen1, 500, 0, 500, 689);
            e.Graphics.DrawLine(blackPen1, 999, 133, 999, 620);
            e.Graphics.DrawLine(blackPen2, 500, 133, 1350, 133);
            e.Graphics.DrawLine(blackPen2, 1278, 75, 1278, 131);
            e.Graphics.DrawLine(blackPen2, 1278, 76, 1346, 76);
        }

        private void turnbackButton_Click(object sender, EventArgs e)
        {
            PlayersForm.goalkeepersList.Clear();
            PlayersForm.defendersList.Clear();
            PlayersForm.midfieldersList.Clear();
            PlayersForm.forwardsList.Clear();

            PlayersForm.playersList.Clear();

            PlayersForm.outfieldplayersList.Clear();

            Goalkeeper.startpictureboxLocationY = 20;
            Goalkeeper.startlabelLocationY = 240;

            Defender.startpictureboxLocationY = 20;
            Defender.startlabelLocationY = 240;

            Midfielder.startpictureboxLocationY = 20;
            Midfielder.startlabelLocationY = 240;

            Forward.startpictureboxLocationY = 20;
            Forward.startlabelLocationY = 240;

            this.Hide();

            MainForm mainForm = new MainForm();

            mainForm.Show();
        }

        private void gotostatsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Player player in PlayersForm.playersList)
            {
                if (player.statsButton == sender)
                {
                    if (player is Goalkeeper)
                    {
                        GoalkeeperStatsForm goalkeeperstatsForm = new GoalkeeperStatsForm();

                        goalkeeperstatsForm.Show();

                        player.statsplayerButton = goalkeeperstatsForm.playerstatssmallpictureButton;

                        goalkeeperstatsForm.Text = player.name + " " + player.surname + " | " + "2015-2016 Season Statistics";

                        goalkeeperstatsForm.playerstatssmallpictureButton.Image = player.smallPicture;

                        goalkeeperstatsForm.playerstatsfullnametextBox.Text += player.surname + "\r\n";
                        goalkeeperstatsForm.playerstatsfullnametextBox.Text += player.name;

                        player.statsButton.Click += goalkeeperstatsForm.goalkeeper_Click;

                        break;
                    }
                    else if (player is OutfieldPlayer)
                    {
                        OutfieldPlayerStatsForm outfieldplayerstatsForm = new OutfieldPlayerStatsForm();

                        outfieldplayerstatsForm.Show();

                        player.statsplayerButton = outfieldplayerstatsForm.playerstatssmallpictureButton;

                        outfieldplayerstatsForm.Text = player.name + " " + player.surname + " | " + "2015-2016 Season Statistics";

                        outfieldplayerstatsForm.playerstatssmallpictureButton.Image = player.smallPicture;

                        outfieldplayerstatsForm.playerstatsfullnametextBox.Text += player.surname + "\r\n";
                        outfieldplayerstatsForm.playerstatsfullnametextBox.Text += player.name;

                        player.statsButton.Click += outfieldplayerstatsForm.outfieldplayer_Click;

                        break;
                    }
                }
            }
        }
    }
}
