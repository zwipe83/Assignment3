
/// <summary>
/// Filename: SavingCalculator.cs
/// Created on: 2024-02-26 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment3.Calculators
{
    /// <summary>
    /// This class handles savings account calculations. Private fields are accesible via Properties.
    /// </summary>
    internal class SavingCalculator
    {
        #region Fields
        private decimal _initialDeposit;
        private decimal _monthlyDeposit;
        private int _periodInMonths;
        private int _periodInYears;
        private double _yearlyInterestRate;
        private double _monthlyInterestRate;
        private double _yearlyFees;
        private double _monthlyFees;
        private decimal _totalAmountPaid;
        private decimal _totalAmountEarned;
        private decimal _totalFees;
        private decimal _balance;
        #endregion
        #region Properties
        public decimal InitialDeposit { get { return _initialDeposit; } internal set { _initialDeposit = value; } }
        public decimal MonthlyDeposit { get { return _monthlyDeposit; } internal set { _monthlyDeposit = value; } }
        public int PeriodInMonths { get { return _periodInMonths; } internal set { _periodInMonths = value; } }
        public int PeriodInYears { get { return _periodInYears; } internal set { _periodInYears = value; } }
        public double YearlyInterestRate { get { return _yearlyInterestRate; } internal set { _yearlyInterestRate = value; } }
        public double MonthlyInterestRate { get { return _monthlyInterestRate; } internal set { _monthlyInterestRate = value; } }
        public double YearlyFees { get { return _yearlyFees; } internal set { _yearlyFees = value; } }
        public double MonthlyFees { get { return _monthlyFees; } internal set { _monthlyFees = value; } }
        public decimal TotalAmountPaid { get { return _totalAmountPaid; } internal set { _totalAmountPaid = value; } }
        public decimal TotalAmountEarned { get { return _totalAmountEarned; } internal set { _totalAmountEarned = value; } }
        public decimal TotalFees { get { return _totalFees; } internal set { _totalFees = value; } }
        public decimal Balance { get { return _balance; } internal set { _balance = value; } }
        #endregion
        #region Constructors
        public SavingCalculator() { }
        #endregion
        #region Methods

        /// <summary>
        /// Perform calculation of final balance and take into account interest and fees.
        /// </summary>
        public void CalculateFinalBalance()
        {
            TotalAmountEarned = 0.0M; //Reset
            TotalFees = 0.0M;

            SetBalance();
            SetTotalAmountPaid();
            CalculatePeriodInMonths();
            CalculateMonthlyInterest();
            CalculateMonthlyFees();

            for (int month = 1; month < PeriodInMonths; month++)
            {
                TotalAmountPaid += MonthlyDeposit;
                decimal interest = Balance * (decimal)MonthlyInterestRate;
                decimal fees = Balance * (decimal)MonthlyFees;
                Balance += interest - fees + MonthlyDeposit;
                TotalAmountEarned += interest;
                TotalFees += fees;
            }
        }
        /// <summary>
        /// Calculate how much you will pay for bank fees per month
        /// </summary>
        private void CalculateMonthlyFees()
        {
            MonthlyFees = YearlyFees / 100 / 12;
        }
        /// <summary>
        /// Calculate monthly interest
        /// </summary>
        private void CalculateMonthlyInterest()
        {
            MonthlyInterestRate = YearlyInterestRate / 100 / 12;
        }
        /// <summary>
        /// Calculate how many months your savings will run
        /// </summary>
        private void CalculatePeriodInMonths()
        {
            PeriodInMonths = PeriodInYears * 12;
        }
        /// <summary>
        /// Set initial total amount paid
        /// </summary>
        private void SetTotalAmountPaid()
        {
            TotalAmountPaid = InitialDeposit + MonthlyDeposit;
        }
        /// <summary>
        /// Set initial account balance
        /// </summary>
        private void SetBalance()
        {
            Balance = InitialDeposit + MonthlyDeposit;
        }
        #endregion
    }
}
