namespace Line_Production
{
    partial class frmSelectRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectRepair));
            this.Lb_inform_NG = new System.Windows.Forms.Label();
            this.cbYes = new System.Windows.Forms.CheckBox();
            this.cbNO = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Lb_inform_NG
            // 
            this.Lb_inform_NG.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lb_inform_NG.Font = new System.Drawing.Font("Palatino Linotype", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_inform_NG.ForeColor = System.Drawing.Color.Red;
            this.Lb_inform_NG.Location = new System.Drawing.Point(0, 0);
            this.Lb_inform_NG.Name = "Lb_inform_NG";
            this.Lb_inform_NG.Size = new System.Drawing.Size(800, 244);
            this.Lb_inform_NG.TabIndex = 2;
            this.Lb_inform_NG.Text = "Có phải hàng Repair hay không?";
            this.Lb_inform_NG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbYes
            // 
            this.cbYes.AutoSize = true;
            this.cbYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYes.ForeColor = System.Drawing.Color.Red;
            this.cbYes.Location = new System.Drawing.Point(125, 292);
            this.cbYes.Name = "cbYes";
            this.cbYes.Size = new System.Drawing.Size(188, 112);
            this.cbYes.TabIndex = 3;
            this.cbYes.Text = "Có";
            this.cbYes.UseVisualStyleBackColor = true;
            this.cbYes.CheckedChanged += new System.EventHandler(this.cbYes_CheckedChanged);
            // 
            // cbNO
            // 
            this.cbNO.AutoSize = true;
            this.cbNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNO.ForeColor = System.Drawing.Color.Red;
            this.cbNO.Location = new System.Drawing.Point(389, 292);
            this.cbNO.Name = "cbNO";
            this.cbNO.Size = new System.Drawing.Size(345, 112);
            this.cbNO.TabIndex = 4;
            this.cbNO.Text = "Không";
            this.cbNO.UseVisualStyleBackColor = true;
            this.cbNO.CheckedChanged += new System.EventHandler(this.cbNO_CheckedChanged);
            // 
            // frmSelectRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNO);
            this.Controls.Add(this.cbYes);
            this.Controls.Add(this.Lb_inform_NG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelectRepair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Lb_inform_NG;
        private System.Windows.Forms.CheckBox cbYes;
        private System.Windows.Forms.CheckBox cbNO;
    }
}