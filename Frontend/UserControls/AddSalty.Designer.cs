
namespace SuperMarket.Frontend.UserControls
{
    partial class AddSalty
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaltyTypes = new System.Windows.Forms.Label();
            this.cbSaltyTypes = new System.Windows.Forms.ComboBox();
            this.lblElergy = new System.Windows.Forms.Label();
            this.cbGluten = new System.Windows.Forms.CheckBox();
            this.cbNuts = new System.Windows.Forms.CheckBox();
            this.cbDairy = new System.Windows.Forms.CheckBox();
            this.cbSugar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSaltyTypes
            // 
            this.lblSaltyTypes.AutoSize = true;
            this.lblSaltyTypes.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSaltyTypes.Location = new System.Drawing.Point(2, 41);
            this.lblSaltyTypes.Name = "lblSaltyTypes";
            this.lblSaltyTypes.Size = new System.Drawing.Size(61, 19);
            this.lblSaltyTypes.TabIndex = 21;
            this.lblSaltyTypes.Text = "Types:";
            // 
            // cbSaltyTypes
            // 
            this.cbSaltyTypes.FormattingEnabled = true;
            this.cbSaltyTypes.Location = new System.Drawing.Point(69, 36);
            this.cbSaltyTypes.Name = "cbSaltyTypes";
            this.cbSaltyTypes.Size = new System.Drawing.Size(148, 24);
            this.cbSaltyTypes.TabIndex = 22;
            // 
            // lblElergy
            // 
            this.lblElergy.AutoSize = true;
            this.lblElergy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblElergy.Location = new System.Drawing.Point(6, 87);
            this.lblElergy.Name = "lblElergy";
            this.lblElergy.Size = new System.Drawing.Size(73, 19);
            this.lblElergy.TabIndex = 32;
            this.lblElergy.Text = "Allergic:";
            // 
            // cbGluten
            // 
            this.cbGluten.AutoSize = true;
            this.cbGluten.Location = new System.Drawing.Point(156, 115);
            this.cbGluten.Name = "cbGluten";
            this.cbGluten.Size = new System.Drawing.Size(69, 21);
            this.cbGluten.TabIndex = 31;
            this.cbGluten.Text = "gluten";
            this.cbGluten.UseVisualStyleBackColor = true;
            // 
            // cbNuts
            // 
            this.cbNuts.AutoSize = true;
            this.cbNuts.Location = new System.Drawing.Point(84, 115);
            this.cbNuts.Name = "cbNuts";
            this.cbNuts.Size = new System.Drawing.Size(57, 21);
            this.cbNuts.TabIndex = 30;
            this.cbNuts.Text = "nuts";
            this.cbNuts.UseVisualStyleBackColor = true;
            // 
            // cbDairy
            // 
            this.cbDairy.AutoSize = true;
            this.cbDairy.Location = new System.Drawing.Point(156, 88);
            this.cbDairy.Name = "cbDairy";
            this.cbDairy.Size = new System.Drawing.Size(61, 21);
            this.cbDairy.TabIndex = 29;
            this.cbDairy.Text = "dairy";
            this.cbDairy.UseVisualStyleBackColor = true;
            // 
            // cbSugar
            // 
            this.cbSugar.AutoSize = true;
            this.cbSugar.Location = new System.Drawing.Point(84, 88);
            this.cbSugar.Name = "cbSugar";
            this.cbSugar.Size = new System.Drawing.Size(66, 21);
            this.cbSugar.TabIndex = 28;
            this.cbSugar.Text = "sugar";
            this.cbSugar.UseVisualStyleBackColor = true;
            // 
            // AddSalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblElergy);
            this.Controls.Add(this.cbGluten);
            this.Controls.Add(this.cbNuts);
            this.Controls.Add(this.cbDairy);
            this.Controls.Add(this.cbSugar);
            this.Controls.Add(this.cbSaltyTypes);
            this.Controls.Add(this.lblSaltyTypes);
            this.Name = "AddSalty";
            this.Size = new System.Drawing.Size(231, 223);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSaltyTypes;
        private System.Windows.Forms.ComboBox cbSaltyTypes;
        private System.Windows.Forms.Label lblElergy;
        private System.Windows.Forms.CheckBox cbGluten;
        private System.Windows.Forms.CheckBox cbNuts;
        private System.Windows.Forms.CheckBox cbDairy;
        private System.Windows.Forms.CheckBox cbSugar;
    }
}
