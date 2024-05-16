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
    public partial class Form2 : Form
    {
        private List<Company> companies;
        private Form1 originalForm;

        public List<Company> Companies
        {
            set
            {
                listBox1.Items.Clear();
                companies = value;
                
                foreach (var company in companies)
                {
                    listBox1.Items.Add(company.CompanyName + "  ------  " + company.CompanyFee);
                    
                }
            }
        }
        public Form2(Form1 form1)
        {
            InitializeComponent();
            originalForm = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string companyName = textBox3.Text;
            string companyFeeText = textBox4.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(companyFeeText))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(companyFeeText, out int companyFee))
            {
                MessageBox.Show("Geçerli bir hizmet bedeli girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Company newCompany = new Company(username, password, companyName,companyFee)
            {
                
                CompanyFee = companyFee
            };

            companies.Add(newCompany);

            listBox1.Items.Add(newCompany.CompanyName + "  ------  " + newCompany.CompanyFee);
            MessageBox.Show("Firma başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            // Clear the TextBoxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Get the selected item's index
                int selectedIndex = listBox1.SelectedIndex;

                // Remove the corresponding Company object from the list
                Company companyToRemove = companies[selectedIndex];
                companies.Remove(companyToRemove);

                // Remove the selected item from the ListBox
                listBox1.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğeyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            originalForm.Show();  
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                
                int selectedIndex = listBox1.SelectedIndex;

                
                Company selectedCompany = companies[selectedIndex];

                
                string newFeeText = textBox5.Text;

                if (!int.TryParse(newFeeText, out int newFee))
                {
                    MessageBox.Show("Geçerli bir hizmet bedeli girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                selectedCompany.CompanyFee = newFee;

                
                listBox1.Items[selectedIndex] = selectedCompany.CompanyName + "  ------  " + selectedCompany.CompanyFee;

                MessageBox.Show("Hizmet bedeli başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFeeBox();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz öğeyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFeeBox()
        {
            
            textBox5.Text = "";
        }
    }
}
