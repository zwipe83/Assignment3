
/// <summary>
/// Filename: MainForm.cs
/// Created on: 2024-02-18 00:00:00
/// Author: Samuel Jeffman
/// </summary>

using Assignment3.Calculators;
using Assignment3.Enumerators;
using Assignment3.Utils;

namespace Assignment3
{
    /// <summary>
    /// Main GUI class
    /// </summary>
    public partial class MainForm : Form
    {
        #region Fields
        /// <summary>
        /// Object of class BMICalculator
        /// </summary>
        private readonly BMICalculator bmiCalculator = new();
        /// <summary>
        /// Object of class UserInput
        /// </summary>
        private readonly UserInput userInput = new();
        /// <summary>
        /// Object of class SavingCalculator
        /// </summary>
        private readonly SavingCalculator savingCalculator = new();
        /// <summary>
        /// Object of class BMRCalculator
        /// </summary>
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
            rdoMetric.Checked = true;
            rdoFemale.Checked = true;
            rdoSedentary.Checked = true;
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
                //Init data
                UnitTypes unit = rdoMetric.Checked ? UnitTypes.Metric : UnitTypes.Imperial;
                string name;
                double height, weight, inches;

                //Read data
                ReadUserData(unit, out name, out height, out weight, out inches);

                //Save data
                bmiCalculator.SetName(name);
                bmiCalculator.SetHeight(height, inches);
                bmiCalculator.SetWeight(weight);
                bmiCalculator.SetUnit(unit);

                //Calculate data
                bmiCalculator.CalculateBMI(unit);
                bmiCalculator.CalculateNormalWeight(unit);

                //Present data
                lblBmiValue.Text = $"{bmiCalculator.GetBmi():N2}";
                lblCategoryValue.Text = $"{EnumUtils.GetDescription(bmiCalculator.GetWeightCategory())}";
                lblNormalWeight.Text = $"Normal weight is between {bmiCalculator.GetNormalWeight()[(int)BMICalculator.WeightRange.lowWeight]:N0} and " +
                                        $"{bmiCalculator.GetNormalWeight()[(int)BMICalculator.WeightRange.highWeight]:N0} " +
                                        $"{(bmiCalculator.GetUnit() == UnitTypes.Metric ? EnumUtils.GetDescription(Metric.Weight.Kilograms) :
                                        EnumUtils.GetDescription(Imperial.Weight.Pounds))}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /// <summary>
        /// Method reads input from GUI and interprets as proper datatypes
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="name"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <param name="inches"></param>
        private void ReadUserData(UnitTypes unit, out string name, out double height, out double weight, out double inches)
        {
            try
            {
                name = userInput.ReadTextAsString(txtName.Text);
                height = userInput.ReadTextAsDouble(txtHeight.Text);
                weight = userInput.ReadTextAsDouble(txtWeight.Text);
                inches = unit == UnitTypes.Imperial ? userInput.ReadTextAsDouble(txtInches.Text) : 0.0;
            }
            catch (Exception)
            {
                name = "";
                height = 0.0;
                weight = 0.0;
                inches = 0.0;
                throw;
            }
        }

        /// <summary>
        /// Handle what happens when radiobutton status changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoMetric_CheckedChanged(object sender, EventArgs e)
        {
            UnitTypes unit = rdoMetric.Checked ? UnitTypes.Metric : UnitTypes.Imperial;
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
            try
            {
                //Read and save user input
                savingCalculator.InitialDeposit = userInput.ReadTextAsDecimal(txtInitial.Text);
                savingCalculator.MonthlyDeposit = userInput.ReadTextAsDecimal(txtMonthly.Text);
                savingCalculator.PeriodInYears = userInput.ReadTextAsInt(txtPeriod.Text);
                savingCalculator.YearlyInterestRate = userInput.ReadTextAsDouble(txtGrowth.Text);
                savingCalculator.YearlyFees = userInput.ReadTextAsDouble(txtFees.Text);

                //Calculate data
                savingCalculator.CalculateFinalBalance();

                //Present data
                lblAmountEarnedValue.Text = $"{savingCalculator.TotalAmountEarned:N2}";
                lblAmountPaidValue.Text = $"{savingCalculator.TotalAmountPaid:N2}";
                lblFinalAmountValue.Text = $"{savingCalculator.Balance:N2}";
                lblTotalFeesValue.Text = $"{savingCalculator.TotalFees:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /// <summary>
        /// Performs BMR calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateBmr_Click(object sender, EventArgs e)
        {
            try
            {
                //Init data
                UnitTypes unit = rdoMetric.Checked ? UnitTypes.Metric : UnitTypes.Imperial;
                string name;
                double height, weight, inches;

                //Read data
                ReadUserData(unit, out name, out height, out weight, out inches);

                //Save data
                bmrCalculator.SetName(name);
                bmrCalculator.SetHeight(height, inches);
                bmrCalculator.SetWeight(weight);
                bmrCalculator.SetUnit(unit);
                bmrCalculator.Age = userInput.ReadTextAsInt(txtAge.Text);

                //Calculate data
                bmrCalculator.CalculateBmr();
                bmrCalculator.CalculateCaloriesToMaintainWeight();

                //Present data
                PresentBmrData(lstBmrResults);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /// <summary>
        /// Presents data in provided listbox
        /// </summary>
        private void PresentBmrData(ListBox listbox)
        {
            double bmr = bmrCalculator.Bmr;
            double caloriesToMaintainWeight = bmrCalculator.CaloriesToMaintainWeight;
            double caloriesToLose500g = bmrCalculator.CalculateCaloriesToChangeWeight(-500);
            double caloriesToLose1000g = bmrCalculator.CalculateCaloriesToChangeWeight(-1000);
            double caloriesToGain500g = bmrCalculator.CalculateCaloriesToChangeWeight(500);
            double caloriesToGain1000g = bmrCalculator.CalculateCaloriesToChangeWeight(1000);

            listbox.Items.Clear();
            listbox.Items.Add($"BMR RESULTS FOR {bmrCalculator.GetName()}\n\n");
            listbox.Items.Add("");
            listbox.Items.Add($"Your BMR (calories/day)\t\t\t{bmr:N1}");
            listbox.Items.Add($"Calories to maintain your weight\t\t{caloriesToMaintainWeight:N1}");
            listbox.Items.Add($"Calories to lose 0.5 kg per week\t\t\t{caloriesToLose500g:N1}");
            listbox.Items.Add($"Calories to lose 1.0 kg per week\t\t\t{caloriesToLose1000g:N1}");
            listbox.Items.Add($"Calories to gain 0.5 kg per week\t\t{caloriesToGain500g:N1}");
            listbox.Items.Add($"Calories to gain 1.0 kg per week\t\t{caloriesToGain1000g:N1}");
            listbox.Items.Add("");
            listbox.Items.Add($"Losing more than 1000 calories per day is to be avoided.");
        }

        /// <summary>
        /// Set sedentary activity level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoSedentary_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSedentary.Checked)
            {
                bmrCalculator.ActivityLevel = Activity.ActivityLevel.Sedentary;
            }
        }
        /// <summary>
        /// Set Lightly activity level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoLightly_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLightly.Checked)
            {
                bmrCalculator.ActivityLevel = Activity.ActivityLevel.LightlyActive;
            }
        }
        /// <summary>
        /// Set moderately activity level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoModerately_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoModerately.Checked)
            {
                bmrCalculator.ActivityLevel = Activity.ActivityLevel.ModeratelyActive;
            }
        }
        /// <summary>
        /// Set Very activity level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoVery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVery.Checked)
            {
                bmrCalculator.ActivityLevel = Activity.ActivityLevel.VeryActive;
            }
        }
        /// <summary>
        /// Set Extra activity level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoExtra.Checked)
            {
                bmrCalculator.ActivityLevel = Activity.ActivityLevel.ExtraActive;
            }
        }
        /// <summary>
        /// User is Female
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFemale.Checked)
            {
                bmrCalculator.Gender = Gender.Female;
            }
        }
        /// <summary>
        /// User is Male
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMale.Checked)
            {
                bmrCalculator.Gender = Gender.Male;
            }
        }
        #endregion
    }
}
