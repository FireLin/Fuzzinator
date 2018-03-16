namespace FuzzyLogicUI
{
    partial class Form1
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
            this.MainPanel = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.configurationUI1 = new FuzzyLogicUI.Controls.ConfigurationUI();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.InOutTabs = new System.Windows.Forms.TabControl();
            this.Input = new System.Windows.Forms.TabPage();
            this.InputView = new System.Windows.Forms.ListView();
            this.Output = new System.Windows.Forms.TabPage();
            this.OutputView = new System.Windows.Forms.ListView();
            this.AddVariable = new System.Windows.Forms.Button();
            this.variable1 = new FuzzyLogicUI.Controls.Variable();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rule1 = new FuzzyLogicUI.Controls.RuleUI();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reultsUI1 = new FuzzyLogicUI.Controls.ReultsUI();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.predefinedTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainPanel.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.InOutTabs.SuspendLayout();
            this.Input.SuspendLayout();
            this.Output.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tabPage5);
            this.MainPanel.Controls.Add(this.tabPage2);
            this.MainPanel.Controls.Add(this.tabPage3);
            this.MainPanel.Controls.Add(this.tabPage4);
            this.MainPanel.Location = new System.Drawing.Point(2, 37);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.SelectedIndex = 0;
            this.MainPanel.Size = new System.Drawing.Size(901, 536);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.SelectedIndexChanged += new System.EventHandler(this.MainPanel_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.configurationUI1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(893, 510);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Configuration";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // configurationUI1
            // 
            this.configurationUI1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.configurationUI1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.configurationUI1.Location = new System.Drawing.Point(0, 0);
            this.configurationUI1.Name = "configurationUI1";
            this.configurationUI1.Size = new System.Drawing.Size(893, 510);
            this.configurationUI1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.InOutTabs);
            this.tabPage2.Controls.Add(this.AddVariable);
            this.tabPage2.Controls.Add(this.variable1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Variables";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove\r\nVariable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InOutTabs
            // 
            this.InOutTabs.Controls.Add(this.Input);
            this.InOutTabs.Controls.Add(this.Output);
            this.InOutTabs.Location = new System.Drawing.Point(7, 96);
            this.InOutTabs.Name = "InOutTabs";
            this.InOutTabs.SelectedIndex = 0;
            this.InOutTabs.Size = new System.Drawing.Size(117, 384);
            this.InOutTabs.TabIndex = 3;
            // 
            // Input
            // 
            this.Input.Controls.Add(this.InputView);
            this.Input.Location = new System.Drawing.Point(4, 22);
            this.Input.Name = "Input";
            this.Input.Padding = new System.Windows.Forms.Padding(3);
            this.Input.Size = new System.Drawing.Size(109, 358);
            this.Input.TabIndex = 0;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = true;
            // 
            // InputView
            // 
            this.InputView.Location = new System.Drawing.Point(1, 0);
            this.InputView.Name = "InputView";
            this.InputView.Size = new System.Drawing.Size(106, 358);
            this.InputView.TabIndex = 1;
            this.InputView.UseCompatibleStateImageBehavior = false;
            this.InputView.SelectedIndexChanged += new System.EventHandler(this.InputView_SelectedIndexChanged);
            // 
            // Output
            // 
            this.Output.Controls.Add(this.OutputView);
            this.Output.Location = new System.Drawing.Point(4, 22);
            this.Output.Name = "Output";
            this.Output.Padding = new System.Windows.Forms.Padding(3);
            this.Output.Size = new System.Drawing.Size(109, 358);
            this.Output.TabIndex = 1;
            this.Output.Text = "Output";
            this.Output.UseVisualStyleBackColor = true;
            // 
            // OutputView
            // 
            this.OutputView.Location = new System.Drawing.Point(0, 0);
            this.OutputView.MultiSelect = false;
            this.OutputView.Name = "OutputView";
            this.OutputView.Size = new System.Drawing.Size(109, 358);
            this.OutputView.TabIndex = 0;
            this.OutputView.UseCompatibleStateImageBehavior = false;
            this.OutputView.SelectedIndexChanged += new System.EventHandler(this.OutputView_SelectedIndexChanged);
            // 
            // AddVariable
            // 
            this.AddVariable.Location = new System.Drawing.Point(6, 17);
            this.AddVariable.Name = "AddVariable";
            this.AddVariable.Size = new System.Drawing.Size(89, 23);
            this.AddVariable.TabIndex = 2;
            this.AddVariable.Text = "Add Variable";
            this.AddVariable.UseVisualStyleBackColor = true;
            this.AddVariable.Click += new System.EventHandler(this.AddVariable_Click);
            // 
            // variable1
            // 
            this.variable1.BackColor = System.Drawing.SystemColors.Menu;
            this.variable1.Current = null;
            this.variable1.Location = new System.Drawing.Point(130, 38);
            this.variable1.Name = "variable1";
            this.variable1.Size = new System.Drawing.Size(737, 456);
            this.variable1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rule1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(893, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rules";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rule1
            // 
            this.rule1.BackColor = System.Drawing.SystemColors.Menu;
            this.rule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rule1.Location = new System.Drawing.Point(6, 3);
            this.rule1.Name = "rule1";
            this.rule1.Size = new System.Drawing.Size(884, 504);
            this.rule1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reultsUI1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(893, 510);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Results";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reultsUI1
            // 
            this.reultsUI1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.reultsUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reultsUI1.Location = new System.Drawing.Point(0, 0);
            this.reultsUI1.Name = "reultsUI1";
            this.reultsUI1.Size = new System.Drawing.Size(893, 510);
            this.reultsUI1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.predefinedTestsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.closeToolStripMenuItem.Text = "New";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // predefinedTestsToolStripMenuItem
            // 
            this.predefinedTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem});
            this.predefinedTestsToolStripMenuItem.Name = "predefinedTestsToolStripMenuItem";
            this.predefinedTestsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.predefinedTestsToolStripMenuItem.Text = "Predefined Tests";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.test1ToolStripMenuItem.Text = "Test1";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.test2ToolStripMenuItem.Text = "Test2";
            this.test2ToolStripMenuItem.Click += new System.EventHandler(this.test2ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(905, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 601);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.InOutTabs.ResumeLayout(false);
            this.Input.ResumeLayout(false);
            this.Output.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainPanel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private FuzzyLogicUI.Controls.Variable variable1;
        private System.Windows.Forms.Button AddVariable;
        private System.Windows.Forms.TabControl InOutTabs;
        private System.Windows.Forms.TabPage Input;
        private System.Windows.Forms.TabPage Output;
        private System.Windows.Forms.ListView OutputView;
        private System.Windows.Forms.ListView InputView;
        private System.Windows.Forms.Button button1;
        private FuzzyLogicUI.Controls.RuleUI rule1;
        private FuzzyLogicUI.Controls.ReultsUI reultsUI1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem predefinedTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private FuzzyLogicUI.Controls.ConfigurationUI configurationUI1;
    }
}

