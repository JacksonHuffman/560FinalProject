namespace ApplicationDMV.InsertForms
{
    partial class NavigateToRegisteredDriverInsertForm
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
            uxNoRegDriverLB = new Label();
            uxNavigateToRegDriverInsertFormBT = new Button();
            uxBackBT = new Button();
            SuspendLayout();
            // 
            // uxNoRegDriverLB
            // 
            uxNoRegDriverLB.AutoSize = true;
            uxNoRegDriverLB.Location = new Point(12, 9);
            uxNoRegDriverLB.Name = "uxNoRegDriverLB";
            uxNoRegDriverLB.Size = new Size(476, 15);
            uxNoRegDriverLB.TabIndex = 0;
            uxNoRegDriverLB.Text = "The driver you are trying to insert information for doesn't exists. Please choose an option!";
            // 
            // uxNavigateToRegDriverInsertFormBT
            // 
            uxNavigateToRegDriverInsertFormBT.BackColor = SystemColors.GradientActiveCaption;
            uxNavigateToRegDriverInsertFormBT.Location = new Point(376, 70);
            uxNavigateToRegDriverInsertFormBT.Margin = new Padding(2);
            uxNavigateToRegDriverInsertFormBT.Name = "uxNavigateToRegDriverInsertFormBT";
            uxNavigateToRegDriverInsertFormBT.Size = new Size(101, 40);
            uxNavigateToRegDriverInsertFormBT.TabIndex = 63;
            uxNavigateToRegDriverInsertFormBT.Text = "Insert Driver";
            uxNavigateToRegDriverInsertFormBT.UseVisualStyleBackColor = false;
            uxNavigateToRegDriverInsertFormBT.Click += uxNavigateToRegDriverInsertFormBT_Click;
            // 
            // uxBackBT
            // 
            uxBackBT.BackColor = SystemColors.GradientActiveCaption;
            uxBackBT.Location = new Point(38, 70);
            uxBackBT.Margin = new Padding(2);
            uxBackBT.Name = "uxBackBT";
            uxBackBT.Size = new Size(101, 40);
            uxBackBT.TabIndex = 64;
            uxBackBT.Text = "Back";
            uxBackBT.UseVisualStyleBackColor = false;
            uxBackBT.Click += uxBackBT_Click;
            // 
            // NavigateToRegisteredDriverInsertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 121);
            Controls.Add(uxBackBT);
            Controls.Add(uxNavigateToRegDriverInsertFormBT);
            Controls.Add(uxNoRegDriverLB);
            Name = "NavigateToRegisteredDriverInsertForm";
            Text = "NavigateToRegisteredDriverInsertForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxNoRegDriverLB;
        private Button uxNavigateToRegDriverInsertFormBT;
        private Button uxBackBT;
    }
}