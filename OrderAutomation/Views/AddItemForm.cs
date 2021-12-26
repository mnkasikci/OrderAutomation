using OrderAutomation.DB;
using OrderAutomation.FormDbHelper;
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
    public partial class AddItemForm : Form
    {
        private readonly DataGridView _itemsGrid;

        public AddItemForm(DataGridView itemsGrid)
        {
            InitializeComponent();
            _itemsGrid = itemsGrid;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DBHelper.AddProduct(
                nameBox.Text.ToString(),
                decimal.Parse(priceBox.Text.ToString()),
                descBox.Text.ToString(),
                decimal.Parse(weightBox.Text.ToString()),
                int.Parse(quantityBox.Text.ToString()));
            _itemsGrid.LoadItems();
            this.Close();   
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
