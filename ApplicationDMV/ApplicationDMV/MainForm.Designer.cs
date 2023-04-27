namespace ApplicationDMV
{
    partial class MainForm
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
            uxInsertRdButton = new Button();
            uxInsertVehiclesLIButton = new Button();
            uxInsertButton = new Label();
            uxSearchLabel = new Label();
            uxSearchRDButton = new Button();
            uxSearchLIButton = new Button();
            uxSearchVehiclesButton = new Button();
            uxWelcomeLabel = new Label();
            uxMenInsuredInKansasBT = new Button();
            uxStatsLB = new Label();
            SuspendLayout();
            // 
            // uxInsertRdButton
            // 
            uxInsertRdButton.BackColor = SystemColors.GradientActiveCaption;
            uxInsertRdButton.ImeMode = ImeMode.NoControl;
            uxInsertRdButton.Location = new Point(94, 191);
            uxInsertRdButton.Margin = new Padding(2, 2, 2, 2);
            uxInsertRdButton.Name = "uxInsertRdButton";
            uxInsertRdButton.Size = new Size(102, 50);
            uxInsertRdButton.TabIndex = 18;
            uxInsertRdButton.Text = "Registered Drivers";
            uxInsertRdButton.UseVisualStyleBackColor = false;
            uxInsertRdButton.Click += uxInsertRdButton_Click;
            // 
            // uxInsertVehiclesLIButton
            // 
            uxInsertVehiclesLIButton.BackColor = SystemColors.GradientActiveCaption;
            uxInsertVehiclesLIButton.ImeMode = ImeMode.NoControl;
            uxInsertVehiclesLIButton.Location = new Point(228, 191);
            uxInsertVehiclesLIButton.Margin = new Padding(2, 2, 2, 2);
            uxInsertVehiclesLIButton.Name = "uxInsertVehiclesLIButton";
            uxInsertVehiclesLIButton.Size = new Size(226, 50);
            uxInsertVehiclesLIButton.TabIndex = 16;
            uxInsertVehiclesLIButton.Text = "Vehicles/License Information";
            uxInsertVehiclesLIButton.UseVisualStyleBackColor = false;
            uxInsertVehiclesLIButton.Click += uxInsertVehicleButton_Click;
            // 
            // uxInsertButton
            // 
            uxInsertButton.AutoSize = true;
            uxInsertButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            uxInsertButton.ImeMode = ImeMode.NoControl;
            uxInsertButton.Location = new Point(94, 164);
            uxInsertButton.Margin = new Padding(2, 0, 2, 0);
            uxInsertButton.Name = "uxInsertButton";
            uxInsertButton.Size = new Size(43, 15);
            uxInsertButton.TabIndex = 15;
            uxInsertButton.Text = "Insert:";
            // 
            // uxSearchLabel
            // 
            uxSearchLabel.AutoSize = true;
            uxSearchLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            uxSearchLabel.ImeMode = ImeMode.NoControl;
            uxSearchLabel.Location = new Point(92, 65);
            uxSearchLabel.Margin = new Padding(2, 0, 2, 0);
            uxSearchLabel.Name = "uxSearchLabel";
            uxSearchLabel.Size = new Size(48, 15);
            uxSearchLabel.TabIndex = 14;
            uxSearchLabel.Text = "Search:";
            // 
            // uxSearchRDButton
            // 
            uxSearchRDButton.BackColor = SystemColors.GradientActiveCaption;
            uxSearchRDButton.ImeMode = ImeMode.NoControl;
            uxSearchRDButton.Location = new Point(94, 92);
            uxSearchRDButton.Margin = new Padding(2, 2, 2, 2);
            uxSearchRDButton.Name = "uxSearchRDButton";
            uxSearchRDButton.Size = new Size(102, 50);
            uxSearchRDButton.TabIndex = 13;
            uxSearchRDButton.Text = "Registered Drivers";
            uxSearchRDButton.UseVisualStyleBackColor = false;
            uxSearchRDButton.Click += uxSearchRDButton_Click;
            // 
            // uxSearchLIButton
            // 
            uxSearchLIButton.BackColor = SystemColors.GradientActiveCaption;
            uxSearchLIButton.ImeMode = ImeMode.NoControl;
            uxSearchLIButton.Location = new Point(355, 92);
            uxSearchLIButton.Margin = new Padding(2, 2, 2, 2);
            uxSearchLIButton.Name = "uxSearchLIButton";
            uxSearchLIButton.Size = new Size(99, 50);
            uxSearchLIButton.TabIndex = 12;
            uxSearchLIButton.Text = "License Infomation";
            uxSearchLIButton.UseVisualStyleBackColor = false;
            uxSearchLIButton.Click += uxSearchLIButton_Click;
            // 
            // uxSearchVehiclesButton
            // 
            uxSearchVehiclesButton.BackColor = SystemColors.GradientActiveCaption;
            uxSearchVehiclesButton.ImeMode = ImeMode.NoControl;
            uxSearchVehiclesButton.Location = new Point(228, 92);
            uxSearchVehiclesButton.Margin = new Padding(2, 2, 2, 2);
            uxSearchVehiclesButton.Name = "uxSearchVehiclesButton";
            uxSearchVehiclesButton.Size = new Size(101, 50);
            uxSearchVehiclesButton.TabIndex = 11;
            uxSearchVehiclesButton.Text = "Vehicles";
            uxSearchVehiclesButton.UseVisualStyleBackColor = false;
            uxSearchVehiclesButton.Click += uxSearchVehiclesButton_Click;
            // 
            // uxWelcomeLabel
            // 
            uxWelcomeLabel.AutoSize = true;
            uxWelcomeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            uxWelcomeLabel.ImeMode = ImeMode.NoControl;
            uxWelcomeLabel.Location = new Point(11, 28);
            uxWelcomeLabel.Margin = new Padding(2, 0, 2, 0);
            uxWelcomeLabel.Name = "uxWelcomeLabel";
            uxWelcomeLabel.Size = new Size(497, 15);
            uxWelcomeLabel.TabIndex = 10;
            uxWelcomeLabel.Text = "Welcome to the DMV database. Selecting a search option will allow the ability to update.";
            // 
            // uxMenInsuredInKansasBT
            // 
            uxMenInsuredInKansasBT.BackColor = SystemColors.GradientActiveCaption;
            uxMenInsuredInKansasBT.ImeMode = ImeMode.NoControl;
            uxMenInsuredInKansasBT.Location = new Point(94, 279);
            uxMenInsuredInKansasBT.Margin = new Padding(2, 2, 2, 2);
            uxMenInsuredInKansasBT.Name = "uxMenInsuredInKansasBT";
            uxMenInsuredInKansasBT.Size = new Size(360, 50);
            uxMenInsuredInKansasBT.TabIndex = 20;
            uxMenInsuredInKansasBT.Text = "Show Which Insurance is Most Popular Among Men in Kansas";
            uxMenInsuredInKansasBT.UseVisualStyleBackColor = false;
            uxMenInsuredInKansasBT.Click += uxMenInsuredInKansasBT_Click;
            // 
            // uxStatsLB
            // 
            uxStatsLB.AutoSize = true;
            uxStatsLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            uxStatsLB.ImeMode = ImeMode.NoControl;
            uxStatsLB.Location = new Point(92, 262);
            uxStatsLB.Margin = new Padding(2, 0, 2, 0);
            uxStatsLB.Name = "uxStatsLB";
            uxStatsLB.Size = new Size(60, 15);
            uxStatsLB.TabIndex = 23;
            uxStatsLB.Text = "Statistics:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(553, 452);
            Controls.Add(uxStatsLB);
            Controls.Add(uxMenInsuredInKansasBT);
            Controls.Add(uxInsertRdButton);
            Controls.Add(uxInsertVehiclesLIButton);
            Controls.Add(uxInsertButton);
            Controls.Add(uxSearchLabel);
            Controls.Add(uxSearchRDButton);
            Controls.Add(uxSearchLIButton);
            Controls.Add(uxSearchVehiclesButton);
            Controls.Add(uxWelcomeLabel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "StartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxInsertRdButton;
        private Button uxInsertVehiclesLIButton;
        private Label uxInsertButton;
        private Label uxSearchLabel;
        private Button uxSearchRDButton;
        private Button uxSearchLIButton;
        private Button uxSearchVehiclesButton;
        private Label uxWelcomeLabel;
        private Button uxMenInsuredInKansasBT;
        private Label uxStatsLB;
    }
}