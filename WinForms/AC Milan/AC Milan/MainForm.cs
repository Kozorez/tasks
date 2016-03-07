using System;
using System.Drawing;
using System.Windows.Forms;

namespace AC_Milan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void goalkeepersButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayersForm playersForm = new PlayersForm();

            playersForm.Show();

            playersForm.Text = "AC Milan Goalkeepers";

            int i = 0;

            foreach (Goalkeeper goalkeeper in PlayersForm.goalkeepersList)
            {
            label:
                if (i < Player.counter)
                {
                    goalkeeper.playerButton = new Button();

                    goalkeeper.playerButton.Size = goalkeeper.smallPicture.Size;
                    goalkeeper.playerButton.Image = goalkeeper.smallPicture;
                    goalkeeper.playerButton.Location = new Point(Player.startpictureboxLocationX + i * Player.differencepictureboxLocation, Goalkeeper.startpictureboxLocationY);

                    goalkeeper.textBox = new TextBox();
                    goalkeeper.textBox.Size = new Size(Player.textboxWidth, Player.textboxHeight);
                    goalkeeper.textBox.Multiline = true;

                    goalkeeper.textBox.Text += goalkeeper.surname + "\r\n";
                    goalkeeper.textBox.Text += goalkeeper.name;

                    goalkeeper.textBox.TextAlign = HorizontalAlignment.Center;

                    goalkeeper.textBox.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);

                    goalkeeper.textBox.Location = new Point(Player.startlabelLocationX + i * Player.differencelabelLocation, Goalkeeper.startlabelLocationY);

                    goalkeeper.textBox.BackColor = Color.White;

                    goalkeeper.textBox.ReadOnly = true;

                    goalkeeper.playerButton.Click += playersForm.player_Click;

                    i++;
                }
                else
                {
                    Goalkeeper.startpictureboxLocationY += 280;
                    Goalkeeper.startlabelLocationY += 280;

                    i = 0;

                    goto label;
                }
            }
        }

        private void defendersButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayersForm playersForm = new PlayersForm();

            playersForm.Show();

            playersForm.Text = "AC Milan Defenders";

            int i = 0;

            foreach (Defender defender in PlayersForm.defendersList)
            {
            label:
                if (i < Player.counter)
                {
                    defender.playerButton = new Button();
                    defender.playerButton.Size = defender.smallPicture.Size;
                    defender.playerButton.Image = defender.smallPicture;
                    defender.playerButton.Location = new Point(Player.startpictureboxLocationX + i * Player.differencepictureboxLocation, Defender.startpictureboxLocationY);

                    defender.textBox = new TextBox();
                    defender.textBox.Size = new Size(Player.textboxWidth, Player.textboxHeight);

                    defender.textBox.Multiline = true;

                    defender.textBox.Text += defender.surname + "\r\n";
                    defender.textBox.Text += defender.name;

                    defender.textBox.TextAlign = HorizontalAlignment.Center;

                    defender.textBox.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);

                    defender.textBox.Location = new Point(Player.startlabelLocationX + i * Player.differencelabelLocation, Defender.startlabelLocationY);

                    defender.textBox.BackColor = Color.White;

                    defender.textBox.ReadOnly = true;

                    defender.playerButton.Click += playersForm.player_Click;

                    i++;
                }
                else
                {
                    Defender.startpictureboxLocationY += 280;
                    Defender.startlabelLocationY += 280;

                    i = 0;

                    goto label;
                }
            }
        }

        private void midfieldersButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayersForm playersForm = new PlayersForm();

            playersForm.Show();

            playersForm.Text = "AC Milan Midfielders";

            int i = 0;

            foreach (Midfielder midfielder in PlayersForm.midfieldersList)
            {
            label:
                if (i < Player.counter)
                {
                    midfielder.playerButton = new Button();
                    midfielder.playerButton.Size = midfielder.smallPicture.Size;
                    midfielder.playerButton.Image = midfielder.smallPicture;
                    midfielder.playerButton.Location = new Point(Player.startpictureboxLocationX + i * Player.differencepictureboxLocation, Midfielder.startpictureboxLocationY);

                    midfielder.textBox = new TextBox();
                    midfielder.textBox.Size = new Size(Player.textboxWidth, Player.textboxHeight);
                    midfielder.textBox.Multiline = true;

                    midfielder.textBox.Text += midfielder.surname + "\r\n";
                    midfielder.textBox.Text += midfielder.name;

                    midfielder.textBox.TextAlign = HorizontalAlignment.Center;

                    midfielder.textBox.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);

                    midfielder.textBox.Location = new Point(Player.startlabelLocationX + i * Player.differencelabelLocation, Midfielder.startlabelLocationY);

                    midfielder.textBox.BackColor = Color.White;

                    midfielder.textBox.ReadOnly = true;

                    midfielder.playerButton.Click += playersForm.player_Click;

                    i++;
                }
                else
                {
                    Midfielder.startpictureboxLocationY += 280;
                    Midfielder.startlabelLocationY += 280;

                    i = 0;

                    goto label;
                }
            }
        }

        private void forwardsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayersForm playersForm = new PlayersForm();

            playersForm.Show();

            playersForm.Text = "AC Milan Forwards";

            int i = 0;

            foreach (Forward forward in PlayersForm.forwardsList)
            {
            label:
                if (i < Player.counter)
                {
                    forward.playerButton = new Button();
                    forward.playerButton.Size = forward.smallPicture.Size;
                    forward.playerButton.Image = forward.smallPicture;
                    forward.playerButton.Location = new Point(Player.startpictureboxLocationX + i * Player.differencepictureboxLocation, Forward.startpictureboxLocationY);

                    forward.textBox = new TextBox();
                    forward.textBox.Size = new Size(Player.textboxWidth, Player.textboxHeight);
                    forward.textBox.Multiline = true;

                    forward.textBox.Text += forward.surname + "\r\n";
                    forward.textBox.Text += forward.name;

                    forward.textBox.TextAlign = HorizontalAlignment.Center;

                    forward.textBox.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);

                    forward.textBox.Location = new Point(Player.startlabelLocationX + i * Player.differencelabelLocation, Forward.startlabelLocationY);

                    forward.textBox.BackColor = Color.White;

                    forward.textBox.ReadOnly = true;

                    forward.playerButton.Click += playersForm.player_Click;

                    i++;
                }
                else
                {
                    Forward.startpictureboxLocationY += 280;
                    Forward.startlabelLocationY += 280;

                    i = 0;

                    goto label;
                }
            }
        }
    }

    public abstract class Player
    {
        #region SPECIFICFEATURES

        public const byte counter = 7;

        public const int startpictureboxLocationX = 20;

        public const int startlabelLocationX = 20;

        public const int differencepictureboxLocation = 180;
        public const int differencelabelLocation = 180;

        public const int textboxWidth = 150;
        public const int textboxHeight = 40;

        #endregion

        #region PLAYERBUTTON

        public Button playerButton;

        #endregion

        #region STATSBUTTON

        public Button statsButton;

        #endregion

        #region STATSPLAYERBUTTON

        public Button statsplayerButton;

        #endregion

        #region TEXTBOX

        public TextBox textBox;

        #endregion

        #region PICTURES

        public Image smallPicture;
        public Image largePicture;

        public Image position;

        public Image marketValue;

        public Image marketvalueTable;

        #endregion

        #region GENERALINFORMATION

        public Image largenationalityPicture;
        public Image smallnationalityPicture;

        public DateTime dateofBirth;
        public DateTime intheteamSince;
        public DateTime contractUntil;

        public int age;

        public double height;
        
        public int weight;

        public double BMI;

        public string surname;
        public string name;

        public string placeofBirth;
        public string playersAgent;

        public string preferredFoot;
        public string outfitter;

        public byte jerseyNumber;

        #endregion

        #region RANKS

        public double gazzettaRank;
        public double corrieredellosportRank;
        public double tuttosportRank;
        public double whoscoredRank;

        #endregion

        #region PERFORMANCE_SCORE

        public double totalScore;
        public double attackScore;
        public double defenceScore;
        public double possessionScore;

        #endregion

        #region DISCIPLINE

        public int redCards;
        public int yellowCards;
        public int cardsforDiving;
        public int cardsforbadTackles;
        public int cardsforverbalAbuse;

        #endregion

        public Player(Image smallPicture, Image largePicture, Image largenationalityPicture, Image smallnationalityPicture, Image marketValue, Image position, Image marketvalueTable, DateTime dateofBirth, DateTime intheteamSince, DateTime contractUntil, double height, int weight, string surname, string name, string placeofBirth, string playersAgent, string preferredFoot, string outfitter, byte jerseyNumber)
        {
            this.smallPicture = smallPicture;
            this.largePicture = largePicture;

            this.largenationalityPicture = largenationalityPicture;
            this.smallnationalityPicture = smallnationalityPicture;

            this.marketValue = marketValue;

            this.position = position;

            this.marketvalueTable = marketvalueTable;

            this.dateofBirth = dateofBirth;
            this.intheteamSince = intheteamSince;
            this.contractUntil = contractUntil;

            this.height = height;

            this.weight = weight;

            this.surname = surname;
            this.name = name;

            this.placeofBirth = placeofBirth;
            this.playersAgent = playersAgent;
            this.preferredFoot = preferredFoot;
            this.outfitter = outfitter;

            this.jerseyNumber = jerseyNumber;

            this.age = DateTime.Now.Year - this.dateofBirth.Year;

            this.BMI = Math.Round(this.weight / Math.Pow(this.height, 2), 1);
            if (Double.IsNaN(this.BMI))
            {
                this.BMI = 0;
            }
        }
    }

    public abstract class OutfieldPlayer : Player
    {
        #region PASSES

        public int totalforwardPasses;
        public int totalbackwardPasses;
        public int totalPasses;
        public int successfulPasses;
        public byte passCompletion;
        public int keyPasses;
        public int assists;
        public int chancesCreated;
        public double averagepassLength;

        #endregion

        #region GOALS

        public int goalsScored;
        public int goalsleftFooted;
        public int goalsrightFooted;
        public int goalsHeaded;
        public int goalsinsideArea;
        public int goalsoutsideArea;
        public int goalsfromsetPieces;
        public int goalsfromPenalties;
        public int goalsfromdirectfreeKick;
        public int goalsfromcrossedfreeKick;
        public int goalsfromCorners;

        #endregion

        #region ATTEMPTS

        public int totalShots;
        public byte shotAccuracy;
        public int shotsinsideArea;
        public int shotsoutsideArea;

        #endregion

        #region DUELS

        public int tacklesWon;
        public int tacklesLost;
        public int successfultakeOns;
        public float successfultakeonsPercentage;
        public int aerialduelsWon;
        public float aerialduelsWonPercentage;
        public float totalduelsPercentage;
        public int foulsSuffered;
        public int foulsCommitted;

        #endregion

        #region DEFENCE

        public int interceptions;
        public int blocks;
        public int clearances;
        public int defensiveErrors;
        public int errorsleadingtoGoal;

        #endregion

        public OutfieldPlayer(Image smallPicture, Image largePicture, Image largenationalityPicture, Image smallnationalityPicture, Image marketValue, Image position, Image marketvalueTable, DateTime dateofBirth, DateTime intheteamSince, DateTime contractUntil, double height, int weight, string surname, string name, string placeofBirth, string playersAgent, string preferredFoot, string outfitter, byte jerseyNumber)
            : base(smallPicture, largePicture, largenationalityPicture, smallnationalityPicture, marketValue, position, marketvalueTable, dateofBirth, intheteamSince, contractUntil, height, weight, surname, name, placeofBirth, playersAgent, preferredFoot, outfitter, jerseyNumber)
        { }
    }
}
