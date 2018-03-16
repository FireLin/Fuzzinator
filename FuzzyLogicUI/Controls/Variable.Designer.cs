namespace FuzzyLogicUI.Controls
{
    partial class Variable
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.VarName = new System.Windows.Forms.Label();
            this.VarTxT = new System.Windows.Forms.TextBox();
            this.Range = new System.Windows.Forms.Label();
            this.RangeTxT = new System.Windows.Forms.TextBox();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveMFBtn = new System.Windows.Forms.Button();
            this.MFTypeCombo = new System.Windows.Forms.ComboBox();
            this.MFParamTxT = new System.Windows.Forms.TextBox();
            this.MFNameTxT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MfBtn = new System.Windows.Forms.Button();
            this.MFView = new System.Windows.Forms.ListView();
            this.RemMFBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 391);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // VarName
            // 
            this.VarName.AutoSize = true;
            this.VarName.Location = new System.Drawing.Point(16, 13);
            this.VarName.Name = "VarName";
            this.VarName.Size = new System.Drawing.Size(75, 13);
            this.VarName.TabIndex = 0;
            this.VarName.Text = "Variable Name";
            // 
            // VarTxT
            // 
            this.VarTxT.Location = new System.Drawing.Point(93, 10);
            this.VarTxT.Name = "VarTxT";
            this.VarTxT.Size = new System.Drawing.Size(143, 20);
            this.VarTxT.TabIndex = 1;
            this.VarTxT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnNameEdit);
            // 
            // Range
            // 
            this.Range.AutoSize = true;
            this.Range.Location = new System.Drawing.Point(282, 13);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(38, 13);
            this.Range.TabIndex = 2;
            this.Range.Text = "Range";
            // 
            // RangeTxT
            // 
            this.RangeTxT.Location = new System.Drawing.Point(326, 10);
            this.RangeTxT.Name = "RangeTxT";
            this.RangeTxT.Size = new System.Drawing.Size(120, 20);
            this.RangeTxT.TabIndex = 3;
            this.RangeTxT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnRangeEdit);
            // 
            // ChartPanel
            // 
            this.ChartPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ChartPanel.Location = new System.Drawing.Point(3, 45);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(728, 237);
            this.ChartPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type";
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Items.AddRange(new object[] {
            "Input",
            "Output"});
            this.TypeCombo.Location = new System.Drawing.Point(544, 9);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(121, 21);
            this.TypeCombo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "List of Membership Functions";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveMFBtn);
            this.groupBox1.Controls.Add(this.MFTypeCombo);
            this.groupBox1.Controls.Add(this.MFParamTxT);
            this.groupBox1.Controls.Add(this.MFNameTxT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(169, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Membership function";
            // 
            // SaveMFBtn
            // 
            this.SaveMFBtn.Location = new System.Drawing.Point(267, 116);
            this.SaveMFBtn.Name = "SaveMFBtn";
            this.SaveMFBtn.Size = new System.Drawing.Size(50, 23);
            this.SaveMFBtn.TabIndex = 7;
            this.SaveMFBtn.Text = "Save";
            this.SaveMFBtn.UseVisualStyleBackColor = true;
            this.SaveMFBtn.Click += new System.EventHandler(this.SaveMFBtn_Click);
            // 
            // MFTypeCombo
            // 
            this.MFTypeCombo.FormattingEnabled = true;
            this.MFTypeCombo.Items.AddRange(new object[] {
            "Trimf",
            "Trapmf"});
            this.MFTypeCombo.Location = new System.Drawing.Point(69, 60);
            this.MFTypeCombo.Name = "MFTypeCombo";
            this.MFTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.MFTypeCombo.TabIndex = 6;
            // 
            // MFParamTxT
            // 
            this.MFParamTxT.Location = new System.Drawing.Point(69, 96);
            this.MFParamTxT.Name = "MFParamTxT";
            this.MFParamTxT.Size = new System.Drawing.Size(192, 20);
            this.MFParamTxT.TabIndex = 5;
            // 
            // MFNameTxT
            // 
            this.MFNameTxT.Location = new System.Drawing.Point(69, 25);
            this.MFNameTxT.Name = "MFNameTxT";
            this.MFNameTxT.Size = new System.Drawing.Size(136, 20);
            this.MFNameTxT.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // MfBtn
            // 
            this.MfBtn.Location = new System.Drawing.Point(510, 312);
            this.MfBtn.Name = "MfBtn";
            this.MfBtn.Size = new System.Drawing.Size(89, 23);
            this.MfBtn.TabIndex = 11;
            this.MfBtn.Text = "add MF";
            this.MfBtn.UseVisualStyleBackColor = true;
            this.MfBtn.Click += new System.EventHandler(this.MfBtn_Click);
            // 
            // MFView
            // 
            this.MFView.Location = new System.Drawing.Point(3, 313);
            this.MFView.MultiSelect = false;
            this.MFView.Name = "MFView";
            this.MFView.Size = new System.Drawing.Size(146, 129);
            this.MFView.TabIndex = 8;
            this.MFView.UseCompatibleStateImageBehavior = false;
            this.MFView.SelectedIndexChanged += new System.EventHandler(this.MFView_SelectedIndexChanged);
            // 
            // RemMFBtn
            // 
            this.RemMFBtn.Location = new System.Drawing.Point(510, 341);
            this.RemMFBtn.Name = "RemMFBtn";
            this.RemMFBtn.Size = new System.Drawing.Size(89, 23);
            this.RemMFBtn.TabIndex = 12;
            this.RemMFBtn.Text = "Remove MF";
            this.RemMFBtn.UseVisualStyleBackColor = true;
            this.RemMFBtn.Click += new System.EventHandler(this.RemMFBtn_Click);
            // 
            // Variable
            // 
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.RemMFBtn);
            this.Controls.Add(this.MfBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MFView);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartPanel);
            this.Controls.Add(this.RangeTxT);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.VarTxT);
            this.Controls.Add(this.VarName);
            this.Name = "Variable";
            this.Size = new System.Drawing.Size(734, 456);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label VarName;
        private System.Windows.Forms.TextBox VarTxT;
        private System.Windows.Forms.Label Range;
        private System.Windows.Forms.TextBox RangeTxT;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MfBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MFTypeCombo;
        private System.Windows.Forms.TextBox MFParamTxT;
        private System.Windows.Forms.TextBox MFNameTxT;
        private System.Windows.Forms.ListView MFView;
        private System.Windows.Forms.Button SaveMFBtn;
        private System.Windows.Forms.Button RemMFBtn;
    }
}
