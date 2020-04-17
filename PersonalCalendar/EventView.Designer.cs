namespace PersonalCalendar
{
    partial class EventView
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AttendeesLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.NewAttendeesLabel = new System.Windows.Forms.Label();
            this.NewEndTimeLabel = new System.Windows.Forms.Label();
            this.NewStartTimeLabel = new System.Windows.Forms.Label();
            this.NewLocationLabel = new System.Windows.Forms.Label();
            this.NewTitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NewDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(126, 306);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(45, 306);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AttendeesLabel
            // 
            this.AttendeesLabel.AutoSize = true;
            this.AttendeesLabel.Location = new System.Drawing.Point(18, 137);
            this.AttendeesLabel.Name = "AttendeesLabel";
            this.AttendeesLabel.Size = new System.Drawing.Size(58, 13);
            this.AttendeesLabel.TabIndex = 12;
            this.AttendeesLabel.Text = "Attendees:";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(18, 108);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.EndTimeLabel.TabIndex = 10;
            this.EndTimeLabel.Text = "End time:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(18, 81);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(54, 13);
            this.StartTimeLabel.TabIndex = 9;
            this.StartTimeLabel.Text = "Start time:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(18, 52);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationLabel.TabIndex = 8;
            this.LocationLabel.Text = "Location:";
            // 
            // NewAttendeesLabel
            // 
            this.NewAttendeesLabel.AutoSize = true;
            this.NewAttendeesLabel.Location = new System.Drawing.Point(76, 137);
            this.NewAttendeesLabel.Name = "NewAttendeesLabel";
            this.NewAttendeesLabel.Size = new System.Drawing.Size(22, 13);
            this.NewAttendeesLabel.TabIndex = 18;
            this.NewAttendeesLabel.Text = "Me";
            // 
            // NewEndTimeLabel
            // 
            this.NewEndTimeLabel.AutoSize = true;
            this.NewEndTimeLabel.Location = new System.Drawing.Point(76, 108);
            this.NewEndTimeLabel.Name = "NewEndTimeLabel";
            this.NewEndTimeLabel.Size = new System.Drawing.Size(45, 13);
            this.NewEndTimeLabel.TabIndex = 16;
            this.NewEndTimeLabel.Text = "1:00 pm";
            // 
            // NewStartTimeLabel
            // 
            this.NewStartTimeLabel.AutoSize = true;
            this.NewStartTimeLabel.Location = new System.Drawing.Point(75, 81);
            this.NewStartTimeLabel.Name = "NewStartTimeLabel";
            this.NewStartTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.NewStartTimeLabel.TabIndex = 15;
            this.NewStartTimeLabel.Text = "12:00 pm";
            // 
            // NewLocationLabel
            // 
            this.NewLocationLabel.AutoSize = true;
            this.NewLocationLabel.Location = new System.Drawing.Point(75, 52);
            this.NewLocationLabel.Name = "NewLocationLabel";
            this.NewLocationLabel.Size = new System.Drawing.Size(167, 13);
            this.NewLocationLabel.TabIndex = 14;
            this.NewLocationLabel.Text = "McKinley\'s, Downtown Shelbyville";
            // 
            // NewTitleLabel
            // 
            this.NewTitleLabel.Location = new System.Drawing.Point(6, 12);
            this.NewTitleLabel.Name = "NewTitleLabel";
            this.NewTitleLabel.Size = new System.Drawing.Size(236, 13);
            this.NewTitleLabel.TabIndex = 13;
            this.NewTitleLabel.Text = "Lunch";
            this.NewTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(18, 162);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 19;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NewDescriptionTextBox
            // 
            this.NewDescriptionTextBox.Enabled = false;
            this.NewDescriptionTextBox.Location = new System.Drawing.Point(21, 179);
            this.NewDescriptionTextBox.Multiline = true;
            this.NewDescriptionTextBox.Name = "NewDescriptionTextBox";
            this.NewDescriptionTextBox.Size = new System.Drawing.Size(204, 121);
            this.NewDescriptionTextBox.TabIndex = 20;
            // 
            // EventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NewDescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NewAttendeesLabel);
            this.Controls.Add(this.NewEndTimeLabel);
            this.Controls.Add(this.NewStartTimeLabel);
            this.Controls.Add(this.NewLocationLabel);
            this.Controls.Add(this.NewTitleLabel);
            this.Controls.Add(this.AttendeesLabel);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Name = "EventView";
            this.Size = new System.Drawing.Size(246, 343);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label AttendeesLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label NewAttendeesLabel;
        private System.Windows.Forms.Label NewEndTimeLabel;
        private System.Windows.Forms.Label NewStartTimeLabel;
        private System.Windows.Forms.Label NewLocationLabel;
        private System.Windows.Forms.Label NewTitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox NewDescriptionTextBox;
    }
}
