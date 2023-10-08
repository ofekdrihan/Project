using SuperMarket.Backend;
using SuperMarket.Backend.Enums;
using SuperMarket.Backend.Model;
using SuperMarket.Frontend.UserControls;
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
    public partial class FormSpecific : Form
    {
        private eProducts currentProductType;
        public FormSpecific(Form1 parent, params eProducts[] specificProducts)
        {
            InitializeComponent();
            InitProductsComboBox(specificProducts);
        }

        private void InitProductsComboBox(eProducts[] specificProducts)
        {
            if (specificProducts.Length == 1)
            {
                comboBoxProduct.Visible = false;
                lblSubClass.Visible = false;
                if (specificProducts[0].ToString().Equals(eProducts.Meat.ToString()))
                {
                    panelUserControl.Controls.Add(new AddMeat());
                    currentProductType = eProducts.Meat;
                    dataGridViewSpecificProducts.DataSource = SuperMarketManager.GetSpecificProducts<Meat>();
                }
                else if (specificProducts[0].ToString().Equals(eProducts.Vegetables.ToString()))
                {
                    panelUserControl.Controls.Add(new AddVegtable());
                    currentProductType = eProducts.Vegetables;
                    dataGridViewSpecificProducts.DataSource = SuperMarketManager.GetSpecificProducts<Vegetables>();
                }
            }
            else
            {
                foreach (eProducts product in specificProducts)
                {
                    comboBoxProduct.Items.Add(product.ToString());
                }
            }
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelUserControl.Controls.Clear();
            if (comboBoxProduct.SelectedItem.ToString().Equals(eProducts.Chocolate.ToString()))
            {
                panelUserControl.Controls.Add(new AddChocolate());
                currentProductType = eProducts.Chocolate;
                dataGridViewSpecificProducts.DataSource = SuperMarketManager.GetSpecificProducts<Chocolate>();
            }
            else if (comboBoxProduct.SelectedItem.ToString().Equals(eProducts.Salty.ToString()))
            {
                panelUserControl.Controls.Add(new AddSalty());
                currentProductType = eProducts.Salty;
                dataGridViewSpecificProducts.DataSource = SuperMarketManager.GetSpecificProducts<Salty>();
            }
            else if (comboBoxProduct.SelectedItem.ToString().Equals(eProducts.HealthySnack.ToString()))
            {
                panelUserControl.Controls.Add(new AddHealthySnack());
                currentProductType = eProducts.HealthySnack;
                dataGridViewSpecificProducts.DataSource = SuperMarketManager.GetSpecificProducts<HealthySnack>();
            }
        }

        public void messageFact()
        {
            Product p = (Product)dataGridViewSpecificProducts.SelectedRows[0].DataBoundItem;
            MessageBox.Show(p.randomFact(), "Random Fact", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void addProduct()
        {
            if (currentProductType == eProducts.Chocolate)
            {
                AddChocolate addChocolate = (AddChocolate)panelUserControl.Controls[0];
                string name = addProductUserControl.textBoxName.Text;
                int weight = Int32.Parse(addProductUserControl.textBoxWeight.Text);
                double price = double.Parse(addProductUserControl.textBoxPrice.Text);
                //int price = Int32.Parse(addProductUserControl.textBoxPrice.Text);
                DateTime dateTime = addProductUserControl.dateTimePickerExpired.Value;
                int cocoaPrecent = Int32.Parse(addChocolate.cocoaPercent.Text);
                eChocolateKinds chocolateTypes = addChocolate.choclateType.SelectedIndex >= 0 ? (eChocolateKinds)addChocolate.choclateType.SelectedIndex : 0;
                eChocolateExtras chocolateExtras = addChocolate.choclateExtras.SelectedIndex >= 0 ? (eChocolateExtras)addChocolate.choclateExtras.SelectedIndex : 0;
                bool IsSugar = addChocolate.IsSugar.Checked;
                bool IsNuts = addChocolate.IsNuts.Checked;
                bool IsGluten = addChocolate.IsGluten.Checked;
                bool IsDairy = addChocolate.IsDairy.Checked;
                Chocolate chocolate = new Chocolate(name, price, weight, dateTime, IsDairy, IsSugar, IsGluten, IsNuts, cocoaPrecent, chocolateTypes, chocolateExtras);
                SuperMarketManager.AddProduct(chocolate);
                dataGridViewSpecificProducts.DataSource = SuperMarketManager.GetSpecificProducts<Chocolate>();
            }
            if (currentProductType == eProducts.HealthySnack)
            {
                AddHealthySnack addHealthySnack = (AddHealthySnack)panelUserControl.Controls[0];
                string name = addProductUserControl.textBoxName.Text;
                int weight = Int32.Parse(addProductUserControl.textBoxWeight.Text);
                double price = double.Parse(addProductUserControl.textBoxPrice.Text);
                DateTime dateTime = addProductUserControl.dateTimePickerExpired.Value;
                int gramOfProtein = Int32.Parse(addHealthySnack.gramOfProtein.Text);
                bool IsSugar = addHealthySnack.IsSugar.Checked;
                bool IsNuts = addHealthySnack.IsNuts.Checked;
                bool IsGluten = addHealthySnack.IsGluten.Checked;
                bool IsDairy = addHealthySnack.IsDairy.Checked;
                eHealthySnackPurposes healthySnackPurposes = addHealthySnack.Purpose.SelectedIndex >= 0 ? (eHealthySnackPurposes)addHealthySnack.Purpose.SelectedIndex : 0;
                HealthySnack healthySnack = new HealthySnack(name, price, weight, dateTime, IsDairy, IsSugar, IsGluten, IsNuts, gramOfProtein, healthySnackPurposes);
                SuperMarketManager.AddProduct(healthySnack);
                dataGridViewSpecificProducts.DataSource = SuperMarketManager.GetSpecificProducts<HealthySnack>();
            }
            if (currentProductType == eProducts.Salty)
            {
                AddSalty addSalty = (AddSalty)panelUserControl.Controls[0];
                string name = addProductUserControl.textBoxName.Text;
                int weight = Int32.Parse(addProductUserControl.textBoxWeight.Text);
                double price = double.Parse(addProductUserControl.textBoxPrice.Text);
                DateTime dateTime = addProductUserControl.dateTimePickerExpired.Value;
                bool IsSugar = addSalty.IsSugar.Checked;
                bool IsNuts = addSalty.IsNuts.Checked;
                bool IsGluten = addSalty.IsGluten.Checked;
                bool IsDairy = addSalty.IsDairy.Checked;
                eSaltyTypes saltyTypes = addSalty.saltyTypes.SelectedIndex >= 0 ? (eSaltyTypes)addSalty.saltyTypes.SelectedIndex : 0;
                Salty salty = new Salty(name, price, weight, dateTime, IsSugar, IsNuts, IsGluten, IsDairy, saltyTypes);
                SuperMarketManager.AddProduct(salty);
                dataGridViewSpecificProducts.DataSource = SuperMarketManager.GetSpecificProducts<Salty>();
            }

            if (currentProductType == eProducts.Meat)
            {
                AddMeat addMeat = (AddMeat)panelUserControl.Controls[0];
                string name = addProductUserControl.textBoxName.Text;
                double price = double.Parse(addProductUserControl.textBoxPrice.Text);
                int weight = Int32.Parse(addProductUserControl.textBoxWeight.Text);
                DateTime dateTime = addProductUserControl.dateTimePickerExpired.Value;
                bool IsFresh = addMeat.Isfresh.Checked;
                eMeatTypes meatTypes = addMeat.meatType.SelectedIndex >= 0 ? (eMeatTypes)addMeat.meatType.SelectedIndex : 0;
                Meat meat = new Meat(name, price, weight, dateTime, IsFresh, meatTypes);
                SuperMarketManager.AddProduct(meat);
                dataGridViewSpecificProducts.DataSource = SuperMarketManager.GetSpecificProducts<Meat>();
            }

            if (currentProductType == eProducts.Vegetables)
            {
                AddVegtable addVeg = (AddVegtable)panelUserControl.Controls[0];
                string name = addProductUserControl.textBoxName.Text;
                double price = double.Parse(addProductUserControl.textBoxPrice.Text);
                int weight = Int32.Parse(addProductUserControl.textBoxWeight.Text);
                DateTime dateTime = addProductUserControl.dateTimePickerExpired.Value;
                bool isFresh = addVeg.IsFresh.Checked;
                eVegetables vegTypes = addVeg.vegType.SelectedIndex >= 0 ? (eVegetables)addVeg.vegType.SelectedIndex : 0;
                bool isOrganic = addVeg.IsOrganic.Checked;
                Vegetables veg = new Vegetables(name, price, weight, dateTime, isFresh, vegTypes, isOrganic);
                SuperMarketManager.AddProduct(veg);
                dataGridViewSpecificProducts.DataSource = SuperMarketManager.GetSpecificProducts<Vegetables>();
            }
            addProductUserControl.textBoxName.Text = " ";
            addProductUserControl.textBoxPrice.Text = " ";
            addProductUserControl.textBoxWeight.Text = " ";
        }
        public void removeProduct()
        {
            foreach (DataGridViewRow row in dataGridViewSpecificProducts.SelectedRows)
            {
                Product p = (Product)row.DataBoundItem;
                SuperMarketManager.RemoveProduct(p);
                dataGridViewSpecificProducts.Rows.Remove(row);
            }
        }
    }
}
