using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FuzzyLogicController.RuleEngine;
using FuzzyLogicController.FLC;

namespace FuzzyLogicUI.Controls
{
    public partial class ConfigurationUI : UserControl
    {
        public ConfigurationUI()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            if (FuzzyApp.Configuration.Implication == ImpMethod.Min)
            {
                ImplCombo.SelectedIndex = 0;
            }
            else
            {
                ImplCombo.SelectedIndex = 1;
            }

            if (FuzzyApp.Configuration.Logic == ConnMethod.Min)
            {
                AndCombo.SelectedIndex = 0;
            }
            else
            {
                AndCombo.SelectedIndex = 1;
            }

            if (FuzzyApp.Configuration.DefuzzificationType == DefuzzifcationType.ModifiedHeight)
            {
                DefuzCombo.SelectedIndex = 0;
            }
            else
            {
                DefuzCombo.SelectedIndex = 1;
            }
            
        }

        private void AndCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AndCombo.SelectedIndex == 0)
            {
                FuzzyApp.Configuration.Logic = ConnMethod.Min;
            }
            else
            {
                FuzzyApp.Configuration.Logic = ConnMethod.Prod;
            }
        }

        private void ImplCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImplCombo.SelectedIndex == 0)
            {
                FuzzyApp.Configuration.Implication = ImpMethod.Min;
            }
            else
            {
                FuzzyApp.Configuration.Implication = ImpMethod.Prod;
            }
        }

        private void DefuzCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DefuzCombo.SelectedIndex == 0)
            {
                FuzzyApp.Configuration.DefuzzificationType = DefuzzifcationType.ModifiedHeight;
            }
            else
            {
                FuzzyApp.Configuration.DefuzzificationType = DefuzzifcationType.Centroid;
            }
        }
    }
}
