namespace ApplicationDMV.InsertForms
{
    partial class InsertNewManufacturer
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
            uxAddingNewMakeLB = new Label();
            uxAddQuestionLB = new Label();
            uxAddBT = new Button();
            uxBackBT = new Button();
            SuspendLayout();
            // 
            // uxAddingNewMakeLB
            // 
            uxAddingNewMakeLB.AutoSize = true;
            uxAddingNewMakeLB.Location = new Point(11, 18);
            uxAddingNewMakeLB.Name = "uxAddingNewMakeLB";
            uxAddingNewMakeLB.Size = new Size(383, 15);
            uxAddingNewMakeLB.TabIndex = 0;
            uxAddingNewMakeLB.Text = "The 'Make' of the vehicle doesn't match with any of our manufacturers.";
            // 
            // uxAddQuestionLB
            // 
            uxAddQuestionLB.AutoSize = true;
            uxAddQuestionLB.Location = new Point(24, 46);
            uxAddQuestionLB.Name = "uxAddQuestionLB";
            uxAddQuestionLB.Size = new Size(357, 15);
            uxAddQuestionLB.TabIndex = 1;
            uxAddQuestionLB.Text = "Would you like to add this as a new manufacturer in our database?";
            // 
            // uxAddBT
            // 
            uxAddBT.BackColor = SystemColors.GradientActiveCaption;
            uxAddBT.Location = new Point(243, 93);
            uxAddBT.Name = "uxAddBT";
            uxAddBT.Size = new Size(121, 37);
            uxAddBT.TabIndex = 5;
            uxAddBT.Text = "Add and Continue";
            uxAddBT.UseVisualStyleBackColor = false;
            uxAddBT.Click += uxAddBT_Click;
            // 
            // uxBackBT
            // 
            uxBackBT.BackColor = SystemColors.GradientActiveCaption;
            uxBackBT.Location = new Point(36, 93);
            uxBackBT.Name = "uxBackBT";
            uxBackBT.Size = new Size(121, 37);
            uxBackBT.TabIndex = 6;
            uxBackBT.Text = "Back";
            uxBackBT.UseVisualStyleBackColor = false;
            uxBackBT.Click += uxBackBT_Click;
            // 
            // InsertNewManufacturer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 153);
            Controls.Add(uxBackBT);
            Controls.Add(uxAddBT);
            Controls.Add(uxAddQuestionLB);
            Controls.Add(uxAddingNewMakeLB);
            Name = "InsertNewManufacturer";
            Text = "InsertNewManufacturer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxAddingNewMakeLB;
        private Label uxAddQuestionLB;
        private Button uxAddBT;
        private Button uxBackBT;
    }
}