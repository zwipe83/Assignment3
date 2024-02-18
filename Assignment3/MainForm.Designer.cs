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
            button1 = new Button();
            txtName = new TextBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            rdbMetric = new RadioButton();
            rdbImperial = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(164, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(147, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(450, 41);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(289, 41);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 1;
            // 
            // rdbMetric
            // 
            rdbMetric.AutoSize = true;
            rdbMetric.Location = new Point(605, 43);
            rdbMetric.Name = "rdbMetric";
            rdbMetric.Size = new Size(59, 19);
            rdbMetric.TabIndex = 2;
            rdbMetric.TabStop = true;
            rdbMetric.Text = "Metric";
            rdbMetric.UseVisualStyleBackColor = true;
            // 
            // rdbImperial
            // 
            rdbImperial.AutoSize = true;
            rdbImperial.Location = new Point(605, 68);
            rdbImperial.Name = "rdbImperial";
            rdbImperial.Size = new Size(68, 19);
            rdbImperial.TabIndex = 2;
            rdbImperial.TabStop = true;
            rdbImperial.Text = "Imperial";
            rdbImperial.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdbImperial);
            Controls.Add(rdbMetric);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(txtName);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtName;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private RadioButton rdbMetric;
        private RadioButton rdbImperial;
    }
}
