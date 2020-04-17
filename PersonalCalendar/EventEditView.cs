using System;
using System.Windows.Forms;

namespace PersonalCalendar
{
    public partial class EventEditView : UserControl
    {
        private MainForm parentForm;
        private Event oldEvent;
        public EventEditView(MainForm parent, Event newEvent)
        {
            parentForm = parent;
            oldEvent = newEvent;
            InitializeComponent();
            TitleTextBox.Text = newEvent.title;
            LocationTextBox.Text = newEvent.location;
            StartTimeTextBox.Text = newEvent.startTime;
            EndTimeTextBox.Text = newEvent.endTime;
            AttendeesTextBox.Text = newEvent.attendees;
            DescriptionTextBox.Text = newEvent.description;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string location = LocationTextBox.Text;
            string startTime = StartTimeTextBox.Text;
            string endTime = EndTimeTextBox.Text;
            string attendees = AttendeesTextBox.Text;
            string description = DescriptionTextBox.Text;
            Event newEvent = new Event(title, location, startTime, endTime, attendees, description);

            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);

            Event.UpdateEvent(oldEvent, newEvent, parentForm.GetSelectedDate(), parentForm);
            parentForm.UpdateEventsPanel();
        }
    }
}
