using SuperMarket.Backend;
using SuperMarket.Backend.Enums;
using System;
using System.Windows.Forms;
using WMPLib;


namespace SuperMarket.Frontend.Forms
{
    public partial class Form1 : Form
    {
        public event EventHandler buttonAddClicked;
        public event EventHandler buttonRemoveClicked;
        public event EventHandler buttonRemoveAllProductsClicked;
        private Form activeForm;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();


        public Form1()
        {
            InitializeComponent();
            player.URL = "super.mp3";
            player.controls.stop();
            this.FormClosing += new FormClosingEventHandler(SuperMarketManager.SaveProductsToFile);
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            pbSuper.Visible = false;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BringToFront();
            panelSpecificProduct.Controls.Add(activeForm);
            childForm.Show();
            
        }

        private void buttonSnakes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSpecific(this, eProducts.Chocolate, eProducts.HealthySnack, eProducts.Salty));
        }

        private void buttonMeat_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSpecific(this, eProducts.Meat));
        }

        private void buttonCleaning_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSpecific(this, eProducts.Vegetables));
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (activeForm is FormSpecific)
            {
                ((FormSpecific)activeForm).addProduct();
            }
            
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (activeForm is FormSpecific)
            {
                ((FormSpecific)activeForm).removeProduct();
            }
            if (activeForm is AllProducts)
            {
                ((AllProducts)activeForm).removeProduct();
            }
        }

        private void buttonAllProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new AllProducts(this));
            player.controls.play();
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            if (activeForm is FormSpecific)
            {
                ((FormSpecific)activeForm).messageFact();
            }
            if (activeForm is AllProducts)
            {
                ((AllProducts)activeForm).messageFact();
            }
        }
    }
}
