using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FuzzyLogicController;
using FuzzyLogicController.RuleEngine;

namespace FuzzyLogicUI.Controls
{
    public partial class ReultsUI : UserControl
    {
        public ReultsUI()
        {
            InitializeComponent();
        }

        public void loadVariables()
        {
            if (FuzzyApp.InputVariables.Count > 0)
            {
                VarLabel.Text = FuzzyApp.InputVariables[0].Name;
                for (int i = 1; i < FuzzyApp.InputVariables.Count; i++)
                {
                    VarLabel.Text = VarLabel.Text + "," + FuzzyApp.InputVariables[i].Name;
                }
            }
        }

        private void clearAll()
        {
            CrispPan.Controls.Clear();
            FuzzPan.Controls.Clear();
            DeFuzzPan.Controls.Clear();
            EnginePan.Controls.Clear();
            CrispView.Clear();
        }

        private void InTxT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clearAll();
                List<double> inputs = FuzzyApp.tokString(InTxT.Text);
                CrispPan.RowCount = FuzzyApp.InputVariables.Count;

                for (int i = 0; i < FuzzyApp.InputVariables.Count; i++)
                {
                    CrispPan.Controls.Add(TextLabel(FuzzyApp.InputVariables[i].Name + " : " + inputs[i],TextType.Normal));
                }

                //Fuzzification
                List<FuzzySet> InSets = new List<FuzzySet>();
                for (int i = 0; i < FuzzyApp.InputVariables.Count; i++)
                {
                    InSets.Add(new FuzzySet(FuzzyApp.FuzzyControl.Fuzzification(inputs[i], FuzzyApp.InputVariables[i]), FuzzyApp.InputVariables[i].Name));
                }

                for (int i = 0; i < InSets.Count; i++)
                {
                    
                    FuzzPan.Controls.Add(TextLabel(InSets[i].Variable, TextType.Normal));

                    for (int j = 0; j < InSets[i].Set.Count; j++)
                    {
                        FuzzPan.Controls.Add(TextLabel(InSets[i].Set[j].MemberShipName + ":" + InSets[i].Set[j].FuzzyValue.ToString(), TextType.Normal));
                    }
                }

                //Inference Engine
                InferEngine engine = new InferEngine(FuzzyApp.Configuration, FuzzyApp.Rules, InSets);
                List<FuzzySet> RuleResults = engine.evaluateRules();

                EnginePan.Controls.Add(TextLabel("Triggered Rules", TextType.Header));

                for (int i = 0; i < engine.FiredRules.Count; i++)
                {
                    EnginePan.Controls.Add(TextLabel("Rule :"+engine.FiredRules[i].ToString(), TextType.Normal,FuzzyApp.Rules[engine.FiredRules[i]-1].ToString()));
                }

                for (int i = 0; i < RuleResults.Count; i++)
                {
                    DeFuzzPan.Controls.Add(TextLabel(RuleResults[i].Variable, TextType.Header));
                    for (int j = 0; j < RuleResults[i].Set.Count; j++)
                    {
                        DeFuzzPan.Controls.Add(TextLabel(RuleResults[i].Set[j].MemberShipName + " : " + RuleResults[i].Set[j].FuzzyValue.ToString(), TextType.Normal));
                    }
                }

                //deFuzzification
                List<double> CrispValues = new List<double>();
                for (int i = 0; i < FuzzyApp.OutputVariables.Count; i++)
                {
                     CrispValues.Add(FuzzyApp.FuzzyControl.DeFuzzification(RuleResults, FuzzyApp.OutputVariables[i]));
                }

                for (int i = 0; i < CrispValues.Count; i++)
                {
                    String text = FuzzyApp.OutputVariables[i].Name + " : " + CrispValues[i].ToString();
                    CrispView.Items.Add(text);
                }

            }
        }

        private Label TextLabel(String Text,TextType type)
        {
            Label Temp = new Label();
            Temp.Dock = DockStyle.Fill;
            Temp.Text = Text;
            if (type == TextType.Header)
            {
                Temp.Font = new Font("san Serif", 12, FontStyle.Italic);
            }
            else if(type == TextType.Normal)
            {
                Temp.Font = new Font("san Serif", 10, FontStyle.Regular);
            }
            return Temp;
        }
        private Label TextLabel(String Text, TextType type,String ToolTip)
        {
            Label Temp = new Label();
            Temp.Dock = DockStyle.Fill;
            Temp.Text = Text;

            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.Active = true;
            tip.ToolTipIcon = ToolTipIcon.Info;
            tip.UseAnimation = true;
            tip.UseFading = true;
            tip.SetToolTip(Temp, ToolTip);

            if (type == TextType.Header)
            {
                Temp.Font = new Font("san Serif", 13, FontStyle.Italic);
            }
            else if (type == TextType.Normal)
            {
                Temp.Font = new Font("san Serif", 10, FontStyle.Regular);
            }
            return Temp;
        }

        private enum TextType
        {
            Header=0,Normal=1
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clearAll();
            InTxT.Text = "";
        }

    }
}
