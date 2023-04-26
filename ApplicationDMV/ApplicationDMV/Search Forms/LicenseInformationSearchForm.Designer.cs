namespace ApplicationDMV.Search_Forms
{
    partial class LicenseInformationSearchForm
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
            uxSearchButton = new Button();
            uxBackButton = new Button();
            uxStateLabel = new Label();
            uxCityLabel = new Label();
            uxZipLabel = new Label();
            uxAddress1Label = new Label();
            uxAddress2Label = new Label();
            uxHeightFeetLabel = new Label();
            uxHeightInchesLabel = new Label();
            uxWeightLabel = new Label();
            uxClassLabel = new Label();
            uxLNLabel = new Label();
            uxDLNumberTB = new TextBox();
            uxStateTB = new TextBox();
            uxCityTB = new TextBox();
            uxZIPTB = new TextBox();
            uxADL1TB = new TextBox();
            uxADL2TB = new TextBox();
            uxFeetTB = new TextBox();
            uxInchesTB = new TextBox();
            uxWeightTB = new TextBox();
            uxClassTB = new TextBox();
            SuspendLayout();
            // 
            // uxSearchButton
            // 
            uxSearchButton.BackColor = SystemColors.GradientActiveCaption;
            uxSearchButton.Location = new Point(276, 408);
            uxSearchButton.Margin = new Padding(2);
            uxSearchButton.Name = "uxSearchButton";
            uxSearchButton.Size = new Size(101, 40);
            uxSearchButton.TabIndex = 63;
            uxSearchButton.Text = "Search";
            uxSearchButton.UseVisualStyleBackColor = false;
            uxSearchButton.Click += uxSearchButton_Click;
            // 
            // uxBackButton
            // 
            uxBackButton.BackColor = SystemColors.GradientActiveCaption;
            uxBackButton.Location = new Point(23, 408);
            uxBackButton.Margin = new Padding(2);
            uxBackButton.Name = "uxBackButton";
            uxBackButton.Size = new Size(101, 40);
            uxBackButton.TabIndex = 62;
            uxBackButton.Text = "Back";
            uxBackButton.UseVisualStyleBackColor = false;
            uxBackButton.Click += uxBackButton_Click;
            // 
            // uxStateLabel
            // 
            uxStateLabel.AutoSize = true;
            uxStateLabel.Location = new Point(143, 68);
            uxStateLabel.Margin = new Padding(2, 0, 2, 0);
            uxStateLabel.Name = "uxStateLabel";
            uxStateLabel.Size = new Size(36, 15);
            uxStateLabel.TabIndex = 51;
            uxStateLabel.Text = "State:";
            uxStateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxCityLabel
            // 
            uxCityLabel.AutoSize = true;
            uxCityLabel.Location = new Point(148, 97);
            uxCityLabel.Margin = new Padding(2, 0, 2, 0);
            uxCityLabel.Name = "uxCityLabel";
            uxCityLabel.Size = new Size(31, 15);
            uxCityLabel.TabIndex = 50;
            uxCityLabel.Text = "City:";
            // 
            // uxZipLabel
            // 
            uxZipLabel.AutoSize = true;
            uxZipLabel.Location = new Point(119, 133);
            uxZipLabel.Margin = new Padding(2, 0, 2, 0);
            uxZipLabel.Name = "uxZipLabel";
            uxZipLabel.Size = new Size(58, 15);
            uxZipLabel.TabIndex = 49;
            uxZipLabel.Text = "Zip Code:";
            // 
            // uxAddress1Label
            // 
            uxAddress1Label.AutoSize = true;
            uxAddress1Label.Location = new Point(91, 168);
            uxAddress1Label.Margin = new Padding(2, 0, 2, 0);
            uxAddress1Label.Name = "uxAddress1Label";
            uxAddress1Label.Size = new Size(86, 15);
            uxAddress1Label.TabIndex = 48;
            uxAddress1Label.Text = "Address Line 1:";
            // 
            // uxAddress2Label
            // 
            uxAddress2Label.AutoSize = true;
            uxAddress2Label.Location = new Point(91, 204);
            uxAddress2Label.Margin = new Padding(2, 0, 2, 0);
            uxAddress2Label.Name = "uxAddress2Label";
            uxAddress2Label.Size = new Size(86, 15);
            uxAddress2Label.TabIndex = 47;
            uxAddress2Label.Text = "Address Line 2:";
            // 
            // uxHeightFeetLabel
            // 
            uxHeightFeetLabel.AutoSize = true;
            uxHeightFeetLabel.Location = new Point(103, 241);
            uxHeightFeetLabel.Margin = new Padding(2, 0, 2, 0);
            uxHeightFeetLabel.Name = "uxHeightFeetLabel";
            uxHeightFeetLabel.Size = new Size(74, 15);
            uxHeightFeetLabel.TabIndex = 46;
            uxHeightFeetLabel.Text = "Height(feet):";
            // 
            // uxHeightInchesLabel
            // 
            uxHeightInchesLabel.AutoSize = true;
            uxHeightInchesLabel.Location = new Point(91, 276);
            uxHeightInchesLabel.Margin = new Padding(2, 0, 2, 0);
            uxHeightInchesLabel.Name = "uxHeightInchesLabel";
            uxHeightInchesLabel.Size = new Size(88, 15);
            uxHeightInchesLabel.TabIndex = 45;
            uxHeightInchesLabel.Text = "Height(inches):";
            // 
            // uxWeightLabel
            // 
            uxWeightLabel.AutoSize = true;
            uxWeightLabel.Location = new Point(129, 311);
            uxWeightLabel.Margin = new Padding(2, 0, 2, 0);
            uxWeightLabel.Name = "uxWeightLabel";
            uxWeightLabel.Size = new Size(48, 15);
            uxWeightLabel.TabIndex = 44;
            uxWeightLabel.Text = "Weight:";
            // 
            // uxClassLabel
            // 
            uxClassLabel.AutoSize = true;
            uxClassLabel.Location = new Point(138, 342);
            uxClassLabel.Margin = new Padding(2, 0, 2, 0);
            uxClassLabel.Name = "uxClassLabel";
            uxClassLabel.Size = new Size(37, 15);
            uxClassLabel.TabIndex = 65;
            uxClassLabel.Text = "Class:";
            // 
            // uxLNLabel
            // 
            uxLNLabel.AutoSize = true;
            uxLNLabel.Location = new Point(81, 41);
            uxLNLabel.Margin = new Padding(2, 0, 2, 0);
            uxLNLabel.Name = "uxLNLabel";
            uxLNLabel.Size = new Size(96, 15);
            uxLNLabel.TabIndex = 42;
            uxLNLabel.Text = "License Number:";
            // 
            // uxDLNumberTB
            // 
            uxDLNumberTB.Location = new Point(206, 33);
            uxDLNumberTB.Name = "uxDLNumberTB";
            uxDLNumberTB.Size = new Size(155, 23);
            uxDLNumberTB.TabIndex = 67;
            // 
            // uxStateTB
            // 
            uxStateTB.Location = new Point(206, 65);
            uxStateTB.Name = "uxStateTB";
            uxStateTB.Size = new Size(37, 23);
            uxStateTB.TabIndex = 68;
            // 
            // uxCityTB
            // 
            uxCityTB.Location = new Point(206, 97);
            uxCityTB.Name = "uxCityTB";
            uxCityTB.Size = new Size(155, 23);
            uxCityTB.TabIndex = 69;
            // 
            // uxZIPTB
            // 
            uxZIPTB.Location = new Point(206, 130);
            uxZIPTB.Name = "uxZIPTB";
            uxZIPTB.Size = new Size(55, 23);
            uxZIPTB.TabIndex = 70;
            // 
            // uxADL1TB
            // 
            uxADL1TB.Location = new Point(206, 165);
            uxADL1TB.Name = "uxADL1TB";
            uxADL1TB.Size = new Size(155, 23);
            uxADL1TB.TabIndex = 71;
            // 
            // uxADL2TB
            // 
            uxADL2TB.Location = new Point(206, 201);
            uxADL2TB.Name = "uxADL2TB";
            uxADL2TB.Size = new Size(155, 23);
            uxADL2TB.TabIndex = 72;
            // 
            // uxFeetTB
            // 
            uxFeetTB.Location = new Point(206, 238);
            uxFeetTB.Name = "uxFeetTB";
            uxFeetTB.Size = new Size(37, 23);
            uxFeetTB.TabIndex = 73;
            // 
            // uxInchesTB
            // 
            uxInchesTB.Location = new Point(206, 273);
            uxInchesTB.Name = "uxInchesTB";
            uxInchesTB.Size = new Size(37, 23);
            uxInchesTB.TabIndex = 74;
            // 
            // uxWeightTB
            // 
            uxWeightTB.Location = new Point(206, 308);
            uxWeightTB.Name = "uxWeightTB";
            uxWeightTB.Size = new Size(37, 23);
            uxWeightTB.TabIndex = 75;
            // 
            // uxClassTB
            // 
            uxClassTB.Location = new Point(206, 339);
            uxClassTB.Name = "uxClassTB";
            uxClassTB.Size = new Size(22, 23);
            uxClassTB.TabIndex = 76;
            // 
            // LicenseInformationSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(401, 459);
            Controls.Add(uxClassTB);
            Controls.Add(uxWeightTB);
            Controls.Add(uxInchesTB);
            Controls.Add(uxFeetTB);
            Controls.Add(uxADL2TB);
            Controls.Add(uxADL1TB);
            Controls.Add(uxZIPTB);
            Controls.Add(uxCityTB);
            Controls.Add(uxStateTB);
            Controls.Add(uxDLNumberTB);
            Controls.Add(uxClassLabel);
            Controls.Add(uxSearchButton);
            Controls.Add(uxBackButton);
            Controls.Add(uxStateLabel);
            Controls.Add(uxCityLabel);
            Controls.Add(uxZipLabel);
            Controls.Add(uxAddress1Label);
            Controls.Add(uxAddress2Label);
            Controls.Add(uxHeightFeetLabel);
            Controls.Add(uxHeightInchesLabel);
            Controls.Add(uxWeightLabel);
            Controls.Add(uxLNLabel);
            Margin = new Padding(2);
            Name = "LicenseInformationSearchForm";
            Text = "License Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxSearchButton;
        private Button uxBackButton;
        private Label uxStateLabel;
        private Label uxCityLabel;
        private Label uxZipLabel;
        private Label uxAddress1Label;
        private Label uxAddress2Label;
        private Label uxHeightFeetLabel;
        private Label uxHeightInchesLabel;
        private Label uxWeightLabel;
        private Label uxClassLabel;
        private Label uxLNLabel;
        private TextBox uxDLNumberTB;
        private TextBox uxStateTB;
        private TextBox uxCityTB;
        private TextBox uxZIPTB;
        private TextBox uxADL1TB;
        private TextBox uxADL2TB;
        private TextBox uxFeetTB;
        private TextBox uxInchesTB;
        private TextBox uxWeightTB;
        private TextBox uxClassTB;
    }
}