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
    public partial class Form3 : Form
    {
        
        public List<Company> Companies { get; set; }

        private Company selectedCompany;



        
        private Form1 mainForm;

        private string item;

        
        public Form3(Form1 mainForm, Company selectedCompany)
        {
            InitializeComponent();
            this.selectedCompany = selectedCompany;
            DisplayVehicles();

            
            comboBox1.Items.Add("Otobüs");
            comboBox1.Items.Add("Tren");
            comboBox1.Items.Add("Uçak");
            this.mainForm = mainForm;
        }

        private void DisplayVehicles()
        {
            listBox1.Items.Clear();

            foreach (Vehicle vehicle in selectedCompany.Vehicles)
            {
                listBox1.Items.Add($"{vehicle.GetType().Name}{vehicle.VehicleId} - Koltuk: {vehicle.SeatCount}, Yakıt: {vehicle.FuelType}, Tüketim: {vehicle.FuelConsumptionRate}");
            }
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int seatCount) &&
            double.TryParse(textBox2.Text, out double fuelConsumptionRate) &&
            comboBox1.SelectedItem != null)
            {
                string vehicleType = comboBox1.SelectedItem.ToString();
                string fuelType = textBox3.Text;

                
                Vehicle newVehicle = null;

                switch (vehicleType)
                {
                    case "Otobüs":
                        newVehicle = new Bus(0,seatCount, fuelType, fuelConsumptionRate);
                        break;
                    case "Tren":
                        newVehicle = new Train(0,seatCount, fuelType, fuelConsumptionRate);
                        break;
                    case "Uçak":
                        newVehicle = new Airplane(0,seatCount, fuelType, fuelConsumptionRate);
                        break;
                    default:
                        MessageBox.Show("Yanlış Araç Seçimi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                selectedCompany.AddVehicle(newVehicle);
                DisplayVehicles();
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                selectedCompany.Vehicles.RemoveAt(listBox1.SelectedIndex);
                DisplayVehicles();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz aracı seçin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = comboBox2.SelectedItem.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(item);
        }

        private void AddRoutesToListBox(Company company)
        {

            listBox2.Items.Clear();

            string first = "1.sefer Demiryolu: İstanbul - Kocaeli - Bilecik - Eskişehir - Ankara - Eskişehir - Bilecik - Kocaeli - İstanbul (gidiş dönüş)";
            listBox2.Items.Add(first);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }
    }
}
