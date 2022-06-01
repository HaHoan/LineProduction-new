namespace Line_Production
{
    partial class fmConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmConfirm));
            this.cbErrorByStaff = new System.Windows.Forms.CheckBox();
            this.cbbErrorByStaff = new System.Windows.Forms.ComboBox();
            this.cbErrorByMachine = new System.Windows.Forms.CheckBox();
            this.cbbErrorByMachine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRemark = new System.Windows.Forms.TextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbErrorByStaff
            // 
            this.cbErrorByStaff.AutoSize = true;
            this.cbErrorByStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbErrorByStaff.Location = new System.Drawing.Point(13, 13);
            this.cbErrorByStaff.Name = "cbErrorByStaff";
            this.cbErrorByStaff.Size = new System.Drawing.Size(146, 19);
            this.cbErrorByStaff.TabIndex = 0;
            this.cbErrorByStaff.Text = "Tình trạng nhân sự";
            this.cbErrorByStaff.UseVisualStyleBackColor = true;
            // 
            // cbbErrorByStaff
            // 
            this.cbbErrorByStaff.DisplayMember = "Name";
            this.cbbErrorByStaff.FormattingEnabled = true;
            this.cbbErrorByStaff.Location = new System.Drawing.Point(12, 38);
            this.cbbErrorByStaff.Name = "cbbErrorByStaff";
            this.cbbErrorByStaff.Size = new System.Drawing.Size(280, 21);
            this.cbbErrorByStaff.TabIndex = 2;
            this.cbbErrorByStaff.ValueMember = "Id";
            // 
            // cbErrorByMachine
            // 
            this.cbErrorByMachine.AutoSize = true;
            this.cbErrorByMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbErrorByMachine.Location = new System.Drawing.Point(13, 112);
            this.cbErrorByMachine.Name = "cbErrorByMachine";
            this.cbErrorByMachine.Size = new System.Drawing.Size(104, 19);
            this.cbErrorByMachine.TabIndex = 3;
            this.cbErrorByMachine.Text = "Lỗi do sự cố";
            this.cbErrorByMachine.UseVisualStyleBackColor = true;
            // 
            // cbbErrorByMachine
            // 
            this.cbbErrorByMachine.DisplayMember = "Name";
            this.cbbErrorByMachine.FormattingEnabled = true;
            this.cbbErrorByMachine.Location = new System.Drawing.Point(59, 137);
            this.cbbErrorByMachine.Name = "cbbErrorByMachine";
            this.cbbErrorByMachine.Size = new System.Drawing.Size(233, 21);
            this.cbbErrorByMachine.TabIndex = 5;
            this.cbbErrorByMachine.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên lỗi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Remark";
            // 
            // txbRemark
            // 
            this.txbRemark.Location = new System.Drawing.Point(59, 173);
            this.txbRemark.Multiline = true;
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.Size = new System.Drawing.Size(233, 80);
            this.txbRemark.TabIndex = 7;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "HH:mm";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(59, 292);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(83, 20);
            this.dtStart.TabIndex = 8;
            this.dtStart.Value = new System.DateTime(2022, 5, 26, 14, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thời gian xảy ra sự cố";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Từ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Đến";
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "HH:mm";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(201, 292);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowUpDown = true;
            this.dtEnd.Size = new System.Drawing.Size(83, 20);
            this.dtEnd.TabIndex = 11;
            this.dtEnd.Value = new System.DateTime(2022, 5, 26, 14, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(59, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // fmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.txbRemark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbErrorByMachine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbErrorByMachine);
            this.Controls.Add(this.cbbErrorByStaff);
            this.Controls.Add(this.cbErrorByStaff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xác nhận lỗi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbErrorByStaff;
        private System.Windows.Forms.ComboBox cbbErrorByStaff;
        private System.Windows.Forms.CheckBox cbErrorByMachine;
        private System.Windows.Forms.ComboBox cbbErrorByMachine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRemark;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button button1;
    }
}