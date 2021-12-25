using OrderAutomation.FormDbHelper;
using OrderAutomation.Models;
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
        OrderDetail _orderDetail;
        public AlisVerisEkrani(Customer customer)
        {
            InitializeComponent();
            _orderDetail = new();
            _customer = customer;
        }
        public decimal ToplamFiyat = 0;
        public decimal VergisizToplamFiyat;
        private readonly Customer _customer;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text!="")
            {


                shophingclass shp = new shophingclass();

                int secilensatir = dataGridView1.SelectedCells[0].RowIndex;

                //datagriden çek
                decimal SecilenUrunFiyat = Convert.ToDecimal(dataGridView1.Rows[secilensatir].Cells[2].Value);
                string SecilenUrun = dataGridView1.Rows[secilensatir].Cells[1].Value.ToString();
                int UrunAdet = Convert.ToInt16(comboBox1.SelectedItem);
                shp.ShoppingTaxfreePrice = SecilenUrunFiyat;
                shp.CalcTax();
                ToplamFiyat += shp.ShoppingTaxwithPrice * UrunAdet;
                VergisizToplamFiyat += shp.ShoppingTaxfreePrice * UrunAdet;
                listBox1.Items.Add(UrunAdet + "*" + SecilenUrun);
                labelkdvsiz.Text = VergisizToplamFiyat.ToString();
                labelkdvli.Text = ToplamFiyat.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var rowId = dataGridView1.Rows.Add();//datagridviewe yeni satır ekler


            var columns = new DataGridViewColumn[]
            {
                new DataGridViewColumn{Visible = false, Name = "ID"},
                new DataGridViewColumn{HeaderText = "Urun Adi"},
                new DataGridViewColumn{HeaderText = "Birim Fiyat"}
            };
            
            //sıfır indisli satıra yani birinci satıra veri ekler
            dataGridView1.SetColumns(columns);
            dataGridView1.LoadItemsFromDb();


            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].HeaderText = "Urun Adi";
            //dataGridView1.Columns[2].HeaderText = "Birim Fiyat";

            ////dataGridView1.Cells[0].Value = 1;
            //dataGridView1.Rows[0].Cells[1].Value = "pantalon";
            //dataGridView1.Rows[0].Cells[2].Value = "100";

            ////bir indisli satıra yani ikinci satıra veri ekler
            //dataGridView1.Rows[1].Cells[0].Value = 2;
            //dataGridView1.Rows[1].Cells[1].Value = "saat";
            //dataGridView1.Rows[1].Cells[2].Value = "10";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ToplamFiyat = VergisizToplamFiyat = 0;
            labelkdvsiz.Text = VergisizToplamFiyat.ToString();
            labelkdvli.Text = ToplamFiyat.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdemeEkrani x = new OdemeEkrani(_customer, _orderDetail);
            x.Show();
        }
    }
}
