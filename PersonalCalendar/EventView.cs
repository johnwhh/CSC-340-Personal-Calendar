using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalCalendar
{
    public partial class EventView : UserControl
    {
        private MainForm parentForm;
        private Event currentEvent;
        public EventView(MainForm parentForm, Event newEvent)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            UpdateEventView(newEvent);
        }

        public void UpdateEventView(Event newEvent)
        {
            NewTitleLabel.Text = newEvent.title;
            NewLocationLabel.Text = newEvent.location;
            NewStartTimeLabel.Text = newEvent.startTime;
            NewEndTimeLabel.Text = newEvent.endTime;
            NewAttendeesLabel.Text = newEvent.attendees;
            NewDescriptionTextBox.Text = newEvent.description;

            currentEvent = newEvent;
        }

        public void enableButtons(bool state)
        {
            EditButton.Enabled = state;
            DeleteButton.Enabled = state;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            parentForm.getEventsPanel().Controls.Remove(this);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EventEditView eventEditView = new EventEditView(this, parentForm, currentEvent);
            enableButtons(false);
            parentForm.Controls.Add(eventEditView);
            eventEditView.Location = new Point(parentForm.Width / 2 - (eventEditView.Width / 2), parentForm.Height / 2 - (eventEditView.Height / 2));
            eventEditView.BringToFront();
        }
    }
}
