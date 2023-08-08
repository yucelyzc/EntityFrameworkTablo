using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkUdemy
{
    public partial class MusteriForm : Form
    {
        OrnekEntities entities = new OrnekEntities();
        public MusteriForm()
        {
            InitializeComponent();
        }

      

        

        private void buttonList_Click(object sender, EventArgs e)
        {
            tumKayitlariGoster();
        }
        private void tumKayitlariGoster()
        {
            var musteriler = entities.Customer.ToList();
            dataGridView1.DataSource = musteriler;
            dataGridView1.ClearSelection();
            MetinKutuTemizle();
        }

        private void MetinKutuTemizle()
        {
            TextBoxName.Clear();
            textBoxCity.Clear();
            textBoxId.Text = "0";
            textBoxSurname.Clear();
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            tumKayitlariGoster();
            textBoxId.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer= new Customer();
            customer.Ad = TextBoxName.Text;
            customer.Soyad=textBoxSurname.Text;
            customer.Sehir=textBoxCity.Text;
            try
            {
                entities.Customer.Add(customer);
                entities.SaveChanges();
                MessageBox.Show("Musteri Kaydi Eklendi");
                tumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Tabani Islemleri Sirasinda Hata Olustu\n"+ex.Message.ToString());
                
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilensatir = dataGridView1.SelectedCells[0].RowIndex;
            textBoxId.Text = dataGridView1.Rows[secilensatir].Cells[0].Value.ToString();
            TextBoxName.Text = dataGridView1.Rows[secilensatir].Cells[1].Value.ToString();
                textBoxSurname.Text = dataGridView1.Rows[secilensatir].Cells[2].Value.ToString();
                textBoxCity.Text = dataGridView1.Rows[secilensatir].Cells[3].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int musteriId = Convert.ToInt32(textBoxId.Text);
                var musteri= entities.Customer.Find(musteriId);
                entities.Customer.Remove(musteri);
                entities.SaveChanges();
                MessageBox.Show("Musteri Kaydi Silindi");
                tumKayitlariGoster();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Veri Tabani Islemleri Sirasinda Hata Olustu\n" + ex.Message.ToString());
            }
        }
    }
}
