using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSYS_Min
{
    public partial class Form1 : Form
    {
        DAO dao;
        DataTable dt;
        BindingSource bs;
        public Form1()
        {
            InitializeComponent();
            dao = new DAO();
             dt = dao.GetStock();
             bs = new BindingSource();
            bs.DataSource = dt;
            dataGrid.DataSource = bs;

        }

        private void SALE_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Sale agreed: " + txtTotal.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
          
       }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            string desc = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            string price = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString()                ;
            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = id;
            item.SubItems.Add(desc);
            item.SubItems.Add(price);
            lvReceipt.Items.Add(item);
            lvReceipt.View = View.Details;

            txtTotal.Text = getTotalPrice(txtTotal.Text, price);

        }
        public string getTotalPrice(String totalPrice,String price)
        {
            string ans = (Convert.ToDecimal(totalPrice) + Convert.ToDecimal(price)).ToString();
            return ans;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dt = dao.GetByCategory(cmbCategories.SelectedItem.ToString());
            bs.DataSource = dt;
        }
    }
}
