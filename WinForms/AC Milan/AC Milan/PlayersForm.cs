using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AC_Milan
{
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();

            #region FILLGOALKEEPERSLIST

            goalkeepersList.Add(ChristianAbbiati);
            goalkeepersList.Add(GianluigiDonnarumma);
            goalkeepersList.Add(DiegoLopez);

            #endregion

            #region FILLDEFENDERSLIST

            defendersList.Add(IgnazioAbate);
            defendersList.Add(Alex);
            defendersList.Add(LucaAntonelli);
            defendersList.Add(DavideCalabria);
            defendersList.Add(MattiaDeSciglio);
            defendersList.Add(RodrigoEly);
            defendersList.Add(PhilippeMexes);
            defendersList.Add(AlessioRomagnoli);
            defendersList.Add(CristianZapata);

            #endregion

            #region FILLMIDFIELDERSLIST

            midfieldersList.Add(AndreaBertolacci);
            midfieldersList.Add(GiacomoBonaventura);
            midfieldersList.Add(NigelDeJong);
            midfieldersList.Add(KeisukeHonda);
            midfieldersList.Add(JoseMauri);
            midfieldersList.Add(RiccardoMontolivo);
            midfieldersList.Add(AntonioNocerino);
            midfieldersList.Add(AndreaPoli);
            midfieldersList.Add(Suso);

            #endregion

            #region FILLFORWARDSLIST

            forwardsList.Add(LuizAdriano);
            forwardsList.Add(CarlosBacca);
            forwardsList.Add(MarioBalotelli);
            forwardsList.Add(AlessioCerci);
            forwardsList.Add(JeremyMenez);
            forwardsList.Add(MbayeNiang);

            #endregion

            #region FILLPLAYERSLIST

            foreach (Goalkeeper goalkeeper in goalkeepersList)
            {
                playersList.Add(goalkeeper);
            }

            foreach (Defender defender in defendersList)
            {
                playersList.Add(defender);
            }

            foreach (Midfielder midfielder in midfieldersList)
            {
                playersList.Add(midfielder);
            }

            foreach (Forward forward in forwardsList)
            {
                playersList.Add(forward);
            }

            #endregion

            #region FILLOUTFIELDPLAYERSLIST

            foreach (Defender defender in defendersList)
            {
                outfieldplayersList.Add(defender);
            }

            foreach (Midfielder midfielder in midfieldersList)
            {
                outfieldplayersList.Add(midfielder);
            }

            foreach (Forward forward in forwardsList)
            {
                outfieldplayersList.Add(forward);
            }

            #endregion
        }

        public static List<Goalkeeper> goalkeepersList = new List<Goalkeeper>();
        public static List<Defender> defendersList = new List<Defender>();
        public static List<Midfielder> midfieldersList = new List<Midfielder>();
        public static List<Forward> forwardsList = new List<Forward>();

        public static List<Player> playersList = new List<Player>();

        public static List<OutfieldPlayer> outfieldplayersList = new List<OutfieldPlayer>();

        #region GOALKEEPERS

        Goalkeeper ChristianAbbiati = new Goalkeeper(Properties.Resources.smallabbiati, Properties.Resources.largeabbiati, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvalueabbiati, Properties.Resources.positionabbiati, Properties.Resources.marketvaluetableabbiati, new DateTime(1977, 7, 8), new DateTime(1998, 7, 1), new DateTime(2016, 6, 30), 1.91, 92, "Abbiati", "Christian", "Abbiategrasso", "Promosport s.r.l.", "right", null, 32);
        Goalkeeper GianluigiDonnarumma = new Goalkeeper(Properties.Resources.smalldonnarumma, Properties.Resources.largedonnarumma, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvaluedonnarumma, Properties.Resources.positiondonnarumma, Properties.Resources.marketvaluetabledonnarumma, new DateTime(1999, 2, 25), new DateTime(2014, 7, 1), new DateTime(), 0, 0, "Donnarumma", "Gianluigi", "Castellammare di Stabia", "Unknown", "Unknown", null, 99);
        Goalkeeper DiegoLopez = new Goalkeeper(Properties.Resources.smalllopez, Properties.Resources.largelopez, Properties.Resources.largespain, Properties.Resources.smallspain, Properties.Resources.marketvaluelopez, Properties.Resources.positionlopez, Properties.Resources.marketvaluetablelopez, new DateTime(1981, 11, 3), new DateTime(2014, 8, 13), new DateTime(2018, 6, 30), 1.96, 87, "López", "Diego", "Paradela", "Manuel García Quilón", "right", null, 1);
        
        #endregion

        #region DEFENDERS

        Defender IgnazioAbate = new Defender(Properties.Resources.smallabate, Properties.Resources.largeabate, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvalueabate, Properties.Resources.positionabate, Properties.Resources.marketvaluetableabate, new DateTime(1986, 11, 12), new DateTime(2009, 7, 1), new DateTime(2019, 6, 30), 1.80, 73, "Abate", "Ignazio", "Sant'Agata dè Goti", "Mino Raiola", "right", null, 20);
        Defender Alex = new Defender(Properties.Resources.smallalex, Properties.Resources.largealex, Properties.Resources.largebrazil, Properties.Resources.smallbrazil, Properties.Resources.marketvaluealex, Properties.Resources.positionalex, Properties.Resources.marketvaluetablealex, new DateTime(1982, 6, 17), new DateTime(2014, 7, 1), new DateTime(2016, 6, 30), 1.88, 92, "Alex", null, "Niterói", "Euro Export Assessoria e Propaganda Ltda.", "right", null, 33);
        Defender LucaAntonelli = new Defender(Properties.Resources.smallantonelli, Properties.Resources.largeantonelli, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvalueantonelli, Properties.Resources.positionantonelli, Properties.Resources.marketvaluetableantonelli, new DateTime(1987, 2, 11), new DateTime(2015, 7, 1), new DateTime(2018, 6, 30), 1.84, 0, "Antonelli", "Luca", "Monza", "Sport Service", "left", null, 31);
        Defender DavideCalabria = new Defender(Properties.Resources.smallcalabria, Properties.Resources.largecalabria, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvaluecalabria, Properties.Resources.positioncalabria, Properties.Resources.marketvaluetablecalabria, new DateTime(1996, 12, 6), new DateTime(2015, 7, 1), new DateTime(), 0, 0, "Calabria", "Davide", "Brescia", "Unknown", "right", null, 96);
        Defender MattiaDeSciglio = new Defender(Properties.Resources.smalldesciglio, Properties.Resources.largedesciglio, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvaluedesciglio, Properties.Resources.positiondesciglio, Properties.Resources.marketvaluetabledesciglio, new DateTime(1992, 10, 20), new DateTime(2011, 7, 1), new DateTime(2016, 5, 30), 1.83, 74, "De Sciglio", "Mattia", "Milano", "Unknown", "right", null, 2);
        Defender RodrigoEly = new Defender(Properties.Resources.smallely, Properties.Resources.largeely, Properties.Resources.largebrazil, Properties.Resources.smallbrazil, Properties.Resources.marketvalueely, Properties.Resources.positionely, Properties.Resources.marketvaluetableely, new DateTime(1993, 11, 3), new DateTime(2015, 7, 1), new DateTime(2019, 6, 30), 1.88, 83, "Ely", "Rodrigo", "Lajeado RS", "Mino Raiola", "right", null, 15);
        Defender PhilippeMexes = new Defender(Properties.Resources.smallmexes, Properties.Resources.largemexes, Properties.Resources.largefrance, Properties.Resources.smallfrance, Properties.Resources.marketvaluemexes, Properties.Resources.positionmexes, Properties.Resources.marketvaluetablemexes, new DateTime(1982, 3, 30), new DateTime(2011, 7, 1), new DateTime(2016, 6, 30), 1.87, 82, "Mexès", "Philippe", "Toulouse", "Dream Team Management", "right", null, 5);      
        Defender AlessioRomagnoli = new Defender(Properties.Resources.smallromagnoli, Properties.Resources.largeromagnoli, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvalueromagnoli, Properties.Resources.positionromagnoli, Properties.Resources.marketvaluetableromagnoli, new DateTime(1995, 1, 12), new DateTime(2015, 08, 11), new DateTime(2020, 06, 30), 0, 0, "Romagnoli", "Alessio", "Anzio", "GoalKick Sportmanagement", "left", null, 13);
        Defender CristianZapata = new Defender(Properties.Resources.smallzapata, Properties.Resources.largezapata, Properties.Resources.largecolombia, Properties.Resources.smallcolombia, Properties.Resources.marketvaluezapata, Properties.Resources.positionzapata, Properties.Resources.marketvaluetablezapata, new DateTime(1986, 9, 30), new DateTime(2013, 7, 1), new DateTime(2016, 6, 30), 1.87, 82, "Zapata", "Cristian", "Padilla", "Unknown", "right", "Lotto", 17);

        #endregion

        #region MIDFIELDERS

        Midfielder AndreaBertolacci = new Midfielder(Properties.Resources.smallbertolacci, Properties.Resources.largebertolacci, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvaluebertolacci, Properties.Resources.positionbertolacci, Properties.Resources.marketvaluetablebertolacci, new DateTime(1991, 1, 11), new DateTime(2015, 7, 2), new DateTime(2019, 6, 30), 1.79, 75, "Bertolacci", "Andrea", "Roma", "W.S.A.", "both", null, 91);
        Midfielder GiacomoBonaventura = new Midfielder(Properties.Resources.smallbonaventura, Properties.Resources.largebonaventura, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvaluebonaventura, Properties.Resources.positionbonaventura, Properties.Resources.marketvaluetablebonaventura, new DateTime(1989, 8, 22), new DateTime(2014, 9, 1), new DateTime(2019, 6, 30), 1.80, 75, "Bonaventura", "Giacomo", "San Severino Marche", "Unknown", "right", null, 28);
        Midfielder NigelDeJong = new Midfielder(Properties.Resources.smalldejong, Properties.Resources.largedejong, Properties.Resources.largenetherlands, Properties.Resources.smallnetherlands, Properties.Resources.marketvaluedejong, Properties.Resources.positiondejong, Properties.Resources.marketvaluetabledejong, new DateTime(1984, 11, 30), new DateTime(2012, 8, 31), new DateTime(2018, 6, 30), 1.74, 72, "De Jong", "Nigel", "Amsterdam", "Juzzt Football", "right", null, 34);
        Midfielder KeisukeHonda = new Midfielder(Properties.Resources.smallhonda, Properties.Resources.largehonda, Properties.Resources.largejapan, Properties.Resources.smalljapan, Properties.Resources.marketvaluehonda, Properties.Resources.positionhonda, Properties.Resources.marketvaluetablehonda, new DateTime(1986, 6, 13), new DateTime(2014, 1, 3), new DateTime(2017, 6, 30), 1.82, 0, "Honda", "Keisuke", "Settsu, Osaka", "GoalKick Sportmanagement", "left", null, 10);
        Midfielder JoseMauri = new Midfielder(Properties.Resources.smallmauri, Properties.Resources.largemauri, Properties.Resources.largeitaly, Properties.Resources.smallargentina, Properties.Resources.marketvaluemauri, Properties.Resources.positionmauri, Properties.Resources.marketvaluetablemauri, new DateTime(1996, 5, 16), new DateTime(2015, 7, 1), new DateTime(), 1.69, 65, "Mauri", "Jóse", "Realicó", "Unknown", "right", null, 4);
        Midfielder RiccardoMontolivo = new Midfielder(Properties.Resources.smallmontolivo, Properties.Resources.largemontolivo, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvaluemontolivo, Properties.Resources.positionmontolivo, Properties.Resources.marketvaluetablemontolivo, new DateTime(1985, 1, 18), new DateTime(2012, 7, 1), new DateTime(2016, 6, 30), 1.82, 79, "Montolivo", "Riccardo", "Milano", "Branchini Associati S.p.A.", "right", null, 18);
        Midfielder AntonioNocerino = new Midfielder(Properties.Resources.smallnocerino, Properties.Resources.largenocerino, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvaluenocerino, Properties.Resources.positionnocerino, Properties.Resources.marketvaluetablenocerino, new DateTime(1985, 4, 9), new DateTime(2011, 8, 31), new DateTime(2016, 6, 30), 1.75, 75, "Nocerino", "Antonio", "Napoli", "Studio Legale Tomlillo", "right", "adidas", 23);
        Midfielder AndreaPoli = new Midfielder(Properties.Resources.smallpoli, Properties.Resources.largepoli, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvaluepoli, Properties.Resources.positionpoli, Properties.Resources.marketvaluetablepoli, new DateTime(1989, 9, 29), new DateTime(2013, 7, 11), new DateTime(2017, 6, 30), 1.82, 77, "Poli", "Andrea", "Vittorio Veneto", "Branchini Associati S.p.A.", "right", null, 16);
        Midfielder Suso = new Midfielder(Properties.Resources.smallsuso, Properties.Resources.largesuso, Properties.Resources.largespain, Properties.Resources.smallspain, Properties.Resources.marketvaluesuso, Properties.Resources.positionsuso, Properties.Resources.marketvaluetablesuso, new DateTime(1993, 11, 19), new DateTime(2015, 1, 17), new DateTime(2019, 6, 30), 1.76, 70, "Suso", null, "Cádiz", "EMG Mundial", "left", null, 8);

        #endregion

        #region FORWARDS

        Forward LuizAdriano = new Forward(Properties.Resources.smalladriano, Properties.Resources.largeadriano, Properties.Resources.largebrazil, Properties.Resources.smallbrazil, Properties.Resources.marketvalueadriano, Properties.Resources.positionadriano, Properties.Resources.marketvaluetableadriano, new DateTime(1987, 4, 12), new DateTime(2015, 7, 2), new DateTime(2020, 6, 30), 1.83, 71, "Adriano", "Luiz", "Porto Alegre", "BBC Management GmbH", "right", null, 9);
        Forward CarlosBacca = new Forward(Properties.Resources.smallbacca, Properties.Resources.largebacca, Properties.Resources.largecolombia, Properties.Resources.smallcolombia, Properties.Resources.marketvaluebacca, Properties.Resources.positionbacca, Properties.Resources.marketvaluetablebacca, new DateTime(1986, 9, 8), new DateTime(2015, 7, 3), new DateTime(2020, 6, 30), 1.81, 77, "Bacca", "Carlos", "Puerto Colombia", "Vos Marketing", "right", null, 70);
        Forward MarioBalotelli = new Forward(Properties.Resources.smallbalotelli, Properties.Resources.largebalotelli, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvaluebalotelli, Properties.Resources.positionbalotelli, Properties.Resources.marketvaluetablebalotelli, new DateTime(1990, 8, 12), new DateTime(2015, 8, 27), new DateTime(2016, 6, 30), 1.89, 88, "Balotelli", "Mario", "Palermo", "Mino Raiola", "right", "Puma", 45);    
        Forward AlessioCerci = new Forward(Properties.Resources.smallcerci, Properties.Resources.largecerci, Properties.Resources.largeitaly, Properties.Resources.smallitaly, Properties.Resources.marketvaluecerci, Properties.Resources.positioncerci, Properties.Resources.marketvaluetablecerci, new DateTime(1987, 7, 23), new DateTime(2015, 1, 5), new DateTime(2016, 6, 30), 1.80, 78, "Cerci", "Alessio", "Velletri", "Sergio Berti", "left", null, 11);
        Forward JeremyMenez = new Forward(Properties.Resources.smallmenez, Properties.Resources.largemenez, Properties.Resources.largefrance, Properties.Resources.smallfrance, Properties.Resources.marketvaluemenez, Properties.Resources.positionmenez, Properties.Resources.marketvaluetablemenez, new DateTime(1987, 5, 7), new DateTime(2014, 7, 1), new DateTime(2017, 6, 30), 1.82, 73, "Menez", "Jeremy", "Longjumeau", "Alain Migliaccio", "right", null, 7);
        Forward MbayeNiang = new Forward(Properties.Resources.smallniang, Properties.Resources.largeniang, Properties.Resources.largefrance, Properties.Resources.smallfrance, Properties.Resources.marketvalueniang, Properties.Resources.positionniang, Properties.Resources.marketvaluetableniang, new DateTime(1994, 12, 19), new DateTime(2012, 8, 28), new DateTime(2019, 6, 30), 1.84, 75, "Niang", "Mbaye", "Meulan", "Moussa Ndiaye", "right", "Nike", 78);

        #endregion

        private void PlayersForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Goalkeeper goalkeeper in PlayersForm.goalkeepersList)
            {
                this.Controls.Add(goalkeeper.playerButton);
                this.Controls.Add(goalkeeper.textBox);
            }

            foreach (Defender defender in PlayersForm.defendersList)
            {
                this.Controls.Add(defender.playerButton);
                this.Controls.Add(defender.textBox);
            }

            foreach (Midfielder midfielder in PlayersForm.midfieldersList)
            {
                this.Controls.Add(midfielder.playerButton);
                this.Controls.Add(midfielder.textBox);
            }

            foreach (Forward forward in PlayersForm.forwardsList)
            {
                this.Controls.Add(forward.playerButton);
                this.Controls.Add(forward.textBox);
            }
        }

        public void player_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayerProfileForm playerprofileForm = new PlayerProfileForm();

            playerprofileForm.Show();

            foreach (Player player in playersList)
            {
                if (player.playerButton == sender)
                {
                    playerprofileForm.Text = player.name + " " + player.surname;
                    playerprofileForm.largeplayerpictureBox.BackgroundImage = player.largePicture;
                    playerprofileForm.largenationalitypictureBox.Image = player.largenationalityPicture;
                    playerprofileForm.playersurnametextBox.Text = player.surname;
                    playerprofileForm.playernametextBox.Text = player.name;
                    playerprofileForm.jerseynumbertextBox.Text = player.jerseyNumber.ToString();
                    playerprofileForm.playerpositionpictureBox.Image = player.position;
                    playerprofileForm.playermarketvaluepictureBox.Image = player.marketValue;
                    playerprofileForm.playermarketvaluetablepictureBox.Image = player.marketvalueTable;

                    playerprofileForm.playerdateofbirthtextBox2.Text = player.dateofBirth.ToShortDateString();
                    playerprofileForm.playerplaceofbirthtextBox2.Text = player.placeofBirth;

                    //
                    
                    playerprofileForm.playerplaceofbirthtextBox2.Size = TextRenderer.MeasureText(playerprofileForm.playerplaceofbirthtextBox2.Text, playerprofileForm.playerplaceofbirthtextBox2.Font);
                    playerprofileForm.playersmallnationalitypictureBox.Image = player.smallnationalityPicture;
                    playerprofileForm.playersmallnationalitypictureBox.Location = new Point(playerprofileForm.playerplaceofbirthtextBox2.Location.X + playerprofileForm.playerplaceofbirthtextBox2.Size.Width, playerprofileForm.playersmallnationalitypictureBox.Location.Y);

                    //
                    
                    playerprofileForm.playeragetextBox2.Text = player.age.ToString();
                    playerprofileForm.playerheighttextBox2.Text = player.height.ToString();
                    playerprofileForm.playerweighttextBox2.Text = player.weight.ToString();
                    playerprofileForm.playerbmitextBox2.Text = player.BMI.ToString();
                    playerprofileForm.playerintheteamsincetextBox2.Text = player.intheteamSince.ToShortDateString();
                    playerprofileForm.playercontractuntiltextBox2.Text = player.contractUntil.ToShortDateString();
                    playerprofileForm.playerplayersagenttextBox2.Text = player.playersAgent;
                    playerprofileForm.playerpreferredfoottextBox2.Text = player.preferredFoot;
                    playerprofileForm.playeroutfittertextBox2.Text = player.outfitter;

                    player.statsButton = playerprofileForm.gotostatsButton;

                    if (player.name != null)
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

    public sealed class Goalkeeper : Player
    {
        public static int startpictureboxLocationY = 20;
        public static int startlabelLocationY = 240;

        #region GOALKEEPING

        public int cleanSheets;
        public int goalsConceded;
        public int saves;
        public float savesperGoal;
        public byte distributionAccuracy;
        public int averagedistributionLength;
        public int punches;
        public int catches;

        #endregion

        public Goalkeeper(Image smallPicture, Image largePicture, Image largenationalityPicture, Image smallnationalityPicture, Image marketValue, Image position, Image marketvalueTable, DateTime dateofBirth, DateTime intheteamSince, DateTime contractUntil, double height, int weight, string surname, string name, string placeofBirth, string playersAgent, string preferredFoot, string outfitter, byte jerseyNumber)
            : base(smallPicture, largePicture, largenationalityPicture, smallnationalityPicture, marketValue, position, marketvalueTable, dateofBirth, intheteamSince, contractUntil, height, weight, surname, name, placeofBirth, playersAgent, preferredFoot, outfitter, jerseyNumber)
        { }
    }

    public sealed class Defender : OutfieldPlayer
    {
        public static int startpictureboxLocationY = 20;
        public static int startlabelLocationY = 240;

        public Defender(Image smallPicture, Image largePicture, Image largenationalityPicture, Image smallnationalityPicture, Image marketValue, Image position, Image marketvalueTable, DateTime dateofBirth, DateTime intheteamSince, DateTime contractUntil, double height, int weight, string surname, string name, string placeofBirth, string playersAgent, string preferredFoot, string outfitter, byte jerseyNumber)
            : base(smallPicture, largePicture, largenationalityPicture, smallnationalityPicture, marketValue, position, marketvalueTable, dateofBirth, intheteamSince, contractUntil, height, weight, surname, name, placeofBirth, playersAgent, preferredFoot, outfitter, jerseyNumber)
        { }
    }

    public sealed class Midfielder : OutfieldPlayer
    {
        public static int startpictureboxLocationY = 20;
        public static int startlabelLocationY = 240;

        public Midfielder(Image smallPicture, Image largePicture, Image largenationalityPicture, Image smallnationalityPicture, Image marketValue, Image position, Image marketvalueTable, DateTime dateofBirth, DateTime intheteamSince, DateTime contractUntil, double height, int weight, string surname, string name, string placeofBirth, string playersAgent, string preferredFoot, string outfitter, byte jerseyNumber)
            : base(smallPicture, largePicture, largenationalityPicture, smallnationalityPicture, marketValue, position, marketvalueTable, dateofBirth, intheteamSince, contractUntil, height, weight, surname, name, placeofBirth, playersAgent, preferredFoot, outfitter, jerseyNumber)
        { }
    }

    public sealed class Forward : OutfieldPlayer
    {
        public static int startpictureboxLocationY = 20;
        public static int startlabelLocationY = 240;

        public Forward(Image smallPicture, Image largePicture, Image largenationalityPicture, Image smallnationalityPicture, Image marketValue, Image position, Image marketvalueTable, DateTime dateofBirth, DateTime intheteamSince, DateTime contractUntil, double height, int weight, string surname, string name, string placeofBirth, string playersAgent, string preferredFoot, string outfitter, byte jerseyNumber)
            : base(smallPicture, largePicture, largenationalityPicture, smallnationalityPicture, marketValue, position, marketvalueTable, dateofBirth, intheteamSince, contractUntil, height, weight, surname, name, placeofBirth, playersAgent, preferredFoot, outfitter, jerseyNumber)
        { }
    }
}
