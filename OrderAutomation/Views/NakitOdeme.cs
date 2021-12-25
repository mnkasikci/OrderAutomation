using OrderAutomation.Models;
using System;
using System.Windows.Forms;

namespace OrderAutomation.Views
{
    public partial class NakitOdeme : Form
    {
        private int enteredAmount;
        private readonly Order _order;
        private readonly decimal _totalAmount;

        public NakitOdeme(Order order)
        {
            InitializeComponent();
            _order = order;
            _totalAmount = _order.CalcTotal();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            enteredAmount = int.Parse(textBox1.Text);
            paraUstu.Text = enteredAmount > _totalAmount ? (enteredAmount - _totalAmount).ToString() : "";
            button1.Enabled = enteredAmount >= _totalAmount;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cash cash = new Cash(_order,enteredAmount);
            cash.ProcessPayment();
            MessageBox.Show("Nakit Ödeme Gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
