namespace Assignment3
{
    public partial class MainForm : Form
    {
        #region Fields
        private readonly BMICalculator bmiCalculator = new();
        private readonly UserInput ui = new();
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

                string name = ui.ReadTextAsString(txtName.Text);
                double height = ui.ReadTextAsDouble(txtHeight.Text);
                double weight = ui.ReadTextAsDouble(txtWeight.Text);
                double inches = unit == UnitTypes.Imperial ? ui.ReadTextAsDouble(txtInches.Text) : 0.0;

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
        #endregion
    }
}
