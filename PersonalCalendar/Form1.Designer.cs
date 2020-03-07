namespace PersonalCalendar
{
    partial class MainForm
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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.EventsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MonthlyEventsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(280, 7);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // AddEventButton
            // 
            this.AddEventButton.Location = new System.Drawing.Point(116, 146);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(152, 23);
            this.AddEventButton.TabIndex = 3;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // EventsPanel
            // 
            this.EventsPanel.AutoScroll = true;
            this.EventsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EventsPanel.Location = new System.Drawing.Point(12, 181);
            this.EventsPanel.Name = "EventsPanel";
            this.EventsPanel.Size = new System.Drawing.Size(760, 368);
            this.EventsPanel.TabIndex = 4;
            this.EventsPanel.WrapContents = false;
            // 
            // MonthlyEventsButton
            // 
            this.MonthlyEventsButton.Location = new System.Drawing.Point(519, 146);
            this.MonthlyEventsButton.Name = "MonthlyEventsButton";
            this.MonthlyEventsButton.Size = new System.Drawing.Size(152, 23);
            this.MonthlyEventsButton.TabIndex = 5;
            this.MonthlyEventsButton.Text = "View Daily Events";
            this.MonthlyEventsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MonthlyEventsButton);
            this.Controls.Add(this.EventsPanel);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.calendar);
            this.Name = "MainForm";
            this.Text = "Personal Calendar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button AddEventButton;

        public System.Windows.Forms.Panel getEventsPanel()
        {
            return EventsPanel;
        }

        private System.Windows.Forms.FlowLayoutPanel EventsPanel;
        private System.Windows.Forms.Button MonthlyEventsButton;
    }
}

