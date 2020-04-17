using System;
using System.Windows.Forms;

namespace PersonalCalendar
{
    public partial class ConfirmationView : UserControl
    {
        private MainForm parentForm;
        private Event oldEvent;
        public ConfirmationView(MainForm parent, Event oldEvent)
        {
            parentForm = parent;
            this.oldEvent = oldEvent;
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
            Event.RemoveEvent(oldEvent, parentForm.GetSelectedDate());
            parentForm.UpdateEventsPanel();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }
    }
}
