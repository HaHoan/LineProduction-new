using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
namespace Line_Production
{
    partial class Control
    {
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblModel = new System.Windows.Forms.TextBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.lblRepair = new System.Windows.Forms.Label();
            this.chkOK = new System.Windows.Forms.CheckBox();
            this.chkNG = new System.Windows.Forms.CheckBox();
            this.groupSoThung = new System.Windows.Forms.GroupBox();
            this.LabelSoThung = new System.Windows.Forms.Label();
            this.LabelPCS1BOX = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.LabelPCBA = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.lblExplain = new System.Windows.Forms.Label();
            this.TextMacBox = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.TextCycleTimeCurrent = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.TextCycleTimeModel = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TextBalance = new System.Windows.Forms.TextBox();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbbModel = new System.Windows.Forms.ComboBox();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.BtStop = new System.Windows.Forms.Button();
            this.BtStart = new System.Windows.Forms.Button();
            this.Table1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirm10 = new System.Windows.Forms.Button();
            this.btnConfirm9 = new System.Windows.Forms.Button();
            this.btnConfirm8 = new System.Windows.Forms.Button();
            this.btnConfirm7 = new System.Windows.Forms.Button();
            this.btnConfirm6 = new System.Windows.Forms.Button();
            this.btnConfirm5 = new System.Windows.Forms.Button();
            this.btnConfirm4 = new System.Windows.Forms.Button();
            this.btnConfirm3 = new System.Windows.Forms.Button();
            this.btnConfirm2 = new System.Windows.Forms.Button();
            this.TextTime10 = new System.Windows.Forms.TextBox();
            this.TextTime9 = new System.Windows.Forms.TextBox();
            this.TextTime8 = new System.Windows.Forms.TextBox();
            this.TextTime7 = new System.Windows.Forms.TextBox();
            this.TextTime6 = new System.Windows.Forms.TextBox();
            this.TextTime5 = new System.Windows.Forms.TextBox();
            this.TextTime4 = new System.Windows.Forms.TextBox();
            this.TextTime3 = new System.Windows.Forms.TextBox();
            this.TextTime2 = new System.Windows.Forms.TextBox();
            this.TextComment9 = new System.Windows.Forms.TextBox();
            this.TextBalance9 = new System.Windows.Forms.TextBox();
            this.TextComment8 = new System.Windows.Forms.TextBox();
            this.TextBalance8 = new System.Windows.Forms.TextBox();
            this.TextComment7 = new System.Windows.Forms.TextBox();
            this.TextBalance7 = new System.Windows.Forms.TextBox();
            this.TextComment6 = new System.Windows.Forms.TextBox();
            this.TextBalance6 = new System.Windows.Forms.TextBox();
            this.TextComment5 = new System.Windows.Forms.TextBox();
            this.TextComment4 = new System.Windows.Forms.TextBox();
            this.TextBalance4 = new System.Windows.Forms.TextBox();
            this.TextComment3 = new System.Windows.Forms.TextBox();
            this.TextComment2 = new System.Windows.Forms.TextBox();
            this.TextComment1 = new System.Windows.Forms.TextBox();
            this.TextActual9 = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.TextActual1 = new System.Windows.Forms.TextBox();
            this.TextPlan1 = new System.Windows.Forms.TextBox();
            this.TextBalance1 = new System.Windows.Forms.TextBox();
            this.TextPlan3 = new System.Windows.Forms.TextBox();
            this.TextPlan4 = new System.Windows.Forms.TextBox();
            this.TextPlan6 = new System.Windows.Forms.TextBox();
            this.TextPlan5 = new System.Windows.Forms.TextBox();
            this.TextPlan7 = new System.Windows.Forms.TextBox();
            this.TextPlan8 = new System.Windows.Forms.TextBox();
            this.TextPlan9 = new System.Windows.Forms.TextBox();
            this.TextActual2 = new System.Windows.Forms.TextBox();
            this.TextBalance2 = new System.Windows.Forms.TextBox();
            this.TextActual3 = new System.Windows.Forms.TextBox();
            this.TextBalance3 = new System.Windows.Forms.TextBox();
            this.TextActual4 = new System.Windows.Forms.TextBox();
            this.TextActual5 = new System.Windows.Forms.TextBox();
            this.TextBalance5 = new System.Windows.Forms.TextBox();
            this.TextActual6 = new System.Windows.Forms.TextBox();
            this.TextActual7 = new System.Windows.Forms.TextBox();
            this.TextActual8 = new System.Windows.Forms.TextBox();
            this.TextTime1 = new System.Windows.Forms.TextBox();
            this.TextComment10 = new System.Windows.Forms.TextBox();
            this.TextBalance10 = new System.Windows.Forms.TextBox();
            this.TextActual10 = new System.Windows.Forms.TextBox();
            this.TextPlan10 = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.btnConfirm1 = new System.Windows.Forms.Button();
            this.TextPlan2 = new System.Windows.Forms.TextBox();
            this.Shape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.BtReduce = new System.Windows.Forms.Button();
            this.BtIncrease = new System.Windows.Forms.Button();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.LabelShapeError = new System.Windows.Forms.Label();
            this.LabelShapeOffLine = new System.Windows.Forms.Label();
            this.LabelShapeOnline = new System.Windows.Forms.Label();
            this.ShapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Shape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Shape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ComPressPort = new System.IO.Ports.SerialPort(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.cbbFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblComcontrol = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer3 = new System.Windows.Forms.Timer(this.components);
            this.LabelTimeDate = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblHistoryNo = new System.Windows.Forms.Label();
            this.bgwLinkWip = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblSettingTime = new System.Windows.Forms.LinkLabel();
            this.lblListModel = new System.Windows.Forms.LinkLabel();
            this.lblConfig = new System.Windows.Forms.LinkLabel();
            this.timerCompress = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.groupSoThung.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.Table1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(5, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(31, 15);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Line:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.lblModel);
            this.GroupBox1.Controls.Add(this.GroupBox5);
            this.GroupBox1.Controls.Add(this.GroupBox4);
            this.GroupBox1.Controls.Add(this.TextCycleTimeCurrent);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.txtPeople);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txtShift);
            this.GroupBox1.Controls.Add(this.txtDate);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.TextCycleTimeModel);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.TextBalance);
            this.GroupBox1.Controls.Add(this.txtActual);
            this.GroupBox1.Controls.Add(this.txtPlan);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.cbbModel);
            this.GroupBox1.Controls.Add(this.txtLine);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.BtStop);
            this.GroupBox1.Controls.Add(this.BtStart);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 59);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(989, 168);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            // 
            // lblModel
            // 
            this.lblModel.BackColor = System.Drawing.Color.White;
            this.lblModel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(54, 44);
            this.lblModel.Name = "lblModel";
            this.lblModel.ReadOnly = true;
            this.lblModel.Size = new System.Drawing.Size(157, 21);
            this.lblModel.TabIndex = 17;
            this.lblModel.Visible = false;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.lblWaiting);
            this.GroupBox5.Controls.Add(this.lblRepair);
            this.GroupBox5.Controls.Add(this.chkOK);
            this.GroupBox5.Controls.Add(this.chkNG);
            this.GroupBox5.Controls.Add(this.groupSoThung);
            this.GroupBox5.Controls.Add(this.LabelPCS1BOX);
            this.GroupBox5.Controls.Add(this.Label23);
            this.GroupBox5.Controls.Add(this.txtSerial);
            this.GroupBox5.Controls.Add(this.LabelPCBA);
            this.GroupBox5.Controls.Add(this.Label17);
            this.GroupBox5.Controls.Add(this.lblExplain);
            this.GroupBox5.Controls.Add(this.TextMacBox);
            this.GroupBox5.Controls.Add(this.Label24);
            this.GroupBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(615, 11);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(351, 148);
            this.GroupBox5.TabIndex = 16;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Quản lý bản mạch";
            // 
            // lblWaiting
            // 
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Location = new System.Drawing.Point(245, 174);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(0, 15);
            this.lblWaiting.TabIndex = 22;
            // 
            // lblRepair
            // 
            this.lblRepair.AutoSize = true;
            this.lblRepair.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepair.ForeColor = System.Drawing.Color.Red;
            this.lblRepair.Location = new System.Drawing.Point(91, 19);
            this.lblRepair.Name = "lblRepair";
            this.lblRepair.Size = new System.Drawing.Size(95, 16);
            this.lblRepair.TabIndex = 21;
            this.lblRepair.Text = "SỬA/ REPAIR";
            this.lblRepair.Visible = false;
            // 
            // chkOK
            // 
            this.chkOK.AutoSize = true;
            this.chkOK.Checked = true;
            this.chkOK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkOK.Location = new System.Drawing.Point(200, 114);
            this.chkOK.Name = "chkOK";
            this.chkOK.Size = new System.Drawing.Size(52, 24);
            this.chkOK.TabIndex = 20;
            this.chkOK.Text = "OK";
            this.chkOK.UseVisualStyleBackColor = true;
            this.chkOK.CheckedChanged += new System.EventHandler(this.chkOK_CheckedChanged);
            // 
            // chkNG
            // 
            this.chkNG.AutoSize = true;
            this.chkNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkNG.Location = new System.Drawing.Point(288, 111);
            this.chkNG.Name = "chkNG";
            this.chkNG.Size = new System.Drawing.Size(54, 24);
            this.chkNG.TabIndex = 17;
            this.chkNG.Text = "NG";
            this.chkNG.UseVisualStyleBackColor = true;
            this.chkNG.CheckedChanged += new System.EventHandler(this.chkNG_CheckedChanged);
            // 
            // groupSoThung
            // 
            this.groupSoThung.Controls.Add(this.LabelSoThung);
            this.groupSoThung.Location = new System.Drawing.Point(200, 58);
            this.groupSoThung.Name = "groupSoThung";
            this.groupSoThung.Size = new System.Drawing.Size(145, 50);
            this.groupSoThung.TabIndex = 15;
            this.groupSoThung.TabStop = false;
            this.groupSoThung.Text = "Số thùng";
            // 
            // LabelSoThung
            // 
            this.LabelSoThung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSoThung.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSoThung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LabelSoThung.Location = new System.Drawing.Point(7, 14);
            this.LabelSoThung.Name = "LabelSoThung";
            this.LabelSoThung.Size = new System.Drawing.Size(132, 31);
            this.LabelSoThung.TabIndex = 11;
            this.LabelSoThung.Text = "100000";
            this.LabelSoThung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LabelPCS1BOX
            // 
            this.LabelPCS1BOX.AutoSize = true;
            this.LabelPCS1BOX.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPCS1BOX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LabelPCS1BOX.Location = new System.Drawing.Point(292, 11);
            this.LabelPCS1BOX.Name = "LabelPCS1BOX";
            this.LabelPCS1BOX.Size = new System.Drawing.Size(42, 31);
            this.LabelPCS1BOX.TabIndex = 11;
            this.LabelPCS1BOX.Text = "10";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label23.Location = new System.Drawing.Point(272, 17);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(16, 22);
            this.Label23.TabIndex = 11;
            this.Label23.Text = "/";
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(12, 113);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(185, 22);
            this.txtSerial.TabIndex = 4;
            this.txtSerial.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSerial_PreviewKeyDown);
            // 
            // LabelPCBA
            // 
            this.LabelPCBA.AutoSize = true;
            this.LabelPCBA.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPCBA.ForeColor = System.Drawing.Color.Red;
            this.LabelPCBA.Location = new System.Drawing.Point(199, 11);
            this.LabelPCBA.Name = "LabelPCBA";
            this.LabelPCBA.Size = new System.Drawing.Size(70, 31);
            this.LabelPCBA.TabIndex = 11;
            this.LabelPCBA.Text = "1000";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(12, 87);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(121, 16);
            this.Label17.TabIndex = 5;
            this.Label17.Text = "Mã Barcode mạch:";
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplain.Location = new System.Drawing.Point(204, 41);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(69, 15);
            this.lblExplain.TabIndex = 10;
            this.lblExplain.Text = "PCS/Thùng";
            // 
            // TextMacBox
            // 
            this.TextMacBox.Enabled = false;
            this.TextMacBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMacBox.Location = new System.Drawing.Point(12, 42);
            this.TextMacBox.Name = "TextMacBox";
            this.TextMacBox.Size = new System.Drawing.Size(179, 22);
            this.TextMacBox.TabIndex = 12;
            this.TextMacBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextMacBox_KeyPress);
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.Transparent;
            this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.Location = new System.Drawing.Point(12, 22);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(75, 16);
            this.Label24.TabIndex = 5;
            this.Label24.Text = "Nhãn thùng";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.lblQuantity);
            this.GroupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(400, 66);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(213, 93);
            this.GroupBox4.TabIndex = 15;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Sản lượng";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Green;
            this.lblQuantity.Location = new System.Drawing.Point(12, 15);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(188, 63);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "200";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextCycleTimeCurrent
            // 
            this.TextCycleTimeCurrent.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCycleTimeCurrent.Location = new System.Drawing.Point(298, 122);
            this.TextCycleTimeCurrent.Name = "TextCycleTimeCurrent";
            this.TextCycleTimeCurrent.ReadOnly = true;
            this.TextCycleTimeCurrent.Size = new System.Drawing.Size(96, 21);
            this.TextCycleTimeCurrent.TabIndex = 5;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(217, 119);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(66, 30);
            this.Label8.TabIndex = 5;
            this.Label8.Text = "Cycle Time \r\nthực tế (s)";
            // 
            // txtPeople
            // 
            this.txtPeople.BackColor = System.Drawing.Color.White;
            this.txtPeople.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeople.Location = new System.Drawing.Point(94, 70);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.ReadOnly = true;
            this.txtPeople.Size = new System.Drawing.Size(117, 21);
            this.txtPeople.TabIndex = 8;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(9, 125);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(66, 15);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Ca Sản xuất:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(6, 101);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 15);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Ngày Sản xuất:";
            // 
            // txtShift
            // 
            this.txtShift.BackColor = System.Drawing.Color.White;
            this.txtShift.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShift.Location = new System.Drawing.Point(94, 122);
            this.txtShift.Name = "txtShift";
            this.txtShift.ReadOnly = true;
            this.txtShift.Size = new System.Drawing.Size(117, 21);
            this.txtShift.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(94, 95);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(117, 21);
            this.txtDate.TabIndex = 4;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(217, 73);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(64, 15);
            this.Label11.TabIndex = 7;
            this.Label11.Text = "Chênh Lệch";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(217, 97);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(79, 15);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Cycle Time (s)\r\n";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(217, 48);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(45, 15);
            this.Label10.TabIndex = 7;
            this.Label10.Text = "Thực tế";
            // 
            // TextCycleTimeModel
            // 
            this.TextCycleTimeModel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCycleTimeModel.Location = new System.Drawing.Point(298, 95);
            this.TextCycleTimeModel.Name = "TextCycleTimeModel";
            this.TextCycleTimeModel.ReadOnly = true;
            this.TextCycleTimeModel.Size = new System.Drawing.Size(96, 21);
            this.TextCycleTimeModel.TabIndex = 6;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(217, 24);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(52, 15);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "Kế hoạch";
            // 
            // TextBalance
            // 
            this.TextBalance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance.Location = new System.Drawing.Point(298, 70);
            this.TextBalance.Name = "TextBalance";
            this.TextBalance.ReadOnly = true;
            this.TextBalance.Size = new System.Drawing.Size(96, 21);
            this.TextBalance.TabIndex = 3;
            // 
            // txtActual
            // 
            this.txtActual.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActual.Location = new System.Drawing.Point(298, 46);
            this.txtActual.Name = "txtActual";
            this.txtActual.ReadOnly = true;
            this.txtActual.Size = new System.Drawing.Size(96, 21);
            this.txtActual.TabIndex = 3;
            // 
            // txtPlan
            // 
            this.txtPlan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlan.Location = new System.Drawing.Point(298, 21);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.ReadOnly = true;
            this.txtPlan.Size = new System.Drawing.Size(96, 21);
            this.txtPlan.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(6, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 15);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Model:";
            // 
            // cbbModel
            // 
            this.cbbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbModel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbModel.Location = new System.Drawing.Point(54, 43);
            this.cbbModel.Name = "cbbModel";
            this.cbbModel.Size = new System.Drawing.Size(157, 23);
            this.cbbModel.TabIndex = 4;
            this.cbbModel.SelectedIndexChanged += new System.EventHandler(this.ComboModel_SelectedIndexChanged);
            // 
            // txtLine
            // 
            this.txtLine.BackColor = System.Drawing.Color.White;
            this.txtLine.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLine.Location = new System.Drawing.Point(54, 18);
            this.txtLine.Name = "txtLine";
            this.txtLine.ReadOnly = true;
            this.txtLine.Size = new System.Drawing.Size(157, 21);
            this.txtLine.TabIndex = 3;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(6, 73);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(71, 15);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Số người cần:";
            // 
            // BtStop
            // 
            this.BtStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtStop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStop.Image = global::Line_Production.Properties.Resources.stop;
            this.BtStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtStop.Location = new System.Drawing.Point(508, 23);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(105, 40);
            this.BtStop.TabIndex = 0;
            this.BtStop.Text = "Kết thúc";
            this.BtStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtStop.UseVisualStyleBackColor = true;
            this.BtStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // BtStart
            // 
            this.BtStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStart.Image = global::Line_Production.Properties.Resources.play;
            this.BtStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtStart.Location = new System.Drawing.Point(398, 23);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(106, 40);
            this.BtStart.TabIndex = 0;
            this.BtStart.Text = "Bắt đầu";
            this.BtStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // Table1
            // 
            this.Table1.BackColor = System.Drawing.Color.LightGray;
            this.Table1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table1.ColumnCount = 6;
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.43211F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.4321F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.4321F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.4321F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77777F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.49383F));
            this.Table1.Controls.Add(this.btnConfirm10, 5, 10);
            this.Table1.Controls.Add(this.btnConfirm9, 5, 9);
            this.Table1.Controls.Add(this.btnConfirm8, 5, 8);
            this.Table1.Controls.Add(this.btnConfirm7, 5, 7);
            this.Table1.Controls.Add(this.btnConfirm6, 5, 6);
            this.Table1.Controls.Add(this.btnConfirm5, 5, 5);
            this.Table1.Controls.Add(this.btnConfirm4, 5, 4);
            this.Table1.Controls.Add(this.btnConfirm3, 5, 3);
            this.Table1.Controls.Add(this.btnConfirm2, 5, 2);
            this.Table1.Controls.Add(this.TextTime10, 0, 10);
            this.Table1.Controls.Add(this.TextTime9, 0, 9);
            this.Table1.Controls.Add(this.TextTime8, 0, 8);
            this.Table1.Controls.Add(this.TextTime7, 0, 7);
            this.Table1.Controls.Add(this.TextTime6, 0, 6);
            this.Table1.Controls.Add(this.TextTime5, 0, 5);
            this.Table1.Controls.Add(this.TextTime4, 0, 4);
            this.Table1.Controls.Add(this.TextTime3, 0, 3);
            this.Table1.Controls.Add(this.TextTime2, 0, 2);
            this.Table1.Controls.Add(this.TextComment9, 4, 9);
            this.Table1.Controls.Add(this.TextBalance9, 3, 9);
            this.Table1.Controls.Add(this.TextComment8, 4, 8);
            this.Table1.Controls.Add(this.TextBalance8, 3, 8);
            this.Table1.Controls.Add(this.TextComment7, 4, 7);
            this.Table1.Controls.Add(this.TextBalance7, 3, 7);
            this.Table1.Controls.Add(this.TextComment6, 4, 6);
            this.Table1.Controls.Add(this.TextBalance6, 3, 6);
            this.Table1.Controls.Add(this.TextComment5, 4, 5);
            this.Table1.Controls.Add(this.TextComment4, 4, 4);
            this.Table1.Controls.Add(this.TextBalance4, 3, 4);
            this.Table1.Controls.Add(this.TextComment3, 4, 3);
            this.Table1.Controls.Add(this.TextComment2, 4, 2);
            this.Table1.Controls.Add(this.TextComment1, 4, 1);
            this.Table1.Controls.Add(this.TextActual9, 2, 9);
            this.Table1.Controls.Add(this.Label16, 4, 0);
            this.Table1.Controls.Add(this.Label15, 3, 0);
            this.Table1.Controls.Add(this.Label14, 2, 0);
            this.Table1.Controls.Add(this.Label12, 0, 0);
            this.Table1.Controls.Add(this.TextActual1, 2, 1);
            this.Table1.Controls.Add(this.TextPlan1, 1, 1);
            this.Table1.Controls.Add(this.TextBalance1, 3, 1);
            this.Table1.Controls.Add(this.TextPlan3, 1, 3);
            this.Table1.Controls.Add(this.TextPlan4, 1, 4);
            this.Table1.Controls.Add(this.TextPlan6, 1, 6);
            this.Table1.Controls.Add(this.TextPlan5, 1, 5);
            this.Table1.Controls.Add(this.TextPlan7, 1, 7);
            this.Table1.Controls.Add(this.TextPlan8, 1, 8);
            this.Table1.Controls.Add(this.TextPlan9, 1, 9);
            this.Table1.Controls.Add(this.TextActual2, 2, 2);
            this.Table1.Controls.Add(this.TextBalance2, 3, 2);
            this.Table1.Controls.Add(this.TextActual3, 2, 3);
            this.Table1.Controls.Add(this.TextBalance3, 3, 3);
            this.Table1.Controls.Add(this.TextActual4, 2, 4);
            this.Table1.Controls.Add(this.TextActual5, 2, 5);
            this.Table1.Controls.Add(this.TextBalance5, 3, 5);
            this.Table1.Controls.Add(this.TextActual6, 2, 6);
            this.Table1.Controls.Add(this.TextActual7, 2, 7);
            this.Table1.Controls.Add(this.TextActual8, 2, 8);
            this.Table1.Controls.Add(this.TextTime1, 0, 1);
            this.Table1.Controls.Add(this.TextComment10, 4, 10);
            this.Table1.Controls.Add(this.TextBalance10, 3, 10);
            this.Table1.Controls.Add(this.TextActual10, 2, 10);
            this.Table1.Controls.Add(this.TextPlan10, 1, 10);
            this.Table1.Controls.Add(this.Label13, 1, 0);
            this.Table1.Controls.Add(this.btnConfirm1, 5, 1);
            this.Table1.Controls.Add(this.TextPlan2, 1, 2);
            this.Table1.Location = new System.Drawing.Point(12, 233);
            this.Table1.Name = "Table1";
            this.Table1.RowCount = 11;
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table1.Size = new System.Drawing.Size(829, 395);
            this.Table1.TabIndex = 3;
            // 
            // btnConfirm10
            // 
            this.btnConfirm10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm10.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm10.Location = new System.Drawing.Point(741, 363);
            this.btnConfirm10.Name = "btnConfirm10";
            this.btnConfirm10.Size = new System.Drawing.Size(84, 28);
            this.btnConfirm10.TabIndex = 72;
            this.btnConfirm10.Text = "Confirm";
            this.btnConfirm10.UseVisualStyleBackColor = true;
            this.btnConfirm10.Visible = false;
            this.btnConfirm10.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnConfirm9
            // 
            this.btnConfirm9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm9.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm9.Location = new System.Drawing.Point(741, 329);
            this.btnConfirm9.Name = "btnConfirm9";
            this.btnConfirm9.Size = new System.Drawing.Size(84, 27);
            this.btnConfirm9.TabIndex = 71;
            this.btnConfirm9.Text = "Confirm";
            this.btnConfirm9.UseVisualStyleBackColor = true;
            this.btnConfirm9.Visible = false;
            this.btnConfirm9.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnConfirm8
            // 
            this.btnConfirm8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm8.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm8.Location = new System.Drawing.Point(741, 295);
            this.btnConfirm8.Name = "btnConfirm8";
            this.btnConfirm8.Size = new System.Drawing.Size(84, 27);
            this.btnConfirm8.TabIndex = 70;
            this.btnConfirm8.Text = "Confirm";
            this.btnConfirm8.UseVisualStyleBackColor = true;
            this.btnConfirm8.Visible = false;
            this.btnConfirm8.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnConfirm7
            // 
            this.btnConfirm7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm7.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm7.Location = new System.Drawing.Point(741, 260);
            this.btnConfirm7.Name = "btnConfirm7";
            this.btnConfirm7.Size = new System.Drawing.Size(84, 28);
            this.btnConfirm7.TabIndex = 69;
            this.btnConfirm7.Text = "Confirm";
            this.btnConfirm7.UseVisualStyleBackColor = true;
            this.btnConfirm7.Visible = false;
            this.btnConfirm7.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnConfirm6
            // 
            this.btnConfirm6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm6.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm6.Location = new System.Drawing.Point(741, 224);
            this.btnConfirm6.Name = "btnConfirm6";
            this.btnConfirm6.Size = new System.Drawing.Size(84, 29);
            this.btnConfirm6.TabIndex = 68;
            this.btnConfirm6.Text = "Confirm";
            this.btnConfirm6.UseVisualStyleBackColor = true;
            this.btnConfirm6.Visible = false;
            this.btnConfirm6.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnConfirm5
            // 
            this.btnConfirm5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm5.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm5.Location = new System.Drawing.Point(741, 189);
            this.btnConfirm5.Name = "btnConfirm5";
            this.btnConfirm5.Size = new System.Drawing.Size(84, 28);
            this.btnConfirm5.TabIndex = 67;
            this.btnConfirm5.Text = "Confirm";
            this.btnConfirm5.UseVisualStyleBackColor = true;
            this.btnConfirm5.Visible = false;
            this.btnConfirm5.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnConfirm4
            // 
            this.btnConfirm4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm4.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm4.Location = new System.Drawing.Point(741, 156);
            this.btnConfirm4.Name = "btnConfirm4";
            this.btnConfirm4.Size = new System.Drawing.Size(84, 26);
            this.btnConfirm4.TabIndex = 66;
            this.btnConfirm4.Text = "Confirm";
            this.btnConfirm4.UseVisualStyleBackColor = true;
            this.btnConfirm4.Visible = false;
            this.btnConfirm4.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnConfirm3
            // 
            this.btnConfirm3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm3.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm3.Location = new System.Drawing.Point(741, 124);
            this.btnConfirm3.Name = "btnConfirm3";
            this.btnConfirm3.Size = new System.Drawing.Size(84, 25);
            this.btnConfirm3.TabIndex = 65;
            this.btnConfirm3.Text = "Confirm";
            this.btnConfirm3.UseVisualStyleBackColor = true;
            this.btnConfirm3.Visible = false;
            this.btnConfirm3.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnConfirm2
            // 
            this.btnConfirm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm2.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm2.Location = new System.Drawing.Point(741, 91);
            this.btnConfirm2.Name = "btnConfirm2";
            this.btnConfirm2.Size = new System.Drawing.Size(84, 26);
            this.btnConfirm2.TabIndex = 64;
            this.btnConfirm2.Text = "Confirm";
            this.btnConfirm2.UseVisualStyleBackColor = true;
            this.btnConfirm2.Visible = false;
            this.btnConfirm2.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // TextTime10
            // 
            this.TextTime10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime10.Location = new System.Drawing.Point(4, 363);
            this.TextTime10.Multiline = true;
            this.TextTime10.Name = "TextTime10";
            this.TextTime10.ReadOnly = true;
            this.TextTime10.Size = new System.Drawing.Size(120, 26);
            this.TextTime10.TabIndex = 61;
            // 
            // TextTime9
            // 
            this.TextTime9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime9.Location = new System.Drawing.Point(4, 329);
            this.TextTime9.Multiline = true;
            this.TextTime9.Name = "TextTime9";
            this.TextTime9.ReadOnly = true;
            this.TextTime9.Size = new System.Drawing.Size(120, 26);
            this.TextTime9.TabIndex = 58;
            // 
            // TextTime8
            // 
            this.TextTime8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextTime8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime8.Location = new System.Drawing.Point(4, 295);
            this.TextTime8.Multiline = true;
            this.TextTime8.Name = "TextTime8";
            this.TextTime8.ReadOnly = true;
            this.TextTime8.Size = new System.Drawing.Size(120, 26);
            this.TextTime8.TabIndex = 57;
            // 
            // TextTime7
            // 
            this.TextTime7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextTime7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime7.Location = new System.Drawing.Point(4, 261);
            this.TextTime7.Multiline = true;
            this.TextTime7.Name = "TextTime7";
            this.TextTime7.ReadOnly = true;
            this.TextTime7.Size = new System.Drawing.Size(120, 26);
            this.TextTime7.TabIndex = 56;
            // 
            // TextTime6
            // 
            this.TextTime6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextTime6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime6.Location = new System.Drawing.Point(4, 225);
            this.TextTime6.Multiline = true;
            this.TextTime6.Name = "TextTime6";
            this.TextTime6.ReadOnly = true;
            this.TextTime6.Size = new System.Drawing.Size(120, 26);
            this.TextTime6.TabIndex = 55;
            // 
            // TextTime5
            // 
            this.TextTime5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextTime5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime5.Location = new System.Drawing.Point(4, 190);
            this.TextTime5.Multiline = true;
            this.TextTime5.Name = "TextTime5";
            this.TextTime5.ReadOnly = true;
            this.TextTime5.Size = new System.Drawing.Size(120, 26);
            this.TextTime5.TabIndex = 54;
            // 
            // TextTime4
            // 
            this.TextTime4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextTime4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime4.Location = new System.Drawing.Point(4, 156);
            this.TextTime4.Multiline = true;
            this.TextTime4.Name = "TextTime4";
            this.TextTime4.ReadOnly = true;
            this.TextTime4.Size = new System.Drawing.Size(120, 26);
            this.TextTime4.TabIndex = 53;
            // 
            // TextTime3
            // 
            this.TextTime3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime3.Location = new System.Drawing.Point(4, 124);
            this.TextTime3.Multiline = true;
            this.TextTime3.Name = "TextTime3";
            this.TextTime3.ReadOnly = true;
            this.TextTime3.Size = new System.Drawing.Size(120, 25);
            this.TextTime3.TabIndex = 52;
            // 
            // TextTime2
            // 
            this.TextTime2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime2.Location = new System.Drawing.Point(4, 91);
            this.TextTime2.Multiline = true;
            this.TextTime2.Name = "TextTime2";
            this.TextTime2.ReadOnly = true;
            this.TextTime2.Size = new System.Drawing.Size(120, 26);
            this.TextTime2.TabIndex = 51;
            // 
            // TextComment9
            // 
            this.TextComment9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment9.Location = new System.Drawing.Point(512, 329);
            this.TextComment9.Name = "TextComment9";
            this.TextComment9.Size = new System.Drawing.Size(222, 26);
            this.TextComment9.TabIndex = 49;
            this.TextComment9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance9
            // 
            this.TextBalance9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance9.Location = new System.Drawing.Point(385, 329);
            this.TextBalance9.Name = "TextBalance9";
            this.TextBalance9.Size = new System.Drawing.Size(120, 26);
            this.TextBalance9.TabIndex = 48;
            this.TextBalance9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment8
            // 
            this.TextComment8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment8.Location = new System.Drawing.Point(512, 295);
            this.TextComment8.Name = "TextComment8";
            this.TextComment8.Size = new System.Drawing.Size(222, 26);
            this.TextComment8.TabIndex = 46;
            this.TextComment8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance8
            // 
            this.TextBalance8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance8.Location = new System.Drawing.Point(385, 295);
            this.TextBalance8.Name = "TextBalance8";
            this.TextBalance8.Size = new System.Drawing.Size(120, 26);
            this.TextBalance8.TabIndex = 45;
            this.TextBalance8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment7
            // 
            this.TextComment7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment7.Location = new System.Drawing.Point(512, 260);
            this.TextComment7.Name = "TextComment7";
            this.TextComment7.Size = new System.Drawing.Size(222, 26);
            this.TextComment7.TabIndex = 44;
            this.TextComment7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance7
            // 
            this.TextBalance7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance7.Location = new System.Drawing.Point(385, 260);
            this.TextBalance7.Name = "TextBalance7";
            this.TextBalance7.Size = new System.Drawing.Size(120, 26);
            this.TextBalance7.TabIndex = 43;
            this.TextBalance7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment6
            // 
            this.TextComment6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment6.Location = new System.Drawing.Point(512, 224);
            this.TextComment6.Name = "TextComment6";
            this.TextComment6.Size = new System.Drawing.Size(222, 26);
            this.TextComment6.TabIndex = 42;
            this.TextComment6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance6
            // 
            this.TextBalance6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance6.Location = new System.Drawing.Point(385, 224);
            this.TextBalance6.Name = "TextBalance6";
            this.TextBalance6.Size = new System.Drawing.Size(120, 26);
            this.TextBalance6.TabIndex = 41;
            this.TextBalance6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment5
            // 
            this.TextComment5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment5.Location = new System.Drawing.Point(512, 189);
            this.TextComment5.Name = "TextComment5";
            this.TextComment5.Size = new System.Drawing.Size(222, 26);
            this.TextComment5.TabIndex = 40;
            this.TextComment5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment4
            // 
            this.TextComment4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment4.Location = new System.Drawing.Point(512, 156);
            this.TextComment4.Name = "TextComment4";
            this.TextComment4.Size = new System.Drawing.Size(222, 26);
            this.TextComment4.TabIndex = 39;
            this.TextComment4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance4
            // 
            this.TextBalance4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance4.Location = new System.Drawing.Point(385, 156);
            this.TextBalance4.Name = "TextBalance4";
            this.TextBalance4.Size = new System.Drawing.Size(120, 26);
            this.TextBalance4.TabIndex = 38;
            this.TextBalance4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment3
            // 
            this.TextComment3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment3.Location = new System.Drawing.Point(512, 124);
            this.TextComment3.Name = "TextComment3";
            this.TextComment3.Size = new System.Drawing.Size(222, 26);
            this.TextComment3.TabIndex = 37;
            this.TextComment3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment2
            // 
            this.TextComment2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment2.Location = new System.Drawing.Point(512, 91);
            this.TextComment2.Name = "TextComment2";
            this.TextComment2.Size = new System.Drawing.Size(222, 26);
            this.TextComment2.TabIndex = 36;
            this.TextComment2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment1
            // 
            this.TextComment1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment1.Location = new System.Drawing.Point(512, 57);
            this.TextComment1.Name = "TextComment1";
            this.TextComment1.Size = new System.Drawing.Size(222, 26);
            this.TextComment1.TabIndex = 35;
            this.TextComment1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual9
            // 
            this.TextActual9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual9.Location = new System.Drawing.Point(258, 329);
            this.TextActual9.Name = "TextActual9";
            this.TextActual9.Size = new System.Drawing.Size(120, 26);
            this.TextActual9.TabIndex = 34;
            this.TextActual9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label16
            // 
            this.Label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(512, 1);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(222, 52);
            this.Label16.TabIndex = 4;
            this.Label16.Text = "Ghi chú";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label15
            // 
            this.Label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(385, 1);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(120, 52);
            this.Label15.TabIndex = 3;
            this.Label15.Text = "Chênh lệch";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label14
            // 
            this.Label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(258, 1);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(120, 52);
            this.Label14.TabIndex = 2;
            this.Label14.Text = "Thực tế";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label12
            // 
            this.Label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(4, 1);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(120, 52);
            this.Label12.TabIndex = 0;
            this.Label12.Text = "Thời gian";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextActual1
            // 
            this.TextActual1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual1.Location = new System.Drawing.Point(258, 57);
            this.TextActual1.Name = "TextActual1";
            this.TextActual1.Size = new System.Drawing.Size(120, 26);
            this.TextActual1.TabIndex = 5;
            this.TextActual1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan1
            // 
            this.TextPlan1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan1.Location = new System.Drawing.Point(131, 57);
            this.TextPlan1.Name = "TextPlan1";
            this.TextPlan1.Size = new System.Drawing.Size(120, 26);
            this.TextPlan1.TabIndex = 7;
            this.TextPlan1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance1
            // 
            this.TextBalance1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance1.Location = new System.Drawing.Point(385, 57);
            this.TextBalance1.Name = "TextBalance1";
            this.TextBalance1.Size = new System.Drawing.Size(120, 26);
            this.TextBalance1.TabIndex = 16;
            this.TextBalance1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan3
            // 
            this.TextPlan3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan3.Location = new System.Drawing.Point(131, 124);
            this.TextPlan3.Name = "TextPlan3";
            this.TextPlan3.Size = new System.Drawing.Size(120, 26);
            this.TextPlan3.TabIndex = 18;
            this.TextPlan3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan4
            // 
            this.TextPlan4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan4.Location = new System.Drawing.Point(131, 156);
            this.TextPlan4.Name = "TextPlan4";
            this.TextPlan4.Size = new System.Drawing.Size(120, 26);
            this.TextPlan4.TabIndex = 19;
            this.TextPlan4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan6
            // 
            this.TextPlan6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan6.Location = new System.Drawing.Point(131, 224);
            this.TextPlan6.Name = "TextPlan6";
            this.TextPlan6.Size = new System.Drawing.Size(120, 26);
            this.TextPlan6.TabIndex = 20;
            this.TextPlan6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan5
            // 
            this.TextPlan5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan5.Location = new System.Drawing.Point(131, 189);
            this.TextPlan5.Name = "TextPlan5";
            this.TextPlan5.Size = new System.Drawing.Size(120, 26);
            this.TextPlan5.TabIndex = 21;
            this.TextPlan5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan7
            // 
            this.TextPlan7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan7.Location = new System.Drawing.Point(131, 260);
            this.TextPlan7.Name = "TextPlan7";
            this.TextPlan7.Size = new System.Drawing.Size(120, 26);
            this.TextPlan7.TabIndex = 22;
            this.TextPlan7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan8
            // 
            this.TextPlan8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan8.Location = new System.Drawing.Point(131, 295);
            this.TextPlan8.Name = "TextPlan8";
            this.TextPlan8.Size = new System.Drawing.Size(120, 26);
            this.TextPlan8.TabIndex = 23;
            this.TextPlan8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan9
            // 
            this.TextPlan9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan9.Location = new System.Drawing.Point(131, 329);
            this.TextPlan9.Name = "TextPlan9";
            this.TextPlan9.Size = new System.Drawing.Size(120, 26);
            this.TextPlan9.TabIndex = 15;
            this.TextPlan9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual2
            // 
            this.TextActual2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual2.Location = new System.Drawing.Point(258, 91);
            this.TextActual2.Name = "TextActual2";
            this.TextActual2.Size = new System.Drawing.Size(120, 26);
            this.TextActual2.TabIndex = 24;
            this.TextActual2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance2
            // 
            this.TextBalance2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance2.Location = new System.Drawing.Point(385, 91);
            this.TextBalance2.Name = "TextBalance2";
            this.TextBalance2.Size = new System.Drawing.Size(120, 26);
            this.TextBalance2.TabIndex = 25;
            this.TextBalance2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual3
            // 
            this.TextActual3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual3.Location = new System.Drawing.Point(258, 124);
            this.TextActual3.Name = "TextActual3";
            this.TextActual3.Size = new System.Drawing.Size(120, 26);
            this.TextActual3.TabIndex = 26;
            this.TextActual3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance3
            // 
            this.TextBalance3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance3.Location = new System.Drawing.Point(385, 124);
            this.TextBalance3.Name = "TextBalance3";
            this.TextBalance3.Size = new System.Drawing.Size(120, 26);
            this.TextBalance3.TabIndex = 27;
            this.TextBalance3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual4
            // 
            this.TextActual4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual4.Location = new System.Drawing.Point(258, 156);
            this.TextActual4.Name = "TextActual4";
            this.TextActual4.Size = new System.Drawing.Size(120, 26);
            this.TextActual4.TabIndex = 28;
            this.TextActual4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual5
            // 
            this.TextActual5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual5.Location = new System.Drawing.Point(258, 189);
            this.TextActual5.Name = "TextActual5";
            this.TextActual5.Size = new System.Drawing.Size(120, 26);
            this.TextActual5.TabIndex = 29;
            this.TextActual5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance5
            // 
            this.TextBalance5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance5.Location = new System.Drawing.Point(385, 189);
            this.TextBalance5.Name = "TextBalance5";
            this.TextBalance5.Size = new System.Drawing.Size(120, 26);
            this.TextBalance5.TabIndex = 30;
            this.TextBalance5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual6
            // 
            this.TextActual6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual6.Location = new System.Drawing.Point(258, 224);
            this.TextActual6.Name = "TextActual6";
            this.TextActual6.Size = new System.Drawing.Size(120, 26);
            this.TextActual6.TabIndex = 31;
            this.TextActual6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual7
            // 
            this.TextActual7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual7.Location = new System.Drawing.Point(258, 260);
            this.TextActual7.Name = "TextActual7";
            this.TextActual7.Size = new System.Drawing.Size(120, 26);
            this.TextActual7.TabIndex = 32;
            this.TextActual7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual8
            // 
            this.TextActual8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual8.Location = new System.Drawing.Point(258, 295);
            this.TextActual8.Name = "TextActual8";
            this.TextActual8.Size = new System.Drawing.Size(120, 26);
            this.TextActual8.TabIndex = 33;
            this.TextActual8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextTime1
            // 
            this.TextTime1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime1.Location = new System.Drawing.Point(4, 57);
            this.TextTime1.Multiline = true;
            this.TextTime1.Name = "TextTime1";
            this.TextTime1.ReadOnly = true;
            this.TextTime1.Size = new System.Drawing.Size(120, 26);
            this.TextTime1.TabIndex = 50;
            // 
            // TextComment10
            // 
            this.TextComment10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment10.Location = new System.Drawing.Point(512, 363);
            this.TextComment10.Name = "TextComment10";
            this.TextComment10.Size = new System.Drawing.Size(222, 26);
            this.TextComment10.TabIndex = 59;
            this.TextComment10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance10
            // 
            this.TextBalance10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance10.Location = new System.Drawing.Point(385, 363);
            this.TextBalance10.Name = "TextBalance10";
            this.TextBalance10.Size = new System.Drawing.Size(120, 26);
            this.TextBalance10.TabIndex = 60;
            this.TextBalance10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual10
            // 
            this.TextActual10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual10.Location = new System.Drawing.Point(258, 363);
            this.TextActual10.Name = "TextActual10";
            this.TextActual10.Size = new System.Drawing.Size(120, 26);
            this.TextActual10.TabIndex = 60;
            this.TextActual10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan10
            // 
            this.TextPlan10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan10.Location = new System.Drawing.Point(131, 363);
            this.TextPlan10.Name = "TextPlan10";
            this.TextPlan10.Size = new System.Drawing.Size(120, 26);
            this.TextPlan10.TabIndex = 60;
            this.TextPlan10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label13
            // 
            this.Label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(131, 1);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(120, 52);
            this.Label13.TabIndex = 1;
            this.Label13.Text = "Kế hoạch";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm1
            // 
            this.btnConfirm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm1.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm1.Location = new System.Drawing.Point(741, 57);
            this.btnConfirm1.Name = "btnConfirm1";
            this.btnConfirm1.Size = new System.Drawing.Size(84, 27);
            this.btnConfirm1.TabIndex = 62;
            this.btnConfirm1.Text = "Confirm";
            this.btnConfirm1.UseVisualStyleBackColor = true;
            this.btnConfirm1.Visible = false;
            this.btnConfirm1.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // TextPlan2
            // 
            this.TextPlan2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan2.Location = new System.Drawing.Point(131, 91);
            this.TextPlan2.Name = "TextPlan2";
            this.TextPlan2.Size = new System.Drawing.Size(120, 26);
            this.TextPlan2.TabIndex = 17;
            this.TextPlan2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Shape2
            // 
            this.Shape2.BackColor = System.Drawing.Color.Yellow;
            this.Shape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.Shape2.BorderColor = System.Drawing.Color.Transparent;
            this.Shape2.FillColor = System.Drawing.Color.Black;
            this.Shape2.Location = new System.Drawing.Point(94, 42);
            this.Shape2.Name = "Shape2";
            this.Shape2.Size = new System.Drawing.Size(33, 33);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.BtReduce);
            this.GroupBox2.Controls.Add(this.BtIncrease);
            this.GroupBox2.Controls.Add(this.Label19);
            this.GroupBox2.Controls.Add(this.Label18);
            this.GroupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(843, 425);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(148, 120);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            // 
            // BtReduce
            // 
            this.BtReduce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtReduce.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtReduce.Image = global::Line_Production.Properties.Resources.minus;
            this.BtReduce.Location = new System.Drawing.Point(78, 70);
            this.BtReduce.Name = "BtReduce";
            this.BtReduce.Size = new System.Drawing.Size(53, 43);
            this.BtReduce.TabIndex = 11;
            this.BtReduce.UseVisualStyleBackColor = true;
            this.BtReduce.Click += new System.EventHandler(this.BtReduce_Click);
            // 
            // BtIncrease
            // 
            this.BtIncrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtIncrease.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIncrease.Image = global::Line_Production.Properties.Resources.plus;
            this.BtIncrease.Location = new System.Drawing.Point(79, 15);
            this.BtIncrease.Name = "BtIncrease";
            this.BtIncrease.Size = new System.Drawing.Size(53, 46);
            this.BtIncrease.TabIndex = 10;
            this.toolTip1.SetToolTip(this.BtIncrease, "Space");
            this.BtIncrease.UseVisualStyleBackColor = true;
            this.BtIncrease.Click += new System.EventHandler(this.BtIncrease_Click);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(2, 80);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(50, 15);
            this.Label19.TabIndex = 9;
            this.Label19.Text = "Giảm SL";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(2, 31);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(55, 15);
            this.Label18.TabIndex = 9;
            this.Label18.Text = "Tăng SL:";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.LabelShapeError);
            this.GroupBox3.Controls.Add(this.LabelShapeOffLine);
            this.GroupBox3.Controls.Add(this.LabelShapeOnline);
            this.GroupBox3.Controls.Add(this.ShapeContainer2);
            this.GroupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(844, 234);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(137, 157);
            this.GroupBox3.TabIndex = 10;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Tình trạng Line";
            // 
            // LabelShapeError
            // 
            this.LabelShapeError.AutoSize = true;
            this.LabelShapeError.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShapeError.Location = new System.Drawing.Point(14, 113);
            this.LabelShapeError.Name = "LabelShapeError";
            this.LabelShapeError.Size = new System.Drawing.Size(69, 15);
            this.LabelShapeError.TabIndex = 9;
            this.LabelShapeError.Text = "Bất thường";
            // 
            // LabelShapeOffLine
            // 
            this.LabelShapeOffLine.AutoSize = true;
            this.LabelShapeOffLine.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShapeOffLine.Location = new System.Drawing.Point(16, 70);
            this.LabelShapeOffLine.Name = "LabelShapeOffLine";
            this.LabelShapeOffLine.Size = new System.Drawing.Size(57, 15);
            this.LabelShapeOffLine.TabIndex = 8;
            this.LabelShapeOffLine.Text = "Báo động";
            // 
            // LabelShapeOnline
            // 
            this.LabelShapeOnline.AutoSize = true;
            this.LabelShapeOnline.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShapeOnline.Location = new System.Drawing.Point(13, 30);
            this.LabelShapeOnline.Name = "LabelShapeOnline";
            this.LabelShapeOnline.Size = new System.Drawing.Size(77, 15);
            this.LabelShapeOnline.TabIndex = 7;
            this.LabelShapeOnline.Text = "Bình thường";
            // 
            // ShapeContainer2
            // 
            this.ShapeContainer2.Location = new System.Drawing.Point(3, 18);
            this.ShapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer2.Name = "ShapeContainer2";
            this.ShapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Shape3,
            this.Shape1,
            this.Shape2});
            this.ShapeContainer2.Size = new System.Drawing.Size(131, 136);
            this.ShapeContainer2.TabIndex = 6;
            this.ShapeContainer2.TabStop = false;
            // 
            // Shape3
            // 
            this.Shape3.BackColor = System.Drawing.Color.Red;
            this.Shape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.Shape3.BorderColor = System.Drawing.Color.Transparent;
            this.Shape3.FillColor = System.Drawing.Color.Black;
            this.Shape3.Location = new System.Drawing.Point(94, 83);
            this.Shape3.Name = "Shape3";
            this.Shape3.Size = new System.Drawing.Size(33, 33);
            // 
            // Shape1
            // 
            this.Shape1.BackColor = System.Drawing.Color.Lime;
            this.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.Shape1.BorderColor = System.Drawing.Color.Transparent;
            this.Shape1.FillColor = System.Drawing.Color.Black;
            this.Shape1.Location = new System.Drawing.Point(94, -1);
            this.Shape1.Name = "Shape1";
            this.Shape1.Size = new System.Drawing.Size(33, 33);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.cbbFilter);
            this.GroupBox7.Controls.Add(this.txtSearch);
            this.GroupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox7.Location = new System.Drawing.Point(838, 544);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(148, 87);
            this.GroupBox7.TabIndex = 15;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "Search";
            // 
            // cbbFilter
            // 
            this.cbbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFilter.FormattingEnabled = true;
            this.cbbFilter.Items.AddRange(new object[] {
            "SERIAL",
            "BOXID"});
            this.cbbFilter.Location = new System.Drawing.Point(5, 22);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Size = new System.Drawing.Size(139, 24);
            this.cbbFilter.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(142, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSearch_PreviewKeyDown);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.LightGray;
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2,
            this.ToolStripStatusLabel3,
            this.lblVersion,
            this.ToolStripStatusLabel4,
            this.lblComcontrol,
            this.ToolStripStatusLabel6,
            this.lblState,
            this.ToolStripStatusLabel7,
            this.lblUser,
            this.ToolStripStatusLabel9,
            this.lblTotal,
            this.ToolStripStatusLabel5,
            this.ToolStripStatusLabel8});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 639);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(984, 22);
            this.StatusStrip1.TabIndex = 16;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.ToolStripStatusLabel1.Text = "Support:";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(40, 17);
            this.ToolStripStatusLabel2.Text = "PE-IT";
            this.ToolStripStatusLabel2.ToolTipText = "Support";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(48, 17);
            this.ToolStripStatusLabel3.Text = "Version:";
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(15, 17);
            this.lblVersion.Text = "0";
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(80, 17);
            this.ToolStripStatusLabel4.Text = "Device Name:";
            // 
            // lblComcontrol
            // 
            this.lblComcontrol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComcontrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblComcontrol.Name = "lblComcontrol";
            this.lblComcontrol.Size = new System.Drawing.Size(45, 17);
            this.lblComcontrol.Text = "COM1";
            // 
            // ToolStripStatusLabel6
            // 
            this.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            this.ToolStripStatusLabel6.Size = new System.Drawing.Size(36, 17);
            this.ToolStripStatusLabel6.Text = "State:";
            // 
            // lblState
            // 
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 17);
            this.lblState.Text = "None";
            // 
            // ToolStripStatusLabel7
            // 
            this.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7";
            this.ToolStripStatusLabel7.Size = new System.Drawing.Size(33, 17);
            this.ToolStripStatusLabel7.Text = "User:";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 17);
            this.lblUser.Text = "u23702";
            // 
            // ToolStripStatusLabel9
            // 
            this.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9";
            this.ToolStripStatusLabel9.Size = new System.Drawing.Size(35, 17);
            this.ToolStripStatusLabel9.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 17);
            this.lblTotal.Text = "#NA";
            // 
            // ToolStripStatusLabel5
            // 
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(42, 17);
            this.ToolStripStatusLabel5.Text = "Server:";
            // 
            // ToolStripStatusLabel8
            // 
            this.ToolStripStatusLabel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8";
            this.ToolStripStatusLabel8.Size = new System.Drawing.Size(76, 17);
            this.ToolStripStatusLabel8.Text = "172.28.10.8";
            // 
            // Timer3
            // 
            this.Timer3.Enabled = true;
            this.Timer3.Interval = 5000;
            this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // LabelTimeDate
            // 
            this.LabelTimeDate.BackColor = System.Drawing.Color.Black;
            this.LabelTimeDate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelTimeDate.Location = new System.Drawing.Point(431, 3);
            this.LabelTimeDate.Name = "LabelTimeDate";
            this.LabelTimeDate.Size = new System.Drawing.Size(270, 65);
            this.LabelTimeDate.TabIndex = 18;
            this.LabelTimeDate.Text = "10:10:50   2016/08/16";
            this.LabelTimeDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(10, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(415, 65);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "BẢNG QUẢN LÝ SẢN LƯỢNG";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHistoryNo
            // 
            this.lblHistoryNo.BackColor = System.Drawing.Color.Black;
            this.lblHistoryNo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblHistoryNo.Location = new System.Drawing.Point(707, 3);
            this.lblHistoryNo.Name = "lblHistoryNo";
            this.lblHistoryNo.Size = new System.Drawing.Size(271, 65);
            this.lblHistoryNo.TabIndex = 23;
            this.lblHistoryNo.Text = "HIS: 01";
            this.lblHistoryNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bgwLinkWip
            // 
            this.bgwLinkWip.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLinkWip_DoWork);
            this.bgwLinkWip.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLinkWip_RunWorkerCompleted);
            // 
            // lblSettingTime
            // 
            this.lblSettingTime.AutoSize = true;
            this.lblSettingTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSettingTime.Image = global::Line_Production.Properties.Resources.icons8_time_30;
            this.lblSettingTime.Location = new System.Drawing.Point(947, 397);
            this.lblSettingTime.MinimumSize = new System.Drawing.Size(25, 25);
            this.lblSettingTime.Name = "lblSettingTime";
            this.lblSettingTime.Size = new System.Drawing.Size(25, 25);
            this.lblSettingTime.TabIndex = 22;
            this.toolTip1.SetToolTip(this.lblSettingTime, "Time");
            this.lblSettingTime.Click += new System.EventHandler(this.lblSettingTime_Click);
            // 
            // lblListModel
            // 
            this.lblListModel.AutoSize = true;
            this.lblListModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListModel.Image = global::Line_Production.Properties.Resources.construction;
            this.lblListModel.Location = new System.Drawing.Point(900, 397);
            this.lblListModel.MinimumSize = new System.Drawing.Size(25, 25);
            this.lblListModel.Name = "lblListModel";
            this.lblListModel.Size = new System.Drawing.Size(25, 25);
            this.lblListModel.TabIndex = 21;
            this.toolTip1.SetToolTip(this.lblListModel, "List Model");
            this.lblListModel.Click += new System.EventHandler(this.lblListModel_Click);
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfig.Image = global::Line_Production.Properties.Resources.tools_16;
            this.lblConfig.Location = new System.Drawing.Point(854, 397);
            this.lblConfig.MinimumSize = new System.Drawing.Size(25, 25);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(25, 25);
            this.lblConfig.TabIndex = 17;
            this.toolTip1.SetToolTip(this.lblConfig, "Config");
            this.lblConfig.Click += new System.EventHandler(this.lblConfig_Click);
            // 
            // timerCompress
            // 
            this.timerCompress.Enabled = true;
            this.timerCompress.Interval = 8;
            this.timerCompress.Tick += new System.EventHandler(this.timerCompress_Tick);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.lblHistoryNo);
            this.Controls.Add(this.LabelTimeDate);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblSettingTime);
            this.Controls.Add(this.lblListModel);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.GroupBox7);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Line Production";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Control_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.groupSoThung.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.Table1.ResumeLayout(false);
            this.Table1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        internal Label Label2;
        internal GroupBox GroupBox1;
        internal TextBox txtDate;
        internal Label Label4;
        internal Label Label3;
        public TextBox txtLine;
        internal Label Label5;
        internal TextBox TextCycleTimeCurrent;
        internal Label Label8;
        internal TextBox TextCycleTimeModel;
        internal Label Label7;
        internal Label Label11;
        internal Label Label10;
        internal Label Label9;
        internal TextBox TextBalance;
        internal TextBox txtActual;
        internal TextBox txtPlan;
        internal TableLayoutPanel Table1;
        internal Label Label12;
        internal Label Label16;
        internal Label Label15;
        internal Label Label14;
        internal Label Label13;
        internal TextBox TextActual1;
        internal TextBox TextComment9;
        internal TextBox TextBalance9;
        internal TextBox TextComment8;
        internal TextBox TextBalance8;
        internal TextBox TextComment7;
        internal TextBox TextBalance7;
        internal TextBox TextComment6;
        internal TextBox TextBalance6;
        internal TextBox TextComment5;
        internal TextBox TextComment4;
        internal TextBox TextBalance4;
        internal TextBox TextComment3;
        internal TextBox TextComment2;
        internal TextBox TextComment1;
        internal TextBox TextActual9;
        internal TextBox TextPlan1;
        internal TextBox TextBalance1;
        internal TextBox TextPlan3;
        internal TextBox TextPlan4;
        internal TextBox TextPlan6;
        internal TextBox TextPlan5;
        internal TextBox TextPlan7;
        internal TextBox TextPlan8;
        internal TextBox TextPlan9;
        internal TextBox TextActual2;
        internal TextBox TextBalance2;
        internal TextBox TextActual3;
        internal TextBox TextBalance3;
        internal TextBox TextActual4;
        internal TextBox TextActual5;
        internal TextBox TextBalance5;
        internal TextBox TextActual6;
        internal TextBox TextActual7;
        internal TextBox TextActual8;
        internal Label Label17;
        internal GroupBox GroupBox2;
        internal Label Label19;
        internal Label Label18;
        internal GroupBox GroupBox3;
        internal TextBox txtPeople;
        public  System.IO.Ports.SerialPort ComPressPort;
        internal Timer Timer1;
        internal Button BtStop;
        internal Button BtStart;
        internal Label Label6;
        internal TextBox txtShift;
        internal Label LabelShapeError;
        internal Label LabelShapeOffLine;
        internal Label LabelShapeOnline;
        internal TextBox TextTime9;
        internal TextBox TextTime8;
        internal TextBox TextTime7;
        internal TextBox TextTime6;
        internal TextBox TextTime5;
        internal TextBox TextTime4;
        internal TextBox TextTime3;
        internal TextBox TextTime2;
        internal TextBox TextTime1;
        internal Label lblQuantity;
        internal Button BtReduce;
        internal Button BtIncrease;
        internal TextBox TextTime10;
        internal TextBox TextComment10;
        internal TextBox TextBalance10;
        internal TextBox TextActual10;
        internal TextBox TextPlan10;
        internal Label LabelPCS1BOX;
        internal Label Label23;
        internal Label LabelPCBA;
        internal Label lblExplain;
        internal TextBox TextMacBox;
        internal Label Label24;
        internal GroupBox GroupBox5;
        internal GroupBox GroupBox4;
        internal Label LabelSoThung;
        internal GroupBox groupSoThung;
        internal GroupBox GroupBox7;
        internal TextBox txtSearch;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripStatusLabel ToolStripStatusLabel3;
        internal ToolStripStatusLabel lblVersion;
        internal ToolStripStatusLabel ToolStripStatusLabel4;
        internal ToolStripStatusLabel lblComcontrol;
        internal ToolStripStatusLabel ToolStripStatusLabel6;
        internal ToolStripStatusLabel lblState;
        internal LinkLabel lblConfig;
        private CheckBox chkNG;
        internal ToolStripStatusLabel ToolStripStatusLabel7;
        public ToolStripStatusLabel lblUser;
        internal ToolStripStatusLabel ToolStripStatusLabel5;
        internal ToolStripStatusLabel ToolStripStatusLabel8;
        internal ToolStripStatusLabel ToolStripStatusLabel9;
        internal ToolStripStatusLabel lblTotal;
        internal Timer Timer3;
        private CheckBox chkOK;
        private OvalShape Shape2;
        private ShapeContainer ShapeContainer2;
        private OvalShape Shape3;
        private OvalShape Shape1;
        internal LinkLabel lblListModel;
        internal LinkLabel lblSettingTime;
        internal TextBox txtSerial;
        private Label lblRepair;
        private ComboBox cbbFilter;
        private Label lblWaiting;
        internal Label LabelTimeDate;
        internal Label Label1;
        internal Label lblHistoryNo;
        private System.ComponentModel.BackgroundWorker bgwLinkWip;
        private ComboBox cbbModel;
        public TextBox lblModel;
        private ToolTip toolTip1;
        private Button btnConfirm10;
        private Button btnConfirm9;
        private Button btnConfirm8;
        private Button btnConfirm7;
        private Button btnConfirm6;
        private Button btnConfirm5;
        private Button btnConfirm4;
        private Button btnConfirm3;
        private Button btnConfirm2;
        private Button btnConfirm1;
        internal TextBox TextPlan2;
        private Timer timerCompress;
    }
}
