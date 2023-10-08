
namespace SuperMarket.Frontend.UserControls
{
    partial class AddMeat
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
            this.lblMeatType = new System.Windows.Forms.Label();
            this.cbCMeattype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbFresh
            // 
            this.cbFresh.AutoSize = true;
            this.cbFresh.Location = new System.Drawing.Point(99, 85);
            this.cbFresh.Name = "cbFresh";
            this.cbFresh.Size = new System.Drawing.Size(62, 21);
            this.cbFresh.TabIndex = 27;
            this.cbFresh.Text = "fresh";
            this.cbFresh.UseVisualStyleBackColor = true;
            // 
            // lblMeatType
            // 
            this.lblMeatType.AutoSize = true;
            this.lblMeatType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMeatType.Location = new System.Drawing.Point(2, 41);
            this.lblMeatType.Name = "lblMeatType";
            this.lblMeatType.Size = new System.Drawing.Size(91, 19);
            this.lblMeatType.TabIndex = 21;
            this.lblMeatType.Text = "Meat type:";
            // 
            // cbCMeattype
            // 
            this.cbCMeattype.FormattingEnabled = true;
            this.cbCMeattype.Location = new System.Drawing.Point(99, 36);
            this.cbCMeattype.Name = "cbCMeattype";
            this.cbCMeattype.Size = new System.Drawing.Size(121, 24);
            this.cbCMeattype.TabIndex = 28;
            // 
            // AddMeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbCMeattype);
            this.Controls.Add(this.cbFresh);
            this.Controls.Add(this.lblMeatType);
            this.Name = "AddMeat";
            this.Size = new System.Drawing.Size(231, 223);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbFresh;
        private System.Windows.Forms.Label lblMeatType;
        private System.Windows.Forms.ComboBox cbCMeattype;
    }
}
