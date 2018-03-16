using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FuzzyLogicUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (FuzzyApp.InputVariables.Count > 0)
            {
                variable1.Current = FuzzyApp.InputVariables[0];
                variable1.Populate();
                populateVariables();
            }
            reloadStrip();
            configurationUI1.loadData();
        }

        private void reloadStrip()
        {
            toolStripStatusLabel1.Text = "Inputs : " + FuzzyApp.InputVariables.Count.ToString();
            toolStripStatusLabel2.Text = "Outputs : " + FuzzyApp.OutputVariables.Count.ToString();
            toolStripStatusLabel3.Text = "Rules : " + FuzzyApp.Rules.Count.ToString();
        }

        private void populateVariables()
        {
            for (int i = 0; i < FuzzyApp.InputVariables.Count; i++)
            {
                if (InputView.Items.ContainsKey(FuzzyApp.InputVariables[i].Name) == false)
                {
                    InputView.Items.Add(FuzzyApp.InputVariables[i].Name, FuzzyApp.InputVariables[i].Name, 1);
                }
            }

            for (int i = 0; i < FuzzyApp.OutputVariables.Count; i++)
            {
                if (OutputView.Items.ContainsKey(FuzzyApp.OutputVariables[i].Name) == false)
                {
                    OutputView.Items.Add(FuzzyApp.OutputVariables[i].Name, FuzzyApp.OutputVariables[i].Name, 1);
                }
            }
        }

        private void AddVariable_Click(object sender, EventArgs e)
        {
            NewVariable var = new NewVariable();
            var.ParentTab = InOutTabs;
            var.ShowDialog();
            populateVariables();
        }

        private void InputView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputView.SelectedIndices.Count > 0)
            {
                int index = InputView.SelectedIndices[0];
                variable1.ClearVariable();
                variable1.Current = FuzzyApp.InputVariables[index];
                variable1.Populate();
            }
        }

        private void OutputView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OutputView.SelectedIndices.Count > 0)
            {
                int index = OutputView.SelectedIndices[0];
                variable1.ClearVariable();
                variable1.Current = FuzzyApp.OutputVariables[index];
                variable1.Populate();
            }
        }

        private void MainPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainPanel.SelectedTab.Text.Equals("Rules"))
            {
                rule1.loadVariables();
                rule1.loadRules();
            }
            else if (MainPanel.SelectedTab.Text.Equals("Results"))
            {
                reultsUI1.loadVariables();
            }
            
                reloadStrip();
            
        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuzzyApp.Initalize();
            variable1.ClearVariable();
            InputView.Clear();
            OutputView.Clear();
            FuzzyApp.defaultSettings1();
            if (FuzzyApp.InputVariables.Count > 0)
            {
                variable1.Current = FuzzyApp.InputVariables[0];
                variable1.Populate();
                populateVariables();
            }
        }

        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuzzyApp.Initalize();
            variable1.ClearVariable();
            InputView.Clear();
            OutputView.Clear();
            FuzzyApp.defaultSettings2();
            if (FuzzyApp.InputVariables.Count > 0)
            {
                variable1.Current = FuzzyApp.InputVariables[0];
                variable1.Populate();
                populateVariables();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuzzyApp.Initalize();
            variable1.ClearVariable();
            InputView.Clear();
            OutputView.Clear();
            reultsUI1.loadVariables();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InOutTabs.SelectedTab.Text == "Input")
            {
                FuzzyApp.InputVariables.RemoveAt(InputView.SelectedIndices[0]);
                InputView.Items.RemoveAt(InputView.SelectedIndices[0]);
            }
            else
            {
                FuzzyApp.OutputVariables.RemoveAt(InputView.SelectedIndices[0]);
                OutputView.Items.RemoveAt(InputView.SelectedIndices[0]);
            }
        }


    }
}