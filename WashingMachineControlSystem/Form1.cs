using System.Data;

namespace WashingMachineControlSystem
{
    public partial class Form1 : Form
    {
        private Dictionary<(string, string, string), (string, string, string)>
            selectedRules = new Dictionary<(string, string, string), (string, string, string)>();
        private List<int> selectedRuleValues = new List<int>();
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < selectedRuleValues.Count; i++)
                {
                    dataGridView1.Rows[selectedRuleValues[i]].Selected = true;
                }
            }catch
            {

            }

        }

        private void AddRules(FuzzyLogic fuzzyLogic)
        {
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].Name = "Sensitivity";
            dataGridView1.Columns[1].Name = "Amount";
            dataGridView1.Columns[2].Name = "Dirtiness";
            dataGridView1.Columns[3].Name = "Rspeed";
            dataGridView1.Columns[4].Name = "Duration";
            dataGridView1.Columns[5].Name = "Detergent";


            foreach (var rule in fuzzyLogic.rules)
            {
                dataGridView1.Rows.Add(rule.Key.Item1, rule.Key.Item2, rule.Key.Item3, rule.Value.Item1, rule.Value.Item2, rule.Value.Item3);
            }


        }

        private void SelectRules(FuzzyLogic fuzzyLogic)
        {
            foreach (var rule in fuzzyLogic.selectedRules!)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    if (rule.Key.Item1 == dataGridView1.Rows[i].Cells[0].Value.ToString() &&
                        rule.Key.Item2 == dataGridView1.Rows[i].Cells[1].Value.ToString() &&
                        rule.Key.Item3 == dataGridView1.Rows[i].Cells[2].Value.ToString() &&
                        rule.Value.Item1 == dataGridView1.Rows[i].Cells[3].Value.ToString() &&
                        rule.Value.Item2 == dataGridView1.Rows[i].Cells[4].Value.ToString() &&
                        rule.Value.Item3 == dataGridView1.Rows[i].Cells[5].Value.ToString())
                    {
                        dataGridView1.Rows[i].Selected = true;
                        selectedRuleValues.Add(i);
                    }
                }
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            detergentMamdanis.Items.Clear();
            durationMamdanis.Items.Clear();
            rotationMamdanis.Items.Clear();
            selectedRuleValues.Clear();
            selectedRules.Clear();
   
            try
            {
                FuzzyLogic fuzzyLogic = new FuzzyLogic(
                dirtiness: Convert.ToDouble(dirtiness.Text), sensitivity: Convert.ToDouble(sensitivity.Text),
                belongingsAmount: Convert.ToDouble(belongingsAmount.Text));

                fuzzyLogic.ApplyAllProcesses();

                selectedRules = fuzzyLogic.selectedRules!;

                AddRules(fuzzyLogic);
                SelectRules(fuzzyLogic);

                foreach (var mamdani in fuzzyLogic.allMamdaniValues!)
                {
                    if (mamdani.Key == Outputs.rotationSpeedEn)
                    {
                        foreach (var kvp in mamdani.Value)
                        {
                            rotationMamdanis.Items.Add(kvp.Value);
                        }
                    }

                    if (mamdani.Key == Outputs.durationEn)
                    {
                        foreach (var kvp in mamdani.Value)
                        {
                            durationMamdanis.Items.Add(kvp.Value);
                        }
                    }

                    if (mamdani.Key == Outputs.detergentEn)
                    {
                        foreach (var kvp in mamdani.Value)
                        {
                            detergentMamdanis.Items.Add(kvp.Value);
                        }
                    }
                }

                foreach (var weightedAvarage in fuzzyLogic.allWeightedAvarages!)
                {
                    if (weightedAvarage.Key == Outputs.rotationSpeedEn)
                    {
                        rotationSpeedWAvarage.Text = weightedAvarage.Value.ToString();
                    }

                    if (weightedAvarage.Key == Outputs.durationEn)
                    {
                        durationWAvarage.Text = weightedAvarage.Value.ToString();
                    }

                    if (weightedAvarage.Key == Outputs.detergentEn)
                    {
                        detergentWAvarage.Text = weightedAvarage.Value.ToString();
                    }
                }

                foreach (var memberShip in fuzzyLogic.sensitivityMemberShip!)
                {
                    if(memberShip.Key == "robust")
                    {
                        s_robustText.Text = memberShip.Value.ToString();
                    }

                    if(memberShip.Key == "medium")
                    {
                        s_mediumText.Text = memberShip.Value.ToString();
                    }

                    if(memberShip.Key == "sensitive")
                    {
                        s_sensitiveText.Text = memberShip.Value.ToString();
                    }
                    
                }

                foreach (var memberShip in fuzzyLogic.belongingsAmountMemberShip!)
                {
                    if (memberShip.Key == "small")
                    {
                        a_smallText.Text = memberShip.Value.ToString();
                    }

                    if (memberShip.Key == "medium")
                    {
                        a_mediumText.Text = memberShip.Value.ToString();
                    }

                    if (memberShip.Key == "large")
                    {
                        a_largeText.Text = memberShip.Value.ToString();
                    }

                }

                foreach (var memberShip in fuzzyLogic.dirtinessMemberShip!)
                {
                    if (memberShip.Key == "low")
                    {
                        d_lowText.Text = memberShip.Value.ToString();
                    }

                    if (memberShip.Key == "medium")
                    {
                        d_mediumText.Text = memberShip.Value.ToString();
                    }

                    if (memberShip.Key == "high")
                    {
                        d_highText.Text = memberShip.Value.ToString();
                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
