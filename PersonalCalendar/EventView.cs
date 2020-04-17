using System;
using System.Drawing;
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

        public void ToggleEditButton(bool state)
        {
            EditButton.Enabled = state;
        }

        public void ToggleDeleteButton(bool state)
        {
            DeleteButton.Enabled = state;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ConfirmationView confirmationView = new ConfirmationView(parentForm, currentEvent);
            parentForm.ToggleButtons(false);
            parentForm.Controls.Add(confirmationView);
            confirmationView.Location = new Point(parentForm.Width / 2 - (confirmationView.Width / 2), parentForm.Height / 2 - (confirmationView.Height / 2));
            confirmationView.BringToFront();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EventEditView eventEditView = new EventEditView(parentForm, currentEvent);
            parentForm.ToggleButtons(false);
            parentForm.Controls.Add(eventEditView);
            eventEditView.Location = new Point(parentForm.Width / 2 - (eventEditView.Width / 2), parentForm.Height / 2 - (eventEditView.Height / 2));
            eventEditView.BringToFront();
        }
    }
}
