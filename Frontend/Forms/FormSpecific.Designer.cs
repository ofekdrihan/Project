
namespace SuperMarket.Frontend.Forms
{
    partial class FormSpecific
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewSpecificProducts = new System.Windows.Forms.DataGridView();
            this.lblSubClass = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.panelAddUserControl = new System.Windows.Forms.Panel();
            this.panelUserControl = new System.Windows.Forms.Panel();
            this.addProductUserControl = new SuperMarket.Frontend.UserControls.AddProduct();
            this.superMarketManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecificProducts)).BeginInit();
            this.panelAddUserControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSpecificProducts
            // 
            this.dataGridViewSpecificProducts.AllowUserToAddRows = false;
            this.dataGridViewSpecificProducts.AllowUserToDeleteRows = false;
            this.dataGridViewSpecificProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecificProducts.Location = new System.Drawing.Point(300, 2);
            this.dataGridViewSpecificProducts.Name = "dataGridViewSpecificProducts";
            this.dataGridViewSpecificProducts.RowHeadersWidth = 51;
            this.dataGridViewSpecificProducts.RowTemplate.Height = 24;
            this.dataGridViewSpecificProducts.Size = new System.Drawing.Size(946, 442);
            this.dataGridViewSpecificProducts.TabIndex = 0;
            // 
            // lblSubClass
            // 
            this.lblSubClass.AutoSize = true;
            this.lblSubClass.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSubClass.Location = new System.Drawing.Point(40, 22);
            this.lblSubClass.Name = "lblSubClass";
            this.lblSubClass.Size = new System.Drawing.Size(104, 22);
            this.lblSubClass.TabIndex = 1;
            this.lblSubClass.Text = "Sub Class";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(150, 23);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProduct.TabIndex = 2;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // panelAddUserControl
            // 
            this.panelAddUserControl.Controls.Add(this.panelUserControl);
            this.panelAddUserControl.Controls.Add(this.addProductUserControl);
            this.panelAddUserControl.Location = new System.Drawing.Point(12, 62);
            this.panelAddUserControl.Name = "panelAddUserControl";
            this.panelAddUserControl.Size = new System.Drawing.Size(259, 382);
            this.panelAddUserControl.TabIndex = 3;
            // 
            // panelUserControl
            // 
            this.panelUserControl.Location = new System.Drawing.Point(0, 159);
            this.panelUserControl.Name = "panelUserControl";
            this.panelUserControl.Size = new System.Drawing.Size(259, 223);
            this.panelUserControl.TabIndex = 1;
            // 
            // addProductUserControl
            // 
            this.addProductUserControl.Location = new System.Drawing.Point(3, 3);
            this.addProductUserControl.Name = "addProductUserControl";
            this.addProductUserControl.Size = new System.Drawing.Size(279, 382);
            this.addProductUserControl.TabIndex = 2;
            // 
            // superMarketManagerBindingSource
            // 
            this.superMarketManagerBindingSource.DataSource = typeof(SuperMarket.Backend.SuperMarketManager);
            // 
            // FormSpecific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 450);
            this.Controls.Add(this.panelAddUserControl);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.lblSubClass);
            this.Controls.Add(this.dataGridViewSpecificProducts);
            this.Name = "FormSpecific";
            this.Text = "FormSpecific";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecificProducts)).EndInit();
            this.panelAddUserControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superMarketManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource superMarketManagerBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewSpecificProducts;
        private System.Windows.Forms.Label lblSubClass;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Panel panelAddUserControl;
        private System.Windows.Forms.Panel panelUserControl;
        private UserControls.AddProduct addProductUserControl;
    }
}