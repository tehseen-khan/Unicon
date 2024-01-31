namespace Unicon
{
    partial class frmUnicon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnicon));
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.LBTo = new System.Windows.Forms.ListBox();
            this.LBFrom = new System.Windows.Forms.ListBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmbParam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdSwap = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "Currency",
            "Decimal",
            "Exponential (scientific)",
            "Fixed-point",
            "General",
            "Number",
            "Percent",
            "Round-trip"});
            this.cmbFormat.Location = new System.Drawing.Point(558, 246);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(182, 28);
            this.cmbFormat.TabIndex = 20;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(318, 243);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(112, 26);
            this.txtTo.TabIndex = 17;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(318, 169);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(112, 26);
            this.txtFrom.TabIndex = 18;
            this.txtFrom.Text = "1.0";
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(322, 412);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(105, 43);
            this.cmdExit.TabIndex = 15;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(322, 284);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(105, 43);
            this.cmdConvert.TabIndex = 16;
            this.cmdConvert.Text = "Convert";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // LBTo
            // 
            this.LBTo.FormattingEnabled = true;
            this.LBTo.ItemHeight = 20;
            this.LBTo.Location = new System.Drawing.Point(156, 131);
            this.LBTo.Name = "LBTo";
            this.LBTo.Size = new System.Drawing.Size(134, 464);
            this.LBTo.TabIndex = 13;
            this.LBTo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LBFrom_MouseMove);
            // 
            // LBFrom
            // 
            this.LBFrom.FormattingEnabled = true;
            this.LBFrom.ItemHeight = 20;
            this.LBFrom.Location = new System.Drawing.Point(14, 131);
            this.LBFrom.Name = "LBFrom";
            this.LBFrom.Size = new System.Drawing.Size(134, 464);
            this.LBFrom.TabIndex = 14;
            this.LBFrom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LBFrom_MouseMove);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(156, 105);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(30, 20);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "TO";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(318, 218);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(27, 20);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "To";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(14, 105);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 20);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "FROM";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(318, 143);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 20);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "From";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 63);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 20);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Parameter";
            // 
            // cmbParam
            // 
            this.cmbParam.DisplayMember = "ParamID";
            this.cmbParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParam.FormattingEnabled = true;
            this.cmbParam.Location = new System.Drawing.Point(99, 60);
            this.cmbParam.Name = "cmbParam";
            this.cmbParam.Size = new System.Drawing.Size(205, 28);
            this.cmbParam.TabIndex = 7;
            this.cmbParam.ValueMember = "ParamID";
            this.cmbParam.SelectedIndexChanged += new System.EventHandler(this.cmbParam_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 33);
            this.label6.TabIndex = 21;
            this.label6.Text = "UNICON";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "dat";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "DB Files|*.dat";
            // 
            // cmdSwap
            // 
            this.cmdSwap.Location = new System.Drawing.Point(322, 345);
            this.cmdSwap.Name = "cmdSwap";
            this.cmdSwap.Size = new System.Drawing.Size(105, 43);
            this.cmdSwap.TabIndex = 22;
            this.cmdSwap.Text = "Swap";
            this.cmdSwap.UseVisualStyleBackColor = true;
            this.cmdSwap.Click += new System.EventHandler(this.cmdSwap_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Program Developed by Tehseen ";
            // 
            // frmUnicon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 605);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdSwap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdConvert);
            this.Controls.Add(this.LBTo);
            this.Controls.Add(this.LBFrom);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cmbParam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmUnicon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unicon";
            this.Load += new System.EventHandler(this.frmUnicon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbFormat;
        internal System.Windows.Forms.TextBox txtTo;
        internal System.Windows.Forms.TextBox txtFrom;
        internal System.Windows.Forms.Button cmdExit;
        internal System.Windows.Forms.Button cmdConvert;
        internal System.Windows.Forms.ListBox LBTo;
        internal System.Windows.Forms.ListBox LBFrom;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cmbParam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Button cmdSwap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

