using System;
using System.Windows.Forms;

namespace PersonalCalendar
{
    public partial class EventCreationView : UserControl
    {
        private MainForm parentForm;
        public EventCreationView(MainForm parent)
        {
            parentForm = parent;
            InitializeComponent();
        }

        private void CreateEventButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string location = LocationTextBox.Text;
            string startTime = StartTimeTextBox.Text;
            string endTime = EndTimeTextBox.Text;
            string attendees = AttendeesTextBox.Text;
            string description = DescriptionTextBox.Text;

            Event newEvent = new Event(title, location, startTime, endTime, attendees, description);
            Event.InsertEvent(newEvent, parentForm.GetSelectedDate(), parentForm);

            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }
    }
}
