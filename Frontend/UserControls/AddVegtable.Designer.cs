
namespace SuperMarket.Frontend.UserControls
{
    partial class AddVegtable
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
            this.cbFresh = new System.Windows.Forms.CheckBox();
            this.lblVegType = new System.Windows.Forms.Label();
            this.cbOrganic = new System.Windows.Forms.CheckBox();
            this.lblPreferences = new System.Windows.Forms.Label();
            this.cbVegType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbFresh
            // 
            this.cbFresh.AutoSize = true;
            this.cbFresh.Location = new System.Drawing.Point(130, 78);
            this.cbFresh.Name = "cbFresh";
            this.cbFresh.Size = new System.Drawing.Size(62, 21);
            this.cbFresh.TabIndex = 30;
            this.cbFresh.Text = "fresh";
            this.cbFresh.UseVisualStyleBackColor = true;
            // 
            // lblVegType
            // 
            this.lblVegType.AutoSize = true;
            this.lblVegType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblVegType.Location = new System.Drawing.Point(3, 23);
            this.lblVegType.Name = "lblVegType";
            this.lblVegType.Size = new System.Drawing.Size(88, 19);
            this.lblVegType.TabIndex = 28;
            this.lblVegType.Text = "Veg. type:";
            // 
            // cbOrganic
            // 
            this.cbOrganic.AutoSize = true;
            this.cbOrganic.Location = new System.Drawing.Point(130, 105);
            this.cbOrganic.Name = "cbOrganic";
            this.cbOrganic.Size = new System.Drawing.Size(77, 21);
            this.cbOrganic.TabIndex = 31;
            this.cbOrganic.Text = "organic";
            this.cbOrganic.UseVisualStyleBackColor = true;
            // 
            // lblPreferences
            // 
            this.lblPreferences.AutoSize = true;
            this.lblPreferences.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPreferences.Location = new System.Drawing.Point(3, 77);
            this.lblPreferences.Name = "lblPreferences";
            this.lblPreferences.Size = new System.Drawing.Size(108, 19);
            this.lblPreferences.TabIndex = 28;
            this.lblPreferences.Text = "preferences:";
            // 
            // cbVegType
            // 
            this.cbVegType.FormattingEnabled = true;
            this.cbVegType.Location = new System.Drawing.Point(102, 23);
            this.cbVegType.Name = "cbVegType";
            this.cbVegType.Size = new System.Drawing.Size(121, 24);
            this.cbVegType.TabIndex = 32;
            // 
            // AddVegtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbVegType);
            this.Controls.Add(this.cbOrganic);
            this.Controls.Add(this.cbFresh);
            this.Controls.Add(this.lblPreferences);
            this.Controls.Add(this.lblVegType);
            this.Name = "AddVegtable";
            this.Size = new System.Drawing.Size(231, 223);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbFresh;
        private System.Windows.Forms.Label lblVegType;
        private System.Windows.Forms.CheckBox cbOrganic;
        private System.Windows.Forms.Label lblPreferences;
        private System.Windows.Forms.ComboBox cbVegType;
    }
}
