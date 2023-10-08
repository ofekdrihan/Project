using SuperMarket.Backend;
using SuperMarket.Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Frontend.Forms
{
    public partial class AllProducts : Form
    {
        public AllProducts(Form1 parent)
        {
            InitializeComponent();
            dgvAllProducts.DataSource = SuperMarketManager.GetProducts();
        }

        public void removeProduct()
        {
            foreach (DataGridViewRow row in dgvAllProducts.SelectedRows)
            {
                Product p = (Product)row.DataBoundItem;
                SuperMarketManager.RemoveProduct(p);
            }
        }

        public void messageFact()
        {
            Product p = (Product)dgvAllProducts.SelectedRows[0].DataBoundItem;
            MessageBox.Show(p.randomFact(), "Random Fact", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
