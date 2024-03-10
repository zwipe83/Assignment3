namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnCalculate = new Button();
            txtName = new TextBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            rdoMetric = new RadioButton();
            rdoImperial = new RadioButton();
            lblName = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            grpUnit = new GroupBox();
            grpResult = new GroupBox();
            lblCategoryValue = new Label();
            lblBmiValue = new Label();
            lblNormalWeight = new Label();
            lblNormal = new Label();
            lblWeightCategory = new Label();
            lblYourBMI = new Label();
            txtInches = new TextBox();
            lblFeet = new Label();
            lblInches = new Label();
            pnlInches = new Panel();
            grpSavings = new GroupBox();
            btnCalculateSaving = new Button();
            lblFees = new Label();
            lblGrowth = new Label();
            lblPeriod = new Label();
            lblMonthly = new Label();
            lblInitial = new Label();
            txtFees = new TextBox();
            txtGrowth = new TextBox();
            txtPeriod = new TextBox();
            txtMonthly = new TextBox();
            txtInitial = new TextBox();
            grpSavingsResult = new GroupBox();
            lblTotalFeesValue = new Label();
            lblTotalFees = new Label();
            lblFinalAmountValue = new Label();
            lblFinalAmount = new Label();
            lblAmountEarnedValue = new Label();
            lblAmountEarned = new Label();
            lblAmountPaidValue = new Label();
            lblAmountPaid = new Label();
            grpBmrCalculator = new GroupBox();
            lstBmrResults = new ListBox();
            grpWeeklyActivity = new GroupBox();
            rdoExtra = new RadioButton();
            rdoVery = new RadioButton();
            rdoModerately = new RadioButton();
            rdoLightly = new RadioButton();
            rdoSedentary = new RadioButton();
            grpGender = new GroupBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            txtAge = new TextBox();
            lblAge = new Label();
            btnCalculateBmr = new Button();
            mainFormBindingSource = new BindingSource(components);
            grpUnit.SuspendLayout();
            grpResult.SuspendLayout();
            pnlInches.SuspendLayout();
            grpSavings.SuspendLayout();
            grpSavingsResult.SuspendLayout();
            grpBmrCalculator.SuspendLayout();
            grpWeeklyActivity.SuspendLayout();
            grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(157, 200);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(133, 51);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate BMI";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 23);
            txtName.TabIndex = 1;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(107, 106);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(60, 23);
            txtWeight.TabIndex = 7;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(107, 77);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(60, 23);
            txtHeight.TabIndex = 4;
            // 
            // rdoMetric
            // 
            rdoMetric.AutoSize = true;
            rdoMetric.Location = new Point(16, 27);
            rdoMetric.Name = "rdoMetric";
            rdoMetric.Size = new Size(59, 19);
            rdoMetric.TabIndex = 3;
            rdoMetric.TabStop = true;
            rdoMetric.Text = "Metric";
            rdoMetric.UseVisualStyleBackColor = true;
            rdoMetric.CheckedChanged += rdoMetric_CheckedChanged;
            // 
            // rdoImperial
            // 
            rdoImperial.AutoSize = true;
            rdoImperial.Location = new Point(16, 52);
            rdoImperial.Name = "rdoImperial";
            rdoImperial.Size = new Size(68, 19);
            rdoImperial.TabIndex = 3;
            rdoImperial.TabStop = true;
            rdoImperial.Text = "Imperial";
            rdoImperial.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Your Name";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(12, 80);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(43, 15);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(12, 109);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(45, 15);
            lblWeight.TabIndex = 3;
            lblWeight.Text = "Weight";
            // 
            // grpUnit
            // 
            grpUnit.Controls.Add(rdoImperial);
            grpUnit.Controls.Add(rdoMetric);
            grpUnit.Location = new Point(281, 77);
            grpUnit.Name = "grpUnit";
            grpUnit.Size = new Size(143, 98);
            grpUnit.TabIndex = 2;
            grpUnit.TabStop = false;
            grpUnit.Text = "Unit";
            // 
            // grpResult
            // 
            grpResult.Controls.Add(lblCategoryValue);
            grpResult.Controls.Add(lblBmiValue);
            grpResult.Controls.Add(lblNormalWeight);
            grpResult.Controls.Add(lblNormal);
            grpResult.Controls.Add(lblWeightCategory);
            grpResult.Controls.Add(lblYourBMI);
            grpResult.Location = new Point(12, 271);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(412, 214);
            grpResult.TabIndex = 5;
            grpResult.TabStop = false;
            grpResult.Text = "Results";
            // 
            // lblCategoryValue
            // 
            lblCategoryValue.BorderStyle = BorderStyle.Fixed3D;
            lblCategoryValue.Location = new Point(171, 63);
            lblCategoryValue.Name = "lblCategoryValue";
            lblCategoryValue.Size = new Size(235, 28);
            lblCategoryValue.TabIndex = 1;
            lblCategoryValue.Text = "--";
            lblCategoryValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBmiValue
            // 
            lblBmiValue.BorderStyle = BorderStyle.Fixed3D;
            lblBmiValue.Location = new Point(285, 19);
            lblBmiValue.Name = "lblBmiValue";
            lblBmiValue.Size = new Size(121, 28);
            lblBmiValue.TabIndex = 1;
            lblBmiValue.Text = "--";
            lblBmiValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNormalWeight
            // 
            lblNormalWeight.Location = new Point(6, 157);
            lblNormalWeight.Name = "lblNormalWeight";
            lblNormalWeight.Size = new Size(400, 20);
            lblNormalWeight.TabIndex = 0;
            lblNormalWeight.Text = "--";
            lblNormalWeight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNormal
            // 
            lblNormal.Location = new Point(171, 112);
            lblNormal.Name = "lblNormal";
            lblNormal.Size = new Size(235, 20);
            lblNormal.TabIndex = 0;
            lblNormal.Text = "Normal BMI is between 18.50 and 24.9";
            lblNormal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblWeightCategory
            // 
            lblWeightCategory.AutoSize = true;
            lblWeightCategory.Location = new Point(6, 70);
            lblWeightCategory.Name = "lblWeightCategory";
            lblWeightCategory.Size = new Size(96, 15);
            lblWeightCategory.TabIndex = 0;
            lblWeightCategory.Text = "Weight Category";
            // 
            // lblYourBMI
            // 
            lblYourBMI.AutoSize = true;
            lblYourBMI.Location = new Point(6, 26);
            lblYourBMI.Name = "lblYourBMI";
            lblYourBMI.Size = new Size(55, 15);
            lblYourBMI.TabIndex = 0;
            lblYourBMI.Text = "Your BMI";
            // 
            // txtInches
            // 
            txtInches.Location = new Point(23, 8);
            txtInches.Name = "txtInches";
            txtInches.Size = new Size(60, 23);
            txtInches.TabIndex = 6;
            // 
            // lblFeet
            // 
            lblFeet.AutoSize = true;
            lblFeet.Location = new Point(2, 11);
            lblFeet.Name = "lblFeet";
            lblFeet.Size = new Size(15, 15);
            lblFeet.TabIndex = 3;
            lblFeet.Text = "ft";
            // 
            // lblInches
            // 
            lblInches.AutoSize = true;
            lblInches.Location = new Point(89, 11);
            lblInches.Name = "lblInches";
            lblInches.Size = new Size(17, 15);
            lblInches.TabIndex = 6;
            lblInches.Text = "in";
            // 
            // pnlInches
            // 
            pnlInches.Controls.Add(txtInches);
            pnlInches.Controls.Add(lblInches);
            pnlInches.Controls.Add(lblFeet);
            pnlInches.Location = new Point(171, 69);
            pnlInches.Name = "pnlInches";
            pnlInches.Size = new Size(104, 31);
            pnlInches.TabIndex = 5;
            // 
            // grpSavings
            // 
            grpSavings.Controls.Add(btnCalculateSaving);
            grpSavings.Controls.Add(lblFees);
            grpSavings.Controls.Add(lblGrowth);
            grpSavings.Controls.Add(lblPeriod);
            grpSavings.Controls.Add(lblMonthly);
            grpSavings.Controls.Add(lblInitial);
            grpSavings.Controls.Add(txtFees);
            grpSavings.Controls.Add(txtGrowth);
            grpSavings.Controls.Add(txtPeriod);
            grpSavings.Controls.Add(txtMonthly);
            grpSavings.Controls.Add(txtInitial);
            grpSavings.Location = new Point(595, 33);
            grpSavings.Name = "grpSavings";
            grpSavings.Size = new Size(250, 261);
            grpSavings.TabIndex = 15;
            grpSavings.TabStop = false;
            grpSavings.Text = "Savings plan";
            // 
            // btnCalculateSaving
            // 
            btnCalculateSaving.Location = new Point(36, 195);
            btnCalculateSaving.Name = "btnCalculateSaving";
            btnCalculateSaving.Size = new Size(172, 40);
            btnCalculateSaving.TabIndex = 21;
            btnCalculateSaving.Text = "Calculate saving";
            btnCalculateSaving.UseVisualStyleBackColor = true;
            btnCalculateSaving.Click += btnCalculateSaving_Click;
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Location = new Point(6, 151);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(56, 15);
            lblFees.TabIndex = 1;
            lblFees.Text = "Fees in %";
            // 
            // lblGrowth
            // 
            lblGrowth.AutoSize = true;
            lblGrowth.Location = new Point(6, 122);
            lblGrowth.Name = "lblGrowth";
            lblGrowth.Size = new Size(105, 15);
            lblGrowth.TabIndex = 1;
            lblGrowth.Text = "Yearly growth in %";
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.Location = new Point(6, 94);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(79, 15);
            lblPeriod.TabIndex = 1;
            lblPeriod.Text = "Period (years)";
            // 
            // lblMonthly
            // 
            lblMonthly.AutoSize = true;
            lblMonthly.Location = new Point(6, 65);
            lblMonthly.Name = "lblMonthly";
            lblMonthly.Size = new Size(94, 15);
            lblMonthly.TabIndex = 1;
            lblMonthly.Text = "Monthly deposit";
            // 
            // lblInitial
            // 
            lblInitial.AutoSize = true;
            lblInitial.Location = new Point(6, 36);
            lblInitial.Name = "lblInitial";
            lblInitial.Size = new Size(78, 15);
            lblInitial.TabIndex = 1;
            lblInitial.Text = "Initial deposit";
            // 
            // txtFees
            // 
            txtFees.Location = new Point(137, 148);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(100, 23);
            txtFees.TabIndex = 20;
            txtFees.TextAlign = HorizontalAlignment.Right;
            // 
            // txtGrowth
            // 
            txtGrowth.Location = new Point(137, 119);
            txtGrowth.Name = "txtGrowth";
            txtGrowth.Size = new Size(100, 23);
            txtGrowth.TabIndex = 19;
            txtGrowth.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPeriod
            // 
            txtPeriod.Location = new Point(137, 91);
            txtPeriod.Name = "txtPeriod";
            txtPeriod.Size = new Size(100, 23);
            txtPeriod.TabIndex = 18;
            txtPeriod.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMonthly
            // 
            txtMonthly.Location = new Point(137, 62);
            txtMonthly.Name = "txtMonthly";
            txtMonthly.Size = new Size(100, 23);
            txtMonthly.TabIndex = 17;
            txtMonthly.TextAlign = HorizontalAlignment.Right;
            // 
            // txtInitial
            // 
            txtInitial.Location = new Point(137, 33);
            txtInitial.Name = "txtInitial";
            txtInitial.Size = new Size(100, 23);
            txtInitial.TabIndex = 16;
            txtInitial.TextAlign = HorizontalAlignment.Right;
            // 
            // grpSavingsResult
            // 
            grpSavingsResult.Controls.Add(lblTotalFeesValue);
            grpSavingsResult.Controls.Add(lblTotalFees);
            grpSavingsResult.Controls.Add(lblFinalAmountValue);
            grpSavingsResult.Controls.Add(lblFinalAmount);
            grpSavingsResult.Controls.Add(lblAmountEarnedValue);
            grpSavingsResult.Controls.Add(lblAmountEarned);
            grpSavingsResult.Controls.Add(lblAmountPaidValue);
            grpSavingsResult.Controls.Add(lblAmountPaid);
            grpSavingsResult.Location = new Point(595, 317);
            grpSavingsResult.Name = "grpSavingsResult";
            grpSavingsResult.Size = new Size(250, 168);
            grpSavingsResult.TabIndex = 9;
            grpSavingsResult.TabStop = false;
            grpSavingsResult.Text = "Future saving";
            // 
            // lblTotalFeesValue
            // 
            lblTotalFeesValue.BorderStyle = BorderStyle.Fixed3D;
            lblTotalFeesValue.Location = new Point(137, 129);
            lblTotalFeesValue.Name = "lblTotalFeesValue";
            lblTotalFeesValue.Size = new Size(100, 23);
            lblTotalFeesValue.TabIndex = 1;
            lblTotalFeesValue.Text = "--";
            lblTotalFeesValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Location = new Point(6, 133);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(56, 15);
            lblTotalFees.TabIndex = 0;
            lblTotalFees.Text = "Total fees";
            // 
            // lblFinalAmountValue
            // 
            lblFinalAmountValue.BorderStyle = BorderStyle.Fixed3D;
            lblFinalAmountValue.Location = new Point(137, 95);
            lblFinalAmountValue.Name = "lblFinalAmountValue";
            lblFinalAmountValue.Size = new Size(100, 23);
            lblFinalAmountValue.TabIndex = 1;
            lblFinalAmountValue.Text = "--";
            lblFinalAmountValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFinalAmount
            // 
            lblFinalAmount.AutoSize = true;
            lblFinalAmount.Location = new Point(6, 99);
            lblFinalAmount.Name = "lblFinalAmount";
            lblFinalAmount.Size = new Size(77, 15);
            lblFinalAmount.TabIndex = 0;
            lblFinalAmount.Text = "Final amount";
            // 
            // lblAmountEarnedValue
            // 
            lblAmountEarnedValue.BorderStyle = BorderStyle.Fixed3D;
            lblAmountEarnedValue.Location = new Point(137, 63);
            lblAmountEarnedValue.Name = "lblAmountEarnedValue";
            lblAmountEarnedValue.Size = new Size(100, 23);
            lblAmountEarnedValue.TabIndex = 1;
            lblAmountEarnedValue.Text = "--";
            lblAmountEarnedValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAmountEarned
            // 
            lblAmountEarned.AutoSize = true;
            lblAmountEarned.Location = new Point(6, 67);
            lblAmountEarned.Name = "lblAmountEarned";
            lblAmountEarned.Size = new Size(90, 15);
            lblAmountEarned.TabIndex = 0;
            lblAmountEarned.Text = "Amount earned";
            // 
            // lblAmountPaidValue
            // 
            lblAmountPaidValue.BorderStyle = BorderStyle.Fixed3D;
            lblAmountPaidValue.Location = new Point(137, 30);
            lblAmountPaidValue.Name = "lblAmountPaidValue";
            lblAmountPaidValue.Size = new Size(100, 23);
            lblAmountPaidValue.TabIndex = 1;
            lblAmountPaidValue.Text = "--";
            lblAmountPaidValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Location = new Point(6, 34);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(77, 15);
            lblAmountPaid.TabIndex = 0;
            lblAmountPaid.Text = "Amount paid";
            // 
            // grpBmrCalculator
            // 
            grpBmrCalculator.Controls.Add(lstBmrResults);
            grpBmrCalculator.Controls.Add(grpWeeklyActivity);
            grpBmrCalculator.Controls.Add(grpGender);
            grpBmrCalculator.Controls.Add(txtAge);
            grpBmrCalculator.Controls.Add(lblAge);
            grpBmrCalculator.Controls.Add(btnCalculateBmr);
            grpBmrCalculator.Location = new Point(12, 501);
            grpBmrCalculator.Name = "grpBmrCalculator";
            grpBmrCalculator.Size = new Size(833, 267);
            grpBmrCalculator.TabIndex = 10;
            grpBmrCalculator.TabStop = false;
            grpBmrCalculator.Text = "BMR Calculator";
            // 
            // lstBmrResults
            // 
            lstBmrResults.FormattingEnabled = true;
            lstBmrResults.ItemHeight = 15;
            lstBmrResults.Location = new Point(361, 22);
            lstBmrResults.Name = "lstBmrResults";
            lstBmrResults.Size = new Size(451, 229);
            lstBmrResults.TabIndex = 99;
            // 
            // grpWeeklyActivity
            // 
            grpWeeklyActivity.Controls.Add(rdoExtra);
            grpWeeklyActivity.Controls.Add(rdoVery);
            grpWeeklyActivity.Controls.Add(rdoModerately);
            grpWeeklyActivity.Controls.Add(rdoLightly);
            grpWeeklyActivity.Controls.Add(rdoSedentary);
            grpWeeklyActivity.Location = new Point(138, 22);
            grpWeeklyActivity.Name = "grpWeeklyActivity";
            grpWeeklyActivity.Size = new Size(209, 155);
            grpWeeklyActivity.TabIndex = 12;
            grpWeeklyActivity.TabStop = false;
            grpWeeklyActivity.Text = "Weekly activity level";
            // 
            // rdoExtra
            // 
            rdoExtra.AutoSize = true;
            rdoExtra.Location = new Point(6, 122);
            rdoExtra.Name = "rdoExtra";
            rdoExtra.Size = new Size(203, 19);
            rdoExtra.TabIndex = 13;
            rdoExtra.TabStop = true;
            rdoExtra.Text = "Extra active, hard exercies or work";
            rdoExtra.UseVisualStyleBackColor = true;
            rdoExtra.CheckedChanged += rdoExtra_CheckedChanged;
            // 
            // rdoVery
            // 
            rdoVery.AutoSize = true;
            rdoVery.Location = new Point(6, 97);
            rdoVery.Name = "rdoVery";
            rdoVery.Size = new Size(153, 19);
            rdoVery.TabIndex = 13;
            rdoVery.TabStop = true;
            rdoVery.Text = "Very active (6 to 7 times)";
            rdoVery.UseVisualStyleBackColor = true;
            rdoVery.CheckedChanged += rdoVery_CheckedChanged;
            // 
            // rdoModerately
            // 
            rdoModerately.AutoSize = true;
            rdoModerately.Location = new Point(6, 72);
            rdoModerately.Name = "rdoModerately";
            rdoModerately.Size = new Size(191, 19);
            rdoModerately.TabIndex = 13;
            rdoModerately.TabStop = true;
            rdoModerately.Text = "Moderately active (3 to 5 times)";
            rdoModerately.UseVisualStyleBackColor = true;
            rdoModerately.CheckedChanged += rdoModerately_CheckedChanged;
            // 
            // rdoLightly
            // 
            rdoLightly.AutoSize = true;
            rdoLightly.Location = new Point(6, 47);
            rdoLightly.Name = "rdoLightly";
            rdoLightly.Size = new Size(135, 19);
            rdoLightly.TabIndex = 13;
            rdoLightly.TabStop = true;
            rdoLightly.Text = "Lightly active (1 to 3)";
            rdoLightly.UseVisualStyleBackColor = true;
            rdoLightly.CheckedChanged += rdoLightly_CheckedChanged;
            // 
            // rdoSedentary
            // 
            rdoSedentary.AutoSize = true;
            rdoSedentary.Location = new Point(6, 22);
            rdoSedentary.Name = "rdoSedentary";
            rdoSedentary.Size = new Size(187, 19);
            rdoSedentary.TabIndex = 13;
            rdoSedentary.TabStop = true;
            rdoSedentary.Text = "Sedentary (little or no exercise)";
            rdoSedentary.UseVisualStyleBackColor = true;
            rdoSedentary.CheckedChanged += rdoSedentary_CheckedChanged;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdoMale);
            grpGender.Controls.Add(rdoFemale);
            grpGender.Location = new Point(6, 22);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(116, 88);
            grpGender.TabIndex = 9;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(6, 47);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 10;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            rdoMale.CheckedChanged += rdoMale_CheckedChanged;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(6, 22);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(63, 19);
            rdoFemale.TabIndex = 10;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            rdoFemale.CheckedChanged += rdoFemale_CheckedChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(62, 124);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(60, 23);
            txtAge.TabIndex = 11;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(6, 127);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age";
            // 
            // btnCalculateBmr
            // 
            btnCalculateBmr.Location = new Point(94, 197);
            btnCalculateBmr.Name = "btnCalculateBmr";
            btnCalculateBmr.Size = new Size(133, 51);
            btnCalculateBmr.TabIndex = 14;
            btnCalculateBmr.Text = "Calculate BMR";
            btnCalculateBmr.UseVisualStyleBackColor = true;
            btnCalculateBmr.Click += btnCalculateBmr_Click;
            // 
            // mainFormBindingSource
            // 
            mainFormBindingSource.DataSource = typeof(MainForm);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 780);
            Controls.Add(grpBmrCalculator);
            Controls.Add(grpSavingsResult);
            Controls.Add(grpSavings);
            Controls.Add(pnlInches);
            Controls.Add(grpResult);
            Controls.Add(grpUnit);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblName);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(txtName);
            Controls.Add(btnCalculate);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Body Mass Index Calculator by Samuel Jeffman";
            grpUnit.ResumeLayout(false);
            grpUnit.PerformLayout();
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            pnlInches.ResumeLayout(false);
            pnlInches.PerformLayout();
            grpSavings.ResumeLayout(false);
            grpSavings.PerformLayout();
            grpSavingsResult.ResumeLayout(false);
            grpSavingsResult.PerformLayout();
            grpBmrCalculator.ResumeLayout(false);
            grpBmrCalculator.PerformLayout();
            grpWeeklyActivity.ResumeLayout(false);
            grpWeeklyActivity.PerformLayout();
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox txtName;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private RadioButton rdoMetric;
        private RadioButton rdoImperial;
        private Label lblName;
        private Label lblHeight;
        private Label lblWeight;
        private GroupBox grpUnit;
        private GroupBox grpResult;
        private Label lblYourBMI;
        private Label lblBmiValue;
        private Label lblNormal;
        private Label lblCategoryValue;
        private Label lblWeightCategory;
        private Label lblNormalWeight;
        private TextBox txtInches;
        private Label lblFeet;
        private Label lblInches;
        private Panel pnlInches;
        private GroupBox grpSavings;
        private Label lblInitial;
        private TextBox txtInitial;
        private Label lblMonthly;
        private TextBox txtMonthly;
        private Label lblPeriod;
        private TextBox txtPeriod;
        private Label lblGrowth;
        private TextBox txtGrowth;
        private Label lblFees;
        private TextBox txtFees;
        private Button btnCalculateSaving;
        private GroupBox grpSavingsResult;
        private Label lblAmountPaid;
        private Label lblAmountPaidValue;
        private Label lblAmountEarnedValue;
        private Label lblAmountEarned;
        private Label lblFinalAmountValue;
        private Label lblFinalAmount;
        private Label lblTotalFeesValue;
        private Label lblTotalFees;
        private GroupBox grpBmrCalculator;
        private GroupBox grpGender;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private GroupBox grpWeeklyActivity;
        private RadioButton rdoSedentary;
        private RadioButton rdoLightly;
        private RadioButton rdoModerately;
        private RadioButton rdoVery;
        private RadioButton rdoExtra;
        private TextBox txtAge;
        private Label lblAge;
        private Button btnCalculateBmr;
        private BindingSource mainFormBindingSource;
        private ListBox lstBmrResults;
    }
}
