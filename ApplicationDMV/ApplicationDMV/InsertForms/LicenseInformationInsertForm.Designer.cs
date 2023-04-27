namespace ApplicationDMV.InsertForms
{
    partial class LicenseInformationInsertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uxExpDateLabel = new Label();
            uxClassLabel = new Label();
            uxDonorStatusLabel = new Label();
            uxInsertBT = new Button();
            uxCityLabel = new Label();
            uxZipLabel = new Label();
            uxAddress1Label = new Label();
            uxAddress2Label = new Label();
            uxHeightFeetLabel = new Label();
            uxHeightInchesLabel = new Label();
            uxWeightLabel = new Label();
            uxDonorCB = new CheckBox();
            uxCityTB = new TextBox();
            uxZIPTB = new TextBox();
            uxADL1TB = new TextBox();
            uxADL2TB = new TextBox();
            uxHeightFeetTB = new TextBox();
            uxHeightInchesTB = new TextBox();
            uxWeightTB = new TextBox();
            uxExpDateTB = new TextBox();
            uxClassTB = new TextBox();
            uxBackBT = new Button();
            SuspendLayout();
            // 
            // uxExpDateLabel
            // 
            uxExpDateLabel.AutoSize = true;
            uxExpDateLabel.Location = new Point(96, 336);
            uxExpDateLabel.Margin = new Padding(2, 0, 2, 0);
            uxExpDateLabel.Name = "uxExpDateLabel";
            uxExpDateLabel.Size = new Size(90, 15);
            uxExpDateLabel.TabIndex = 94;
            uxExpDateLabel.Text = "Expiration Date:";
            // 
            // uxClassLabel
            // 
            uxClassLabel.AutoSize = true;
            uxClassLabel.Location = new Point(149, 370);
            uxClassLabel.Margin = new Padding(2, 0, 2, 0);
            uxClassLabel.Name = "uxClassLabel";
            uxClassLabel.Size = new Size(37, 15);
            uxClassLabel.TabIndex = 93;
            uxClassLabel.Text = "Class:";
            // 
            // uxDonorStatusLabel
            // 
            uxDonorStatusLabel.AutoSize = true;
            uxDonorStatusLabel.Location = new Point(140, 392);
            uxDonorStatusLabel.Margin = new Padding(2, 0, 2, 0);
            uxDonorStatusLabel.Name = "uxDonorStatusLabel";
            uxDonorStatusLabel.Size = new Size(45, 15);
            uxDonorStatusLabel.TabIndex = 92;
            uxDonorStatusLabel.Text = "Donor?";
            // 
            // uxInsertBT
            // 
            uxInsertBT.BackColor = SystemColors.GradientActiveCaption;
            uxInsertBT.Location = new Point(260, 430);
            uxInsertBT.Margin = new Padding(2);
            uxInsertBT.Name = "uxInsertBT";
            uxInsertBT.Size = new Size(101, 40);
            uxInsertBT.TabIndex = 91;
            uxInsertBT.Text = "Insert";
            uxInsertBT.UseVisualStyleBackColor = false;
            uxInsertBT.Click += uxInsertBT_Click;
            // 
            // uxCityLabel
            // 
            uxCityLabel.AutoSize = true;
            uxCityLabel.Location = new Point(155, 123);
            uxCityLabel.Margin = new Padding(2, 0, 2, 0);
            uxCityLabel.Name = "uxCityLabel";
            uxCityLabel.Size = new Size(31, 15);
            uxCityLabel.TabIndex = 78;
            uxCityLabel.Text = "City:";
            // 
            // uxZipLabel
            // 
            uxZipLabel.AutoSize = true;
            uxZipLabel.Location = new Point(127, 152);
            uxZipLabel.Margin = new Padding(2, 0, 2, 0);
            uxZipLabel.Name = "uxZipLabel";
            uxZipLabel.Size = new Size(58, 15);
            uxZipLabel.TabIndex = 77;
            uxZipLabel.Text = "Zip Code:";
            // 
            // uxAddress1Label
            // 
            uxAddress1Label.AutoSize = true;
            uxAddress1Label.Location = new Point(100, 183);
            uxAddress1Label.Margin = new Padding(2, 0, 2, 0);
            uxAddress1Label.Name = "uxAddress1Label";
            uxAddress1Label.Size = new Size(86, 15);
            uxAddress1Label.TabIndex = 76;
            uxAddress1Label.Text = "Address Line 1:";
            // 
            // uxAddress2Label
            // 
            uxAddress2Label.AutoSize = true;
            uxAddress2Label.Location = new Point(99, 210);
            uxAddress2Label.Margin = new Padding(2, 0, 2, 0);
            uxAddress2Label.Name = "uxAddress2Label";
            uxAddress2Label.Size = new Size(86, 15);
            uxAddress2Label.TabIndex = 75;
            uxAddress2Label.Text = "Address Line 2:";
            // 
            // uxHeightFeetLabel
            // 
            uxHeightFeetLabel.AutoSize = true;
            uxHeightFeetLabel.Location = new Point(112, 239);
            uxHeightFeetLabel.Margin = new Padding(2, 0, 2, 0);
            uxHeightFeetLabel.Name = "uxHeightFeetLabel";
            uxHeightFeetLabel.Size = new Size(74, 15);
            uxHeightFeetLabel.TabIndex = 74;
            uxHeightFeetLabel.Text = "Height(feet):";
            // 
            // uxHeightInchesLabel
            // 
            uxHeightInchesLabel.AutoSize = true;
            uxHeightInchesLabel.Location = new Point(102, 275);
            uxHeightInchesLabel.Margin = new Padding(2, 0, 2, 0);
            uxHeightInchesLabel.Name = "uxHeightInchesLabel";
            uxHeightInchesLabel.Size = new Size(88, 15);
            uxHeightInchesLabel.TabIndex = 73;
            uxHeightInchesLabel.Text = "Height(inches):";
            // 
            // uxWeightLabel
            // 
            uxWeightLabel.AutoSize = true;
            uxWeightLabel.Location = new Point(138, 305);
            uxWeightLabel.Margin = new Padding(2, 0, 2, 0);
            uxWeightLabel.Name = "uxWeightLabel";
            uxWeightLabel.Size = new Size(48, 15);
            uxWeightLabel.TabIndex = 72;
            uxWeightLabel.Text = "Weight:";
            // 
            // uxDonorCB
            // 
            uxDonorCB.AutoSize = true;
            uxDonorCB.Location = new Point(213, 391);
            uxDonorCB.Name = "uxDonorCB";
            uxDonorCB.Size = new Size(45, 19);
            uxDonorCB.TabIndex = 97;
            uxDonorCB.Text = "YES";
            uxDonorCB.UseVisualStyleBackColor = true;
            // 
            // uxCityTB
            // 
            uxCityTB.Location = new Point(202, 120);
            uxCityTB.Name = "uxCityTB";
            uxCityTB.Size = new Size(159, 23);
            uxCityTB.TabIndex = 98;
            // 
            // uxZIPTB
            // 
            uxZIPTB.Location = new Point(202, 149);
            uxZIPTB.Name = "uxZIPTB";
            uxZIPTB.Size = new Size(56, 23);
            uxZIPTB.TabIndex = 99;
            // 
            // uxADL1TB
            // 
            uxADL1TB.Location = new Point(202, 180);
            uxADL1TB.Name = "uxADL1TB";
            uxADL1TB.Size = new Size(159, 23);
            uxADL1TB.TabIndex = 100;
            // 
            // uxADL2TB
            // 
            uxADL2TB.Location = new Point(202, 210);
            uxADL2TB.Name = "uxADL2TB";
            uxADL2TB.Size = new Size(159, 23);
            uxADL2TB.TabIndex = 101;
            // 
            // uxHeightFeetTB
            // 
            uxHeightFeetTB.Location = new Point(202, 239);
            uxHeightFeetTB.Name = "uxHeightFeetTB";
            uxHeightFeetTB.Size = new Size(29, 23);
            uxHeightFeetTB.TabIndex = 102;
            // 
            // uxHeightInchesTB
            // 
            uxHeightInchesTB.Location = new Point(202, 268);
            uxHeightInchesTB.Name = "uxHeightInchesTB";
            uxHeightInchesTB.Size = new Size(29, 23);
            uxHeightInchesTB.TabIndex = 103;
            // 
            // uxWeightTB
            // 
            uxWeightTB.Location = new Point(202, 305);
            uxWeightTB.Name = "uxWeightTB";
            uxWeightTB.Size = new Size(40, 23);
            uxWeightTB.TabIndex = 104;
            // 
            // uxExpDateTB
            // 
            uxExpDateTB.Location = new Point(202, 333);
            uxExpDateTB.Name = "uxExpDateTB";
            uxExpDateTB.Size = new Size(159, 23);
            uxExpDateTB.TabIndex = 105;
            // 
            // uxClassTB
            // 
            uxClassTB.Location = new Point(202, 362);
            uxClassTB.Name = "uxClassTB";
            uxClassTB.Size = new Size(29, 23);
            uxClassTB.TabIndex = 106;
            // 
            // uxBackBT
            // 
            uxBackBT.BackColor = SystemColors.GradientActiveCaption;
            uxBackBT.Location = new Point(41, 430);
            uxBackBT.Margin = new Padding(2);
            uxBackBT.Name = "uxBackBT";
            uxBackBT.Size = new Size(101, 40);
            uxBackBT.TabIndex = 107;
            uxBackBT.Text = "Back";
            uxBackBT.UseVisualStyleBackColor = false;
            uxBackBT.Click += uxBackBT_Click;
            // 
            // LicenseInformationInsertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(402, 492);
            Controls.Add(uxBackBT);
            Controls.Add(uxClassTB);
            Controls.Add(uxExpDateTB);
            Controls.Add(uxWeightTB);
            Controls.Add(uxHeightInchesTB);
            Controls.Add(uxHeightFeetTB);
            Controls.Add(uxADL2TB);
            Controls.Add(uxADL1TB);
            Controls.Add(uxZIPTB);
            Controls.Add(uxCityTB);
            Controls.Add(uxDonorCB);
            Controls.Add(uxExpDateLabel);
            Controls.Add(uxClassLabel);
            Controls.Add(uxDonorStatusLabel);
            Controls.Add(uxInsertBT);
            Controls.Add(uxCityLabel);
            Controls.Add(uxZipLabel);
            Controls.Add(uxAddress1Label);
            Controls.Add(uxAddress2Label);
            Controls.Add(uxHeightFeetLabel);
            Controls.Add(uxHeightInchesLabel);
            Controls.Add(uxWeightLabel);
            Margin = new Padding(2);
            Name = "LicenseInformationInsertForm";
            Text = "License Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label uxExpDateLabel;
        private Label uxClassLabel;
        private Label uxDonorStatusLabel;
        private Button uxInsertBT;
        private Label uxCityLabel;
        private Label uxZipLabel;
        private Label uxAddress1Label;
        private Label uxAddress2Label;
        private Label uxHeightFeetLabel;
        private Label uxHeightInchesLabel;
        private Label uxWeightLabel;
        private CheckBox uxDonorCB;
        private TextBox uxCityTB;
        private TextBox uxZIPTB;
        private TextBox uxADL1TB;
        private TextBox uxADL2TB;
        private TextBox uxHeightFeetTB;
        private TextBox uxHeightInchesTB;
        private TextBox uxWeightTB;
        private TextBox uxExpDateTB;
        private TextBox uxClassTB;
        private Button uxBackBT;
    }
}