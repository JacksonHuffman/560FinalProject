namespace ApplicationDMV
{
    partial class AggregatedQueriesForm
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
            this.uxQuery1Button = new System.Windows.Forms.Button();
            this.uxQuery4Button = new System.Windows.Forms.Button();
            this.uxQuery3Button = new System.Windows.Forms.Button();
            this.uxQuery2Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxQuery1Button
            // 
            this.uxQuery1Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxQuery1Button.Location = new System.Drawing.Point(167, 161);
            this.uxQuery1Button.Name = "uxQuery1Button";
            this.uxQuery1Button.Size = new System.Drawing.Size(216, 128);
            this.uxQuery1Button.TabIndex = 4;
            this.uxQuery1Button.Text = "Query 1";
            this.uxQuery1Button.UseVisualStyleBackColor = false;
            //this.uxQuery1Button.Click += new System.EventHandler(this.uxQuery1Button_Click);
            // 
            // uxQuery4Button
            // 
            this.uxQuery4Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxQuery4Button.Location = new System.Drawing.Point(719, 479);
            this.uxQuery4Button.Name = "uxQuery4Button";
            this.uxQuery4Button.Size = new System.Drawing.Size(216, 128);
            this.uxQuery4Button.TabIndex = 5;
            this.uxQuery4Button.Text = "Query 4";
            this.uxQuery4Button.UseVisualStyleBackColor = false;
            //this.uxQuery4Button.Click += new System.EventHandler(this.uxQuery4Button_Click);
            // 
            // uxQuery3Button
            // 
            this.uxQuery3Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxQuery3Button.Location = new System.Drawing.Point(167, 479);
            this.uxQuery3Button.Name = "uxQuery3Button";
            this.uxQuery3Button.Size = new System.Drawing.Size(216, 128);
            this.uxQuery3Button.TabIndex = 6;
            this.uxQuery3Button.Text = "Query 3";
            this.uxQuery3Button.UseVisualStyleBackColor = false;
            //this.uxQuery3Button.Click += new System.EventHandler(this.uxQuery3Button_Click);
            // 
            // uxQuery2Button
            // 
            this.uxQuery2Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxQuery2Button.Location = new System.Drawing.Point(719, 161);
            this.uxQuery2Button.Name = "uxQuery2Button";
            this.uxQuery2Button.Size = new System.Drawing.Size(216, 128);
            this.uxQuery2Button.TabIndex = 7;
            this.uxQuery2Button.Text = "Query 2";
            this.uxQuery2Button.UseVisualStyleBackColor = false;
            //this.uxQuery2Button.Click += new System.EventHandler(this.uxQuery2Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 75);
            this.label1.TabIndex = 8;
            this.label1.Text = "Show all registered drivers in the state of Kansas \r\nthat are expired, ranking th" +
    "em according to which\r\n licenses have been expired the longest.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "Show the number of expiring driver\'s \r\nlicenses for each month in 2016.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 75);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rank the three most popular insurance \r\ncompanies among men for registered \r\ndriv" +
    "ers in the state of Colorado.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 75);
            this.label4.TabIndex = 11;
            this.label4.Text = "Show the number of registered drivers who\r\n drive a gray Toyota Camry and whose t" +
    "ags \r\nexpire in three months.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AggregatedQueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1116, 720);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxQuery2Button);
            this.Controls.Add(this.uxQuery3Button);
            this.Controls.Add(this.uxQuery4Button);
            this.Controls.Add(this.uxQuery1Button);
            this.Name = "AggregatedQueriesForm";
            this.Text = "Aggregated Queries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button uxQuery1Button;
        private Button uxQuery4Button;
        private Button uxQuery3Button;
        private Button uxQuery2Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}