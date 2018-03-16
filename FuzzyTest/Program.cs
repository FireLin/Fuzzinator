using System;
using System.Collections.Generic;
using System.Text;
using FuzzyLogicController.FLC;
using FuzzyLogicController.MFs;
using FuzzyLogicController.RuleEngine;
using FuzzyLogicController;

namespace FuzzyTest
{
    class Program
    {

        static void Main(string[] args)
        {
            test2(12,35);
            //test1(4.37,29.8);
            //test1(12.1, 21.5);
        }

        private static void test2(double in1, double in2)
        {
            Config conf = new Config(ImpMethod.Prod,
                                                       ConnMethod.Min
                                                       );

            LingVariable X1 = new LingVariable("X1", VarType.Input);
            X1.setRange(0, 35);
            X1.addMF(new Trapmf("Low", -10, 0, 10, 15));
            X1.addMF(new Trapmf("Medium", 10, 15, 25, 30));
            X1.addMF(new Trapmf("High", 25, 30, 35, 40));

            LingVariable X2 = new LingVariable("X2", VarType.Input);
            X2.setRange(0, 65);
            X2.addMF(new Trapmf("Low", -10, 0, 20, 41));
            X2.addMF(new Trimf("Medium", 20, 41, 60));
            X2.addMF(new Trapmf("High", 41, 60, 65, 70));

            LingVariable Y1 = new LingVariable("Y1", VarType.Output);
            Y1.setRange(0, 100);
            Y1.addMF(new Trapmf("Low", 10, 20, 30, 40));
            Y1.addMF(new Trapmf("Medium", 40, 50, 60, 70));
            Y1.addMF(new Trapmf("High", 70, 80, 90, 100));

            FLC c = new FLC(conf);
            double front = in1;
            double back = in2;
            FuzzySet set1 = new FuzzySet(c.Fuzzification(front,X1), X1.Name);
            FuzzySet set2 = new FuzzySet(c.Fuzzification(back, X2), X2.Name);

            Console.WriteLine("1. Crisp Input\n");
            Console.WriteLine("Front Side Sensor: " + front.ToString());
            Console.WriteLine("Back Side Sensor: " + back.ToString());


            List<FuzzySet> fuzset = new List<FuzzySet>();
            fuzset.Add(set1);
            fuzset.Add(set2);

            Console.WriteLine("\n2. Fuzzfication of inputs\n");
            for (int i = 0; i < fuzset.Count; i++)
            {
                Console.WriteLine(fuzset[i].Variable);

                for (int j = 0; j < fuzset[i].Set.Count; j++)
                {
                    Console.WriteLine(fuzset[i].Set[j].ToString());
                }

                Console.WriteLine();
            }

            List<RuleItem> rule1in = new List<RuleItem>();
            List<RuleItem> rule1out = new List<RuleItem>();
            List<RuleItem> rule2in = new List<RuleItem>();
            List<RuleItem> rule2out = new List<RuleItem>();
            List<RuleItem> rule3in = new List<RuleItem>();
            List<RuleItem> rule3out = new List<RuleItem>();
            List<RuleItem> rule4in = new List<RuleItem>();
            List<RuleItem> rule4out = new List<RuleItem>();
            List<RuleItem> rule5in = new List<RuleItem>();
            List<RuleItem> rule5out = new List<RuleItem>();
            List<RuleItem> rule9in = new List<RuleItem>();
            List<RuleItem> rule9out = new List<RuleItem>();

            rule1in.AddRange(new RuleItem[2] { new RuleItem("X1", "Low"), new RuleItem("X2", "Low") });
            rule1out.AddRange(new RuleItem[1] { new RuleItem("Y1", "High")});

            rule2in.AddRange(new RuleItem[2] { new RuleItem("X1", "Low"), new RuleItem("X2", "Medium") });
            rule2out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Low") });

            rule3in.AddRange(new RuleItem[2] { new RuleItem("X1", "Low"), new RuleItem("X2", "High") });
            rule3out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Medium") });

            rule4in.AddRange(new RuleItem[2] { new RuleItem("X1", "Medium"), new RuleItem("X2", "Low") });
            rule4out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Medium") });

            rule5in.AddRange(new RuleItem[2] { new RuleItem("X1", "Medium"), new RuleItem("X2", "Medium") });
            rule5out.AddRange(new RuleItem[1] { new RuleItem("Y1", "High") });

            rule9in.AddRange(new RuleItem[2] { new RuleItem("X1", "High"), new RuleItem("X2", "High") });
            rule9out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Medium") });
          
            List<Rule> rules = new List<Rule>();
            rules.Add(new Rule(rule1in, rule1out, Connector.And));
            rules.Add(new Rule(rule2in, rule2out, Connector.And));
            rules.Add(new Rule(rule3in, rule3out, Connector.And));
            rules.Add(new Rule(rule4in, rule4out, Connector.And));
            rules.Add(new Rule(rule5in, rule5out, Connector.And));
            rules.Add(new Rule(rule9in, rule9out, Connector.And));

            InferEngine engine = new InferEngine(conf, rules, fuzset);

            List<FuzzySet> impli = engine.evaluateRules();

            Console.WriteLine("3. Fuzzy Output After Rules Evaluation \n");
            for (int i = 0; i < engine.FiredRules.Count; i++)
            {
                Console.WriteLine("Rule "+engine.FiredRules[i].ToString());
            }
            for (int i = 0; i < impli.Count; i++)
            {
                Console.WriteLine(impli[i].Variable);

                for (int j = 0; j < impli[i].Set.Count; j++)
                {
                    Console.WriteLine(impli[i].Set[j].ToString());
                }

                Console.WriteLine();
            }

            double crisp1 = c.DeFuzzification(impli, Y1);
            Console.WriteLine("4. Crisp Output\n");
            Console.WriteLine("Output Y1: " + crisp1.ToString());

            Console.ReadLine();

        }

        private static void test1(double in1, double in2)
        {
            //Controller Configuration
            Config conf = new Config(ImpMethod.Min,
                                                        ConnMethod.Min
                                                        );

            //Creating Lingustic Variables and Membership functions for inputs
            //inputs
            LingVariable FSS = new LingVariable("FSS", VarType.Input);
            FSS.setRange(0, 30);
            FSS.addMF(new Trapmf("Low", -9, -1, 2, 9));
            FSS.addMF(new Trapmf("Medium", 2, 8.333, 14.17, 21.5));
            FSS.addMF(new Trapmf("High", 14.17, 18.33, 26, 34));

            LingVariable BSS = new LingVariable("BSS", VarType.Input);
            BSS.setRange(0, 60);
            BSS.addMF(new Trapmf("Low", -15.5, -1.75, 1.54, 21.87));
            BSS.addMF(new Trimf("Medium", 1.54, 21.87, 41));
            BSS.addMF(new Trapmf("High", 21.78, 36.1, 44.7, 58.8));

            //output
            LingVariable Speed = new LingVariable("Speed", VarType.Output);
            Speed.setRange(10, 70);
            Speed.addMF(new Trimf("Low", 20, 30, 40));
            Speed.addMF(new Trimf("Medium", 40, 50, 55));
            Speed.addMF(new Trimf("High", 55, 60, 70));

            LingVariable Steer = new LingVariable("Steer", VarType.Output);
            Steer.setRange(-180, 180);
            Steer.addMF(new Trimf("Right", -180, -93, -40));
            Steer.addMF(new Trimf("Zero", -40, 0, 40));
            Steer.addMF(new Trimf("Left", 40, 90, 180));

            // Fuzzify Values and get FuzzySet contain MembershipValues and Fireing Strength for each Lingustic Variable

            FLC c = new FLC(conf);
            double front = in1;
            double back = in2;
            FuzzySet set1 = new FuzzySet(c.Fuzzification(front, FSS), FSS.Name);
            FuzzySet set2 = new FuzzySet(c.Fuzzification(back, BSS), BSS.Name);

            Console.WriteLine("1. Crisp Input\n");
            Console.WriteLine("Front Side Sensor: " + front.ToString());
            Console.WriteLine("Back Side Sensor: " + back.ToString());

            List<FuzzySet> fuzset = new List<FuzzySet>();
            fuzset.Add(set1);
            fuzset.Add(set2);

            Console.WriteLine("\n2. Fuzzfication of inputs\n");
            for (int i = 0; i < fuzset.Count; i++)
            {
                Console.WriteLine(fuzset[i].Variable);

                for (int j = 0; j < fuzset[i].Set.Count; j++)
                {
                    Console.WriteLine(fuzset[i].Set[j].ToString());
                }

                Console.WriteLine();
            }

            //Create Rules
            List<RuleItem> rule1in = new List<RuleItem>();
            List<RuleItem> rule1out = new List<RuleItem>();
            List<RuleItem> rule2in = new List<RuleItem>();
            List<RuleItem> rule2out = new List<RuleItem>();
            List<RuleItem> rule3in = new List<RuleItem>();
            List<RuleItem> rule3out = new List<RuleItem>();

            //rule 3 in out
            rule3in.AddRange(new RuleItem[2] { new RuleItem("FSS", "Low"), new RuleItem("BSS", "Low") });
            rule3out.AddRange(new RuleItem[2] { new RuleItem("Speed", "High"), new RuleItem("Steer", "Right") });

            //rule 2 in out
            rule2in.AddRange(new RuleItem[2] { new RuleItem("FSS", "Low"), new RuleItem("BSS", "High") });
            rule2out.AddRange(new RuleItem[2] { new RuleItem("Speed", "Medium"), new RuleItem("Steer", "Left") });

            //rule 1 in out
            rule1in.AddRange(new RuleItem[2] { new RuleItem("FSS", "Medium"), new RuleItem("BSS", "Medium") });
            rule1out.AddRange(new RuleItem[2] { new RuleItem("Speed", "Medium"), new RuleItem("Steer", "Zero") });

            List<Rule> rules = new List<Rule>();
            rules.Add(new Rule(rule1in, rule1out, Connector.And));
            rules.Add(new Rule(rule2in, rule2out, Connector.And));
            rules.Add(new Rule(rule3in, rule3out, Connector.And));

            //Using the inference Engine  ... Completed
            InferEngine engine = new InferEngine(conf, rules, fuzset);

            List<FuzzySet> impli = engine.evaluateRules();

            Console.WriteLine("3. Fuzzy Output After Rules Evaluation \n");
            for (int i = 0; i < engine.FiredRules.Count; i++)
            {
                Console.WriteLine("Rule " + engine.FiredRules[i].ToString());
            }
            for (int i = 0; i < impli.Count; i++)
            {
                Console.WriteLine(impli[i].Variable);

                for (int j = 0; j < impli[i].Set.Count; j++)
                {
                    Console.WriteLine(impli[i].Set[j].ToString());
                }

                Console.WriteLine();
            }

            double crisp1 = c.DeFuzzification(impli, Speed);
            double crisp2 = c.DeFuzzification(impli, Steer);
            Console.WriteLine("4. Crisp Output\n");
            Console.WriteLine("Output Speed: " + crisp1.ToString());
            Console.WriteLine("Output Steer: " + crisp2.ToString());

            Console.ReadLine();
        
        }

      
    }
}
