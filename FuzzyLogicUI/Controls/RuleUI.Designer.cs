namespace FuzzyLogicUI.Controls
{
    partial class RuleUI
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VarTree = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutRulePan = new System.Windows.Forms.FlowLayoutPanel();
            this.InRulePan = new System.Windows.Forms.FlowLayoutPanel();
            this.ClearRuleBtn = new System.Windows.Forms.Button();
            this.addRuleBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RulePan = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VarTree);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variables";
            // 
            // VarTree
            // 
            this.VarTree.HotTracking = true;
            this.VarTree.Location = new System.Drawing.Point(6, 20);
            this.VarTree.Name = "VarTree";
            this.VarTree.Size = new System.Drawing.Size(140, 229);
            this.VarTree.TabIndex = 0;
            this.VarTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.VarTree_NodeMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.OutRulePan);
            this.groupBox2.Controls.Add(this.InRulePan);
            this.groupBox2.Controls.Add(this.ClearRuleBtn);
            this.groupBox2.Controls.Add(this.addRuleBtn);
            this.groupBox2.Location = new System.Drawing.Point(183, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Rule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Then";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IF";
            // 
            // OutRulePan
            // 
            this.OutRulePan.AutoScroll = true;
            this.OutRulePan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutRulePan.Location = new System.Drawing.Point(7, 124);
            this.OutRulePan.Name = "OutRulePan";
            this.OutRulePan.Size = new System.Drawing.Size(668, 76);
            this.OutRulePan.TabIndex = 3;
            // 
            // InRulePan
            // 
            this.InRulePan.AutoScroll = true;
            this.InRulePan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InRulePan.Location = new System.Drawing.Point(7, 33);
            this.InRulePan.Name = "InRulePan";
            this.InRulePan.Size = new System.Drawing.Size(668, 72);
            this.InRulePan.TabIndex = 2;
            // 
            // ClearRuleBtn
            // 
            this.ClearRuleBtn.Location = new System.Drawing.Point(619, 206);
            this.ClearRuleBtn.Name = "ClearRuleBtn";
            this.ClearRuleBtn.Size = new System.Drawing.Size(56, 23);
            this.ClearRuleBtn.TabIndex = 1;
            this.ClearRuleBtn.Text = "Clear";
            this.ClearRuleBtn.UseVisualStyleBackColor = true;
            this.ClearRuleBtn.Click += new System.EventHandler(this.ClearRuleBtn_Click);
            // 
            // addRuleBtn
            // 
            this.addRuleBtn.Location = new System.Drawing.Point(538, 206);
            this.addRuleBtn.Name = "addRuleBtn";
            this.addRuleBtn.Size = new System.Drawing.Size(75, 23);
            this.addRuleBtn.TabIndex = 0;
            this.addRuleBtn.Text = "Add Rule";
            this.addRuleBtn.UseVisualStyleBackColor = true;
            this.addRuleBtn.Click += new System.EventHandler(this.addRuleBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RulePan);
            this.groupBox3.Location = new System.Drawing.Point(16, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(848, 218);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "System Rules";
            // 
            // RulePan
            // 
            this.RulePan.AutoScroll = true;
            this.RulePan.ColumnCount = 1;
            this.RulePan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RulePan.Location = new System.Drawing.Point(6, 19);
            this.RulePan.Name = "RulePan";
            this.RulePan.RowCount = 1;
            this.RulePan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RulePan.Size = new System.Drawing.Size(836, 193);
            this.RulePan.TabIndex = 0;
            // 
            // RuleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RuleUI";
            this.Size = new System.Drawing.Size(893, 510);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addRuleBtn;
        private System.Windows.Forms.Button ClearRuleBtn;
        private System.Windows.Forms.TreeView VarTree;
        private System.Windows.Forms.FlowLayoutPanel InRulePan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel OutRulePan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel RulePan;
    }
}
