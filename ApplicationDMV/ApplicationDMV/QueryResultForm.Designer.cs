namespace ApplicationDMV
{
    partial class QueryResultForm
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
            uxResultsListBox = new ListBox();
            uxUpdateBT = new Button();
            uxBackBT = new Button();
            uxNumResultsLB = new Label();
            uxHomeBT = new Button();
            SuspendLayout();
            // 
            // uxResultsListBox
            // 
            uxResultsListBox.FormattingEnabled = true;
            uxResultsListBox.ItemHeight = 15;
            uxResultsListBox.Location = new Point(12, 27);
            uxResultsListBox.Margin = new Padding(2);
            uxResultsListBox.Name = "uxResultsListBox";
            uxResultsListBox.Size = new Size(714, 139);
            uxResultsListBox.TabIndex = 0;
            // 
            // uxUpdateBT
            // 
            uxUpdateBT.BackColor = SystemColors.GradientActiveCaption;
            uxUpdateBT.Location = new Point(401, 256);
            uxUpdateBT.Margin = new Padding(2);
            uxUpdateBT.Name = "uxUpdateBT";
            uxUpdateBT.Size = new Size(101, 40);
            uxUpdateBT.TabIndex = 65;
            uxUpdateBT.Text = "Update";
            uxUpdateBT.UseVisualStyleBackColor = false;
            uxUpdateBT.Click += uxUpdateBT_Click;
            // 
            // uxBackBT
            // 
            uxBackBT.BackColor = SystemColors.GradientActiveCaption;
            uxBackBT.Location = new Point(66, 256);
            uxBackBT.Margin = new Padding(2);
            uxBackBT.Name = "uxBackBT";
            uxBackBT.Size = new Size(101, 40);
            uxBackBT.TabIndex = 66;
            uxBackBT.Text = "Back";
            uxBackBT.UseVisualStyleBackColor = false;
            uxBackBT.Click += uxBackBT_Click;
            // 
            // uxNumResultsLB
            // 
            uxNumResultsLB.AutoSize = true;
            uxNumResultsLB.Location = new Point(12, 224);
            uxNumResultsLB.Name = "uxNumResultsLB";
            uxNumResultsLB.Size = new Size(110, 15);
            uxNumResultsLB.TabIndex = 67;
            uxNumResultsLB.Text = "Number of Records";
            // 
            // uxHomeBT
            // 
            uxHomeBT.BackColor = SystemColors.GradientActiveCaption;
            uxHomeBT.Location = new Point(232, 256);
            uxHomeBT.Margin = new Padding(2);
            uxHomeBT.Name = "uxHomeBT";
            uxHomeBT.Size = new Size(101, 40);
            uxHomeBT.TabIndex = 68;
            uxHomeBT.Text = "Return to Home";
            uxHomeBT.UseVisualStyleBackColor = false;
            uxHomeBT.Click += uxHomeBT_Click;
            // 
            // QueryResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(746, 308);
            Controls.Add(uxHomeBT);
            Controls.Add(uxNumResultsLB);
            Controls.Add(uxBackBT);
            Controls.Add(uxUpdateBT);
            Controls.Add(uxResultsListBox);
            Margin = new Padding(2);
            Name = "QueryResultForm";
            Text = "QueryResultForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox uxResultsListBox;
        private Label uxResultLabel;
        private Button uxUpdateBT;
        private Button uxBackBT;
        private Label uxNumResultsLB;
        private Button uxHomeBT;
    }
}