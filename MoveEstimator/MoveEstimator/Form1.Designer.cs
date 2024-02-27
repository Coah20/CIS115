namespace MoveEstimator
{
    partial class Form1
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
            hrsTxt = new TextBox();
            milesTxt = new TextBox();
            hoursWorked = new Label();
            button1 = new Button();
            milesDriven = new Label();
            costEstimste = new Label();
            costTxt = new TextBox();
            clearButton = new Button();
            SuspendLayout();
            // 
            // hrsTxt
            // 
            hrsTxt.Location = new Point(242, 76);
            hrsTxt.Name = "hrsTxt";
            hrsTxt.Size = new Size(125, 27);
            hrsTxt.TabIndex = 0;
            // 
            // milesTxt
            // 
            milesTxt.Location = new Point(242, 130);
            milesTxt.Name = "milesTxt";
            milesTxt.Size = new Size(125, 27);
            milesTxt.TabIndex = 1;
            // 
            // hoursWorked
            // 
            hoursWorked.AutoSize = true;
            hoursWorked.Location = new Point(121, 83);
            hoursWorked.Name = "hoursWorked";
            hoursWorked.Size = new Size(103, 20);
            hoursWorked.TabIndex = 2;
            hoursWorked.Text = "Hours Worked";
            // 
            // button1
            // 
            button1.Location = new Point(130, 208);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // milesDriven
            // 
            milesDriven.AutoSize = true;
            milesDriven.Location = new Point(121, 137);
            milesDriven.Name = "milesDriven";
            milesDriven.Size = new Size(91, 20);
            milesDriven.TabIndex = 4;
            milesDriven.Text = "Miles Driven";
            // 
            // costEstimste
            // 
            costEstimste.AutoSize = true;
            costEstimste.Location = new Point(113, 279);
            costEstimste.Name = "costEstimste";
            costEstimste.Size = new Size(99, 20);
            costEstimste.TabIndex = 5;
            costEstimste.Text = "Cost Esitmate";
            costEstimste.Click += label3_Click;
            // 
            // costTxt
            // 
            costTxt.Enabled = false;
            costTxt.Location = new Point(242, 279);
            costTxt.Name = "costTxt";
            costTxt.Size = new Size(125, 27);
            costTxt.TabIndex = 6;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(273, 208);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(530, 432);
            Controls.Add(clearButton);
            Controls.Add(costTxt);
            Controls.Add(costEstimste);
            Controls.Add(milesDriven);
            Controls.Add(button1);
            Controls.Add(hoursWorked);
            Controls.Add(milesTxt);
            Controls.Add(hrsTxt);
            Name = "Form1";
            Text = "Move Estimator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox hrsTxt;
        private TextBox milesTxt;
        private Label hoursWorked;
        private Button button1;
        private Label milesDriven;
        private Label costEstimste;
        private TextBox costTxt;
        private Button clearButton;
    }
}
