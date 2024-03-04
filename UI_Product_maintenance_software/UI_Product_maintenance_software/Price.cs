using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Product_maintenance_software
{
    public partial class Price : Form
    {
        public static Add instance;

        public Price()
        {
            InitializeComponent();
            //instance = this;
        }

        private void Price_Load(object sender, EventArgs e)
        {

        }

        private void Addproduct_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addproduct_Save_Click(object sender, EventArgs e)
        {

            // Mainlist.SelectedItems[0].SubItems[1].Text = Price_box;
            var i = Main.instance.Mainlist.FocusedItem.Index;
            Main.instance.Mainlist.Items[i].SubItems[1].Text = Price_box.Text;
            this.Close();
        }

        private void Price_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
