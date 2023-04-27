namespace ApplicationDMV.InsertForms
{
    partial class GoToUpdateLicenseForm
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
            uxPromptToGoToUpdateFormLB = new Label();
            uxGoToUpdateBT = new Button();
            uxBackBT = new Button();
            SuspendLayout();
            // 
            // uxPromptToGoToUpdateFormLB
            // 
            uxPromptToGoToUpdateFormLB.AutoSize = true;
            uxPromptToGoToUpdateFormLB.Location = new Point(24, 18);
            uxPromptToGoToUpdateFormLB.Name = "uxPromptToGoToUpdateFormLB";
            uxPromptToGoToUpdateFormLB.Size = new Size(288, 15);
            uxPromptToGoToUpdateFormLB.TabIndex = 0;
            uxPromptToGoToUpdateFormLB.Text = "This driver already has an existing license in this state.";
            // 
            // uxGoToUpdateBT
            // 
            uxGoToUpdateBT.BackColor = SystemColors.GradientActiveCaption;
            uxGoToUpdateBT.Location = new Point(231, 63);
            uxGoToUpdateBT.Margin = new Padding(2);
            uxGoToUpdateBT.Name = "uxGoToUpdateBT";
            uxGoToUpdateBT.Size = new Size(101, 40);
            uxGoToUpdateBT.TabIndex = 92;
            uxGoToUpdateBT.Text = "Go Update";
            uxGoToUpdateBT.UseVisualStyleBackColor = false;
            uxGoToUpdateBT.Click += uxGoToUpdateBT_Click;
            // 
            // uxBackBT
            // 
            uxBackBT.BackColor = SystemColors.GradientActiveCaption;
            uxBackBT.Location = new Point(24, 63);
            uxBackBT.Margin = new Padding(2);
            uxBackBT.Name = "uxBackBT";
            uxBackBT.Size = new Size(101, 40);
            uxBackBT.TabIndex = 93;
            uxBackBT.Text = "Back";
            uxBackBT.UseVisualStyleBackColor = false;
            uxBackBT.Click += uxBackBT_Click;
            // 
            // GoToUpdateLicenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 123);
            Controls.Add(uxBackBT);
            Controls.Add(uxGoToUpdateBT);
            Controls.Add(uxPromptToGoToUpdateFormLB);
            Name = "GoToUpdateLicenseForm";
            Text = "GoToUpdateLicenseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxPromptToGoToUpdateFormLB;
        private Button uxGoToUpdateBT;
        private Button uxBackBT;
    }
}