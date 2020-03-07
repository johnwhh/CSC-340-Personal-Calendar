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
    public partial class EventEditView : UserControl
    {
        private MainForm parentForm;
        private EventView eventView;
        public EventEditView(EventView eventView, MainForm parent, Event newEvent)
        {
            this.eventView = eventView;
            this.parentForm = parent;
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
            eventView.enableButtons(true);
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
            eventView.UpdateEventView(newEvent);
            eventView.enableButtons(true);
            parentForm.Controls.Remove(this);
        }
    }
}
