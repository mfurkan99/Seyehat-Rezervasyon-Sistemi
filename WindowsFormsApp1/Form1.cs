using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Admin adminUser;
        List<Company> companies;
        public Form1()
        {
            InitializeComponent();
            adminUser = new Admin();
            companies = new List<Company>();

            
            Company companyA = new Company("A", "1234", "A",1000);
            companyA.AddVehicle(new Bus(0,20, "Benzin", 10)); 
            companyA.AddVehicle(new Bus(0,15, "Benzin", 10));
            companies.Add(companyA);

            Company companyB = new Company("B", "1234", "B",1000);
            companyB.AddVehicle(new Bus(0,15, "Motorin", 5));
            companyB.AddVehicle(new Bus(0,20, "Motorin", 5));
            companies.Add(companyB);

            Company companyC = new Company("C", "1234", "C",1000);
            companyC.AddVehicle(new Bus(0,20, "Motorin", 6));
            companyC.AddVehicle(new Airplane(0,30, "Gaz", 25));
            companyC.AddVehicle(new Airplane(0,30, "Gaz", 25));
            companies.Add(companyC);

            Company companyD = new Company("D", "1234", "D",1000);
            companyD.AddVehicle(new Train(0,25, "Elektrik", 3));
            companyD.AddVehicle(new Train(0,25, "Elektrik", 3));
            companyD.AddVehicle(new Train(0,25, "Elektrik", 3));
            companies.Add(companyD);

            Company companyF = new Company("F", "1234", "F",1000);
            companyF.AddVehicle(new Airplane(0,30, "Gaz", 20));
            companyF.AddVehicle(new Airplane(0,30, "Gaz", 20));
            companies.Add(companyF);

            Route busistanbulToKocaeliRoute = new Route("İstanbul", "Kocaeli", 100);
            Route buskocaeliToAnkaraRoute = new Route("Kocaeli", "Ankara", 400);
            Route busankaraToKocaeliRoute = new Route("Ankara", "Kocaeli", 400);
            Route buskocaeliToIstanbulRoute = new Route("Kocaeli", "İstanbul", 100);
            Route busistanbulToAnkaraRoute = new Route("İstanbul", "Ankara", 500);
            Route busAnkaraToIstanbulRoute = new Route("Ankara", "İstanbul", 500);
            Route buskocaeliToEskisehirRoute = new Route("Kocaeli", "Eskisehir", 200);
            Route buseskisehirToKocaeliRoute = new Route("Eskisehir", "Kocaeli", 200);
            Route buseskisehirToKonyaRoute = new Route("Eskisehir", "Konya", 300);
            Route buskonyaToEskisehirRoute = new Route("Konya", "Eskisehir", 300);

            Route busistanbulToEskisehirRoute = new Route("İstanbul", "Eskisehir", 300);
            Route buseskisehirToIstanbulRoute = new Route("Eskisehir", "İstanbul", 300);
            Route busistanbulToKonyaRoute = new Route("İstanbul", "Konya", 600);
            Route busKonyaToIstanbulRoute = new Route("Konya", "İstanbul", 600);
            Route buskocaeliToKonyaRoute = new Route("Kocaeli", "Konya", 500);
            Route buskonyaToKocaeliRoute = new Route("Konya", "Kocaeli", 500);



            Route airistanbulToKonyaRoute = new Route("İstanbul", "Konya", 300);
            Route airkonyaToIstanbulRoute = new Route("Konya", "İstanbul", 300);

            Route airistanbulToAnkaraRoute = new Route("İstanbul", "Ankara", 250);
            Route airankaraToIstanbulRoute = new Route("Ankara", "İstanbul", 250);

            Route trainistanbulToKocaeliRoute = new Route("İstanbul", "Kocaeli", 75);
            Route trainkocaeliToBilecikRoute = new Route("Kocaeli", "Bilecik", 75);
            Route trainbilecikToEskisehirRoute = new Route("Bilecik", "Eskisehir", 75);
            Route traineskisehirToAnkaraRoute = new Route("Eskisehir", "Ankara", 150);
            Route trainankaraToEskisehirRoute = new Route("Ankara", "Eskisehir", 150);
            Route traineskisehirToBilecikRoute = new Route("Eskisehir", "Bilecik", 75);
            Route trainbileciktoKocaeliRoute = new Route("Bilecik", "Kocaeli", 75);
            Route trainkocaeliToIstanbulRoute = new Route("Kocaeli", "İstanbul", 75);
            Route traineskisehirToKonyaRoute = new Route("Eskisehir", "Konya", 225);
            Route trainkonyaToEskisehirRoute = new Route("Konya", "Eskisehir", 225);

            Route trainistanbulToBilecikRoute = new Route("İstanbul", "Bilecik", 225);
            Route trainBilecikToIstanbulRoute = new Route("Bilecik", "İstanbul", 225);
            Route trainistanbulToEskisehirRoute = new Route("İstanbul", "Eskisehir", 300);
            Route trainistanbulToAnkaraRoute = new Route("İstanbul", "Ankara", 375);
            Route trainkocaeliToEskisehirRoute = new Route("Kocaeli", "Eskisehir", 150);
            Route trainEskisehirToKocaeliRoute = new Route("Eskisehir", "Kocaeli", 150);
            Route trainkocaeliToAnkaraRoute = new Route("Kocaeli", "Ankara", 300);
            Route trainankaraToKocaeliRoute = new Route("Ankara", "Kocaeli", 300);
            Route trainbilecikToAnkaraRoute = new Route("Bilecik", "Ankara", 225);
            Route trainankaraToBilecikRoute = new Route("Ankara", "Bilecik", 225);



            Trip busistanbulToKocaeliTrip = new Trip(3, companyA.Vehicles[0], busistanbulToKocaeliRoute, DateTime.Now, 50.0);
            Trip buskocaeliToAnkaraTrip = new Trip(3, companyA.Vehicles[0], buskocaeliToAnkaraRoute, DateTime.Now, 400.0);
            Trip busankaraToKocaeliTrip = new Trip(3, companyA.Vehicles[0], busankaraToKocaeliRoute, DateTime.Now, 400.0);
            Trip buskocaeliToIstanbulTrip = new Trip(3, companyA.Vehicles[0], buskocaeliToIstanbulRoute, DateTime.Now, 50.0);
            Trip busistanbulToAnkaraTrip = new Trip(3, companyA.Vehicles[0], busistanbulToAnkaraRoute, DateTime.Now, 300.0);
            Trip busAnkaraToIstanbulTrip = new Trip(3, companyA.Vehicles[0], busAnkaraToIstanbulRoute, DateTime.Now, 300.0);

            Trip busistanbulToKocaeliTrip2 = new Trip(3, companyA.Vehicles[1], busistanbulToKocaeliRoute, DateTime.Now, 50.0);
            Trip buskocaeliToAnkaraTrip2 = new Trip(3, companyA.Vehicles[1], buskocaeliToAnkaraRoute, DateTime.Now, 400.0);
            Trip busankaraToKocaeliTrip2 = new Trip(3, companyA.Vehicles[1], busankaraToKocaeliRoute, DateTime.Now, 400.0);
            Trip buskocaeliToIstanbulTrip2 = new Trip(3, companyA.Vehicles[1], buskocaeliToIstanbulRoute, DateTime.Now, 50.0);
            Trip busistanbulToAnkaraTrip2 = new Trip(3, companyA.Vehicles[1], busistanbulToAnkaraRoute, DateTime.Now, 300.0);
            Trip busAnkaraToIstanbulTrip2 = new Trip(3, companyA.Vehicles[1], busAnkaraToIstanbulRoute, DateTime.Now, 300.0);

            Trip busistanbulToKocaeliTripB1 = new Trip(3, companyB.Vehicles[0], busistanbulToKocaeliRoute, DateTime.Now, 50.0);
            Trip buskocaeliToAnkaraTripB1 = new Trip(3, companyB.Vehicles[0], buskocaeliToAnkaraRoute, DateTime.Now, 400.0);
            Trip busankaraToKocaeliTripB1 = new Trip(3, companyB.Vehicles[0], busankaraToKocaeliRoute, DateTime.Now, 400.0);
            Trip buskocaeliToIstanbulTripB1 = new Trip(3, companyB.Vehicles[0], buskocaeliToIstanbulRoute, DateTime.Now, 50.0);
            Trip busistanbulToAnkaraTripB1 = new Trip(3, companyB.Vehicles[0], busistanbulToAnkaraRoute, DateTime.Now, 300.0);
            Trip busAnkaraToIstanbulTripB1 = new Trip(3, companyB.Vehicles[0], busAnkaraToIstanbulRoute, DateTime.Now, 300.0);

            Trip busistanbulToKocaeliTripB2 = new Trip(4, companyB.Vehicles[1], busistanbulToKocaeliRoute, DateTime.Now, 50.0);
            Trip buskocaeliToEskisehirTripB2 = new Trip(4, companyB.Vehicles[1], buskocaeliToEskisehirRoute, DateTime.Now, 100.0);
            Trip buseskisehirToKonyaTripB2 = new Trip(4, companyB.Vehicles[1], buseskisehirToKonyaRoute, DateTime.Now, 150.0);
            Trip buskonyaToEskisehirTripB2 = new Trip(4, companyB.Vehicles[1], buskonyaToEskisehirRoute, DateTime.Now, 150.0);
            Trip buseskisehirToKocaeliTripB2 = new Trip(4, companyB.Vehicles[1], buseskisehirToKocaeliRoute, DateTime.Now, 100.0);
            Trip buskocaeliToIstanbulTripB2 = new Trip(4, companyB.Vehicles[1], buskocaeliToIstanbulRoute, DateTime.Now, 50.0);
            Trip busistanbulToEskisehirTripB2 = new Trip(4, companyB.Vehicles[1], busistanbulToEskisehirRoute, DateTime.Now, 150.0);
            Trip busistanbulToKonyaTripB2 = new Trip(4, companyB.Vehicles[1], busistanbulToKonyaRoute, DateTime.Now, 300.0);

            Trip busistanbulToKocaeliTripC1 = new Trip(4, companyC.Vehicles[0], busistanbulToKocaeliRoute, DateTime.Now, 50.0);
            Trip buskocaeliToEskisehirTripC1 = new Trip(4, companyC.Vehicles[0], buskocaeliToEskisehirRoute, DateTime.Now, 100.0);
            Trip buseskisehirToKonyaTripC1 = new Trip(4, companyC.Vehicles[0], buseskisehirToKonyaRoute, DateTime.Now, 150.0);
            Trip buskonyaToEskisehirTripC1 = new Trip(4, companyC.Vehicles[0], buskonyaToEskisehirRoute, DateTime.Now, 150.0);
            Trip buseskisehirToKocaeliTripC1 = new Trip(4, companyC.Vehicles[0], buseskisehirToKocaeliRoute, DateTime.Now, 100.0);
            Trip buskocaeliToIstanbulTripC1 = new Trip(4, companyC.Vehicles[0], buskocaeliToIstanbulRoute, DateTime.Now, 50.0);

            Trip airistanbulToKonyaTripC2 = new Trip(5, companyC.Vehicles[1], airistanbulToKonyaRoute, DateTime.Now, 1200.0);
            Trip airkonyaToIstanbulTripC2 = new Trip(5, companyC.Vehicles[1], airkonyaToIstanbulRoute, DateTime.Now, 1200.0);

            Trip airistanbulToKonyaTripC3 = new Trip(5, companyC.Vehicles[2], airistanbulToKonyaRoute, DateTime.Now, 1200.0);
            Trip airkonyaToIstanbulTripC3 = new Trip(5, companyC.Vehicles[2], airkonyaToIstanbulRoute, DateTime.Now, 1200.0);

            Trip trainistanbulToKocaeliTripD1 = new Trip(1, companyD.Vehicles[0], trainistanbulToKocaeliRoute, DateTime.Now, 50.0);
            Trip trainkocaeliToBilecikTripD1 = new Trip(1, companyD.Vehicles[0], trainkocaeliToBilecikRoute, DateTime.Now, 50.0);
            Trip trainbilecikToEskisehirTripD1 = new Trip(1, companyD.Vehicles[0], trainbilecikToEskisehirRoute, DateTime.Now, 50.0);
            Trip traineskisehirToAnkaraTripD1 = new Trip(1, companyD.Vehicles[0], traineskisehirToAnkaraRoute, DateTime.Now, 100.0);
            Trip trainankaraToEskisehirTripD1 = new Trip(1, companyD.Vehicles[0], trainankaraToEskisehirRoute, DateTime.Now, 100.0);
            Trip traineskisehirToBilecikTripD1 = new Trip(1, companyD.Vehicles[0], traineskisehirToBilecikRoute, DateTime.Now, 50.0);
            Trip trainbilecikToKocaeliTripD1 = new Trip(1, companyD.Vehicles[0], trainbileciktoKocaeliRoute, DateTime.Now, 50.0);
            Trip trainkocaeliToIstanbulTripD1 = new Trip(1, companyD.Vehicles[0], trainkocaeliToIstanbulRoute, DateTime.Now, 50.0);
            Trip trainistanbulToBilecikTripD1 = new Trip(1, companyD.Vehicles[0], trainistanbulToBilecikRoute, DateTime.Now, 150.0);
            Trip trainistanbulToEskisehirTripD1 = new Trip(1, companyD.Vehicles[0], trainistanbulToEskisehirRoute, DateTime.Now, 200.0);
            Trip trainistanbulToAnkaraTripD1 = new Trip(1, companyD.Vehicles[0], trainistanbulToAnkaraRoute, DateTime.Now, 250.0);
            Trip trainkocaeliToEskisehirTripD1 = new Trip(1, companyD.Vehicles[0], trainkocaeliToEskisehirRoute, DateTime.Now, 100.0);
            Trip trainkocaeliToAnkaraTripD1 = new Trip(1, companyD.Vehicles[0], trainkocaeliToAnkaraRoute, DateTime.Now, 200.0);
            Trip trainbilecikToAnkaraTripD1 = new Trip(1, companyD.Vehicles[0], trainbilecikToAnkaraRoute, DateTime.Now, 150.0);
            Trip trainankaraTobilecikTripD1 = new Trip(1, companyD.Vehicles[0], trainankaraToBilecikRoute, DateTime.Now, 200.0);
            Trip trainankaraToKocaeliTripD1 = new Trip(1, companyD.Vehicles[0], trainankaraToKocaeliRoute, DateTime.Now, 200.0);


            Trip trainistanbulToKocaeliTripD2 = new Trip(2, companyD.Vehicles[1], trainistanbulToKocaeliRoute, DateTime.Now, 50.0);
            Trip trainkocaeliToBilecikTripD2 = new Trip(2, companyD.Vehicles[1], trainkocaeliToBilecikRoute, DateTime.Now, 50.0);
            Trip trainbilecikToEskisehirTripD2 = new Trip(2, companyD.Vehicles[1], trainbilecikToEskisehirRoute, DateTime.Now, 50.0);
            Trip traineskisehirToKonyaTripD2 = new Trip(2, companyD.Vehicles[1], traineskisehirToKonyaRoute, DateTime.Now, 100.0);
            Trip trainkonyaToEskisehirTripD2 = new Trip(2, companyD.Vehicles[1], trainkonyaToEskisehirRoute, DateTime.Now, 100.0);
            Trip traineskisehirToBilecikD2 = new Trip(2, companyD.Vehicles[1], traineskisehirToBilecikRoute, DateTime.Now, 75.0);
            Trip trainbilecikToKocaeliTripD2 = new Trip(2, companyD.Vehicles[1], trainbileciktoKocaeliRoute, DateTime.Now, 50.0);
            Trip trainkocaeliToIstanbulTripD2 = new Trip(2, companyD.Vehicles[1], trainkocaeliToIstanbulRoute, DateTime.Now, 50.0);

            Trip trainistanbulToKocaeliTripD3 = new Trip(2, companyD.Vehicles[2], trainistanbulToKocaeliRoute, DateTime.Now, 50.0);
            Trip trainkocaeliToBilecikTripD3 = new Trip(2, companyD.Vehicles[2], trainkocaeliToBilecikRoute, DateTime.Now, 50.0);
            Trip trainbilecikToEskisehirTripD3 = new Trip(2, companyD.Vehicles[2], trainbilecikToEskisehirRoute, DateTime.Now, 50.0);
            Trip traineskisehirToKonyaTripD3 = new Trip(2, companyD.Vehicles[2], traineskisehirToKonyaRoute, DateTime.Now, 100.0);
            Trip trainkonyaToEskisehirTripD3 = new Trip(2, companyD.Vehicles[2], trainkonyaToEskisehirRoute, DateTime.Now, 100.0);
            Trip traineskisehirToBilecikD3 = new Trip(2, companyD.Vehicles[2], traineskisehirToBilecikRoute, DateTime.Now, 75.0);
            Trip trainbilecikToKocaeliTripD3 = new Trip(2, companyD.Vehicles[2], trainbileciktoKocaeliRoute, DateTime.Now, 50.0);
            Trip trainkocaeliToIstanbulTripD3 = new Trip(2, companyD.Vehicles[2], trainkocaeliToIstanbulRoute, DateTime.Now, 50.0);

            Trip airistanbulToAnkaraTripF1 = new Trip(6, companyF.Vehicles[0], airistanbulToAnkaraRoute, DateTime.Now, 1000.0);
            Trip airankaraToIstanbulTripF1 = new Trip(6, companyF.Vehicles[0], airankaraToIstanbulRoute, DateTime.Now, 1000.0);

            Trip airistanbulToAnkaraTripF2 = new Trip(6, companyF.Vehicles[0], airistanbulToAnkaraRoute, DateTime.Now, 1000.0);
            Trip airankaraToIstanbulTripF2 = new Trip(6, companyF.Vehicles[0], airankaraToIstanbulRoute, DateTime.Now, 1000.0);


            Console.WriteLine();


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;

            if (enteredUsername == adminUser.Username && enteredPassword == adminUser.Password)
            {
                Form2 form2 = new Form2(this);  
                form2.Companies = companies;
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string companyUsername = textBox3.Text;
            string companyPassword = textBox4.Text;

            
            foreach (var company in companies)
            {
                if (companyUsername == company.Username && companyPassword == company.Password)
                {
                    Form3 form3 = new Form3(this, company);
                    form3.Companies = companies;
                    form3.Show();
                    this.Hide();
                    return; 
                }
            }

            
            MessageBox.Show("Hatalı giriş yaptınız. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();

            
            
        }
    }
}
