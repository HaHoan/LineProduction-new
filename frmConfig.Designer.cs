﻿using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic

namespace Line_Production
{
    

    [DesignerGenerated()]
    public partial class frmConfig : System.Windows.Forms.Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.cbLinkPathLog = new System.Windows.Forms.CheckBox();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbCOM = new System.Windows.Forms.ComboBox();
            this.btnTestCOM = new System.Windows.Forms.Button();
            this.btnSaveChanged = new System.Windows.Forms.Button();
            this.cbbProcess = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSleepTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLinkWip = new System.Windows.Forms.CheckBox();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTestComPress = new System.Windows.Forms.Button();
            this.cbbComPress = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbLinkPathLog
            // 
            this.cbLinkPathLog.AutoSize = true;
            this.cbLinkPathLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLinkPathLog.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbLinkPathLog.Location = new System.Drawing.Point(183, 294);
            this.cbLinkPathLog.Name = "cbLinkPathLog";
            this.cbLinkPathLog.Size = new System.Drawing.Size(101, 17);
            this.cbLinkPathLog.TabIndex = 2;
            this.cbLinkPathLog.Text = "Link PathLog";
            this.cbLinkPathLog.UseVisualStyleBackColor = true;
            this.cbLinkPathLog.CheckedChanged += new System.EventHandler(this.cbLinkPathLog_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 55);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Path Log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(85, 51);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(205, 20);
            this.txtLog.TabIndex = 26;
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point(297, 51);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(31, 20);
            this.btnBrower.TabIndex = 27;
            this.btnBrower.Text = "...";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(87, 154);
            this.txtStation.Name = "txtStation";
            this.txtStation.ReadOnly = true;
            this.txtStation.Size = new System.Drawing.Size(205, 20);
            this.txtStation.TabIndex = 32;
            this.txtStation.Text = "VI_YO";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 157);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 13);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "Station";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(86, 86);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(205, 20);
            this.txtId.TabIndex = 36;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(11, 93);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(27, 13);
            this.Label5.TabIndex = 35;
            this.Label5.Text = "Line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "COM";
            // 
            // cbbCOM
            // 
            this.cbbCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCOM.FormattingEnabled = true;
            this.cbbCOM.Location = new System.Drawing.Point(87, 193);
            this.cbbCOM.Name = "cbbCOM";
            this.cbbCOM.Size = new System.Drawing.Size(121, 21);
            this.cbbCOM.TabIndex = 38;
            // 
            // btnTestCOM
            // 
            this.btnTestCOM.Location = new System.Drawing.Point(217, 191);
            this.btnTestCOM.Name = "btnTestCOM";
            this.btnTestCOM.Size = new System.Drawing.Size(75, 23);
            this.btnTestCOM.TabIndex = 39;
            this.btnTestCOM.Text = "Test COM";
            this.btnTestCOM.UseVisualStyleBackColor = true;
            this.btnTestCOM.Click += new System.EventHandler(this.btnTestCOM_Click);
            // 
            // btnSaveChanged
            // 
            this.btnSaveChanged.BackColor = System.Drawing.Color.Green;
            this.btnSaveChanged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanged.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanged.Image = global::Line_Production.Properties.Resources.Save;
            this.btnSaveChanged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanged.Location = new System.Drawing.Point(174, 328);
            this.btnSaveChanged.Name = "btnSaveChanged";
            this.btnSaveChanged.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSaveChanged.Size = new System.Drawing.Size(118, 30);
            this.btnSaveChanged.TabIndex = 24;
            this.btnSaveChanged.Text = "Save change";
            this.btnSaveChanged.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanged.UseVisualStyleBackColor = false;
            this.btnSaveChanged.Click += new System.EventHandler(this.btnSaveChanged_Click);
            // 
            // cbbProcess
            // 
            this.cbbProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbProcess.FormattingEnabled = true;
            this.cbbProcess.Location = new System.Drawing.Point(87, 17);
            this.cbbProcess.Name = "cbbProcess";
            this.cbbProcess.Size = new System.Drawing.Size(205, 21);
            this.cbbProcess.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Process:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Customer";
            // 
            // txbSleepTime
            // 
            this.txbSleepTime.Location = new System.Drawing.Point(88, 260);
            this.txbSleepTime.Name = "txbSleepTime";
            this.txbSleepTime.Size = new System.Drawing.Size(205, 20);
            this.txbSleepTime.TabIndex = 54;
            this.txbSleepTime.Text = "1000";
            this.txbSleepTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSleepTime_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Sleep Time";
            // 
            // cbLinkWip
            // 
            this.cbLinkWip.AutoSize = true;
            this.cbLinkWip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLinkWip.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbLinkWip.Location = new System.Drawing.Point(87, 294);
            this.cbLinkWip.Name = "cbLinkWip";
            this.cbLinkWip.Size = new System.Drawing.Size(74, 17);
            this.cbLinkWip.TabIndex = 55;
            this.cbLinkWip.Text = "LinkWIP";
            this.cbLinkWip.UseVisualStyleBackColor = true;
            this.cbLinkWip.CheckedChanged += new System.EventHandler(this.cbLinkWip_CheckedChanged);
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
            this.cbbCustomer.Location = new System.Drawing.Point(87, 118);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(204, 21);
            this.cbbCustomer.TabIndex = 56;
            this.cbbCustomer.ValueMember = "NAME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(85, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Tên chương trình wip";
            // 
            // btnTestComPress
            // 
            this.btnTestComPress.Location = new System.Drawing.Point(217, 225);
            this.btnTestComPress.Name = "btnTestComPress";
            this.btnTestComPress.Size = new System.Drawing.Size(75, 23);
            this.btnTestComPress.TabIndex = 60;
            this.btnTestComPress.Text = "Test COM";
            this.btnTestComPress.UseVisualStyleBackColor = true;
            this.btnTestComPress.Click += new System.EventHandler(this.btnTestComPress_Click);
            // 
            // cbbComPress
            // 
            this.cbbComPress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbComPress.FormattingEnabled = true;
            this.cbbComPress.Location = new System.Drawing.Point(87, 227);
            this.cbbComPress.Name = "cbbComPress";
            this.cbbComPress.Size = new System.Drawing.Size(121, 21);
            this.cbbComPress.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "COM PRESS";
            // 
            // frmConfig
            // 
            this.AcceptButton = this.btnSaveChanged;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 371);
            this.Controls.Add(this.btnTestComPress);
            this.Controls.Add(this.cbbComPress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbCustomer);
            this.Controls.Add(this.cbLinkWip);
            this.Controls.Add(this.txbSleepTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTestCOM);
            this.Controls.Add(this.cbbCOM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnSaveChanged);
            this.Controls.Add(this.cbLinkPathLog);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configs";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private CheckBox cbLinkPathLog;
        private Button btnSaveChanged;
        internal FolderBrowserDialog FolderBrowserDialog1;
        internal Label Label1;
        internal TextBox txtLog;
        internal Button btnBrower;
        internal TextBox txtStation;
        internal Label Label3;
        internal TextBox txtId;
        internal Label Label5;
        private Label label4;
        private ComboBox cbbCOM;
        private Button btnTestCOM;
        private ComboBox cbbProcess;
        private Label label2;
        internal Label label6;
        internal TextBox txbSleepTime;
        internal Label label7;
        private CheckBox cbLinkWip;
        private ComboBox cbbCustomer;
        private Label label8;
        private Button btnTestComPress;
        private ComboBox cbbComPress;
        private Label label9;
    }
}