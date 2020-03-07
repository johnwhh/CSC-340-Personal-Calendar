namespace PersonalCalendar
{
    partial class EventCreationView
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
            this.newEventPanel = new System.Windows.Forms.Panel();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateEventButton = new System.Windows.Forms.Button();
            this.AttendeesTextBox = new System.Windows.Forms.TextBox();
            this.EndTimeTextBox = new System.Windows.Forms.TextBox();
            this.StartTimeTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AttendeesLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NewEventLabel = new System.Windows.Forms.Label();
            this.newEventPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newEventPanel
            // 
            this.newEventPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newEventPanel.Controls.Add(this.DescriptionTextBox);
            this.newEventPanel.Controls.Add(this.DescriptionLabel);
            this.newEventPanel.Controls.Add(this.CancelButton);
            this.newEventPanel.Controls.Add(this.CreateEventButton);
            this.newEventPanel.Controls.Add(this.AttendeesTextBox);
            this.newEventPanel.Controls.Add(this.EndTimeTextBox);
            this.newEventPanel.Controls.Add(this.StartTimeTextBox);
            this.newEventPanel.Controls.Add(this.LocationTextBox);
            this.newEventPanel.Controls.Add(this.TitleTextBox);
            this.newEventPanel.Controls.Add(this.AttendeesLabel);
            this.newEventPanel.Controls.Add(this.EndTimeLabel);
            this.newEventPanel.Controls.Add(this.StartTimeLabel);
            this.newEventPanel.Controls.Add(this.LocationLabel);
            this.newEventPanel.Controls.Add(this.TitleLabel);
            this.newEventPanel.Controls.Add(this.NewEventLabel);
            this.newEventPanel.Location = new System.Drawing.Point(0, 0);
            this.newEventPanel.Name = "newEventPanel";
            this.newEventPanel.Size = new System.Drawing.Size(326, 377);
            this.newEventPanel.TabIndex = 7;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(35, 214);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(254, 78);
            this.DescriptionTextBox.TabIndex = 16;
            this.DescriptionTextBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(32, 198);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 15;
            this.DescriptionLabel.Text = "Description:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(168, 315);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.Location = new System.Drawing.Point(62, 315);
            this.CreateEventButton.Name = "CreateEventButton";
            this.CreateEventButton.Size = new System.Drawing.Size(100, 23);
            this.CreateEventButton.TabIndex = 13;
            this.CreateEventButton.Text = "Create Event";
            this.CreateEventButton.UseVisualStyleBackColor = true;
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // AttendeesTextBox
            // 
            this.AttendeesTextBox.Location = new System.Drawing.Point(117, 162);
            this.AttendeesTextBox.Name = "AttendeesTextBox";
            this.AttendeesTextBox.Size = new System.Drawing.Size(172, 20);
            this.AttendeesTextBox.TabIndex = 12;
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.Location = new System.Drawing.Point(117, 136);
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.Size = new System.Drawing.Size(172, 20);
            this.EndTimeTextBox.TabIndex = 10;
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.Location = new System.Drawing.Point(117, 110);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.Size = new System.Drawing.Size(172, 20);
            this.StartTimeTextBox.TabIndex = 9;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(117, 82);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(172, 20);
            this.LocationTextBox.TabIndex = 8;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(117, 57);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(172, 20);
            this.TitleTextBox.TabIndex = 7;
            // 
            // AttendeesLabel
            // 
            this.AttendeesLabel.AutoSize = true;
            this.AttendeesLabel.Location = new System.Drawing.Point(32, 169);
            this.AttendeesLabel.Name = "AttendeesLabel";
            this.AttendeesLabel.Size = new System.Drawing.Size(58, 13);
            this.AttendeesLabel.TabIndex = 6;
            this.AttendeesLabel.Text = "Attendees:";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(32, 139);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.EndTimeLabel.TabIndex = 4;
            this.EndTimeLabel.Text = "End time:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(32, 112);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(54, 13);
            this.StartTimeLabel.TabIndex = 3;
            this.StartTimeLabel.Text = "Start time:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(32, 83);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationLabel.TabIndex = 2;
            this.LocationLabel.Text = "Location:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(32, 57);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title:";
            // 
            // NewEventLabel
            // 
            this.NewEventLabel.AutoSize = true;
            this.NewEventLabel.Location = new System.Drawing.Point(128, 18);
            this.NewEventLabel.Name = "NewEventLabel";
            this.NewEventLabel.Size = new System.Drawing.Size(60, 13);
            this.NewEventLabel.TabIndex = 0;
            this.NewEventLabel.Text = "New Event";
            // 
            // EventCreationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newEventPanel);
            this.Name = "EventCreationView";
            this.Size = new System.Drawing.Size(326, 377);
            this.newEventPanel.ResumeLayout(false);
            this.newEventPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel newEventPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateEventButton;
        private System.Windows.Forms.TextBox AttendeesTextBox;
        private System.Windows.Forms.TextBox EndTimeTextBox;
        private System.Windows.Forms.TextBox StartTimeTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label AttendeesLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NewEventLabel;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}
