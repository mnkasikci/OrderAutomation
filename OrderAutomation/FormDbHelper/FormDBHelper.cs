using OrderAutomation.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static void LoadItemsFromDb(this DataGridView gridView)
        {
            var dbResult = DBHelper.UrunListesiniAl();
            int row = 0;
            foreach (var item in dbResult)
            {
                gridView.Rows[row].Cells[0].Value = item.Id;
                gridView.Rows[row].Cells[1].Value = item.Name;
                gridView.Rows[row].Cells[2].Value = item.Price;
                row++;
            }
        }
    }
}
