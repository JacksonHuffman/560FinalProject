namespace ApplicationDMV
{
    partial class RegDriverSearchForm
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
            uxSearchButton = new Button();
            uxSexLabel = new Label();
            uxMNLabel = new Label();
            uxLNLabel = new Label();
            uxFNLabel = new Label();
            uxBackButton = new Button();
            uxFNTB = new TextBox();
            uxMNTB = new TextBox();
            uxLNTB = new TextBox();
            uxSexTB = new TextBox();
            SuspendLayout();
            // 
            // uxSearchButton
            // 
            uxSearchButton.BackColor = SystemColors.GradientActiveCaption;
            uxSearchButton.Location = new Point(273, 267);
            uxSearchButton.Margin = new Padding(2);
            uxSearchButton.Name = "uxSearchButton";
            uxSearchButton.Size = new Size(101, 40);
            uxSearchButton.TabIndex = 0;
            uxSearchButton.Text = "Search";
            uxSearchButton.UseVisualStyleBackColor = false;
            uxSearchButton.Click += uxSearchButton_Click;
            // 
            // uxSexLabel
            // 
            uxSexLabel.AutoSize = true;
            uxSexLabel.Location = new Point(148, 177);
            uxSexLabel.Margin = new Padding(2, 0, 2, 0);
            uxSexLabel.Name = "uxSexLabel";
            uxSexLabel.Size = new Size(28, 15);
            uxSexLabel.TabIndex = 3;
            uxSexLabel.Text = "Sex:";
            // 
            // uxMNLabel
            // 
            uxMNLabel.AutoSize = true;
            uxMNLabel.Location = new Point(95, 104);
            uxMNLabel.Margin = new Padding(2, 0, 2, 0);
            uxMNLabel.Name = "uxMNLabel";
            uxMNLabel.Size = new Size(82, 15);
            uxMNLabel.TabIndex = 5;
            uxMNLabel.Text = "Middle Name:";
            // 
            // uxLNLabel
            // 
            uxLNLabel.AutoSize = true;
            uxLNLabel.Location = new Point(110, 141);
            uxLNLabel.Margin = new Padding(2, 0, 2, 0);
            uxLNLabel.Name = "uxLNLabel";
            uxLNLabel.Size = new Size(66, 15);
            uxLNLabel.TabIndex = 6;
            uxLNLabel.Text = "Last Name:";
            // 
            // uxFNLabel
            // 
            uxFNLabel.AutoSize = true;
            uxFNLabel.Location = new Point(110, 69);
            uxFNLabel.Margin = new Padding(2, 0, 2, 0);
            uxFNLabel.Name = "uxFNLabel";
            uxFNLabel.Size = new Size(67, 15);
            uxFNLabel.TabIndex = 7;
            uxFNLabel.Text = "First Name:";
            // 
            // uxBackButton
            // 
            uxBackButton.BackColor = SystemColors.GradientActiveCaption;
            uxBackButton.Location = new Point(49, 267);
            uxBackButton.Margin = new Padding(2);
            uxBackButton.Name = "uxBackButton";
            uxBackButton.Size = new Size(101, 40);
            uxBackButton.TabIndex = 14;
            uxBackButton.Text = "Back";
            uxBackButton.UseVisualStyleBackColor = false;
            uxBackButton.Click += uxBackButton_Click;
            // 
            // uxFNTB
            // 
            uxFNTB.Location = new Point(213, 66);
            uxFNTB.Name = "uxFNTB";
            uxFNTB.Size = new Size(161, 23);
            uxFNTB.TabIndex = 16;
            // 
            // uxMNTB
            // 
            uxMNTB.Location = new Point(213, 101);
            uxMNTB.Name = "uxMNTB";
            uxMNTB.Size = new Size(161, 23);
            uxMNTB.TabIndex = 17;
            // 
            // uxLNTB
            // 
            uxLNTB.Location = new Point(213, 138);
            uxLNTB.Name = "uxLNTB";
            uxLNTB.Size = new Size(161, 23);
            uxLNTB.TabIndex = 18;
            // 
            // uxSexTB
            // 
            uxSexTB.Location = new Point(213, 174);
            uxSexTB.Name = "uxSexTB";
            uxSexTB.Size = new Size(35, 23);
            uxSexTB.TabIndex = 19;
            // 
            // RegDriverSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(406, 349);
            Controls.Add(uxSexTB);
            Controls.Add(uxLNTB);
            Controls.Add(uxMNTB);
            Controls.Add(uxFNTB);
            Controls.Add(uxBackButton);
            Controls.Add(uxFNLabel);
            Controls.Add(uxLNLabel);
            Controls.Add(uxMNLabel);
            Controls.Add(uxSexLabel);
            Controls.Add(uxSearchButton);
            Margin = new Padding(2);
            Name = "RegDriverSearchForm";
            Text = "Registered Driver Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxSearchButton;
        private Label uxSexLabel;
        private Label uxMNLabel;
        private Label uxLNLabel;
        private Label uxFNLabel;
        private Button uxBackButton;
        private TextBox uxFNTB;
        private TextBox uxMNTB;
        private TextBox uxLNTB;
        private TextBox uxSexTB;
    }
}