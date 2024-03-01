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
            btnCalculate = new Button();
            txtName = new TextBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            rdbMetric = new RadioButton();
            rdbImperial = new RadioButton();
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
            groupBox1 = new GroupBox();
            lblTotalFeesValue = new Label();
            lblTotalFees = new Label();
            lblFinalAmountValue = new Label();
            lblFinalAmount = new Label();
            lblAmountEarnedValue = new Label();
            lblAmountEarned = new Label();
            lblAmountPaidValue = new Label();
            lblAmountPaid = new Label();
            grpUnit.SuspendLayout();
            grpResult.SuspendLayout();
            pnlInches.SuspendLayout();
            grpSavings.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(157, 200);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(133, 51);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
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
            txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(107, 77);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(60, 23);
            txtHeight.TabIndex = 2;
            // 
            // rdbMetric
            // 
            rdbMetric.AutoSize = true;
            rdbMetric.Location = new Point(16, 27);
            rdbMetric.Name = "rdbMetric";
            rdbMetric.Size = new Size(59, 19);
            rdbMetric.TabIndex = 2;
            rdbMetric.TabStop = true;
            rdbMetric.Text = "Metric";
            rdbMetric.UseVisualStyleBackColor = true;
            rdbMetric.CheckedChanged += rdbMetric_CheckedChanged;
            // 
            // rdbImperial
            // 
            rdbImperial.AutoSize = true;
            rdbImperial.Location = new Point(16, 52);
            rdbImperial.Name = "rdbImperial";
            rdbImperial.Size = new Size(68, 19);
            rdbImperial.TabIndex = 2;
            rdbImperial.TabStop = true;
            rdbImperial.Text = "Imperial";
            rdbImperial.UseVisualStyleBackColor = true;
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
            grpUnit.Controls.Add(rdbImperial);
            grpUnit.Controls.Add(rdbMetric);
            grpUnit.Location = new Point(281, 77);
            grpUnit.Name = "grpUnit";
            grpUnit.Size = new Size(143, 98);
            grpUnit.TabIndex = 4;
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
            lblCategoryValue.Text = "label1";
            lblCategoryValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBmiValue
            // 
            lblBmiValue.BorderStyle = BorderStyle.Fixed3D;
            lblBmiValue.Location = new Point(285, 19);
            lblBmiValue.Name = "lblBmiValue";
            lblBmiValue.Size = new Size(121, 28);
            lblBmiValue.TabIndex = 1;
            lblBmiValue.Text = "label1";
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
            txtInches.TabIndex = 2;
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
            pnlInches.TabIndex = 7;
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
            grpSavings.Location = new Point(534, 33);
            grpSavings.Name = "grpSavings";
            grpSavings.Size = new Size(250, 261);
            grpSavings.TabIndex = 8;
            grpSavings.TabStop = false;
            grpSavings.Text = "Saving plan";
            // 
            // btnCalculateSaving
            // 
            btnCalculateSaving.Location = new Point(36, 195);
            btnCalculateSaving.Name = "btnCalculateSaving";
            btnCalculateSaving.Size = new Size(172, 40);
            btnCalculateSaving.TabIndex = 5;
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
            txtFees.TabIndex = 4;
            // 
            // txtGrowth
            // 
            txtGrowth.Location = new Point(137, 119);
            txtGrowth.Name = "txtGrowth";
            txtGrowth.Size = new Size(100, 23);
            txtGrowth.TabIndex = 3;
            // 
            // txtPeriod
            // 
            txtPeriod.Location = new Point(137, 91);
            txtPeriod.Name = "txtPeriod";
            txtPeriod.Size = new Size(100, 23);
            txtPeriod.TabIndex = 2;
            // 
            // txtMonthly
            // 
            txtMonthly.Location = new Point(137, 62);
            txtMonthly.Name = "txtMonthly";
            txtMonthly.Size = new Size(100, 23);
            txtMonthly.TabIndex = 1;
            // 
            // txtInitial
            // 
            txtInitial.Location = new Point(137, 33);
            txtInitial.Name = "txtInitial";
            txtInitial.Size = new Size(100, 23);
            txtInitial.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotalFeesValue);
            groupBox1.Controls.Add(lblTotalFees);
            groupBox1.Controls.Add(lblFinalAmountValue);
            groupBox1.Controls.Add(lblFinalAmount);
            groupBox1.Controls.Add(lblAmountEarnedValue);
            groupBox1.Controls.Add(lblAmountEarned);
            groupBox1.Controls.Add(lblAmountPaidValue);
            groupBox1.Controls.Add(lblAmountPaid);
            groupBox1.Location = new Point(534, 317);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 168);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Future saving";
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 516);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox txtName;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private RadioButton rdbMetric;
        private RadioButton rdbImperial;
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
        private GroupBox groupBox1;
        private Label lblAmountPaid;
        private Label lblAmountPaidValue;
        private Label lblAmountEarnedValue;
        private Label lblAmountEarned;
        private Label lblFinalAmountValue;
        private Label lblFinalAmount;
        private Label lblTotalFeesValue;
        private Label lblTotalFees;
    }
}
