namespace ApplicationDMV.InsertForms
{
    partial class InsertVehicleInformation
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
            uxInsertBT = new Button();
            uxBackButton = new Button();
            this.uxColorLabel = new Label();
            this.uxPlateLabel = new Label();
            this.uxPolicyLabel = new Label();
            this.uxPlateexLabel = new Label();
            this.uxPolicyexLabel = new Label();
            uxInsuruanceLB = new Label();
            uxMakeLB = new Label();
            uxModelLB = new Label();
            uxYearLB = new Label();
            uxVINLB = new Label();
            uxVINTB = new TextBox();
            uxColorTB = new TextBox();
            uxPlateTB = new TextBox();
            uxPolicyTB = new TextBox();
            uxPlateExpTB = new TextBox();
            uxPolicyExpTB = new TextBox();
            uxInsuranceTB = new TextBox();
            uxMakeTB = new TextBox();
            uxModelTB = new TextBox();
            uxYearTB = new TextBox();
            SuspendLayout();
            // 
            // uxInsertBT
            // 
            uxInsertBT.BackColor = SystemColors.GradientActiveCaption;
            uxInsertBT.Location = new Point(282, 357);
            uxInsertBT.Margin = new Padding(2);
            uxInsertBT.Name = "uxInsertBT";
            uxInsertBT.Size = new Size(101, 40);
            uxInsertBT.TabIndex = 63;
            uxInsertBT.Text = "Insert";
            uxInsertBT.UseVisualStyleBackColor = false;
            uxInsertBT.Click += uxInsertBT_Click;
            // 
            // uxBackButton
            // 
            uxBackButton.BackColor = SystemColors.GradientActiveCaption;
            uxBackButton.Location = new Point(77, 357);
            uxBackButton.Margin = new Padding(2);
            uxBackButton.Name = "uxBackButton";
            uxBackButton.Size = new Size(101, 40);
            uxBackButton.TabIndex = 62;
            uxBackButton.Text = "Back";
            uxBackButton.UseVisualStyleBackColor = false;
            uxBackButton.Click += uxBackButton_Click;
            // 
            // uxColorLB
            // 
            this.uxColorLabel.AutoSize = true;
            this.uxColorLabel.Location = new Point(166, 87);
            this.uxColorLabel.Margin = new Padding(2, 0, 2, 0);
            this.uxColorLabel.Name = "uxColorLB";
            this.uxColorLabel.Size = new Size(39, 15);
            this.uxColorLabel.TabIndex = 51;
            this.uxColorLabel.Text = "Color:";
            this.uxColorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxPlateLabel
            // 
            this.uxPlateLabel.AutoSize = true;
            this.uxPlateLabel.Location = new Point(121, 111);
            this.uxPlateLabel.Margin = new Padding(2, 0, 2, 0);
            this.uxPlateLabel.Name = "uxPlateLabel";
            this.uxPlateLabel.Size = new Size(83, 15);
            this.uxPlateLabel.TabIndex = 50;
            this.uxPlateLabel.Text = "Plate Number:";
            // 
            // uxPolicyLB
            // 
            this.uxPolicyLabel.AutoSize = true;
            this.uxPolicyLabel.Location = new Point(116, 138);
            this.uxPolicyLabel.Margin = new Padding(2, 0, 2, 0);
            this.uxPolicyLabel.Name = "uxPolicyLabel";
            this.uxPolicyLabel.Size = new Size(89, 15);
            this.uxPolicyLabel.TabIndex = 49;
            this.uxPolicyLabel.Text = "Policy Number:";
            // 
            // uxPlateexLabel
            // 
            this.uxPlateexLabel.AutoSize = true;
            this.uxPlateexLabel.Location = new Point(85, 167);
            this.uxPlateexLabel.Margin = new Padding(2, 0, 2, 0);
            this.uxPlateexLabel.Name = "uxPlateexLabel";
            this.uxPlateexLabel.Size = new Size(119, 15);
            this.uxPlateexLabel.TabIndex = 48;
            this.uxPlateexLabel.Text = "Plate Expiration Date:";
            // 
            // uxPolicyexLabel
            // 
            this.uxPolicyexLabel.AutoSize = true;
            this.uxPolicyexLabel.Location = new Point(77, 195);
            this.uxPolicyexLabel.Margin = new Padding(2, 0, 2, 0);
            this.uxPolicyexLabel.Name = "uxPolicyexLabel";
            this.uxPolicyexLabel.Size = new Size(125, 15);
            this.uxPolicyexLabel.TabIndex = 47;
            this.uxPolicyexLabel.Text = "Policy Expiration Date:";
            // 
            // uxInsuruanceLB
            // 
            uxInsuruanceLB.AutoSize = true;
            uxInsuruanceLB.Location = new Point(94, 226);
            uxInsuruanceLB.Margin = new Padding(2, 0, 2, 0);
            uxInsuruanceLB.Name = "uxInsuruanceLB";
            uxInsuruanceLB.Size = new Size(108, 15);
            uxInsuruanceLB.TabIndex = 46;
            uxInsuruanceLB.Text = "Insurance Provider:";
            // 
            // uxMakeLB
            // 
            uxMakeLB.AutoSize = true;
            uxMakeLB.Location = new Point(166, 257);
            uxMakeLB.Margin = new Padding(2, 0, 2, 0);
            uxMakeLB.Name = "uxMakeLB";
            uxMakeLB.Size = new Size(39, 15);
            uxMakeLB.TabIndex = 45;
            uxMakeLB.Text = "Make:";
            // 
            // uxModelLB
            // 
            uxModelLB.AutoSize = true;
            uxModelLB.Location = new Point(160, 285);
            uxModelLB.Margin = new Padding(2, 0, 2, 0);
            uxModelLB.Name = "uxModelLB";
            uxModelLB.Size = new Size(44, 15);
            uxModelLB.TabIndex = 44;
            uxModelLB.Text = "Model:";
            // 
            // uxYearLB
            // 
            uxYearLB.AutoSize = true;
            uxYearLB.Location = new Point(173, 317);
            uxYearLB.Margin = new Padding(2, 0, 2, 0);
            uxYearLB.Name = "uxYearLB";
            uxYearLB.Size = new Size(32, 15);
            uxYearLB.TabIndex = 43;
            uxYearLB.Text = "Year:";
            // 
            // uxVINLB
            // 
            uxVINLB.AutoSize = true;
            uxVINLB.Location = new Point(176, 58);
            uxVINLB.Margin = new Padding(2, 0, 2, 0);
            uxVINLB.Name = "uxVINLB";
            uxVINLB.Size = new Size(29, 15);
            uxVINLB.TabIndex = 42;
            uxVINLB.Text = "VIN:";
            // 
            // uxVINTB
            // 
            uxVINTB.Location = new Point(233, 50);
            uxVINTB.Name = "uxVINTB";
            uxVINTB.Size = new Size(159, 23);
            uxVINTB.TabIndex = 64;
            // 
            // uxColorTB
            // 
            uxColorTB.Location = new Point(233, 79);
            uxColorTB.Name = "uxColorTB";
            uxColorTB.Size = new Size(159, 23);
            uxColorTB.TabIndex = 100;
            // 
            // uxPlateTB
            // 
            uxPlateTB.Location = new Point(233, 108);
            uxPlateTB.Name = "uxPlateTB";
            uxPlateTB.Size = new Size(159, 23);
            uxPlateTB.TabIndex = 101;
            // 
            // uxPolicyTB
            // 
            uxPolicyTB.Location = new Point(233, 138);
            uxPolicyTB.Name = "uxPolicyTB";
            uxPolicyTB.Size = new Size(159, 23);
            uxPolicyTB.TabIndex = 102;
            // 
            // uxPlateExpTB
            // 
            uxPlateExpTB.Location = new Point(233, 167);
            uxPlateExpTB.Name = "uxPlateExpTB";
            uxPlateExpTB.Size = new Size(159, 23);
            uxPlateExpTB.TabIndex = 103;
            // 
            // uxPolicyExpTB
            // 
            uxPolicyExpTB.Location = new Point(233, 196);
            uxPolicyExpTB.Name = "uxPolicyExpTB";
            uxPolicyExpTB.Size = new Size(159, 23);
            uxPolicyExpTB.TabIndex = 104;
            // 
            // uxInsuranceTB
            // 
            uxInsuranceTB.Location = new Point(233, 223);
            uxInsuranceTB.Name = "uxInsuranceTB";
            uxInsuranceTB.Size = new Size(159, 23);
            uxInsuranceTB.TabIndex = 105;
            // 
            // uxMakeTB
            // 
            uxMakeTB.Location = new Point(233, 252);
            uxMakeTB.Name = "uxMakeTB";
            uxMakeTB.Size = new Size(159, 23);
            uxMakeTB.TabIndex = 106;
            // 
            // uxModelTB
            // 
            uxModelTB.Location = new Point(233, 281);
            uxModelTB.Name = "uxModelTB";
            uxModelTB.Size = new Size(159, 23);
            uxModelTB.TabIndex = 107;
            // 
            // uxYearTB
            // 
            uxYearTB.Location = new Point(233, 310);
            uxYearTB.Name = "uxYearTB";
            uxYearTB.Size = new Size(49, 23);
            uxYearTB.TabIndex = 108;
            // 
            // InsertVehicleInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(432, 421);
            Controls.Add(uxYearTB);
            Controls.Add(uxModelTB);
            Controls.Add(uxMakeTB);
            Controls.Add(uxInsuranceTB);
            Controls.Add(uxPolicyExpTB);
            Controls.Add(uxPlateExpTB);
            Controls.Add(uxPolicyTB);
            Controls.Add(uxPlateTB);
            Controls.Add(uxColorTB);
            Controls.Add(uxVINTB);
            Controls.Add(uxInsertBT);
            Controls.Add(uxBackButton);
            Controls.Add(this.uxColorLabel);
            Controls.Add(this.uxPlateLabel);
            Controls.Add(this.uxPolicyLabel);
            Controls.Add(this.uxPlateexLabel);
            Controls.Add(this.uxPolicyexLabel);
            Controls.Add(uxInsuruanceLB);
            Controls.Add(uxMakeLB);
            Controls.Add(uxModelLB);
            Controls.Add(uxYearLB);
            Controls.Add(uxVINLB);
            Margin = new Padding(2);
            Name = "InsertVehicleInformation";
            Text = "Vehicle Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxInsertBT;
        private Button uxBackButton;
        private TextBox uxColorTB;
        private TextBox uxPlateTB;
        private TextBox uxPolicyTB;
        private TextBox uxPlateExTB;
        private TextBox uxYearTB;
        private TextBox uxModelTB;
        private TextBox uxMakeTB;
        private TextBox uxPolicyExTB;
        private TextBox uxInsuranceTB;
        private TextBox uxVINTB;
        private Label uxColorLabel;
        private Label uxPlateLabel;
        private Label uxPolicyLabel;
        private Label uxPlateexLabel;
        private Label uxPolicyexLabel;
        private Label uxInsuruanceLB;
        private Label uxMakeLB;
        private Label uxModelLB;
        private Label uxYearLB;
        private Label uxVINLB;
        private TextBox uxPlateExpTB;
        private TextBox uxPolicyExpTB;
    }
}