using OrderAutomation.DB;
using OrderAutomation.Models;
using OrderAutomation.ViewModels;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderAutomation.FormDbHelper
{
    public static class FormDBHelper
    {
        public static void SetColumns(this DataGridView gridView,DataGridViewColumn[] columns)
        {
            for(int i=0;i<columns.Length;i++)
            {
                gridView.Columns[i].Visible = columns[i].Visible;
                gridView.Columns[i].HeaderText = columns[i].HeaderText;
                gridView.Columns[i].Name = columns[i].Name;
            }
        }
        public static IEnumerable<Item> LoadItemsFromDb (this DataGridView gridView)
        {
            var dbResult = DBHelper.UrunListesiniAl();
            int row = 0;
            foreach (var item in dbResult)
            {
                gridView.Rows[row].Cells[0].Value = item.Id;
                gridView.Rows[row].Cells[1].Value = item.Name;
                gridView.Rows[row].Cells[2].Value = item.Price;
                gridView.Rows[row].Cells[3].Value = item.Description;
                gridView.Rows[row].Cells[4].Value = item.Weight;
                gridView.Rows[row].Cells[5].Value = item.Quantity;

                row++;
            }
            return dbResult;
        }

        public static void LoadOrders(this DataGridView orders)
        {
            var ordersList= DBHelper.GetOrders();
            var dataTable = DataTableHelper.CreateDataTable(ordersList);
            orders.DataSource = dataTable;
        }
        public static void LoadItems(this DataGridView items)
        {
            var itemsList = DBHelper.GetItems();
            var dataTable = DataTableHelper.CreateDataTable(itemsList);
            items.DataSource = dataTable;
            items.Columns[0].ReadOnly = true;
        }
        public static void LoadPayments(this DataGridView payments)
        {
            var paymentsList = DBHelper.GetPayments();
            var dataTable = DataTableHelper.CreateDataTable(paymentsList);
            payments.DataSource = dataTable;
        }

    }
}
