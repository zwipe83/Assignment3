namespace Assignment3
{
    public partial class MainForm : Form
    {
        #region Fields
        private readonly BMICalculator bmiCalculator = new();
        private readonly UserInput ui = new();
        private readonly SavingCalculator savingCalculator = new();
        private readonly BMRCalculator bmrCalculator = new();
        #endregion
        #region Constructors
        public MainForm()
        {
            InitializeComponent();

            InitGUI();
        }
        #endregion
        #region Initializers
        /// <summary>
        /// Do stuff on startup
        /// </summary>
        private void InitGUI()
        {
            rdbMetric.Checked = true;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Read input and perform bmi calculation and present result to gui.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Maybe this method can be simplified further?
                UnitTypes unit = rdbMetric.Checked ? UnitTypes.Metric : UnitTypes.Imperial;
                string name;
                double height, weight, inches;
                ReadUserData(unit, out name, out height, out weight, out inches);

                bmiCalculator.SetName(name);
                bmiCalculator.SetHeight(height, inches);
                bmiCalculator.SetWeight(weight);
                bmiCalculator.SetUnit(unit);

                bmiCalculator.CalculateBMI(unit);
                bmiCalculator.CalculateNormalWeight(unit);

                lblBmiValue.Text = $"{bmiCalculator.GetBmi():N2}";
                lblCategoryValue.Text = $"{EnumUtils.GetDescription(bmiCalculator.GetWeightCategory())}";
                lblNormalWeight.Text = $"Normal weight is between {bmiCalculator.GetNormalWeight()[(int)BMICalculator.WeightRange.lowWeight]:N0} and " +
                                        $"{bmiCalculator.GetNormalWeight()[(int)BMICalculator.WeightRange.highWeight]:N0} " +
                                        $"{(bmiCalculator.GetUnit() == UnitTypes.Metric ? EnumUtils.GetDescription(Metric.Weight.Kilograms) :
                                        EnumUtils.GetDescription(Imperial.Weight.Pounds))}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}");
            }
        }

        private void ReadUserData(UnitTypes unit, out string name, out double height, out double weight, out double inches)
        {
            name = ui.ReadTextAsString(txtName.Text);
            height = ui.ReadTextAsDouble(txtHeight.Text);
            weight = ui.ReadTextAsDouble(txtWeight.Text);
            inches = unit == UnitTypes.Imperial ? ui.ReadTextAsDouble(txtInches.Text) : 0.0;
        }

        /// <summary>
        /// Handle what happens when radiobutton status changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbMetric_CheckedChanged(object sender, EventArgs e)
        {
            UnitTypes unit = rdbMetric.Checked ? UnitTypes.Metric : UnitTypes.Imperial;
            switch (unit)
            {
                case UnitTypes.Metric:
                    pnlInches.Visible = false;
                    lblHeight.Text = $"Height ({EnumUtils.GetDescription(Metric.Length.Centimeters)})";
                    lblWeight.Text = $"Weight ({EnumUtils.GetDescription(Metric.Weight.Kilograms)})";
                    break;
                case UnitTypes.Imperial:
                    pnlInches.Visible = true;
                    lblHeight.Text = $"Height ({EnumUtils.GetDescription(Imperial.Length.Feet)})";
                    lblWeight.Text = $"Weight ({EnumUtils.GetDescription(Imperial.Weight.Pounds)})";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Perform savings calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateSaving_Click(object sender, EventArgs e)
        {
            savingCalculator.InitialDeposit = ui.ReadTextAsDecimal(txtInitial.Text);
            savingCalculator.MonthlyDeposit = ui.ReadTextAsDecimal(txtMonthly.Text);
            savingCalculator.PeriodInYears = ui.ReadTextAsInt(txtPeriod.Text);
            savingCalculator.YearlyInterestRate = ui.ReadTextAsDouble(txtGrowth.Text);
            savingCalculator.YearlyFees = ui.ReadTextAsDouble(txtFees.Text);

            savingCalculator.CalculateFinalBalance();

            lblAmountEarnedValue.Text = $"{savingCalculator.TotalAmountEarned:N2}";
            lblAmountPaidValue.Text = $"{savingCalculator.TotalAmountPaid:N2}";
            lblFinalAmountValue.Text = $"{savingCalculator.Balance:N2}";
            lblTotalFeesValue.Text = $"{savingCalculator.TotalFees:N2}";
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            rdbFemale.Checked = true;
            rdbMetric.Checked = true;
            rdbSedentary.Checked = true;
        }

        private void btnCalculateBmr_Click(object sender, EventArgs e)
        {
            UnitTypes unit = rdbMetric.Checked ? UnitTypes.Metric : UnitTypes.Imperial;
            string name;
            double height, weight, inches;
            ReadUserData(unit, out name, out height, out weight, out inches);

            bmrCalculator.SetName(name);
            bmrCalculator.SetHeight(height, inches);
            bmrCalculator.SetWeight(weight);
            bmrCalculator.SetUnit(unit);
            bmrCalculator.Age = ui.ReadTextAsInt(txtAge.Text);

            bmrCalculator.CalculateBmr();
            bmrCalculator.CalculateCaloriesToMaintainWeight();

            lbBmrResults.Items.Clear();
            lbBmrResults.Items.Add($"BMR RESULTS FOR {bmrCalculator.GetName()}\n\n");
            lbBmrResults.Items.Add("");
            lbBmrResults.Items.Add($"Your BMR (calories/day)\t\t\t{bmrCalculator.Bmr:N1}");
            lbBmrResults.Items.Add($"Calories to maintain your weight\t\t{bmrCalculator.CaloriesToMaintainWeight:N1}");
            lbBmrResults.Items.Add($"Calories to lose 0.5 kg per week\t\t{bmrCalculator.CalculateCaloriesToChangeWeight(-500):N1}");
            lbBmrResults.Items.Add($"Calories to lose 1.0 kg per week\t\t{bmrCalculator.CalculateCaloriesToChangeWeight(-1000):N1}");
            lbBmrResults.Items.Add($"Calories to gain 0.5 kg per week\t\t{bmrCalculator.CalculateCaloriesToChangeWeight(500):N1}");
            lbBmrResults.Items.Add($"Calories to gain 1.0 kg per week\t\t{bmrCalculator.CalculateCaloriesToChangeWeight(1000):N1}");
            lbBmrResults.Items.Add("");
            lbBmrResults.Items.Add($"Losing more than 1000 calories per day is to be avoided.");
        }

        private void rdbSedentary_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSedentary.Checked)
            {
                bmrCalculator.ActivityLevel = Activity.ActivityLevel.Sedentary;
            }
        }

        private void rdbLightly_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLightly.Checked)
            {
                bmrCalculator.ActivityLevel = Activity.ActivityLevel.LightlyActive;
            }
        }

        private void rdbModerately_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbModerately.Checked)
            {
                bmrCalculator.ActivityLevel = Activity.ActivityLevel.ModeratelyActive;
            }
        }

        private void rdbVery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVery.Checked)
            {
                bmrCalculator.ActivityLevel = Activity.ActivityLevel.VeryActive;
            }
        }

        private void rdbExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbExtra.Checked)
            {
                bmrCalculator.ActivityLevel = Activity.ActivityLevel.ExtraActive;
            }
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFemale.Checked)
            {
                bmrCalculator.Gender = Gender.Female;
            }
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMale.Checked)
            {
                bmrCalculator.Gender = Gender.Male;
            }
        }
    }
}
