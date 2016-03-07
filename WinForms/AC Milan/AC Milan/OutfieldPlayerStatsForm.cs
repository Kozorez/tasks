using System;
using System.Drawing;
using System.Windows.Forms;

namespace AC_Milan
{
    public partial class OutfieldPlayerStatsForm : Form
    {
        public OutfieldPlayerStatsForm()
        {
            InitializeComponent();
        }

        public void outfieldplayer_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayerProfileForm playerprofileForm = new PlayerProfileForm();

            playerprofileForm.Show();

            foreach (OutfieldPlayer outfieldPlayer in PlayersForm.outfieldplayersList)
            {
                if (outfieldPlayer.statsplayerButton == sender)
                {
                    playerprofileForm.Text = outfieldPlayer.name + " " + outfieldPlayer.surname;
                    playerprofileForm.largeplayerpictureBox.BackgroundImage = outfieldPlayer.largePicture;
                    playerprofileForm.largenationalitypictureBox.Image = outfieldPlayer.largenationalityPicture;
                    playerprofileForm.playersurnametextBox.Text = outfieldPlayer.surname;
                    playerprofileForm.playernametextBox.Text = outfieldPlayer.name;
                    playerprofileForm.jerseynumbertextBox.Text = outfieldPlayer.jerseyNumber.ToString();
                    playerprofileForm.playerpositionpictureBox.Image = outfieldPlayer.position;
                    playerprofileForm.playermarketvaluepictureBox.Image = outfieldPlayer.marketValue;
                    playerprofileForm.playermarketvaluetablepictureBox.Image = outfieldPlayer.marketvalueTable;
                    playerprofileForm.playerdateofbirthtextBox2.Text = outfieldPlayer.dateofBirth.ToShortDateString();
                    playerprofileForm.playerplaceofbirthtextBox2.Text = outfieldPlayer.placeofBirth;
                    playerprofileForm.playerplaceofbirthtextBox2.Size = TextRenderer.MeasureText(playerprofileForm.playerplaceofbirthtextBox2.Text, playerprofileForm.playerplaceofbirthtextBox2.Font);
                    playerprofileForm.playersmallnationalitypictureBox.Image = outfieldPlayer.smallnationalityPicture;
                    playerprofileForm.playersmallnationalitypictureBox.Location = new Point(playerprofileForm.playerplaceofbirthtextBox2.Location.X + playerprofileForm.playerplaceofbirthtextBox2.Size.Width, playerprofileForm.playersmallnationalitypictureBox.Location.Y);
                    playerprofileForm.playeragetextBox2.Text = outfieldPlayer.age.ToString();
                    playerprofileForm.playerheighttextBox2.Text = outfieldPlayer.height.ToString();
                    playerprofileForm.playerweighttextBox2.Text = outfieldPlayer.weight.ToString();
                    playerprofileForm.playerbmitextBox2.Text = outfieldPlayer.BMI.ToString();
                    playerprofileForm.playerintheteamsincetextBox2.Text = outfieldPlayer.intheteamSince.ToShortDateString();
                    playerprofileForm.playercontractuntiltextBox2.Text = outfieldPlayer.contractUntil.ToShortDateString();
                    playerprofileForm.playerplayersagenttextBox2.Text = outfieldPlayer.playersAgent;
                    playerprofileForm.playerpreferredfoottextBox2.Text = outfieldPlayer.preferredFoot;
                    playerprofileForm.playeroutfittertextBox2.Text = outfieldPlayer.outfitter;

                    outfieldPlayer.statsButton = playerprofileForm.gotostatsButton;

                    if (outfieldPlayer.name != null)
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
