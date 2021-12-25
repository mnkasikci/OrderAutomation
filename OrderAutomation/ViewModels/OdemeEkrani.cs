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
    public partial class OdemeEkrani : Form
    {
        private readonly OrderDetail _orderDetail;
        private readonly Customer _customer;
        private readonly Order _order;

        public OdemeEkrani(Customer customer, OrderDetail order) 
        {
            InitializeComponent();
            VergisizToplamBedel.Text = order.CalcSubTotal().ToString();
            _orderDetail = order;
            _customer = customer;
            _order = new Order(_orderDetail, DateTime.Now, _customer);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OdemeEkrani_Load(object sender, EventArgs e)
        {
            
        }

        private void VergisizToplamBedelEtiketi_Click(object sender, EventArgs e)
        {

        }

        private void nakitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nakit Ödeme Gerçekleşti","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void creditCardButton_Click(object sender, EventArgs e)
        {
            var x = new KrediKarti(_order);
            x.Show();
        }
    }
}
