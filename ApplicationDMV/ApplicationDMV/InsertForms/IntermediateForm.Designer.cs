namespace ApplicationDMV.InsertForms
{
    partial class IntermediateForm
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
            this.components = new System.ComponentModel.Container();
            this.uxVehicleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxDLNumberTB = new System.Windows.Forms.MaskedTextBox();
            this.uxLIButton = new System.Windows.Forms.Button();
            this.uxHomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxVehicleButton
            // 
            this.uxVehicleButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxVehicleButton.Enabled = false;
            this.uxVehicleButton.Location = new System.Drawing.Point(98, 214);
            this.uxVehicleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxVehicleButton.Name = "uxVehicleButton";
            this.uxVehicleButton.Size = new System.Drawing.Size(113, 49);
            this.uxVehicleButton.TabIndex = 0;
            this.uxVehicleButton.Text = "Add Vehicle";
            this.uxVehicleButton.UseVisualStyleBackColor = false;
            this.uxVehicleButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter the driver\'s license number of the target person:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uxDLNumberTB
            // 
            this.uxDLNumberTB.Location = new System.Drawing.Point(137, 130);
            this.uxDLNumberTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxDLNumberTB.Name = "uxDLNumberTB";
            this.uxDLNumberTB.Size = new System.Drawing.Size(200, 27);
            this.uxDLNumberTB.TabIndex = 3;
            // 
            // uxLIButton
            // 
            this.uxLIButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxLIButton.Enabled = false;
            this.uxLIButton.Location = new System.Drawing.Point(266, 214);
            this.uxLIButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxLIButton.Name = "uxLIButton";
            this.uxLIButton.Size = new System.Drawing.Size(113, 49);
            this.uxLIButton.TabIndex = 4;
            this.uxLIButton.Text = "Add License Information";
            this.uxLIButton.UseVisualStyleBackColor = false;
            this.uxLIButton.Click += new System.EventHandler(this.uxLIButton_Click);
            // 
            // uxHomeButton
            // 
            this.uxHomeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uxHomeButton.Location = new System.Drawing.Point(182, 282);
            this.uxHomeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxHomeButton.Name = "uxHomeButton";
            this.uxHomeButton.Size = new System.Drawing.Size(113, 49);
            this.uxHomeButton.TabIndex = 5;
            this.uxHomeButton.Text = "Return to Home";
            this.uxHomeButton.UseVisualStyleBackColor = false;
            this.uxHomeButton.Click += new System.EventHandler(this.uxHomeButton_Click);
            // 
            // IntermediateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(499, 360);
            this.Controls.Add(this.uxHomeButton);
            this.Controls.Add(this.uxLIButton);
            this.Controls.Add(this.uxDLNumberTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxVehicleButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IntermediateForm";
            this.Text = "Associated Driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button uxVehicleButton;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private MaskedTextBox uxDLNumberTB;
        private Button uxLIButton;
        private Button uxHomeButton;
    }
}