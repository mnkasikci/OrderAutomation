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

namespace OrderAutomation.Views
{
    public partial class OdemeEkrani : Form
    {
        private readonly OrderDetail _orderDetail;
        private readonly Customer _customer;
        private readonly Order _order;

        public OdemeEkrani(Customer customer, OrderDetail order) 
        {
            InitializeComponent();
            var amount = order.CalcSubTotal();
            VergisizToplamBedel.Text = amount.ToString();
            toplamBedel.Text = (amount * 1.18M).ToString();
            _orderDetail = order;
            _customer = customer;
            _order = new Order(_orderDetail, DateTime.Now, _customer);

        }

        private void OdemeEkrani_Load(object sender, EventArgs e)
        {
            
        }

        private void VergisizToplamBedelEtiketi_Click(object sender, EventArgs e)
        {

        }

        private void nakitButton_Click(object sender, EventArgs e)
        {
            var x = new NakitOdeme(_order);
            x.Show();
        }

        private void creditCardButton_Click(object sender, EventArgs e)
        {
            var x = new KrediKarti(_order);
            x.Show();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            var x = new CekOdeme(_order);
            x.Show();
        }
    }
}
