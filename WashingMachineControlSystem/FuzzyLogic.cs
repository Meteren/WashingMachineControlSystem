using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineControlSystem
{
    enum Inputs
    {
        dirtinessEn,
        sensitivityEn,
        belongingsEn,
        none
    }

    enum Outputs
    {
        detergentEn,
        durationEn,
        rotationSpeedEn,
        none
    }

    class FuzzyLogic
    {
        private double dirtiness, sensitivity, belongingsAmount;
        public Dictionary<string, double>? dirtinessMemberShip, sensitivityMemberShip, belongingsAmountMemberShip;
        public Dictionary<(string, string, string), (string, string, string)>? selectedRules;
        public Dictionary<Outputs, Dictionary<string, double>>? allMamdaniValues;
        public Dictionary<Outputs, double>? allWeightedAvarages;
        public FuzzyLogic(double dirtiness,double sensitivity,double belongingsAmount)
        {
            this.dirtiness = dirtiness;
            this.sensitivity = sensitivity;
            this.belongingsAmount = belongingsAmount;
        }

        public Dictionary<(string, string, string), (string, string, string)> rules = new Dictionary<(string, string, string), (string, string, string)>()
        {
            {("sensitive", "small", "low"), ("sensitive", "short", "very_little")},
            {("sensitive", "small", "medium"), ("normal_sensitive", "short", "little")},
            { ("sensitive", "small", "high"), ("normal", "normal_short", "normal")},
            { ("sensitive", "medium", "low"), ("sensitive", "short", "normal")},
            { ("sensitive", "medium", "medium"), ("normal_sensitive", "normal_short", "normal")},
            { ("sensitive", "medium", "high"), ("normal", "normal", "much")},
            { ("sensitive", "large", "low"), ("normal_sensitive", "normal_short", "normal")},
            { ("sensitive", "large", "medium"), ("normal_sensitive", "normal", "much")},
            { ("sensitive", "large", "high"), ("normal", "normal_long", "much")},
            { ("medium", "small", "low"), ("normal_sensitive", "normal_short", "little")},
            { ("medium", "small", "medium"), ("normal", "short", "normal")},
            { ("medium", "small", "high"), ("normal_strong", "normal", "much")},
            { ("medium", "medium", "low"), ("normal_sensitive", "normal_short", "normal")},
            { ("medium", "medium", "medium"), ("normal", "normal", "normal")},
            { ("medium", "medium", "high"), ("sensitive", "long", "much")},
            { ("medium", "large", "low"), ("sensitive", "normal", "normal")},
            { ("medium", "large", "medium"), ("sensitive", "normal_long", "much")},
            { ("medium", "large", "high"), ("normal", "long", "very_much")},
            { ("robust", "small", "low"), ("normal", "normal", "little")},
            { ("robust", "small", "medium"), ("normal_strong", "normal", "normal")},
            { ("robust", "small", "high"), ("strong", "normal_long", "much")},
            { ("robust", "medium", "low"), ("normal", "normal", "normal")},
            { ("robust", "medium", "medium"), ("normal_strong", "normal_long", "normal")},
            { ("robust", "medium", "high"), ("strong", "long", "much")},
            { ("robust", "large", "low"), ("normal_strong", "normal_long", "much")},
            { ("robust", "large", "medium"), ("normal_strong", "long", "much")},
            { ("robust", "large", "high"), ("strong", "long", "very_much")}
        };

        public void ApplyAllProcesses()
        {

            //apply membership functions
            dirtinessMemberShip = ApplyMemberShipFunction(dirtiness,Inputs.dirtinessEn);
            sensitivityMemberShip = ApplyMemberShipFunction(sensitivity,Inputs.sensitivityEn);
            belongingsAmountMemberShip = ApplyMemberShipFunction(belongingsAmount, Inputs.belongingsEn);



            //find selected rules
            selectedRules = FindSelectedRules(dirtinessMemberShip,sensitivityMemberShip,belongingsAmountMemberShip);


            //apply mamdani process
            allMamdaniValues = CalculateMamdaniValues(selectedRules,dirtinessMemberShip,sensitivityMemberShip,belongingsAmountMemberShip);


            //calculate weighted avarage
            allWeightedAvarages = CalculateWeightedAvarages(allMamdaniValues);


        }

        private Dictionary<string,double> ApplyMemberShipFunction(double value,Inputs input)
        {
            Dictionary<string, double> memberShipValues = new Dictionary<string, double>();

            if(input == Inputs.dirtinessEn)
            {
                foreach (var kvp in memberShipFunctions[Inputs.dirtinessEn])
                {
                    if (kvp.Key == "low")
                    {
                        memberShipValues.Add(kvp.Key, (double)kvp.Value.DynamicInvoke(value, -4.5, -2.5, 2, 4.5)!);
                        
                    }
                    if (kvp.Key == "medium")
                    {
                        memberShipValues.Add(kvp.Key, (double)kvp.Value.DynamicInvoke(value, 3, 5, 7)!);
                    }
                    if (kvp.Key == "high")
                    {
                        memberShipValues.Add(kvp.Key, (double)kvp.Value.DynamicInvoke(value, 5.5, 8, 12.5, 15)!);
                    }

                }

            }

            if (input == Inputs.sensitivityEn)
            {
                foreach (var kvp in memberShipFunctions[Inputs.sensitivityEn])
                {
                    if (kvp.Key == "robust")
                    {
                        memberShipValues.Add(kvp.Key, (double)kvp.Value.DynamicInvoke(value, -4, -1.5, 2, 4)!);
                    }
                    if (kvp.Key == "medium")
                    {
                        memberShipValues.Add(kvp.Key, (double)kvp.Value.DynamicInvoke(value, 3, 5, 7)!);
                    }
                    if (kvp.Key == "sensitive")
                    {
                        memberShipValues.Add(kvp.Key, (double)kvp.Value.DynamicInvoke(value, 5.5, 8, 12.5, 14)!);
                    }

                }
            }

                
            if(input == Inputs.belongingsEn)
            {
                foreach (var kvp in memberShipFunctions[Inputs.belongingsEn])
                {
                    if (kvp.Key == "small")
                    {
                        memberShipValues.Add(kvp.Key, (double)kvp.Value.DynamicInvoke(value, -4, -1.5, 2, 4)!);
                    }
                    if (kvp.Key == "medium")
                    {
                        memberShipValues.Add(kvp.Key, (double)kvp.Value.DynamicInvoke(value, 3, 5, 7)!);
                    }
                    if (kvp.Key == "large")
                    {
                        memberShipValues.Add(kvp.Key, (double)kvp.Value.DynamicInvoke(value, 5.5, 8, 12.5, 14)!);
                    }

                }

            }

            return memberShipValues;
        }

        private static Dictionary<Inputs, Dictionary<string, Delegate>> memberShipFunctions = new Dictionary<Inputs, Dictionary<string, Delegate>>()
        {
            {Inputs.dirtinessEn, new Dictionary<string, Delegate>()
            {
              { "low", new Func<double,double,double,double,double,double>(Trapezoid!)},
              { "medium", new Func<double,double,double,double,double>(Triangle!)},
              { "high", new Func<double,double,double,double,double,double>(Trapezoid)},
            }
            },

            {Inputs.sensitivityEn, new Dictionary<string, Delegate>()
            {
              { "robust", new Func<double,double,double,double,double,double>(Trapezoid)},
              { "medium", new Func<double,double,double,double,double>(Triangle)},
              { "sensitive", new Func<double,double,double,double,double,double>(Trapezoid)},
            } 
            },

            {Inputs.belongingsEn, new Dictionary<string, Delegate>()
            {
              { "small", new Func<double,double,double,double,double,double>(Trapezoid)},
              { "medium", new Func<double,double,double,double,double>(Triangle)},
              { "large", new Func<double,double,double,double,double,double>(Trapezoid)},
            }

            }

        };

        private static double Trapezoid(double input,double min, double value1,double value2, double max)
        {
            if (input > min && input < value1)
            {
                return (input - min) / (value1 - min);
            }
            else if (input > value1 && input < value2)
            {
                return 1;
            }
            else if (input > value2 && input < max)
            {
                return (1 - ((input - value2) / (max - value2)));
            }
            else
            {
                return 0;
            }
        }

        private static double Triangle(double input, double min,double value1,double max)
        {
            if (input > min && input < value1)
            {
                return (input - min) / (value1-min);
            }
            else if (input == value1)
            {
                return 1;
            }
            else if (input > value1 && input < max)
            {
                return (1 - ((input - value1) / (max - value1)));
            }
            else
            {
                return 0;
            }
        }

        private Dictionary<(string,string,string),(string,string,string)> FindSelectedRules(
            Dictionary<string, double> dirtinessMembership, Dictionary<string, double> sensitivityMemberShip, Dictionary<string, double> belongingsAmountMemberShip)
        {
            Dictionary<(string, string, string), (string, string, string)> selectedRules = 
                new Dictionary<(string, string, string), (string, string, string)>();

            foreach(var rule in rules)
            {
                double value = 
                    Math.Min(sensitivityMemberShip[rule.Key.Item1], Math.Min(belongingsAmountMemberShip[rule.Key.Item2],dirtinessMembership[rule.Key.Item3]));
                
                if (value != 0)
                {
                    selectedRules.Add(rule.Key, rule.Value);
                }
            }
            return selectedRules;
        }

        private Dictionary<Outputs, Dictionary<string, double>> CalculateMamdaniValues(
            Dictionary<(string, string, string), (string, string, string)> selectedRules,
            Dictionary<string, double> dirtinessMembership, Dictionary<string, double> sensitivityMemberShip,
            Dictionary<string, double> belongingsAmountMemberShip)
        {

            Dictionary<Outputs, Dictionary<string, double>> allMamdaniValues = new Dictionary<Outputs, Dictionary<string, double>>
            {
                { Outputs.rotationSpeedEn, new Dictionary<string, double>() }
            };

            foreach (var member in rotationSpeedMembers)
            {
                double mamdaniValue = 0;
                bool isRuleApplied = false;
                foreach (var rule in selectedRules)
                {
                    if (member.Key == rule.Value.Item1)
                    {
                        isRuleApplied = true;
                        double value =
                    Math.Min(sensitivityMemberShip[rule.Key.Item1], Math.Min(belongingsAmountMemberShip[rule.Key.Item2], dirtinessMembership[rule.Key.Item3]));
                        mamdaniValue = Math.Max(value, mamdaniValue);
                       

                    }

                }

                if (isRuleApplied)
                {
                    
                    allMamdaniValues[Outputs.rotationSpeedEn].Add(member.Key, mamdaniValue);
                    isRuleApplied = false;
                }

            }
           
            allMamdaniValues.Add(Outputs.durationEn, new Dictionary<string, double>());

            foreach (var member in durationMembers)
            {
                double mamdaniValue = 0;
                bool isRuleApplied = false;
                foreach (var rule in selectedRules)
                {
                    if (member.Key == rule.Value.Item2)
                    {
                        isRuleApplied = true;
                        double value =
                    Math.Min(sensitivityMemberShip[rule.Key.Item1], Math.Min(belongingsAmountMemberShip[rule.Key.Item2], dirtinessMembership[rule.Key.Item3]));
                        mamdaniValue = Math.Max(value, mamdaniValue);
                    }

                }
                if (isRuleApplied)
                {
                    allMamdaniValues[Outputs.durationEn].Add(member.Key, mamdaniValue);
                    isRuleApplied = false;
                }
               

            }

            allMamdaniValues.Add(Outputs.detergentEn, new Dictionary<string, double>());

            foreach (var member in detergentMembers)
            {
                double mamdaniValue = 0;
                bool isRuleApplied = false;
                foreach (var rule in selectedRules)
                {
                    if (member.Key == rule.Value.Item3)
                    {
                        isRuleApplied = true;
                        double value =
                    Math.Min(sensitivityMemberShip[rule.Key.Item1], Math.Min(belongingsAmountMemberShip[rule.Key.Item2], dirtinessMembership[rule.Key.Item3]));
                        mamdaniValue = Math.Max(value, mamdaniValue);

                    }

                }

                if (isRuleApplied)
                {
                    allMamdaniValues[Outputs.detergentEn].Add(member.Key, mamdaniValue);
                    isRuleApplied = false;
                }
                

            }

            return allMamdaniValues;
        }

        private Dictionary<Outputs, double> CalculateWeightedAvarages(Dictionary<Outputs, Dictionary<string, double>> allMamdaniValues)
        {
            Dictionary<Outputs, double> allWeightedAvarages = new Dictionary<Outputs, double>();
            double sumOfMamdanis = 0.0;
            double avarage = 0.0;

            foreach (var kvp in allMamdaniValues[Outputs.detergentEn])
            {
                if (kvp.Key == "very_little")
                {
                    avarage += detergentMembers[kvp.Key][2] * kvp.Value;
                }else if(kvp.Key == "very much")
                {
                    avarage += detergentMembers[kvp.Key][1] * kvp.Value;
                }
                else
                {
                    avarage += detergentMembers[kvp.Key][1] * kvp.Value;
                }

                sumOfMamdanis += kvp.Value;
            }


            allWeightedAvarages.Add(Outputs.detergentEn, avarage / sumOfMamdanis);

            sumOfMamdanis = 0.0;
            avarage = 0.0;

            foreach (var kvp in allMamdaniValues[Outputs.durationEn])
            {
                if (kvp.Key == "short")
                {
                    avarage += durationMembers[kvp.Key][2] * kvp.Value;
                }else if(kvp.Key == "long")
                {
                    avarage += durationMembers[kvp.Key][1] * kvp.Value;
                }
                else
                {
                    avarage += durationMembers[kvp.Key][1] * kvp.Value;
                }

                sumOfMamdanis += kvp.Value;
            }


            allWeightedAvarages.Add(Outputs.durationEn, (avarage / sumOfMamdanis));

            sumOfMamdanis = 0.0;
            avarage = 0.0;

            foreach (var kvp in allMamdaniValues[Outputs.rotationSpeedEn])
            {
                if (kvp.Key == "sensitive")
                {
                    avarage += rotationSpeedMembers[kvp.Key][2] * kvp.Value;
                }else if(kvp.Key == "strong")
                {
                    avarage += rotationSpeedMembers[kvp.Key][1] * kvp.Value;
                }
                else
                {
                    avarage += rotationSpeedMembers[kvp.Key][1] * kvp.Value;
                }

                sumOfMamdanis += kvp.Value;
            }


            allWeightedAvarages.Add(Outputs.rotationSpeedEn, avarage / sumOfMamdanis);

            return allWeightedAvarages;
        }

        private Dictionary<string,List<double>> detergentMembers = new Dictionary<string, List<double>>()
        {
            {"very_little", new List<double>(){0, 0, 20, 85}},
            {"little", new List<double>(){20, 85, 150}},
            {"normal", new List<double>(){85, 150, 215} },
            {"much" ,new List<double>(){150, 215, 280 } },
            {"very_much",new List<double>(){215, 280, 300, 300}}
        };

        private Dictionary<string,List<double> > durationMembers = new Dictionary<string, List<double>>()
        {
            {"short", new List<double>(){-46.5, -25.28, 22.3, 39.9}},
            {"normal_short", new List<double>(){22.3, 39.9, 57.5 }},
            {"normal", new List<double>(){ 39.9, 57.5, 75.1 } },
            {"normal_long",new List<double>(){ 57.5, 75.1, 92.7 } },
            {"long",new List<double>(){ 75, 92.7, 111.6, 130 } }
        };

        private Dictionary<string, List<double>> rotationSpeedMembers = new Dictionary<string, List<double>>()
        {
            {"sensitive",new List<double>(){-5.8, -2.8, 0.514, 1.5 }},
            {"normal_sensitive", new List<double>(){ 0.514, 2.75, 5 } },
            {"normal", new List<double>(){2.75, 5, 7.25 } },
            {"normal_strong" ,new List<double>(){5, 7.25, 9.5}},
            {"strong",new List<double>(){8.5, 9.5, 12.8, 15.2 }}
        };


    }
}
