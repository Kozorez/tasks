using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic
{
    public partial class MainForm : Form
    {
        PassengerCar passengerCar1 = new PassengerCar(Color.CadetBlue);
        PassengerCar passengerCar2 = new PassengerCar(Color.Sienna);
        Truck truck = new Truck(Color.ForestGreen, 5);
        TrafficLight trafficLight = new TrafficLight();

        public MainForm()
        {
            InitializeComponent();

            allCars.Add(passengerCar1);
            allCars.Add(passengerCar2);
            allCars.Add(truck);

            carsTimer.Interval = 100;
            carsTimer.Tick += carsTimer_Tick;
            carsTimer.Enabled = true;

            trafficlightTimer.Interval = 1500;
            trafficlightTimer.Tick += trafficlightTimer_Tick;
            trafficlightTimer.Enabled = true;
        }

        List<Car> allCars = new List<Car>();
        List<Car> beforeCars = new List<Car>();
        List<Car> forwardCars = new List<Car>();
        List<Car> nonchoicedCars = new List<Car>();

        Timer carsTimer = new Timer();
        Timer trafficlightTimer = new Timer();

        static bool carsCrash = false;
        static bool carsExisting = true;

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black);
            e.Graphics.DrawLine(blackPen, 0, 254, 1349, 254);
            e.Graphics.DrawLine(blackPen, 0, 474, 1349, 474);

            this.Controls.Add(passengerCar1.carpictureBox);
            this.Controls.Add(passengerCar2.carpictureBox);
            this.Controls.Add(truck.carpictureBox);
            this.Controls.Add(trafficLight.trafficlightpictureBox);
        }

        private void carsTimer_Tick(object sender, EventArgs e)
        {
            if (!carsCrash && carsExisting)
            {
                foreach (Car choicedCar in allCars)
                {
                    foreach (Car car in allCars)
                    {
                        if (car != choicedCar)
                        {
                            nonchoicedCars.Add(car);
                        }
                    }

                    foreach (Car car in nonchoicedCars)
                    {
                        if (choicedCar.carpictureBox.Location.X - car.carpictureBox.Location.X < 0)
                        {
                            forwardCars.Add(car);
                        }
                        else
                        {
                            beforeCars.Add(car);
                        }
                    }

                    double minDistance = choicedCar.GetMinimalDistance(nonchoicedCars) / 10;

                    choicedCar.ChangeAverageSpeedByMinimalDistance(minDistance);

                    choicedCar.ChangeAverageSpeedByTrafficLight(trafficLight, beforeCars);

                    double distanceChange = choicedCar.averageSpeed * (carsTimer.Interval / 100);

                    choicedCar.endingPoint = new Point((int)(choicedCar.carpictureBox.Location.X + distanceChange), (int)choicedCar.carpictureBox.Location.Y);

                    carsCrash = choicedCar.isCrashed(forwardCars);

                    if (carsCrash)
                    {
                        MessageBox.Show("Cars are crashed!");

                        return;
                    }

                    beforeCars.Clear();

                    forwardCars.Clear();

                    nonchoicedCars.Clear();

                    carsExisting = choicedCar.isExisting(allCars);

                    if (!carsExisting)
                    {
                        MessageBox.Show("All cars are out of the road!");

                        return;
                    }
                }

                foreach (Car car in allCars)
                {
                    car.carpictureBox.Location = car.endingPoint;
                }

                foreach (Car car in allCars)
                {
                    car.isReacting = false;
                }
            }
            else
            {
                foreach (Car car in allCars)
                {
                    car.carpictureBox.Location = car.startingPoint;
                }
                
                carsCrash = false;
                carsExisting = true;
            }
        }

        private void trafficlightTimer_Tick(object sender, EventArgs e)
        {
            if (trafficLight.isGreen)
            {
                trafficLight.isGreen = false;
                trafficLight.trafficlightpictureBox.Image = Traffic.Properties.Resources.red_light;
            }
            else
            {
                trafficLight.isGreen = true;
                trafficLight.trafficlightpictureBox.Image = Traffic.Properties.Resources.green_light;
            }
        }
    }

    public abstract class Car
    {
        static Random random = new Random();

        static int carsCounter = 0;
        const int carsdifference = 125;

        public double maxSpeed;
        public double averageSpeed;
        public double dampingSpeed;
        public double accelerationSpeed;
        
        public Color color;

        public PictureBox carpictureBox;

        public Point startingPoint;
        public Point endingPoint;

        public bool isReacting = false;

        public Car(Color color)
        {
            this.maxSpeed = random.Next(14, 19);
            this.averageSpeed = random.Next(6, 11);
            this.accelerationSpeed = random.Next(2, 3);
            this.dampingSpeed = random.Next(2, 3);
            this.color = color;

            carpictureBox = new PictureBox();
            carpictureBox.Size = new Size(75, 50);
            carpictureBox.BackColor = color;
            carpictureBox.Location = new Point(75 + carsCounter * carsdifference, 339);
            carsCounter++;

            startingPoint = carpictureBox.Location;
        }

        public double GetMinimalDistance(List<Car> nonchoicedCars)
        {
            double minDistance = double.MaxValue;

            foreach (Car car in nonchoicedCars)
            {
                if (car.carpictureBox.Location.X - this.carpictureBox.Location.X < minDistance && car.carpictureBox.Location.X - this.carpictureBox.Location.X > 0)
                {
                    minDistance = car.carpictureBox.Location.X - this.carpictureBox.Location.X;
                }
            }

            return minDistance;
        }

        public void ChangeAverageSpeedByMinimalDistance(double minDistance)
        {
            if (minDistance < 3)
            {
                this.averageSpeed = this.averageSpeed - this.dampingSpeed;

                if (this.averageSpeed <= 0)
                {
                    this.averageSpeed = 1;
                }
            }
            else if (minDistance > 5)
            {
                this.averageSpeed = this.averageSpeed + this.accelerationSpeed;

                if (this.averageSpeed > this.maxSpeed)
                {
                    this.averageSpeed = this.maxSpeed;
                }
            }
        }

        public void ChangeAverageSpeedByTrafficLight(TrafficLight trafficLight, List<Car> beforeCars)
        {
            if (!trafficLight.isGreen && trafficLight.trafficlightpictureBox.Location.X - this.carpictureBox.Location.X <= 250 && trafficLight.trafficlightpictureBox.Location.X - this.carpictureBox.Location.X >= 0)
            {
                if (!this.isReacting)
                {
                    this.isReacting = true;
                    this.averageSpeed -= 2;
                }
            }

            if (this.isReacting)
            {
                foreach (Car car in beforeCars)
                {
                    if (!car.isReacting)
                    {
                        car.isReacting = true;
                        car.averageSpeed -= 2;
                    }
                }
            }
        }

        public bool isCrashed(List<Car> forwardCars)
        {
            foreach (Car forwardCar in forwardCars)
            {
                if ((this.carpictureBox.Location.X + this.carpictureBox.Size.Width) - forwardCar.carpictureBox.Location.X > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool isExisting(List<Car> allCars)
        {
            bool carExisting = false;

            foreach (Car car in allCars)
            {
                if (car.carpictureBox.Location.X < (1366 - car.carpictureBox.Size.Width))
                {
                    carExisting = true;
                    break;
                }
            }

            if (!carExisting)
            {
                return false;
            }

            return true;
        }
    }

    public sealed class PassengerCar : Car
    {
        public PassengerCar(Color color) : base(color)
        { }
    }

    public sealed class Truck : Car
    {
        double carrying;

        public Truck(Color color, double carrying) : base(color)
        {
            this.carrying = carrying;

            if (carrying > 5)
            {
                this.maxSpeed--;
                this.accelerationSpeed--;
                this.dampingSpeed++;
            }
        }
    }

    public class TrafficLight
    {
        public bool isGreen;

        public PictureBox trafficlightpictureBox;

        public TrafficLight()
        {
            this.isGreen = true;
            
            trafficlightpictureBox = new PictureBox();
            trafficlightpictureBox.Size = Traffic.Properties.Resources.green_light.Size;
            trafficlightpictureBox.Image = Traffic.Properties.Resources.green_light;
            trafficlightpictureBox.Location = new Point(655, 174);
        }
    }
}
