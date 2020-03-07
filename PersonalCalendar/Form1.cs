using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalCalendar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            MonthCalendar calendar = sender as MonthCalendar;
            //MessageBox.Show(calendar.SelectionEnd.ToString());
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            EventCreationView eventCreationView = new EventCreationView(this);

            Controls.Add(eventCreationView);
            eventCreationView.Location = new Point(this.Width / 2 - (eventCreationView.Width / 2), this.Height / 2 - (eventCreationView.Height / 2));
            eventCreationView.BringToFront();
        }
        
        public void AddEvent(Event newEvent)
        {
            EventView newEventView = new EventView(this, newEvent);
            EventsPanel.Controls.Add(newEventView);
        }
    }
}
