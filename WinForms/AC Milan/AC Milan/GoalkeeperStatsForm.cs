using System;
using System.Drawing;
using System.Windows.Forms;

namespace AC_Milan
{
    public partial class GoalkeeperStatsForm : Form
    {
        public GoalkeeperStatsForm()
        {
            InitializeComponent();
        }

        public void goalkeeper_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayerProfileForm playerprofileForm = new PlayerProfileForm();

            playerprofileForm.Show();

            foreach (Goalkeeper goalkeeper in PlayersForm.goalkeepersList)
            {
                if (goalkeeper.statsplayerButton == sender)
                {
                    playerprofileForm.Text = goalkeeper.name + " " + goalkeeper.surname;
                    playerprofileForm.largeplayerpictureBox.BackgroundImage = goalkeeper.largePicture;
                    playerprofileForm.largenationalitypictureBox.Image = goalkeeper.largenationalityPicture;
                    playerprofileForm.playersurnametextBox.Text = goalkeeper.surname;
                    playerprofileForm.playernametextBox.Text = goalkeeper.name;
                    playerprofileForm.jerseynumbertextBox.Text = goalkeeper.jerseyNumber.ToString();
                    playerprofileForm.playerpositionpictureBox.Image = goalkeeper.position;
                    playerprofileForm.playermarketvaluepictureBox.Image = goalkeeper.marketValue;
                    playerprofileForm.playermarketvaluetablepictureBox.Image = goalkeeper.marketvalueTable;
                    playerprofileForm.playerdateofbirthtextBox2.Text = goalkeeper.dateofBirth.ToShortDateString();
                    playerprofileForm.playerplaceofbirthtextBox2.Text = goalkeeper.placeofBirth;
                    playerprofileForm.playerplaceofbirthtextBox2.Size = TextRenderer.MeasureText(playerprofileForm.playerplaceofbirthtextBox2.Text, playerprofileForm.playerplaceofbirthtextBox2.Font);
                    playerprofileForm.playersmallnationalitypictureBox.Image = goalkeeper.smallnationalityPicture;
                    playerprofileForm.playersmallnationalitypictureBox.Location = new Point(playerprofileForm.playerplaceofbirthtextBox2.Location.X + playerprofileForm.playerplaceofbirthtextBox2.Size.Width, playerprofileForm.playersmallnationalitypictureBox.Location.Y);
                    playerprofileForm.playeragetextBox2.Text = goalkeeper.age.ToString();
                    playerprofileForm.playerheighttextBox2.Text = goalkeeper.height.ToString();
                    playerprofileForm.playerweighttextBox2.Text = goalkeeper.weight.ToString();
                    playerprofileForm.playerbmitextBox2.Text = goalkeeper.BMI.ToString();
                    playerprofileForm.playerintheteamsincetextBox2.Text = goalkeeper.intheteamSince.ToShortDateString();
                    playerprofileForm.playercontractuntiltextBox2.Text = goalkeeper.contractUntil.ToShortDateString();
                    playerprofileForm.playerplayersagenttextBox2.Text = goalkeeper.playersAgent;
                    playerprofileForm.playerpreferredfoottextBox2.Text = goalkeeper.preferredFoot;
                    playerprofileForm.playeroutfittertextBox2.Text = goalkeeper.outfitter;

                    goalkeeper.statsButton = playerprofileForm.gotostatsButton;

                    if (goalkeeper.name != null)
                    {
                        playerprofileForm.playernametextBox.Visible = true;
                    }
                    else
                    {
                        playerprofileForm.playersurnametextBox.Location = new Point(700, 39);
                        playerprofileForm.playernametextBox.Visible = false;
                    }

                    break;
                }
            }
        }
    }
}
