using System.Diagnostics;
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
            this.label6 = new System.Windows.Forms.Label();
            this.txbSleepTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Path Log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(81, 12);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(205, 20);
            this.txtLog.TabIndex = 26;
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point(293, 12);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(31, 20);
            this.btnBrower.TabIndex = 27;
            this.btnBrower.Text = "...";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(82, 106);
            this.txtStation.Name = "txtStation";
            this.txtStation.ReadOnly = true;
            this.txtStation.Size = new System.Drawing.Size(205, 20);
            this.txtStation.TabIndex = 32;
            this.txtStation.Text = "VI_YO";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 109);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 13);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "Station";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(205, 20);
            this.txtId.TabIndex = 36;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 45);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(27, 13);
            this.Label5.TabIndex = 35;
            this.Label5.Text = "Line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "COM";
            // 
            // cbbCOM
            // 
            this.cbbCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCOM.FormattingEnabled = true;
            this.cbbCOM.Location = new System.Drawing.Point(82, 145);
            this.cbbCOM.Name = "cbbCOM";
            this.cbbCOM.Size = new System.Drawing.Size(121, 21);
            this.cbbCOM.TabIndex = 38;
            // 
            // btnTestCOM
            // 
            this.btnTestCOM.Location = new System.Drawing.Point(212, 143);
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
            this.btnSaveChanged.Location = new System.Drawing.Point(167, 220);
            this.btnSaveChanged.Name = "btnSaveChanged";
            this.btnSaveChanged.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSaveChanged.Size = new System.Drawing.Size(118, 30);
            this.btnSaveChanged.TabIndex = 24;
            this.btnSaveChanged.Text = "Save change";
            this.btnSaveChanged.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanged.UseVisualStyleBackColor = false;
            this.btnSaveChanged.Click += new System.EventHandler(this.btnSaveChanged_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Customer";
            // 
            // txbSleepTime
            // 
            this.txbSleepTime.Location = new System.Drawing.Point(83, 184);
            this.txbSleepTime.Name = "txbSleepTime";
            this.txbSleepTime.Size = new System.Drawing.Size(205, 20);
            this.txbSleepTime.TabIndex = 54;
            this.txbSleepTime.Text = "1000";
            this.txbSleepTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSleepTime_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Sleep Time";
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
            "FUJIXEROX",
            "ICHIKOH_2LABEL"});
            this.cbbCustomer.Location = new System.Drawing.Point(82, 70);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(204, 21);
            this.cbbCustomer.TabIndex = 56;
            this.cbbCustomer.ValueMember = "NAME";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lblStatus.Location = new System.Drawing.Point(6, 231);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 57;
            // 
            // frmConfig
            // 
            this.AcceptButton = this.btnSaveChanged;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 256);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbbCustomer);
            this.Controls.Add(this.txbSleepTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configs";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
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
        internal Label label6;
        internal TextBox txbSleepTime;
        internal Label label7;
        private ComboBox cbbCustomer;
        private Label lblStatus;
    }
}