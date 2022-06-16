using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic

namespace Line_Production
{
    [DesignerGenerated()]
    public partial class ResultForm : System.Windows.Forms.Form
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
            this.dgrvSearch = new System.Windows.Forms.DataGridView();
            this.ProductionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updator_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updator_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wo_sap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvSearch
            // 
            this.dgrvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductionID,
            this.BoxID,
            this.Serial,
            this.Station,
            this.UpdateTime,
            this.Repair,
            this.ID,
            this.Updator_Code,
            this.Updator_Name,
            this.Line,
            this.NamePC,
            this.ShiftDate,
            this.Status,
            this.Wo_sap,
            this.UMes});
            this.dgrvSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvSearch.Location = new System.Drawing.Point(0, 0);
            this.dgrvSearch.Name = "dgrvSearch";
            this.dgrvSearch.Size = new System.Drawing.Size(841, 461);
            this.dgrvSearch.TabIndex = 0;
            // 
            // ProductionID
            // 
            this.ProductionID.DataPropertyName = "ProductionID";
            this.ProductionID.HeaderText = "ProductionID";
            this.ProductionID.Name = "ProductionID";
            // 
            // BoxID
            // 
            this.BoxID.DataPropertyName = "BoxID";
            this.BoxID.HeaderText = "BoxID";
            this.BoxID.Name = "BoxID";
            // 
            // Serial
            // 
            this.Serial.DataPropertyName = "BoardNo";
            this.Serial.HeaderText = "Serial";
            this.Serial.Name = "Serial";
            // 
            // Station
            // 
            this.Station.DataPropertyName = "Station";
            this.Station.HeaderText = "Station";
            this.Station.Name = "Station";
            // 
            // UpdateTime
            // 
            this.UpdateTime.DataPropertyName = "UpdateTime";
            this.UpdateTime.HeaderText = "UpdateTime";
            this.UpdateTime.Name = "UpdateTime";
            // 
            // Repair
            // 
            this.Repair.DataPropertyName = "Repair";
            this.Repair.HeaderText = "Repair";
            this.Repair.Name = "Repair";
            this.Repair.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Updator_Code
            // 
            this.Updator_Code.DataPropertyName = "Updator_Code";
            this.Updator_Code.HeaderText = "Updator_Code";
            this.Updator_Code.Name = "Updator_Code";
            this.Updator_Code.Visible = false;
            // 
            // Updator_Name
            // 
            this.Updator_Name.DataPropertyName = "Updator_Name";
            this.Updator_Name.HeaderText = "Updator_Name";
            this.Updator_Name.Name = "Updator_Name";
            this.Updator_Name.Visible = false;
            // 
            // Line
            // 
            this.Line.DataPropertyName = "Line";
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            this.Line.Visible = false;
            // 
            // NamePC
            // 
            this.NamePC.DataPropertyName = "NamePC";
            this.NamePC.HeaderText = "NamePC";
            this.NamePC.Name = "NamePC";
            this.NamePC.Visible = false;
            // 
            // ShiftDate
            // 
            this.ShiftDate.DataPropertyName = "ShiftDate";
            this.ShiftDate.HeaderText = "ShiftDate";
            this.ShiftDate.Name = "ShiftDate";
            this.ShiftDate.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = false;
            // 
            // Wo_sap
            // 
            this.Wo_sap.DataPropertyName = "Wo_Sap";
            this.Wo_sap.HeaderText = "Usap";
            this.Wo_sap.Name = "Wo_sap";
            this.Wo_sap.Visible = false;
            // 
            // UMes
            // 
            this.UMes.DataPropertyName = "Wo_Mes";
            this.UMes.HeaderText = "UMes";
            this.UMes.Name = "UMes";
            this.UMes.Visible = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 461);
            this.Controls.Add(this.dgrvSearch);
            this.Name = "ResultForm";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        internal DataGridView dgrvSearch;
        private DataGridViewTextBoxColumn ProductionID;
        private DataGridViewTextBoxColumn BoxID;
        private DataGridViewTextBoxColumn Serial;
        private DataGridViewTextBoxColumn Station;
        private DataGridViewTextBoxColumn UpdateTime;
        private DataGridViewTextBoxColumn Repair;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Updator_Code;
        private DataGridViewTextBoxColumn Updator_Name;
        private DataGridViewTextBoxColumn Line;
        private DataGridViewTextBoxColumn NamePC;
        private DataGridViewTextBoxColumn ShiftDate;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Wo_sap;
        private DataGridViewTextBoxColumn UMes;
    }
}
