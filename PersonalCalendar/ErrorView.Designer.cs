namespace PersonalCalendar
{
    partial class ErrorView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(59, 14);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(29, 13);
            this.ErrorLabel.TabIndex = 0;
            this.ErrorLabel.Text = "Error";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(-1, 43);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(150, 13);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "There has been a time conflict";
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(35, 111);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton.TabIndex = 2;
            this.ContinueButton.Text = "OK";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ErrorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Name = "ErrorView";
            this.Size = new System.Drawing.Size(148, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button ContinueButton;
    }
}
