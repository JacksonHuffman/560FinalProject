namespace ApplicationDMV.Search_Forms
{
    partial class VehicleSearchForm
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
            uxColorLabel = new Label();
            uxPlateLabel = new Label();
            uxPolicyLabel = new Label();
            uxInsuranceLabel = new Label();
            uxMakeLabel = new Label();
            uxModelLabel = new Label();
            uxYearLabel = new Label();
            uxVINLabel = new Label();
            uxBackButton = new Button();
            uxSearchButton = new Button();
            uxVINTB = new TextBox();
            uxColorTB = new TextBox();
            uxPlateNumTB = new TextBox();
            uxPolicyNumTB = new TextBox();
            uxInsuranceTB = new TextBox();
            uxMakeTB = new TextBox();
            uxModelTB = new TextBox();
            uxYearTB = new TextBox();
            SuspendLayout();
            // 
            // uxColorLabel
            // 
            uxColorLabel.AutoSize = true;
            uxColorLabel.Location = new Point(141, 108);
            uxColorLabel.Margin = new Padding(2, 0, 2, 0);
            uxColorLabel.Name = "uxColorLabel";
            uxColorLabel.Size = new Size(39, 15);
            uxColorLabel.TabIndex = 29;
            uxColorLabel.Text = "Color:";
            uxColorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxPlateLabel
            // 
            uxPlateLabel.AutoSize = true;
            uxPlateLabel.Location = new Point(97, 136);
            uxPlateLabel.Margin = new Padding(2, 0, 2, 0);
            uxPlateLabel.Name = "uxPlateLabel";
            uxPlateLabel.Size = new Size(83, 15);
            uxPlateLabel.TabIndex = 28;
            uxPlateLabel.Text = "Plate Number:";
            // 
            // uxPolicyLabel
            // 
            uxPolicyLabel.AutoSize = true;
            uxPolicyLabel.Location = new Point(88, 165);
            uxPolicyLabel.Margin = new Padding(2, 0, 2, 0);
            uxPolicyLabel.Name = "uxPolicyLabel";
            uxPolicyLabel.Size = new Size(89, 15);
            uxPolicyLabel.TabIndex = 27;
            uxPolicyLabel.Text = "Policy Number:";
            // 
            // uxInsuranceLabel
            // 
            uxInsuranceLabel.AutoSize = true;
            uxInsuranceLabel.Location = new Point(72, 198);
            uxInsuranceLabel.Margin = new Padding(2, 0, 2, 0);
            uxInsuranceLabel.Name = "uxInsuranceLabel";
            uxInsuranceLabel.Size = new Size(108, 15);
            uxInsuranceLabel.TabIndex = 24;
            uxInsuranceLabel.Text = "Insurance Provider:";
            // 
            // uxMakeLabel
            // 
            uxMakeLabel.AutoSize = true;
            uxMakeLabel.Location = new Point(141, 229);
            uxMakeLabel.Margin = new Padding(2, 0, 2, 0);
            uxMakeLabel.Name = "uxMakeLabel";
            uxMakeLabel.Size = new Size(39, 15);
            uxMakeLabel.TabIndex = 23;
            uxMakeLabel.Text = "Make:";
            // 
            // uxModelLabel
            // 
            uxModelLabel.AutoSize = true;
            uxModelLabel.Location = new Point(136, 259);
            uxModelLabel.Margin = new Padding(2, 0, 2, 0);
            uxModelLabel.Name = "uxModelLabel";
            uxModelLabel.Size = new Size(44, 15);
            uxModelLabel.TabIndex = 22;
            uxModelLabel.Text = "Model:";
            // 
            // uxYearLabel
            // 
            uxYearLabel.AutoSize = true;
            uxYearLabel.Location = new Point(148, 292);
            uxYearLabel.Margin = new Padding(2, 0, 2, 0);
            uxYearLabel.Name = "uxYearLabel";
            uxYearLabel.Size = new Size(32, 15);
            uxYearLabel.TabIndex = 21;
            uxYearLabel.Text = "Year:";
            // 
            // uxVINLabel
            // 
            uxVINLabel.AutoSize = true;
            uxVINLabel.Location = new Point(151, 77);
            uxVINLabel.Margin = new Padding(2, 0, 2, 0);
            uxVINLabel.Name = "uxVINLabel";
            uxVINLabel.Size = new Size(29, 15);
            uxVINLabel.TabIndex = 20;
            uxVINLabel.Text = "VIN:";
            // 
            // uxBackButton
            // 
            uxBackButton.BackColor = SystemColors.GradientActiveCaption;
            uxBackButton.Location = new Point(38, 319);
            uxBackButton.Margin = new Padding(2);
            uxBackButton.Name = "uxBackButton";
            uxBackButton.Size = new Size(101, 40);
            uxBackButton.TabIndex = 40;
            uxBackButton.Text = "Back";
            uxBackButton.UseVisualStyleBackColor = false;
            uxBackButton.Click += uxBackButton_Click;
            // 
            // uxSearchButton
            // 
            uxSearchButton.BackColor = SystemColors.GradientActiveCaption;
            uxSearchButton.Location = new Point(253, 319);
            uxSearchButton.Margin = new Padding(2);
            uxSearchButton.Name = "uxSearchButton";
            uxSearchButton.Size = new Size(101, 40);
            uxSearchButton.TabIndex = 41;
            uxSearchButton.Text = "Search";
            uxSearchButton.UseVisualStyleBackColor = false;
            uxSearchButton.Click += uxSearchButton_Click;
            // 
            // uxVINTB
            // 
            uxVINTB.Location = new Point(201, 74);
            uxVINTB.Name = "uxVINTB";
            uxVINTB.Size = new Size(172, 23);
            uxVINTB.TabIndex = 42;
            // 
            // uxColorTB
            // 
            uxColorTB.Location = new Point(201, 103);
            uxColorTB.Name = "uxColorTB";
            uxColorTB.Size = new Size(172, 23);
            uxColorTB.TabIndex = 43;
            // 
            // uxPlateNumTB
            // 
            uxPlateNumTB.Location = new Point(201, 132);
            uxPlateNumTB.Name = "uxPlateNumTB";
            uxPlateNumTB.Size = new Size(172, 23);
            uxPlateNumTB.TabIndex = 44;
            // 
            // uxPolicyNumTB
            // 
            uxPolicyNumTB.Location = new Point(201, 161);
            uxPolicyNumTB.Name = "uxPolicyNumTB";
            uxPolicyNumTB.Size = new Size(172, 23);
            uxPolicyNumTB.TabIndex = 45;
            // 
            // uxInsuranceTB
            // 
            uxInsuranceTB.Location = new Point(201, 195);
            uxInsuranceTB.Name = "uxInsuranceTB";
            uxInsuranceTB.Size = new Size(172, 23);
            uxInsuranceTB.TabIndex = 46;
            // 
            // uxMakeTB
            // 
            uxMakeTB.Location = new Point(201, 226);
            uxMakeTB.Name = "uxMakeTB";
            uxMakeTB.Size = new Size(172, 23);
            uxMakeTB.TabIndex = 47;
            // 
            // uxModelTB
            // 
            uxModelTB.Location = new Point(201, 256);
            uxModelTB.Name = "uxModelTB";
            uxModelTB.Size = new Size(172, 23);
            uxModelTB.TabIndex = 48;
            // 
            // uxYearTB
            // 
            uxYearTB.Location = new Point(201, 285);
            uxYearTB.Name = "uxYearTB";
            uxYearTB.Size = new Size(44, 23);
            uxYearTB.TabIndex = 49;
            // 
            // VehicleSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(385, 380);
            Controls.Add(uxYearTB);
            Controls.Add(uxModelTB);
            Controls.Add(uxMakeTB);
            Controls.Add(uxInsuranceTB);
            Controls.Add(uxPolicyNumTB);
            Controls.Add(uxPlateNumTB);
            Controls.Add(uxColorTB);
            Controls.Add(uxVINTB);
            Controls.Add(uxSearchButton);
            Controls.Add(uxBackButton);
            Controls.Add(uxColorLabel);
            Controls.Add(uxPlateLabel);
            Controls.Add(uxPolicyLabel);
            Controls.Add(uxInsuranceLabel);
            Controls.Add(uxMakeLabel);
            Controls.Add(uxModelLabel);
            Controls.Add(uxYearLabel);
            Controls.Add(uxVINLabel);
            Margin = new Padding(2);
            Name = "VehicleSearchForm";
            Text = "VehicleSearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label uxColorLabel;
        private Label uxPlateLabel;
        private Label uxPolicyLabel;
        private Label uxInsuranceLabel;
        private Label uxMakeLabel;
        private Label uxModelLabel;
        private Label uxYearLabel;
        private Label uxVINLabel;
        private Button uxBackButton;
        private Button uxSearchButton;
        private TextBox uxVINTB;
        private TextBox uxColorTB;
        private TextBox uxPlateNumTB;
        private TextBox uxPolicyNumTB;
        private TextBox uxInsuranceTB;
        private TextBox uxMakeTB;
        private TextBox uxModelTB;
        private TextBox uxYearTB;
    }
}