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
    public partial class UrunForm : Form
    {
        OrnekEntities entities = new OrnekEntities();
        public UrunForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tumKayitlariGoster();
            

        }
        private void tumKayitlariGoster()
        {
            var urunler = entities.Urun.ToList();
            dataGridView1.DataSource = urunler;
            dataGridView1.ClearSelection();
            MetinKutuTemizle();
        }

        private void MetinKutuTemizle()
        {
            textAd.Clear();
            textId.Text = "0";
            textFiyat.Clear();
            
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
