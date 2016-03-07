using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankQueue
{
    public partial class MainForm : Form
    {
        Creditor creditor1 = new Creditor();
        Creditor creditor2 = new Creditor();
        Creditor creditor3 = new Creditor();

        Customer customer1 = new Customer();
        Customer customer2 = new Customer();
        Customer customer3 = new Customer();
        Customer customer4 = new Customer();
        Customer customer5 = new Customer();
        Customer customer6 = new Customer();
        Customer customer7 = new Customer();
        Customer customer8 = new Customer();
        Customer customer9 = new Customer();
        Customer customer10 = new Customer();
        Customer customer11 = new Customer();
        Customer customer12 = new Customer();
        Customer customer13 = new Customer();
        Customer customer14 = new Customer();
        Customer customer15 = new Customer();
        Customer customer16 = new Customer();
        Customer customer17 = new Customer();
        Customer customer18 = new Customer();
        Customer customer19 = new Customer();
        Customer customer20 = new Customer();
        Customer customer21 = new Customer();
        Customer customer22 = new Customer();
        Customer customer23 = new Customer();
        Customer customer24 = new Customer();
        Customer customer25 = new Customer();

        public MainForm()
        {
            InitializeComponent();

            creditors.Add(creditor1);
            creditors.Add(creditor2);
            creditors.Add(creditor3);

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);
            customers.Add(customer5);
            customers.Add(customer6);
            customers.Add(customer7);
            customers.Add(customer8);
            customers.Add(customer9);
            customers.Add(customer10);
            customers.Add(customer11);
            customers.Add(customer12);
            customers.Add(customer13);
            customers.Add(customer14);
            customers.Add(customer15);
            customers.Add(customer16);
            customers.Add(customer17);
            customers.Add(customer18);
            customers.Add(customer19);
            customers.Add(customer20);
            customers.Add(customer21);
            customers.Add(customer22);
            customers.Add(customer23);
            customers.Add(customer24);
            customers.Add(customer25);

            for (int i = 0; i < creditors.Count; i++)
            {
                freeCreditors.Add(creditors[i]);
            }

            for (int i = 0; i < customers.Count; i++)
            {
                leftCustomers.Add(customers[i]);
            }

            Random random = new Random();

            customers_timer.Interval = 2000;
            customers_timer.Tick += customers_timer_Tick;
            customers_timer.Enabled = true;

            creditor1_timer.Interval = random.Next(7500, 12500);
            creditor1_timer.Tick += creditor1_timer_Tick;
            creditor1_timer.Enabled = false;

            creditor2_timer.Interval = random.Next(7500, 12500);
            creditor2_timer.Tick += creditor2_timer_Tick;
            creditor2_timer.Enabled = false;

            creditor3_timer.Interval = random.Next(7500, 12500);
            creditor3_timer.Tick += creditor3_timer_Tick;
            creditor3_timer.Enabled = false;
        }

        List<Creditor> creditors = new List<Creditor>();
        List<Creditor> freeCreditors = new List<Creditor>();
        List<Customer> customers = new List<Customer>();
        List<Customer> leftCustomers = new List<Customer>();

        Timer customers_timer = new Timer();
        Timer creditor1_timer = new Timer();
        Timer creditor2_timer = new Timer();
        Timer creditor3_timer = new Timer();

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Creditor creditor in creditors)
            {
                this.Controls.Add(creditor.creditorpictureBox);
                this.Controls.Add(creditor.creditortextBox);
            }
            foreach (Customer customer in customers)
            {
                this.Controls.Add(customer.customerpictureBox);
            }
        }

        private void customers_timer_Tick(object sender, EventArgs e)
        {
            if (leftCustomers.Count != 0)
            {
                Random random = new Random();

                Customer choicedCustomer = (from customer in leftCustomers
                                            where customer.ID == 1
                                            select customer).First();

                if (freeCreditors.Count != 0)
                {
                label:

                    int choice = random.Next(1, 4);

                    switch (choice)
                    {
                        case 1:
                            {
                                if (creditor1.isFree)
                                {
                                    creditor1.customer = choicedCustomer;
                                    creditor1.isFree = false;
                                    freeCreditors.Remove(creditor1);
                                    choicedCustomer.customerpictureBox.Location = new Point(creditor1.creditorpictureBox.Location.X + 75, creditor1.creditorpictureBox.Location.Y);
                                    choicedCustomer.customerpictureBox.Image = BankQueue.Properties.Resources.green_man;
                                    creditor1_timer.Enabled = true;
                                }
                                else
                                {
                                    goto label;
                                }
                                break;
                            }
                        case 2:
                            {
                                if (creditor2.isFree)
                                {
                                    creditor2.customer = choicedCustomer;
                                    creditor2.isFree = false;
                                    freeCreditors.Remove(creditor2);
                                    choicedCustomer.customerpictureBox.Location = new Point(creditor2.creditorpictureBox.Location.X + 75, creditor2.creditorpictureBox.Location.Y);
                                    choicedCustomer.customerpictureBox.Image = BankQueue.Properties.Resources.green_man;
                                    creditor2_timer.Enabled = true;
                                }
                                else
                                {
                                    goto label;
                                }
                                break;
                            }
                        case 3:
                            {
                                if (creditor3.isFree)
                                {
                                    creditor3.customer = choicedCustomer;
                                    creditor3.isFree = false;
                                    freeCreditors.Remove(creditor3);
                                    choicedCustomer.customerpictureBox.Location = new Point(creditor3.creditorpictureBox.Location.X + 75, creditor3.creditorpictureBox.Location.Y);
                                    choicedCustomer.customerpictureBox.Image = BankQueue.Properties.Resources.green_man;
                                    creditor3_timer.Enabled = true;
                                }
                                else
                                {
                                    goto label;
                                }
                                break;
                            }
                    }

                    leftCustomers.Remove(choicedCustomer);

                    foreach (Customer customer in leftCustomers)
                    {
                        customer.ID--;
                        customer.customerpictureBox.Location = new Point(customer.customerpictureBox.Location.X - 100, customer.customerpictureBox.Location.Y);
                    }
                }
            }
            else if (leftCustomers.Count == 0 && customers.Count != 0)
            {
                return;
            }
            else
            {
                customers_timer.Enabled = false;
                MessageBox.Show("It was a hard day for the creditors, let them have a rest!");
            }
        }

        private void creditor1_timer_Tick(object sender, EventArgs e)
        {
            if (creditor1.customer != null)
            {
                creditor1.earnedMoney += creditor1.customer.paidMoney;
                creditor1.creditortextBox.Text = creditor1.earnedMoney.ToString();
                creditor1.isFree = true;
                freeCreditors.Add(creditor1);
                creditor1_timer.Enabled = false;
                customers.Remove(creditor1.customer);
                this.Controls.Remove(creditor1.customer.customerpictureBox);
                creditor1.customer = null;
            }
        }

        private void creditor2_timer_Tick(object sender, EventArgs e)
        {
            if (creditor2.customer != null)
            {
                creditor2.earnedMoney += creditor2.customer.paidMoney;
                creditor2.creditortextBox.Text = creditor2.earnedMoney.ToString();
                creditor2.isFree = true;
                freeCreditors.Add(creditor2);
                creditor2_timer.Enabled = false;
                customers.Remove(creditor2.customer);
                this.Controls.Remove(creditor2.customer.customerpictureBox);
                creditor2.customer = null;
            }
        }

        private void creditor3_timer_Tick(object sender, EventArgs e)
        {
            if (creditor3.customer != null)
            {
                creditor3.earnedMoney += creditor3.customer.paidMoney;
                creditor3.creditortextBox.Text = creditor3.earnedMoney.ToString();
                creditor3.isFree = true;
                freeCreditors.Add(creditor3);
                creditor3_timer.Enabled = false;
                customers.Remove(creditor3.customer);
                this.Controls.Remove(creditor3.customer.customerpictureBox);
                creditor3.customer = null;
            }
        }
    }

    public class Creditor
    {
        static int creditorCounter = 0;
        const int creditordifference = 200;

        public double earnedMoney = 0;
        public bool isFree = true;

        public Customer customer;

        public PictureBox creditorpictureBox;

        public TextBox creditortextBox;

        public Creditor()
        {
            creditorpictureBox = new PictureBox();
            creditorpictureBox.Size = BankQueue.Properties.Resources.black_man.Size;
            creditorpictureBox.Image = BankQueue.Properties.Resources.black_man;
            creditorpictureBox.Location = new Point(75, 114 + creditorCounter * creditordifference);

            creditortextBox = new TextBox();
            creditortextBox.Size = new Size(50, 20);
            creditortextBox.Location = new Point(this.creditorpictureBox.Location.X, this.creditorpictureBox.Location.Y - 35);
            creditortextBox.Enabled = false;

            creditorCounter++;
        }
    }

    public class Customer
    {
        static Random random = new Random();

        static int customerCounter = 0;
        const int customerdifference = 100;

        public double ID;
        public double availableMoney;
        public double paidMoney;

        public PictureBox customerpictureBox;

        public Customer()
        {
            this.ID = customerCounter + 1;
            this.availableMoney = random.Next(100, 1001);
            this.paidMoney = (availableMoney / 10) * random.Next(2, 8);

            customerpictureBox = new PictureBox();
            customerpictureBox.Size = BankQueue.Properties.Resources.yellow_man.Size;
            customerpictureBox.Image = BankQueue.Properties.Resources.yellow_man;
            customerpictureBox.Location = new Point(300 + customerCounter * customerdifference, 314);
            customerCounter++;
        }
    }
}