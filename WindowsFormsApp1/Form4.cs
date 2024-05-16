using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void cmbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBus = cmbOtobus.SelectedItem.ToString();
            switch (selectedBus)
            {
                case "Bus1":koltukdoldur(8, false);
                    break;
                case "Bus2":koltukdoldur(12, false);
                    break;
                case "Bus3":koltukdoldur(16, false);
                    break;
            }

            void koltukdoldur(int sira, bool arkabeslimi)
            {
                yavaslat:
                foreach(Control ctrl in this.Controls)
                {
                    if(ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if(btn.Text=="Kaydet")
                        {
                            continue;
                        }
                        else
                        {
                            this.Controls.Remove(ctrl);
                            goto yavaslat;
                        }
                    }
                }

                int koltukno = 1;
                for(int i = 0; i < sira; i++)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 5 + (j * 45);
                        koltuk.Text = koltukno.ToString();
                        koltukno++;
                        koltuk.ContextMenuStrip = contextMenuStrip1;
                        koltuk.MouseDown += Koltuk_MouseDown;
                        this.Controls.Add(koltuk);
                    }
                }
            }
        }

        Button tiklanan;

        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cmbOtobus.SelectedIndex==-1 || cmbNereden.SelectedIndex==-1 || cmbNereye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return;
            }
            Form5 kayit = new Form5();
            DialogResult sonuc = kayit.ShowDialog();
            if(sonuc==DialogResult.OK)
            {
                ListViewItem item = new ListViewItem();
                item.Text = string.Format("{0} {1} {2} {3}", kayit.textBox1, kayit.textBox2, kayit.textBox3,kayit.dateTimePicker1);

                item.SubItems.Add(cmbNereden.Text);
                item.SubItems.Add(cmbNereye.Text);
                item.SubItems.Add(tiklanan.Text);
                item.SubItems.Add(dateTimePicker1.Text);

                tiklanan.BackColor = Color.Red;
                listView1.Items.Add(item);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
