using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomation
{
    public partial class AlisVerisEkrani : Form
    {
        public AlisVerisEkrani()
        {
            InitializeComponent();
        }
        public decimal ToplamFiyat = 0;
        public decimal VergisizToplamFiyat;
        private void button1_Click(object sender, EventArgs e)
        {

            shophingclass shp = new shophingclass();
            
            int secilensatir = dataGridView1.SelectedCells[0].RowIndex;

            //datagriden çek
            decimal SecilenUrunFiyat = Convert.ToDecimal(dataGridView1.Rows[secilensatir].Cells[2].Value);
            string SecilenUrun = dataGridView1.Rows[secilensatir].Cells[1].Value.ToString();
            int UrunAdet = Convert.ToInt16(comboBox1.SelectedItem);
            shp.ShoppingTaxfreePrice = SecilenUrunFiyat;
            shp.CalcTax();
            ToplamFiyat += shp.ShoppingTaxwithPrice*UrunAdet;
            VergisizToplamFiyat += shp.ShoppingTaxfreePrice * UrunAdet;
            listBox1.Items.Add(UrunAdet + "*" + SecilenUrun );
            labelkdvsiz.Text = VergisizToplamFiyat.ToString();
            labelkdvli.Text = ToplamFiyat.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add();//datagridviewe yeni satır ekler
            //sıfır indisli satıra yani birinci satıra veri ekler
            dataGridView1.Rows[0].Cells[0].Value = 1;
            dataGridView1.Rows[0].Cells[1].Value = "pantalon";
            dataGridView1.Rows[0].Cells[2].Value = "100";
            //bir indisli satıra yani ikinci satıra veri ekler
            dataGridView1.Rows[1].Cells[0].Value = 2;
            dataGridView1.Rows[1].Cells[1].Value = "saat";
            dataGridView1.Rows[1].Cells[2].Value = "10";
        }
    }
}
