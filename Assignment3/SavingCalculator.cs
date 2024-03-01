namespace Assignment3
{
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
        public SavingCalculator()
        {
            InitialDeposit = 0.0M;
            MonthlyDeposit = 0.0M;
            PeriodInMonths = 0;
            PeriodInYears = 0;
            YearlyInterestRate = 0;
            YearlyFees = 0;
            TotalAmountPaid = 0.0M;
            TotalAmountEarned = 0.0M;
            Balance = 0.0M;
        }
        #endregion
        #region Methods

        public void CalculateFinalBalance()
        {

            Balance = InitialDeposit + MonthlyDeposit;
            TotalAmountPaid = InitialDeposit + MonthlyDeposit;
            PeriodInMonths = PeriodInYears * 12;
            MonthlyInterestRate = YearlyInterestRate / 100 / 12;
            MonthlyFees = YearlyFees / 100 / 12;
            TotalAmountEarned = 0.0M;
            TotalFees = 0.0M;
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
        #endregion
    }
}
