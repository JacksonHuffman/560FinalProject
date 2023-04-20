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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uxWelcomeLabel = new System.Windows.Forms.Label();
            this.uxSearchVehiclesButton = new System.Windows.Forms.Button();
            this.uxSearchLIButton = new System.Windows.Forms.Button();
            this.uxSearchRDButton = new System.Windows.Forms.Button();
            this.uxSearchLabel = new System.Windows.Forms.Label();
            this.uxInsertButton = new System.Windows.Forms.Label();
            this.uxInsertRdButton = new System.Windows.Forms.Button();
            this.uxInsertLicenseButton = new System.Windows.Forms.Button();
            this.uxInsertVehicleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxWelcomeLabel
            // 
            resources.ApplyResources(this.uxWelcomeLabel, "uxWelcomeLabel");
            this.uxWelcomeLabel.Name = "uxWelcomeLabel";
            // 
            // uxSearchVehiclesButton
            // 
            resources.ApplyResources(this.uxSearchVehiclesButton, "uxSearchVehiclesButton");
            this.uxSearchVehiclesButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxSearchVehiclesButton.Name = "uxSearchVehiclesButton";
            this.uxSearchVehiclesButton.UseVisualStyleBackColor = false;
            // 
            // uxSearchLIButton
            // 
            resources.ApplyResources(this.uxSearchLIButton, "uxSearchLIButton");
            this.uxSearchLIButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxSearchLIButton.Name = "uxSearchLIButton";
            this.uxSearchLIButton.UseVisualStyleBackColor = false;
            // 
            // uxSearchRDButton
            // 
            resources.ApplyResources(this.uxSearchRDButton, "uxSearchRDButton");
            this.uxSearchRDButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxSearchRDButton.Name = "uxSearchRDButton";
            this.uxSearchRDButton.UseVisualStyleBackColor = false;
            // 
            // uxSearchLabel
            // 
            resources.ApplyResources(this.uxSearchLabel, "uxSearchLabel");
            this.uxSearchLabel.Name = "uxSearchLabel";
            // 
            // uxInsertButton
            // 
            resources.ApplyResources(this.uxInsertButton, "uxInsertButton");
            this.uxInsertButton.Name = "uxInsertButton";
            // 
            // uxInsertRdButton
            // 
            resources.ApplyResources(this.uxInsertRdButton, "uxInsertRdButton");
            this.uxInsertRdButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxInsertRdButton.Name = "uxInsertRdButton";
            this.uxInsertRdButton.UseVisualStyleBackColor = false;
            // 
            // uxInsertLicenseButton
            // 
            resources.ApplyResources(this.uxInsertLicenseButton, "uxInsertLicenseButton");
            this.uxInsertLicenseButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxInsertLicenseButton.Name = "uxInsertLicenseButton";
            this.uxInsertLicenseButton.UseVisualStyleBackColor = false;
            // 
            // uxInsertVehicleButton
            // 
            resources.ApplyResources(this.uxInsertVehicleButton, "uxInsertVehicleButton");
            this.uxInsertVehicleButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxInsertVehicleButton.Name = "uxInsertVehicleButton";
            this.uxInsertVehicleButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.uxInsertRdButton);
            this.Controls.Add(this.uxInsertLicenseButton);
            this.Controls.Add(this.uxInsertVehicleButton);
            this.Controls.Add(this.uxInsertButton);
            this.Controls.Add(this.uxSearchLabel);
            this.Controls.Add(this.uxSearchRDButton);
            this.Controls.Add(this.uxSearchLIButton);
            this.Controls.Add(this.uxSearchVehiclesButton);
            this.Controls.Add(this.uxWelcomeLabel);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label uxWelcomeLabel;
        private Button uxSearchVehiclesButton;
        private Button uxSearchLIButton;
        private Button uxSearchRDButton;
        private Label uxSearchLabel;
        private Label uxInsertButton;
        private Button uxInsertRdButton;
        private Button uxInsertLicenseButton;
        private Button uxInsertVehicleButton;
    }
}