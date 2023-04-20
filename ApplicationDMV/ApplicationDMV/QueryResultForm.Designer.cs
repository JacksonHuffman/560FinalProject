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
            this.uxResultsListBox = new System.Windows.Forms.ListBox();
            this.uxResultLabel = new System.Windows.Forms.Label();
            this.uxUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxResultsListBox
            // 
            this.uxResultsListBox.FormattingEnabled = true;
            this.uxResultsListBox.ItemHeight = 25;
            this.uxResultsListBox.Location = new System.Drawing.Point(198, 63);
            this.uxResultsListBox.Name = "uxResultsListBox";
            this.uxResultsListBox.Size = new System.Drawing.Size(362, 254);
            this.uxResultsListBox.TabIndex = 0;
            // 
            // uxResultLabel
            // 
            this.uxResultLabel.AutoSize = true;
            this.uxResultLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxResultLabel.Location = new System.Drawing.Point(326, 24);
            this.uxResultLabel.Name = "uxResultLabel";
            this.uxResultLabel.Size = new System.Drawing.Size(112, 25);
            this.uxResultLabel.TabIndex = 1;
            this.uxResultLabel.Text = "Placeholder";
            // 
            // uxUpdateButton
            // 
            this.uxUpdateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxUpdateButton.Enabled = false;
            this.uxUpdateButton.Location = new System.Drawing.Point(309, 338);
            this.uxUpdateButton.Name = "uxUpdateButton";
            this.uxUpdateButton.Size = new System.Drawing.Size(144, 67);
            this.uxUpdateButton.TabIndex = 65;
            this.uxUpdateButton.Text = "Update";
            this.uxUpdateButton.UseVisualStyleBackColor = false;
            // 
            // QueryResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxUpdateButton);
            this.Controls.Add(this.uxResultLabel);
            this.Controls.Add(this.uxResultsListBox);
            this.Name = "QueryResultForm";
            this.Text = "QueryResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox uxResultsListBox;
        private Label uxResultLabel;
        private Button uxUpdateButton;
    }
}