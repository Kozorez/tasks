using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar_System
{
    public partial class MainForm : Form
    {
        Planets sun = new Planets(Solar_System.Properties.Resources.sun, 0, 30);
        Planets mercury = new Planets(Solar_System.Properties.Resources.mercury, 0.4, 60);
        Planets venus = new Planets(Solar_System.Properties.Resources.venus, 0.7, 90);
        Planets earth = new Planets(Solar_System.Properties.Resources.earth, 0.9, 120);
        Planets mars = new Planets(Solar_System.Properties.Resources.mars, 1.1, 150);
        Planets jupiter = new Planets(Solar_System.Properties.Resources.jupiter, 1.7, 180);
        Planets saturn = new Planets(Solar_System.Properties.Resources.saturn, 2.0, 210);
        Planets uranus = new Planets(Solar_System.Properties.Resources.uranus, 2.1, 240);
        Planets neptune = new Planets(Solar_System.Properties.Resources.neptune, 2.2, 270);
        Planets pluto = new Planets(Solar_System.Properties.Resources.pluto, 2.7, 300);

        public MainForm()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Enabled = true;

            planets.Add(mercury);
            planets.Add(venus);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);

            Satellites moon = new Satellites(earth, Solar_System.Properties.Resources.moon, 0.4);
            Satellites satellite1 = new Satellites(jupiter, Solar_System.Properties.Resources.satellite, 0.8);
            Satellites satellite2 = new Satellites(neptune, Solar_System.Properties.Resources.satellite, 1.2);
            Satellites satellite3 = new Satellites(pluto, Solar_System.Properties.Resources.satellite, 1.6);
            Satellites satellite4 = new Satellites(saturn, Solar_System.Properties.Resources.satellite, 2);

            satellites.Add(moon);
            satellites.Add(satellite1);
            satellites.Add(satellite2);
            satellites.Add(satellite3);
            satellites.Add(satellite4);

            this.Controls.Add(sun.planetpictureBox);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Planets planet in planets)
            {
                this.Controls.Add(planet.planetpictureBox);
            }

            foreach (Satellites satellite in satellites)
            {
                this.Controls.Add(satellite.satellitepictureBox);
            }
        }

        List<Planets> planets = new List<Planets>();
        List<Satellites> satellites = new List<Satellites>();

        Timer timer = new Timer();

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (Planets planet in planets)
            {
                planet.angle += planet.speed;
                double x = planet.radius * Math.Cos(planet.angle) + sun.planetpictureBox.Location.X;
                double y = planet.radius * Math.Sin(planet.angle) + sun.planetpictureBox.Location.Y;
                
                planet.planetpictureBox.Location = new Point((int)x, (int)y);
            }

            foreach (Satellites satellite in satellites)
            {
                satellite.angle += satellite.speed;
                double x = satellite.radius * Math.Cos(satellite.angle) + satellite.planet.planetpictureBox.Location.X;
                double y = satellite.radius * Math.Sin(satellite.angle) + satellite.planet.planetpictureBox.Location.Y;

                satellite.satellitepictureBox.Location = new Point((int)x, (int)y);
            }
        }  
    }

    public class Planets
    {
        static int planetsCounter = 0;
        const int planetsdifference = 50;
        
        public double angle = 0;
        public double speed;
        public double radius;

        public PictureBox planetpictureBox;

        public Planets(Image image, double speed, double radius)
        {
            planetpictureBox = new PictureBox();
            planetpictureBox.Size = image.Size;
            planetpictureBox.Image = image;
            planetpictureBox.Location = new Point(663 + planetsCounter * planetsdifference, 344);
            planetsCounter++;

            this.speed = speed;
            this.radius = radius;
        }
    }

    public class Satellites
    {
        public Planets planet;

        public double angle = 0;
        public double speed;
        public double radius;

        public PictureBox satellitepictureBox;

        public Satellites(Planets planet, Image image, double speed)
        {
            satellitepictureBox = new PictureBox();
            satellitepictureBox.Size = image.Size;
            satellitepictureBox.Image = image;
            satellitepictureBox.Location = new Point(planet.planetpictureBox.Location.X + 10, planet.planetpictureBox.Location.Y);

            this.planet = planet;

            this.speed = speed;
            this.radius = 50;
        }
    }
}
