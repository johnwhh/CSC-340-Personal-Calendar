using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalCalendar
{
    public partial class MainForm : Form
    {
        private bool isViewingMonthly = false;
        public MainForm()
        {
            InitializeComponent();
            ShowDailyEvents();
        }

        public void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateEventsPanel();
        }

        public void UpdateEventsPanel()
        {
            if (!isViewingMonthly)
                ShowDailyEvents();
            else
                ShowMonthlyEvents();
        }

        private void ShowDailyEvents()
        {
            EventsPanel.Controls.Clear();

            string date = GetSelectedDate();
            foreach (Event @event in Event.GetDailyEvents(date))
            {
                AddEvent(@event);
            }
        }

        private void ShowMonthlyEvents()
        {
            string month = Calendar.SelectionEnd.Month.ToString();
            string year = Calendar.SelectionEnd.Year.ToString();
            EventsPanel.Controls.Clear();
            foreach (Event @event in Event.GetMonthlyEvents(month, year))
            {
                AddEvent(@event);
            }
        }

        public string GetSelectedDate()
        {
            return Calendar.SelectionEnd.Year.ToString() + "-" + Calendar.SelectionEnd.Month.ToString() + "-" + Calendar.SelectionEnd.Day.ToString();
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            EventCreationView eventCreationView = new EventCreationView(this);

            Controls.Add(eventCreationView);
            eventCreationView.Location = new Point(Width / 2 - (eventCreationView.Width / 2), Height / 2 - (eventCreationView.Height / 2));
            eventCreationView.BringToFront();
        }
        
        public void AddEvent(Event newEvent)
        {
            EventView newEventView = new EventView(this, newEvent);
            EventsPanel.Controls.Add(newEventView);
        }

        private void MonthlyEventsButton_Click(object sender, EventArgs e)
        {
            isViewingMonthly = !isViewingMonthly;

            

            if (isViewingMonthly)
            {
                MonthlyEventsButton.Text = "View Daily Events";
                ShowMonthlyEvents();
                ToggleEditButtons(false);
            } else
            {
                MonthlyEventsButton.Text = "View Monthly Events";
                ShowDailyEvents();
                ToggleEditButtons(true);
            }

        }

        public void ToggleButtons(bool state)
        {
            AddEventButton.Enabled = state;
            MonthlyEventsButton.Enabled = state;

            foreach (Control control in EventsPanel.Controls)
            {
                EventView eventView = control as EventView;
                
                eventView.ToggleEditButton(state);
                eventView.ToggleDeleteButton(state);
            }
        }

        public void ToggleEditButtons(bool state)
        {
            foreach (Control control in EventsPanel.Controls)
            {
                EventView eventView = control as EventView;

                eventView.ToggleEditButton(state);
            }
        }
    }
}
