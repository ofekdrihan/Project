
namespace SuperMarket.Frontend.Forms
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFact = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.buttonVegetables = new System.Windows.Forms.Button();
            this.buttonMeat = new System.Windows.Forms.Button();
            this.buttonSnakes = new System.Windows.Forms.Button();
            this.buttonAllProducts = new System.Windows.Forms.Button();
            this.panelSpecificProduct = new System.Windows.Forms.Panel();
            this.pbSuper = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelSpecificProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuper)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFact);
            this.panel1.Controls.Add(this.btnRemoveProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.buttonVegetables);
            this.panel1.Controls.Add(this.buttonMeat);
            this.panel1.Controls.Add(this.buttonSnakes);
            this.panel1.Controls.Add(this.buttonAllProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 462);
            this.panel1.TabIndex = 0;
            // 
            // btnFact
            // 
            this.btnFact.BackgroundImage = global::SuperMarket.Properties.Resources.find;
            this.btnFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFact.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFact.Location = new System.Drawing.Point(0, 385);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(250, 70);
            this.btnFact.TabIndex = 6;
            this.btnFact.UseVisualStyleBackColor = true;
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.BackgroundImage = global::SuperMarket.Properties.Resources.btnRemove;
            this.btnRemoveProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(126, 309);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(124, 70);
            this.btnRemoveProduct.TabIndex = 5;
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackgroundImage = global::SuperMarket.Properties.Resources.btnAdd;
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddProduct.Location = new System.Drawing.Point(0, 309);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(124, 70);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // buttonVegetables
            // 
            this.buttonVegetables.BackgroundImage = global::SuperMarket.Properties.Resources.Veg;
            this.buttonVegetables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVegetables.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVegetables.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVegetables.Location = new System.Drawing.Point(0, 233);
            this.buttonVegetables.Name = "buttonVegetables";
            this.buttonVegetables.Size = new System.Drawing.Size(250, 70);
            this.buttonVegetables.TabIndex = 3;
            this.buttonVegetables.UseVisualStyleBackColor = true;
            this.buttonVegetables.Click += new System.EventHandler(this.buttonCleaning_Click);
            // 
            // buttonMeat
            // 
            this.buttonMeat.BackgroundImage = global::SuperMarket.Properties.Resources.Meat;
            this.buttonMeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMeat.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMeat.Location = new System.Drawing.Point(0, 157);
            this.buttonMeat.Name = "buttonMeat";
            this.buttonMeat.Size = new System.Drawing.Size(250, 70);
            this.buttonMeat.TabIndex = 2;
            this.buttonMeat.UseVisualStyleBackColor = true;
            this.buttonMeat.Click += new System.EventHandler(this.buttonMeat_Click);
            // 
            // buttonSnakes
            // 
            this.buttonSnakes.BackgroundImage = global::SuperMarket.Properties.Resources.Snack;
            this.buttonSnakes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSnakes.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSnakes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSnakes.Location = new System.Drawing.Point(3, 81);
            this.buttonSnakes.Name = "buttonSnakes";
            this.buttonSnakes.Size = new System.Drawing.Size(250, 70);
            this.buttonSnakes.TabIndex = 1;
            this.buttonSnakes.UseVisualStyleBackColor = true;
            this.buttonSnakes.Click += new System.EventHandler(this.buttonSnakes_Click);
            // 
            // buttonAllProducts
            // 
            this.buttonAllProducts.BackgroundImage = global::SuperMarket.Properties.Resources.AllPro;
            this.buttonAllProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAllProducts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAllProducts.Location = new System.Drawing.Point(3, 5);
            this.buttonAllProducts.Name = "buttonAllProducts";
            this.buttonAllProducts.Size = new System.Drawing.Size(250, 70);
            this.buttonAllProducts.TabIndex = 0;
            this.buttonAllProducts.UseVisualStyleBackColor = true;
            this.buttonAllProducts.Click += new System.EventHandler(this.buttonAllProducts_Click);
            // 
            // panelSpecificProduct
            // 
            this.panelSpecificProduct.Controls.Add(this.pbSuper);
            this.panelSpecificProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSpecificProduct.Location = new System.Drawing.Point(250, 0);
            this.panelSpecificProduct.Name = "panelSpecificProduct";
            this.panelSpecificProduct.Size = new System.Drawing.Size(1267, 462);
            this.panelSpecificProduct.TabIndex = 1;
            // 
            // pbSuper
            // 
            this.pbSuper.BackgroundImage = global::SuperMarket.Properties.Resources.super2;
            this.pbSuper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSuper.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbSuper.Location = new System.Drawing.Point(0, 0);
            this.pbSuper.Name = "pbSuper";
            this.pbSuper.Size = new System.Drawing.Size(1267, 462);
            this.pbSuper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSuper.TabIndex = 0;
            this.pbSuper.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 462);
            this.Controls.Add(this.panelSpecificProduct);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperMarket";
            this.panel1.ResumeLayout(false);
            this.panelSpecificProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSuper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSpecificProduct;
        private System.Windows.Forms.Button buttonVegetables;
        private System.Windows.Forms.Button buttonMeat;
        private System.Windows.Forms.Button buttonSnakes;
        private System.Windows.Forms.Button buttonAllProducts;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.PictureBox pbSuper;
    }
}

