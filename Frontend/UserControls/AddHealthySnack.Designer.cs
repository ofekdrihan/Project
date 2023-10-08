
namespace SuperMarket.Frontend.UserControls
{
    partial class AddHealthySnack
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
            this.txtGOP = new System.Windows.Forms.TextBox();
            this.lblProteinGram = new System.Windows.Forms.Label();
            this.lblElergy = new System.Windows.Forms.Label();
            this.cbGluten = new System.Windows.Forms.CheckBox();
            this.cbNuts = new System.Windows.Forms.CheckBox();
            this.cbDairy = new System.Windows.Forms.CheckBox();
            this.cbSugar = new System.Windows.Forms.CheckBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.cbPurpose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtGOP
            // 
            this.txtGOP.Location = new System.Drawing.Point(105, 40);
            this.txtGOP.Name = "txtGOP";
            this.txtGOP.Size = new System.Drawing.Size(123, 22);
            this.txtGOP.TabIndex = 22;
            // 
            // lblProteinGram
            // 
            this.lblProteinGram.AutoSize = true;
            this.lblProteinGram.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblProteinGram.Location = new System.Drawing.Point(2, 41);
            this.lblProteinGram.Name = "lblProteinGram";
            this.lblProteinGram.Size = new System.Drawing.Size(97, 19);
            this.lblProteinGram.TabIndex = 21;
            this.lblProteinGram.Text = "protein gr.:";
            // 
            // lblElergy
            // 
            this.lblElergy.AutoSize = true;
            this.lblElergy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblElergy.Location = new System.Drawing.Point(3, 127);
            this.lblElergy.Name = "lblElergy";
            this.lblElergy.Size = new System.Drawing.Size(73, 19);
            this.lblElergy.TabIndex = 27;
            this.lblElergy.Text = "Allergic:";
            // 
            // cbGluten
            // 
            this.cbGluten.AutoSize = true;
            this.cbGluten.Location = new System.Drawing.Point(161, 155);
            this.cbGluten.Name = "cbGluten";
            this.cbGluten.Size = new System.Drawing.Size(69, 21);
            this.cbGluten.TabIndex = 26;
            this.cbGluten.Text = "gluten";
            this.cbGluten.UseVisualStyleBackColor = true;
            // 
            // cbNuts
            // 
            this.cbNuts.AutoSize = true;
            this.cbNuts.Location = new System.Drawing.Point(89, 155);
            this.cbNuts.Name = "cbNuts";
            this.cbNuts.Size = new System.Drawing.Size(57, 21);
            this.cbNuts.TabIndex = 25;
            this.cbNuts.Text = "nuts";
            this.cbNuts.UseVisualStyleBackColor = true;
            // 
            // cbDairy
            // 
            this.cbDairy.AutoSize = true;
            this.cbDairy.Location = new System.Drawing.Point(161, 128);
            this.cbDairy.Name = "cbDairy";
            this.cbDairy.Size = new System.Drawing.Size(61, 21);
            this.cbDairy.TabIndex = 24;
            this.cbDairy.Text = "dairy";
            this.cbDairy.UseVisualStyleBackColor = true;
            // 
            // cbSugar
            // 
            this.cbSugar.AutoSize = true;
            this.cbSugar.Location = new System.Drawing.Point(89, 128);
            this.cbSugar.Name = "cbSugar";
            this.cbSugar.Size = new System.Drawing.Size(66, 21);
            this.cbSugar.TabIndex = 23;
            this.cbSugar.Text = "sugar";
            this.cbSugar.UseVisualStyleBackColor = true;
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPurpose.Location = new System.Drawing.Point(3, 82);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(81, 19);
            this.lblPurpose.TabIndex = 28;
            this.lblPurpose.Text = "Purpose:";
            // 
            // cbPurpose
            // 
            this.cbPurpose.FormattingEnabled = true;
            this.cbPurpose.Location = new System.Drawing.Point(105, 82);
            this.cbPurpose.Name = "cbPurpose";
            this.cbPurpose.Size = new System.Drawing.Size(121, 24);
            this.cbPurpose.TabIndex = 29;
            // 
            // AddHealthySnack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbPurpose);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblElergy);
            this.Controls.Add(this.cbGluten);
            this.Controls.Add(this.cbNuts);
            this.Controls.Add(this.cbDairy);
            this.Controls.Add(this.cbSugar);
            this.Controls.Add(this.txtGOP);
            this.Controls.Add(this.lblProteinGram);
            this.Name = "AddHealthySnack";
            this.Size = new System.Drawing.Size(231, 223);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGOP;
        private System.Windows.Forms.Label lblProteinGram;
        private System.Windows.Forms.Label lblElergy;
        private System.Windows.Forms.CheckBox cbGluten;
        private System.Windows.Forms.CheckBox cbNuts;
        private System.Windows.Forms.CheckBox cbDairy;
        private System.Windows.Forms.CheckBox cbSugar;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.ComboBox cbPurpose;
    }
}
