using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
    public partial class addSaleGrid : Form
    {

        
        public int pRowIndex { get; set; }
        
        public addSaleGrid()
        {
            InitializeComponent();
            pRowIndex = cashMain.instance.productGrid1.CurrentCell.RowIndex;
            this.Text = cashMain.instance.productGrid1.Rows[pRowIndex].Cells["Products"].Value.ToString();
        }

        private void add_to_grid_btn_Click(object sender, EventArgs e)
        {
            int rowId = cashMain.instance.salesGrid1.Rows.Add();

            // Grab the new row!
            DataGridViewRow row = cashMain.instance.salesGrid1.Rows[rowId];

            // Add the data
            int num_units = int.Parse(unitsBox.Text);
            float unit_price = float.Parse(cashMain.instance.productGrid1.Rows[pRowIndex].Cells["Price"].Value.ToString());
            row.Cells["Items"].Value = cashMain.instance.productGrid1.Rows[pRowIndex].Cells["Products"].Value.ToString();
            row.Cells["units"].Value = num_units.ToString();
            row.Cells["unit Price"].Value = unit_price.ToString();
            float result = num_units * unit_price;
            row.Cells["total"].Value = result.ToString();
            cashMain.instance.totalPrice.Text = cashMain.CalculateTotal().ToString();
            cashMain.instance.deletebtn.Enabled = true;
            this.Close();



        }

        // only allow numbers
        private void unitsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
