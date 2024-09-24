namespace Assignment2
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
            makeandmodellbl = new Label();
            carsListBox = new ListBox();
            yearlbl = new Label();
            yearTextBox = new TextBox();
            redRadioButton = new RadioButton();
            blueRadioButton = new RadioButton();
            blackRadioButton = new RadioButton();
            whiteRadioButton = new RadioButton();
            acCheckBox = new CheckBox();
            powerWindowsCheckBox = new CheckBox();
            syriusRadioCheckBox = new CheckBox();
            laneAssistCheckBox = new CheckBox();
            purchaseBtn = new Button();
            purchaseSummary = new Label();
            colorgroupBox = new GroupBox();
            featuresgroupBox = new GroupBox();
            colorgroupBox.SuspendLayout();
            featuresgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // makeandmodellbl
            // 
            makeandmodellbl.AutoSize = true;
            makeandmodellbl.Location = new Point(20, 18);
            makeandmodellbl.Name = "makeandmodellbl";
            makeandmodellbl.Size = new Size(121, 20);
            makeandmodellbl.TabIndex = 0;
            makeandmodellbl.Text = "&Make and model";
            // 
            // carsListBox
            // 
            carsListBox.FormattingEnabled = true;
            carsListBox.Items.AddRange(new object[] { "Chevrolet Camaro", "Ford Mustang", "Toyota Yaris", "Nissan Kicks" });
            carsListBox.Location = new Point(20, 41);
            carsListBox.Name = "carsListBox";
            carsListBox.Size = new Size(150, 104);
            carsListBox.TabIndex = 1;
            carsListBox.SelectedIndexChanged += carslistBox_SelectedIndexChanged;
            // 
            // yearlbl
            // 
            yearlbl.AutoSize = true;
            yearlbl.Location = new Point(242, 18);
            yearlbl.Name = "yearlbl";
            yearlbl.Size = new Size(37, 20);
            yearlbl.TabIndex = 2;
            yearlbl.Text = "&Year";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(242, 41);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(125, 27);
            yearTextBox.TabIndex = 3;
            // 
            // redRadioButton
            // 
            redRadioButton.AutoSize = true;
            redRadioButton.Location = new Point(6, 31);
            redRadioButton.Name = "redRadioButton";
            redRadioButton.Size = new Size(56, 24);
            redRadioButton.TabIndex = 6;
            redRadioButton.TabStop = true;
            redRadioButton.Text = "Red";
            redRadioButton.UseVisualStyleBackColor = true;
            redRadioButton.CheckedChanged += redRadioButton_CheckedChanged;
            // 
            // blueRadioButton
            // 
            blueRadioButton.AutoSize = true;
            blueRadioButton.Location = new Point(6, 61);
            blueRadioButton.Name = "blueRadioButton";
            blueRadioButton.Size = new Size(59, 24);
            blueRadioButton.TabIndex = 7;
            blueRadioButton.TabStop = true;
            blueRadioButton.Text = "Blue";
            blueRadioButton.UseVisualStyleBackColor = true;
            blueRadioButton.CheckedChanged += blueRadioButton_CheckedChanged;
            // 
            // blackRadioButton
            // 
            blackRadioButton.AutoSize = true;
            blackRadioButton.Location = new Point(6, 91);
            blackRadioButton.Name = "blackRadioButton";
            blackRadioButton.Size = new Size(65, 24);
            blackRadioButton.TabIndex = 8;
            blackRadioButton.TabStop = true;
            blackRadioButton.Text = "Black";
            blackRadioButton.UseVisualStyleBackColor = true;
            blackRadioButton.CheckedChanged += blackRadioButton_CheckedChanged;
            // 
            // whiteRadioButton
            // 
            whiteRadioButton.AutoSize = true;
            whiteRadioButton.Location = new Point(6, 121);
            whiteRadioButton.Name = "whiteRadioButton";
            whiteRadioButton.Size = new Size(69, 24);
            whiteRadioButton.TabIndex = 9;
            whiteRadioButton.TabStop = true;
            whiteRadioButton.Text = "White";
            whiteRadioButton.UseVisualStyleBackColor = true;
            whiteRadioButton.CheckedChanged += whiteRadioButton_CheckedChanged;
            // 
            // acCheckBox
            // 
            acCheckBox.AutoSize = true;
            acCheckBox.Location = new Point(6, 32);
            acCheckBox.Name = "acCheckBox";
            acCheckBox.Size = new Size(50, 24);
            acCheckBox.TabIndex = 10;
            acCheckBox.Text = "AC";
            acCheckBox.UseVisualStyleBackColor = true;
            // 
            // powerWindowsCheckBox
            // 
            powerWindowsCheckBox.AutoSize = true;
            powerWindowsCheckBox.Location = new Point(6, 61);
            powerWindowsCheckBox.Name = "powerWindowsCheckBox";
            powerWindowsCheckBox.Size = new Size(133, 24);
            powerWindowsCheckBox.TabIndex = 11;
            powerWindowsCheckBox.Text = "Power windows";
            powerWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // syriusRadioCheckBox
            // 
            syriusRadioCheckBox.AutoSize = true;
            syriusRadioCheckBox.Location = new Point(6, 91);
            syriusRadioCheckBox.Name = "syriusRadioCheckBox";
            syriusRadioCheckBox.Size = new Size(112, 24);
            syriusRadioCheckBox.TabIndex = 12;
            syriusRadioCheckBox.Text = "Syrius Radio";
            syriusRadioCheckBox.UseVisualStyleBackColor = true;
            // 
            // laneAssistCheckBox
            // 
            laneAssistCheckBox.AutoSize = true;
            laneAssistCheckBox.Location = new Point(6, 121);
            laneAssistCheckBox.Name = "laneAssistCheckBox";
            laneAssistCheckBox.Size = new Size(101, 24);
            laneAssistCheckBox.TabIndex = 13;
            laneAssistCheckBox.Text = "Lane assist";
            laneAssistCheckBox.UseVisualStyleBackColor = true;
            // 
            // purchaseBtn
            // 
            purchaseBtn.Location = new Point(20, 243);
            purchaseBtn.Name = "purchaseBtn";
            purchaseBtn.Size = new Size(94, 29);
            purchaseBtn.TabIndex = 14;
            purchaseBtn.Text = "&Purchase";
            purchaseBtn.UseVisualStyleBackColor = true;
            purchaseBtn.Click += purchasebtn_Click;
            // 
            // purchaseSummary
            // 
            purchaseSummary.BorderStyle = BorderStyle.FixedSingle;
            purchaseSummary.Location = new Point(142, 301);
            purchaseSummary.Name = "purchaseSummary";
            purchaseSummary.Size = new Size(601, 113);
            purchaseSummary.TabIndex = 15;
            purchaseSummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // colorgroupBox
            // 
            colorgroupBox.Controls.Add(redRadioButton);
            colorgroupBox.Controls.Add(blueRadioButton);
            colorgroupBox.Controls.Add(blackRadioButton);
            colorgroupBox.Controls.Add(whiteRadioButton);
            colorgroupBox.Location = new Point(409, 18);
            colorgroupBox.Name = "colorgroupBox";
            colorgroupBox.Size = new Size(173, 156);
            colorgroupBox.TabIndex = 16;
            colorgroupBox.TabStop = false;
            colorgroupBox.Text = "&Color";
            // 
            // featuresgroupBox
            // 
            featuresgroupBox.Controls.Add(acCheckBox);
            featuresgroupBox.Controls.Add(powerWindowsCheckBox);
            featuresgroupBox.Controls.Add(syriusRadioCheckBox);
            featuresgroupBox.Controls.Add(laneAssistCheckBox);
            featuresgroupBox.Location = new Point(618, 18);
            featuresgroupBox.Name = "featuresgroupBox";
            featuresgroupBox.Size = new Size(159, 156);
            featuresgroupBox.TabIndex = 17;
            featuresgroupBox.TabStop = false;
            featuresgroupBox.Text = "&Features";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(featuresgroupBox);
            Controls.Add(colorgroupBox);
            Controls.Add(purchaseSummary);
            Controls.Add(purchaseBtn);
            Controls.Add(yearTextBox);
            Controls.Add(yearlbl);
            Controls.Add(carsListBox);
            Controls.Add(makeandmodellbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Assignment 2";
            colorgroupBox.ResumeLayout(false);
            colorgroupBox.PerformLayout();
            featuresgroupBox.ResumeLayout(false);
            featuresgroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label makeandmodellbl;
        private ListBox carsListBox;
        private Label yearlbl;
        private TextBox yearTextBox;
        private RadioButton redRadioButton;
        private RadioButton blueRadioButton;
        private RadioButton blackRadioButton;
        private RadioButton whiteRadioButton;
        private CheckBox acCheckBox;
        private CheckBox powerWindowsCheckBox;
        private CheckBox syriusRadioCheckBox;
        private CheckBox laneAssistCheckBox;
        private Button purchaseBtn;
        private Label purchaseSummary;
        private GroupBox colorgroupBox;
        private GroupBox featuresgroupBox;
    }
}
