namespace Line_Production
{
    partial class AddModelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbModelID = new System.Windows.Forms.TextBox();
            this.txbPersonInLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCycle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbWarmQuatity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMnQuantity = new System.Windows.Forms.TextBox();
            this.ckbUseBarcode = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNumberInModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPCB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveChanged = new System.Windows.Forms.Button();
            this.txbContentLength = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbContentIndex = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCheckFirst = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbHistoryNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model ID";
            // 
            // txbModelID
            // 
            this.txbModelID.Location = new System.Drawing.Point(154, 20);
            this.txbModelID.Name = "txbModelID";
            this.txbModelID.Size = new System.Drawing.Size(172, 20);
            this.txbModelID.TabIndex = 1;
            this.txbModelID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbModelID_PreviewKeyDown);
            // 
            // txbPersonInLine
            // 
            this.txbPersonInLine.Location = new System.Drawing.Point(154, 65);
            this.txbPersonInLine.Name = "txbPersonInLine";
            this.txbPersonInLine.Size = new System.Drawing.Size(172, 20);
            this.txbPersonInLine.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số người trên Line";
            // 
            // txbCycle
            // 
            this.txbCycle.Location = new System.Drawing.Point(154, 112);
            this.txbCycle.Name = "txbCycle";
            this.txbCycle.Size = new System.Drawing.Size(172, 20);
            this.txbCycle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cycle Time";
            // 
            // txbWarmQuatity
            // 
            this.txbWarmQuatity.Location = new System.Drawing.Point(154, 161);
            this.txbWarmQuatity.Name = "txbWarmQuatity";
            this.txbWarmQuatity.Size = new System.Drawing.Size(172, 20);
            this.txbWarmQuatity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cảnh báo số lượng";
            // 
            // txbMnQuantity
            // 
            this.txbMnQuantity.Location = new System.Drawing.Point(154, 208);
            this.txbMnQuantity.Name = "txbMnQuantity";
            this.txbMnQuantity.Size = new System.Drawing.Size(172, 20);
            this.txbMnQuantity.TabIndex = 9;
            // 
            // ckbUseBarcode
            // 
            this.ckbUseBarcode.AutoSize = true;
            this.ckbUseBarcode.Checked = true;
            this.ckbUseBarcode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUseBarcode.Location = new System.Drawing.Point(217, 389);
            this.ckbUseBarcode.Name = "ckbUseBarcode";
            this.ckbUseBarcode.Size = new System.Drawing.Size(109, 17);
            this.ckbUseBarcode.TabIndex = 13;
            this.ckbUseBarcode.Text = "Sử dụng Barcode";
            this.ckbUseBarcode.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cảnh báo SL bất thường";
            // 
            // txbNumberInModel
            // 
            this.txbNumberInModel.Location = new System.Drawing.Point(154, 311);
            this.txbNumberInModel.Name = "txbNumberInModel";
            this.txbNumberInModel.Size = new System.Drawing.Size(172, 20);
            this.txbNumberInModel.TabIndex = 27;
            this.txbNumberInModel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(25, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nếu không có mac thùng thì nhập số lượng mạch / thùng tại đây";
            // 
            // txbPCB
            // 
            this.txbPCB.Location = new System.Drawing.Point(488, 252);
            this.txbPCB.Name = "txbPCB";
            this.txbPCB.Size = new System.Drawing.Size(172, 20);
            this.txbPCB.TabIndex = 29;
            this.txbPCB.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "PCB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Customer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Line_Production.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(356, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 204);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveChanged
            // 
            this.btnSaveChanged.BackColor = System.Drawing.Color.Green;
            this.btnSaveChanged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanged.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanged.Image = global::Line_Production.Properties.Resources.Save;
            this.btnSaveChanged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanged.Location = new System.Drawing.Point(488, 450);
            this.btnSaveChanged.Name = "btnSaveChanged";
            this.btnSaveChanged.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSaveChanged.Size = new System.Drawing.Size(119, 44);
            this.btnSaveChanged.TabIndex = 25;
            this.btnSaveChanged.Text = "Save change";
            this.btnSaveChanged.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanged.UseVisualStyleBackColor = false;
            this.btnSaveChanged.Click += new System.EventHandler(this.btnSaveChanged_Click);
            // 
            // txbContentLength
            // 
            this.txbContentLength.Location = new System.Drawing.Point(488, 352);
            this.txbContentLength.Name = "txbContentLength";
            this.txbContentLength.Size = new System.Drawing.Size(172, 20);
            this.txbContentLength.TabIndex = 36;
            this.txbContentLength.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "ContentLength";
            // 
            // txbContentIndex
            // 
            this.txbContentIndex.Location = new System.Drawing.Point(488, 296);
            this.txbContentIndex.Name = "txbContentIndex";
            this.txbContentIndex.Size = new System.Drawing.Size(172, 20);
            this.txbContentIndex.TabIndex = 34;
            this.txbContentIndex.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "ContentIndex";
            // 
            // cbCheckFirst
            // 
            this.cbCheckFirst.AutoSize = true;
            this.cbCheckFirst.Location = new System.Drawing.Point(488, 390);
            this.cbCheckFirst.Name = "cbCheckFirst";
            this.cbCheckFirst.Size = new System.Drawing.Size(79, 17);
            this.cbCheckFirst.TabIndex = 37;
            this.cbCheckFirst.Text = "Check First";
            this.cbCheckFirst.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(576, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Tự động tìm barcode đầu tiên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(600, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Hình ảnh tham khảo";
            // 
            // txbHistoryNo
            // 
            this.txbHistoryNo.Enabled = false;
            this.txbHistoryNo.Location = new System.Drawing.Point(154, 248);
            this.txbHistoryNo.Name = "txbHistoryNo";
            this.txbHistoryNo.Size = new System.Drawing.Size(172, 20);
            this.txbHistoryNo.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "History No";
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.DisplayMember = "NAME";
            this.cbbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Items.AddRange(new object[] {
            "VALEO",
            "ICHIKOH",
            "HONDALOCK",
            "TOYODENSO",
            "YOKOWO",
            "YASKAWA",
            "FORMLABS",
            "NICHICON",
            "KYOCERA",
            "BROTHER",
            "CANON",
            "FUJIXEROX"});
            this.cbbCustomer.Location = new System.Drawing.Point(154, 351);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(172, 21);
            this.cbbCustomer.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(332, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "(*)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(332, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "(*)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(332, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "(*)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(332, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = "(*)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(333, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "(*)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(336, 355);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "(*)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(336, 251);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "(*)";
            // 
            // AddModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 506);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbbCustomer);
            this.Controls.Add(this.txbHistoryNo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbCheckFirst);
            this.Controls.Add(this.txbContentLength);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbContentIndex);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbPCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbNumberInModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSaveChanged);
            this.Controls.Add(this.ckbUseBarcode);
            this.Controls.Add(this.txbMnQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbWarmQuatity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCycle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPersonInLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbModelID);
            this.Controls.Add(this.label1);
            this.Name = "AddModelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddModelForm";
            this.Shown += new System.EventHandler(this.AddModelForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbModelID;
        private System.Windows.Forms.TextBox txbPersonInLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbWarmQuatity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMnQuantity;
        private System.Windows.Forms.CheckBox ckbUseBarcode;
        private System.Windows.Forms.Button btnSaveChanged;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNumberInModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbContentLength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbContentIndex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbCheckFirst;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbHistoryNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
    }
}