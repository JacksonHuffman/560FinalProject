namespace ApplicationDMV.InsertForms
{
    partial class InsertDLNumberStateCode
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
            uxDLNumberLB = new Label();
            uxDLNumberTB = new TextBox();
            uxStateCodeLB = new Label();
            uxStateCodeTB = new TextBox();
            uxGoToLicenseInfoBT = new Button();
            SuspendLayout();
            // 
            // uxDLNumberLB
            // 
            uxDLNumberLB.AutoSize = true;
            uxDLNumberLB.Location = new Point(60, 19);
            uxDLNumberLB.Name = "uxDLNumberLB";
            uxDLNumberLB.Size = new Size(279, 15);
            uxDLNumberLB.TabIndex = 0;
            uxDLNumberLB.Text = "Enter the driver's generated driver's license number:";
            // 
            // uxDLNumberTB
            // 
            uxDLNumberTB.Location = new Point(101, 46);
            uxDLNumberTB.Name = "uxDLNumberTB";
            uxDLNumberTB.Size = new Size(190, 23);
            uxDLNumberTB.TabIndex = 1;
            // 
            // uxStateCodeLB
            // 
            uxStateCodeLB.AutoSize = true;
            uxStateCodeLB.Location = new Point(60, 83);
            uxStateCodeLB.Name = "uxStateCodeLB";
            uxStateCodeLB.Size = new Size(273, 15);
            uxStateCodeLB.TabIndex = 2;
            uxStateCodeLB.Text = "Enter the state code for which this license is under:";
            // 
            // uxStateCodeTB
            // 
            uxStateCodeTB.Location = new Point(101, 110);
            uxStateCodeTB.Name = "uxStateCodeTB";
            uxStateCodeTB.Size = new Size(190, 23);
            uxStateCodeTB.TabIndex = 3;
            // 
            // uxGoToLicenseInfoBT
            // 
            uxGoToLicenseInfoBT.BackColor = SystemColors.GradientActiveCaption;
            uxGoToLicenseInfoBT.Location = new Point(140, 150);
            uxGoToLicenseInfoBT.Name = "uxGoToLicenseInfoBT";
            uxGoToLicenseInfoBT.Size = new Size(121, 37);
            uxGoToLicenseInfoBT.TabIndex = 4;
            uxGoToLicenseInfoBT.Text = "Add and Continue";
            uxGoToLicenseInfoBT.UseVisualStyleBackColor = false;
            uxGoToLicenseInfoBT.Click += uxGoToLicenseInfoBT_Click;
            // 
            // InsertDLNumberStateCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(401, 199);
            Controls.Add(uxGoToLicenseInfoBT);
            Controls.Add(uxStateCodeTB);
            Controls.Add(uxStateCodeLB);
            Controls.Add(uxDLNumberTB);
            Controls.Add(uxDLNumberLB);
            Name = "InsertDLNumberStateCode";
            Text = "InsertDLNumberStateCode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxDLNumberLB;
        private TextBox uxDLNumberTB;
        private Label uxStateCodeLB;
        private TextBox uxStateCodeTB;
        private Button uxGoToLicenseInfoBT;
    }
}