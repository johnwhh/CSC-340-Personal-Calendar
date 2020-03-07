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
    public partial class EventCreationView : UserControl
    {
        private MainForm parentForm;
        public EventCreationView(MainForm parent)
        {
            this.parentForm = parent;
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

            parentForm.AddEvent(new Event(title, location, startTime, endTime, attendees, description));
            parentForm.Controls.Remove(this);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parentForm.Controls.Remove(this);
        }
    }
}
