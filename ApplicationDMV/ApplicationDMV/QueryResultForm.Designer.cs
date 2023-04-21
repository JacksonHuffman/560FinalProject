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
            this.uxHomeButton = new System.Windows.Forms.Button();
            this.uxNumResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxResultsListBox
            // 
            this.uxResultsListBox.FormattingEnabled = true;
            this.uxResultsListBox.ItemHeight = 20;
            this.uxResultsListBox.Location = new System.Drawing.Point(158, 50);
            this.uxResultsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxResultsListBox.Name = "uxResultsListBox";
            this.uxResultsListBox.Size = new System.Drawing.Size(290, 204);
            this.uxResultsListBox.TabIndex = 0;
            // 
            // uxResultLabel
            // 
            this.uxResultLabel.AutoSize = true;
            this.uxResultLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxResultLabel.Location = new System.Drawing.Point(158, 9);
            this.uxResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxResultLabel.Name = "uxResultLabel";
            this.uxResultLabel.Size = new System.Drawing.Size(195, 20);
            this.uxResultLabel.TabIndex = 1;
            this.uxResultLabel.Text = "Placeholder for the criteria";
            // 
            // uxUpdateButton
            // 
            this.uxUpdateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxUpdateButton.Enabled = false;
            this.uxUpdateButton.Location = new System.Drawing.Point(333, 323);
            this.uxUpdateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxUpdateButton.Name = "uxUpdateButton";
            this.uxUpdateButton.Size = new System.Drawing.Size(115, 54);
            this.uxUpdateButton.TabIndex = 65;
            this.uxUpdateButton.Text = "Update";
            this.uxUpdateButton.UseVisualStyleBackColor = false;
            // 
            // uxHomeButton
            // 
            this.uxHomeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxHomeButton.Location = new System.Drawing.Point(158, 323);
            this.uxHomeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxHomeButton.Name = "uxHomeButton";
            this.uxHomeButton.Size = new System.Drawing.Size(115, 54);
            this.uxHomeButton.TabIndex = 66;
            this.uxHomeButton.Text = "Return to Home";
            this.uxHomeButton.UseVisualStyleBackColor = false;
            this.uxHomeButton.Click += new System.EventHandler(this.uxHomeButton_Click);
            // 
            // uxNumResultsLabel
            // 
            this.uxNumResultsLabel.AutoSize = true;
            this.uxNumResultsLabel.Location = new System.Drawing.Point(158, 267);
            this.uxNumResultsLabel.Name = "uxNumResultsLabel";
            this.uxNumResultsLabel.Size = new System.Drawing.Size(325, 20);
            this.uxNumResultsLabel.TabIndex = 67;
            this.uxNumResultsLabel.Text = "placeholder for the number of records retrieved";
            // 
            // QueryResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(640, 430);
            this.Controls.Add(this.uxNumResultsLabel);
            this.Controls.Add(this.uxHomeButton);
            this.Controls.Add(this.uxUpdateButton);
            this.Controls.Add(this.uxResultLabel);
            this.Controls.Add(this.uxResultsListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QueryResultForm";
            this.Text = "QueryResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox uxResultsListBox;
        private Label uxResultLabel;
        private Button uxUpdateButton;
        private Button uxHomeButton;
        private Label uxNumResultsLabel;
    }
}