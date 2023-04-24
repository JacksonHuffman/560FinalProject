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
            this.uxInsertRdButton = new System.Windows.Forms.Button();
            this.uxInsertVehiclesLIButton = new System.Windows.Forms.Button();
            this.uxInsertButton = new System.Windows.Forms.Label();
            this.uxSearchLabel = new System.Windows.Forms.Label();
            this.uxSearchRDButton = new System.Windows.Forms.Button();
            this.uxSearchLIButton = new System.Windows.Forms.Button();
            this.uxSearchVehiclesButton = new System.Windows.Forms.Button();
            this.uxWelcomeLabel = new System.Windows.Forms.Label();
            this.uxAggregatedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxInsertRdButton
            // 
            this.uxInsertRdButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxInsertRdButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxInsertRdButton.Location = new System.Drawing.Point(134, 319);
            this.uxInsertRdButton.Name = "uxInsertRdButton";
            this.uxInsertRdButton.Size = new System.Drawing.Size(146, 84);
            this.uxInsertRdButton.TabIndex = 18;
            this.uxInsertRdButton.Text = "Registered Drivers";
            this.uxInsertRdButton.UseVisualStyleBackColor = false;
            this.uxInsertRdButton.Click += new System.EventHandler(this.uxInsertRdButton_Click);
            // 
            // uxInsertVehiclesLIButton
            // 
            this.uxInsertVehiclesLIButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxInsertVehiclesLIButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxInsertVehiclesLIButton.Location = new System.Drawing.Point(326, 319);
            this.uxInsertVehiclesLIButton.Name = "uxInsertVehiclesLIButton";
            this.uxInsertVehiclesLIButton.Size = new System.Drawing.Size(323, 84);
            this.uxInsertVehiclesLIButton.TabIndex = 16;
            this.uxInsertVehiclesLIButton.Text = "Vehicles/License Information";
            this.uxInsertVehiclesLIButton.UseVisualStyleBackColor = false;
            this.uxInsertVehiclesLIButton.Click += new System.EventHandler(this.uxInsertVehicleButton_Click);
            // 
            // uxInsertButton
            // 
            this.uxInsertButton.AutoSize = true;
            this.uxInsertButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxInsertButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxInsertButton.Location = new System.Drawing.Point(134, 273);
            this.uxInsertButton.Name = "uxInsertButton";
            this.uxInsertButton.Size = new System.Drawing.Size(67, 25);
            this.uxInsertButton.TabIndex = 15;
            this.uxInsertButton.Text = "Insert:";
            // 
            // uxSearchLabel
            // 
            this.uxSearchLabel.AutoSize = true;
            this.uxSearchLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxSearchLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxSearchLabel.Location = new System.Drawing.Point(132, 108);
            this.uxSearchLabel.Name = "uxSearchLabel";
            this.uxSearchLabel.Size = new System.Drawing.Size(74, 25);
            this.uxSearchLabel.TabIndex = 14;
            this.uxSearchLabel.Text = "Search:";
            // 
            // uxSearchRDButton
            // 
            this.uxSearchRDButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxSearchRDButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxSearchRDButton.Location = new System.Drawing.Point(134, 154);
            this.uxSearchRDButton.Name = "uxSearchRDButton";
            this.uxSearchRDButton.Size = new System.Drawing.Size(146, 84);
            this.uxSearchRDButton.TabIndex = 13;
            this.uxSearchRDButton.Text = "Registered Drivers";
            this.uxSearchRDButton.UseVisualStyleBackColor = false;
            this.uxSearchRDButton.Click += new System.EventHandler(this.uxSearchRDButton_Click);
            // 
            // uxSearchLIButton
            // 
            this.uxSearchLIButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxSearchLIButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxSearchLIButton.Location = new System.Drawing.Point(507, 154);
            this.uxSearchLIButton.Name = "uxSearchLIButton";
            this.uxSearchLIButton.Size = new System.Drawing.Size(142, 84);
            this.uxSearchLIButton.TabIndex = 12;
            this.uxSearchLIButton.Text = "License Infomation";
            this.uxSearchLIButton.UseVisualStyleBackColor = false;
            this.uxSearchLIButton.Click += new System.EventHandler(this.uxSearchLIButton_Click);
            // 
            // uxSearchVehiclesButton
            // 
            this.uxSearchVehiclesButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxSearchVehiclesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxSearchVehiclesButton.Location = new System.Drawing.Point(326, 154);
            this.uxSearchVehiclesButton.Name = "uxSearchVehiclesButton";
            this.uxSearchVehiclesButton.Size = new System.Drawing.Size(144, 84);
            this.uxSearchVehiclesButton.TabIndex = 11;
            this.uxSearchVehiclesButton.Text = "Vehicles";
            this.uxSearchVehiclesButton.UseVisualStyleBackColor = false;
            this.uxSearchVehiclesButton.Click += new System.EventHandler(this.uxSearchVehiclesButton_Click);
            // 
            // uxWelcomeLabel
            // 
            this.uxWelcomeLabel.AutoSize = true;
            this.uxWelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxWelcomeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxWelcomeLabel.Location = new System.Drawing.Point(16, 47);
            this.uxWelcomeLabel.Name = "uxWelcomeLabel";
            this.uxWelcomeLabel.Size = new System.Drawing.Size(768, 25);
            this.uxWelcomeLabel.TabIndex = 10;
            this.uxWelcomeLabel.Text = "Welcome to the DMV database. Selecting a search option will allow the ability to " +
    "update.";
            // 
            // uxAggregatedButton
            // 
            this.uxAggregatedButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxAggregatedButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxAggregatedButton.Location = new System.Drawing.Point(134, 489);
            this.uxAggregatedButton.Name = "uxAggregatedButton";
            this.uxAggregatedButton.Size = new System.Drawing.Size(515, 84);
            this.uxAggregatedButton.TabIndex = 20;
            this.uxAggregatedButton.Text = "Aggregated queries";
            this.uxAggregatedButton.UseVisualStyleBackColor = false;
            this.uxAggregatedButton.Click += new System.EventHandler(this.uxAggregatedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(132, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Insert:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(790, 754);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxAggregatedButton);
            this.Controls.Add(this.uxInsertRdButton);
            this.Controls.Add(this.uxInsertVehiclesLIButton);
            this.Controls.Add(this.uxInsertButton);
            this.Controls.Add(this.uxSearchLabel);
            this.Controls.Add(this.uxSearchRDButton);
            this.Controls.Add(this.uxSearchLIButton);
            this.Controls.Add(this.uxSearchVehiclesButton);
            this.Controls.Add(this.uxWelcomeLabel);
            this.Name = "MainForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button uxAggregatedButton;
        private Label label1;
    }
}