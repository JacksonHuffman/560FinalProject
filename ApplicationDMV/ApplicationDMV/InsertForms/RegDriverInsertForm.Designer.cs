namespace ApplicationDMV.InsertForms
{
    partial class RegDriverInsertForm
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
            uxBackButton = new Button();
            uxFNLabel = new Label();
            uxLNLabel = new Label();
            uxMNLabel = new Label();
            uxDOBLabel = new Label();
            uxSexLabel = new Label();
            uxDLNLabel = new Label();
            uxInsertButton = new Button();
            uxFNTB = new TextBox();
            uxMNTB = new TextBox();
            uxLNTB = new TextBox();
            uxDOBTB = new TextBox();
            uxSexTB = new TextBox();
            SuspendLayout();
            // 
            // uxBackButton
            // 
            uxBackButton.BackColor = SystemColors.GradientActiveCaption;
            uxBackButton.Location = new Point(57, 245);
            uxBackButton.Margin = new Padding(2);
            uxBackButton.Name = "uxBackButton";
            uxBackButton.Size = new Size(101, 40);
            uxBackButton.TabIndex = 28;
            uxBackButton.Text = "Back";
            uxBackButton.UseVisualStyleBackColor = false;
            uxBackButton.Click += uxBackButton_Click;
            // 
            // uxFNLabel
            // 
            uxFNLabel.AutoSize = true;
            uxFNLabel.Location = new Point(72, 52);
            uxFNLabel.Margin = new Padding(2, 0, 2, 0);
            uxFNLabel.Name = "uxFNLabel";
            uxFNLabel.Size = new Size(67, 15);
            uxFNLabel.TabIndex = 21;
            uxFNLabel.Text = "First Name:";
            // 
            // uxLNLabel
            // 
            uxLNLabel.AutoSize = true;
            uxLNLabel.Location = new Point(73, 114);
            uxLNLabel.Margin = new Padding(2, 0, 2, 0);
            uxLNLabel.Name = "uxLNLabel";
            uxLNLabel.Size = new Size(66, 15);
            uxLNLabel.TabIndex = 20;
            uxLNLabel.Text = "Last Name:";
            // 
            // uxMNLabel
            // 
            uxMNLabel.AutoSize = true;
            uxMNLabel.Location = new Point(57, 83);
            uxMNLabel.Margin = new Padding(2, 0, 2, 0);
            uxMNLabel.Name = "uxMNLabel";
            uxMNLabel.Size = new Size(82, 15);
            uxMNLabel.TabIndex = 19;
            uxMNLabel.Text = "Middle Name:";
            // 
            // uxDOBLabel
            // 
            uxDOBLabel.AutoSize = true;
            uxDOBLabel.Location = new Point(63, 144);
            uxDOBLabel.Margin = new Padding(2, 0, 2, 0);
            uxDOBLabel.Name = "uxDOBLabel";
            uxDOBLabel.Size = new Size(76, 15);
            uxDOBLabel.TabIndex = 18;
            uxDOBLabel.Text = "Date of Birth:";
            // 
            // uxSexLabel
            // 
            uxSexLabel.AutoSize = true;
            uxSexLabel.Location = new Point(111, 176);
            uxSexLabel.Margin = new Padding(2, 0, 2, 0);
            uxSexLabel.Name = "uxSexLabel";
            uxSexLabel.Size = new Size(28, 15);
            uxSexLabel.TabIndex = 17;
            uxSexLabel.Text = "Sex:";
            // 
            // uxDLNLabel
            // 
            uxDLNLabel.AutoSize = true;
            uxDLNLabel.Location = new Point(57, 47);
            uxDLNLabel.Margin = new Padding(2, 0, 2, 0);
            uxDLNLabel.Name = "uxDLNLabel";
            uxDLNLabel.Size = new Size(0, 15);
            uxDLNLabel.TabIndex = 16;
            // 
            // uxInsertButton
            // 
            uxInsertButton.BackColor = SystemColors.GradientActiveCaption;
            uxInsertButton.Location = new Point(229, 245);
            uxInsertButton.Margin = new Padding(2);
            uxInsertButton.Name = "uxInsertButton";
            uxInsertButton.Size = new Size(101, 40);
            uxInsertButton.TabIndex = 15;
            uxInsertButton.Text = "Insert";
            uxInsertButton.UseVisualStyleBackColor = false;
            uxInsertButton.Click += uxInsertButton_Click;
            // 
            // uxFNTB
            // 
            uxFNTB.Location = new Point(192, 48);
            uxFNTB.Name = "uxFNTB";
            uxFNTB.Size = new Size(138, 23);
            uxFNTB.TabIndex = 29;
            // 
            // uxMNTB
            // 
            uxMNTB.Location = new Point(192, 80);
            uxMNTB.Name = "uxMNTB";
            uxMNTB.Size = new Size(138, 23);
            uxMNTB.TabIndex = 30;
            // 
            // uxLNTB
            // 
            uxLNTB.Location = new Point(192, 114);
            uxLNTB.Name = "uxLNTB";
            uxLNTB.Size = new Size(138, 23);
            uxLNTB.TabIndex = 31;
            // 
            // uxDOBTB
            // 
            uxDOBTB.Location = new Point(192, 144);
            uxDOBTB.Name = "uxDOBTB";
            uxDOBTB.Size = new Size(138, 23);
            uxDOBTB.TabIndex = 32;
            // 
            // uxSexTB
            // 
            uxSexTB.Location = new Point(192, 173);
            uxSexTB.Name = "uxSexTB";
            uxSexTB.Size = new Size(34, 23);
            uxSexTB.TabIndex = 33;
            // 
            // RegDriverInsertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(387, 309);
            Controls.Add(uxSexTB);
            Controls.Add(uxDOBTB);
            Controls.Add(uxLNTB);
            Controls.Add(uxMNTB);
            Controls.Add(uxFNTB);
            Controls.Add(uxBackButton);
            Controls.Add(uxFNLabel);
            Controls.Add(uxLNLabel);
            Controls.Add(uxMNLabel);
            Controls.Add(uxDOBLabel);
            Controls.Add(uxSexLabel);
            Controls.Add(uxDLNLabel);
            Controls.Add(uxInsertButton);
            Margin = new Padding(2);
            Name = "RegDriverInsertForm";
            Text = "Registered Driver Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxBackButton;
        private TextBox uxDLNTB;
        private Label uxFNLabel;
        private Label uxLNLabel;
        private Label uxMNLabel;
        private Label uxDOBLabel;
        private Label uxSexLabel;
        private Label uxDLNLabel;
        private Button uxInsertButton;
        private TextBox uxFNTB;
        private TextBox uxMNTB;
        private TextBox uxLNTB;
        private TextBox uxDOBTB;
        private TextBox uxSexTB;
    }
}