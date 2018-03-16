namespace FuzzyLogicUI.Controls
{
    partial class ReultsUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.VarLabel = new System.Windows.Forms.Label();
            this.InTxT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CrispPan = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.DeFuzzPan = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.EnginePan = new System.Windows.Forms.TableLayoutPanel();
            this.FuzzPan = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CrispView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inputs:";
            // 
            // VarLabel
            // 
            this.VarLabel.AutoSize = true;
            this.VarLabel.Location = new System.Drawing.Point(74, 10);
            this.VarLabel.Name = "VarLabel";
            this.VarLabel.Size = new System.Drawing.Size(35, 13);
            this.VarLabel.TabIndex = 1;
            this.VarLabel.Text = "label2";
            // 
            // InTxT
            // 
            this.InTxT.Location = new System.Drawing.Point(77, 26);
            this.InTxT.Name = "InTxT";
            this.InTxT.Size = new System.Drawing.Size(530, 20);
            this.InTxT.TabIndex = 2;
            this.InTxT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InTxT_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CrispPan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DeFuzzPan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EnginePan);
            this.groupBox1.Controls.Add(this.FuzzPan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 350);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // CrispPan
            // 
            this.CrispPan.AutoScroll = true;
            this.CrispPan.ColumnCount = 1;
            this.CrispPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CrispPan.Location = new System.Drawing.Point(10, 43);
            this.CrispPan.Name = "CrispPan";
            this.CrispPan.RowCount = 1;
            this.CrispPan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CrispPan.Size = new System.Drawing.Size(131, 294);
            this.CrispPan.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fuzzy Output";
            // 
            // DeFuzzPan
            // 
            this.DeFuzzPan.AutoScroll = true;
            this.DeFuzzPan.ColumnCount = 1;
            this.DeFuzzPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DeFuzzPan.Location = new System.Drawing.Point(593, 43);
            this.DeFuzzPan.Name = "DeFuzzPan";
            this.DeFuzzPan.RowCount = 1;
            this.DeFuzzPan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DeFuzzPan.Size = new System.Drawing.Size(238, 294);
            this.DeFuzzPan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Inference Engine";
            // 
            // EnginePan
            // 
            this.EnginePan.AutoScroll = true;
            this.EnginePan.ColumnCount = 1;
            this.EnginePan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.EnginePan.Location = new System.Drawing.Point(424, 43);
            this.EnginePan.Name = "EnginePan";
            this.EnginePan.RowCount = 1;
            this.EnginePan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EnginePan.Size = new System.Drawing.Size(136, 294);
            this.EnginePan.TabIndex = 4;
            // 
            // FuzzPan
            // 
            this.FuzzPan.AutoScroll = true;
            this.FuzzPan.ColumnCount = 1;
            this.FuzzPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FuzzPan.Location = new System.Drawing.Point(164, 43);
            this.FuzzPan.Name = "FuzzPan";
            this.FuzzPan.RowCount = 1;
            this.FuzzPan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FuzzPan.Size = new System.Drawing.Size(235, 294);
            this.FuzzPan.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fuzzification ( Fuzzy Inputs)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Crisp Inputs";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(806, 24);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Crisp Output";
            // 
            // CrispView
            // 
            this.CrispView.Location = new System.Drawing.Point(77, 61);
            this.CrispView.MultiSelect = false;
            this.CrispView.Name = "CrispView";
            this.CrispView.Size = new System.Drawing.Size(725, 52);
            this.CrispView.TabIndex = 9;
            this.CrispView.UseCompatibleStateImageBehavior = false;
            this.CrispView.View = System.Windows.Forms.View.Tile;
            // 
            // ReultsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.CrispView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InTxT);
            this.Controls.Add(this.VarLabel);
            this.Controls.Add(this.label1);
            this.Name = "ReultsUI";
            this.Size = new System.Drawing.Size(893, 510);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VarLabel;
        private System.Windows.Forms.TextBox InTxT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel FuzzPan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel EnginePan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel DeFuzzPan;
        private System.Windows.Forms.TableLayoutPanel CrispPan;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView CrispView;

    }
}
