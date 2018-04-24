namespace PercentProgramLeoK
{
    partial class frmPercentProgramLeoK
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
            this.lblRequest = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.btnGetPercent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(12, 36);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(215, 20);
            this.lblRequest.TabIndex = 0;
            this.lblRequest.Text = "Please enter a level mark:";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(233, 36);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(108, 20);
            this.txtLevel.TabIndex = 1;
            // 
            // btnGetPercent
            // 
            this.btnGetPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPercent.Location = new System.Drawing.Point(127, 91);
            this.btnGetPercent.Name = "btnGetPercent";
            this.btnGetPercent.Size = new System.Drawing.Size(123, 36);
            this.btnGetPercent.TabIndex = 2;
            this.btnGetPercent.Text = "Get Percent";
            this.btnGetPercent.UseVisualStyleBackColor = true;
            this.btnGetPercent.Click += new System.EventHandler(this.btnGetPercent_Click);
            // 
            // frmPercentProgramLeoK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 169);
            this.Controls.Add(this.btnGetPercent);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lblRequest);
            this.Name = "frmPercentProgramLeoK";
            this.Text = "Percentage Program by Leo Kay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Button btnGetPercent;
    }
}

