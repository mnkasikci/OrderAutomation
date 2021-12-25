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
        OrderDetailView _orderDetail;
        List<Item> Items;
        public AlisVerisEkrani(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            _orderDetail = new();
        }
        
        private readonly Customer _customer;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text!="")
            {

                int chosenRow = dataGridView1.SelectedCells[0].RowIndex;
                int quantity = Convert.ToInt16(comboBox1.SelectedItem);

                _orderDetail.AddItemView(quantity, Items[chosenRow]);
                _orderDetail.ReGenerate(listBox1);
                decimal subTotal = _orderDetail.CalcSubTotal();
                labelkdvsiz.Text = subTotal.ToString();
                labelkdvli.Text = (subTotal * 1.18M).ToString();

                //listBox1.Items.Add(UrunAdet + " * " + SecilenUrun);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var rowId = dataGridView1.Rows.Add();//datagridviewe yeni satır ekler


            var columns = new DataGridViewColumn[]
            {
                new DataGridViewColumn{Visible = false, Name = "ID"},
                new DataGridViewColumn{HeaderText = "Urun Adi"},
                new DataGridViewColumn{HeaderText = "Birim Fiyat"},
                new DataGridViewColumn{HeaderText = "Aciklama"},
                new DataGridViewColumn{HeaderText = "Agirlik"},
                new DataGridViewColumn{HeaderText = "Stok"}
            };
            
            //sıfır indisli satıra yani birinci satıra veri ekler
            dataGridView1.SetColumns(columns);
            Items = dataGridView1.LoadItemsFromDb().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _orderDetail.ClearItems();
            _orderDetail.ReGenerate(listBox1);
            labelkdvsiz.Text = labelkdvli.Text = "";
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
