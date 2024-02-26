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
            grpUnit.SuspendLayout();
            grpResult.SuspendLayout();
            pnlInches.SuspendLayout();
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
            grpResult.Size = new Size(412, 201);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 545);
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
    }
}
