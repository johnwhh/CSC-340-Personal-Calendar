using System;
using System.Collections.Generic;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;

namespace PersonalCalendar
{
    public class Event
    {
        private const string connStr = "Put EKU Database connection details here";
        public string title;
        public string location;
        public string startTime;
        public string endTime;
        public string attendees;
        public string description;

        public Event(string title, string location, string startTime, string endTime, string attendees, string description)
        {
            this.title = title;
            this.location = location;
            this.startTime = startTime;
            this.endTime = endTime;
            this.attendees = attendees;
            this.description = description;
        }

        public static void InsertEvent(Event newEvent, string date, MainForm parentForm) 
        {
            if (TimeConflictExists(newEvent, date))
            {
                ErrorView errorView = new ErrorView(parentForm);
                parentForm.Controls.Add(errorView);
                errorView.Location = new Point(parentForm.Width / 2 - (errorView.Width / 2), parentForm.Height / 2 - (errorView.Height / 2));
                errorView.BringToFront();
                return;
            }
            parentForm.AddEvent(newEvent);
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string statement = "INSERT INTO holtzworthevent (title, location, startTime, endTime, attendees, description, date) VALUES (@title, @location, @startTime, @endTime, @attendees, @description, @date);";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@title", newEvent.title);
                cmd.Parameters.AddWithValue("@location", newEvent.location);
                cmd.Parameters.AddWithValue("@startTime", newEvent.startTime);
                cmd.Parameters.AddWithValue("@endTime", newEvent.endTime);
                cmd.Parameters.AddWithValue("@attendees", newEvent.attendees);
                cmd.Parameters.AddWithValue("@description", newEvent.description);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private static bool TimeConflictExists(Event newEvent, string date)
        {
            Event[] events = GetDailyEvents(date).ToArray();

            foreach (Event @event in events)
            {
                Console.WriteLine("Old event start: " + TimeToFloat(@event.startTime).ToString() + "  end: " + TimeToFloat(@event.endTime).ToString());
                Console.WriteLine("New event start: " + TimeToFloat(newEvent.startTime).ToString() + "  end: " + TimeToFloat(newEvent.endTime).ToString());
                bool startConflictExists = TimeToFloat(newEvent.endTime) >= TimeToFloat(@event.startTime) && TimeToFloat(newEvent.endTime) <= TimeToFloat(@event.endTime);
                bool endConflictExists = TimeToFloat(newEvent.startTime) <= TimeToFloat(@event.endTime) && TimeToFloat(newEvent.startTime) >= TimeToFloat(@event.startTime);
                if (startConflictExists || endConflictExists)
                    return true;
            }
            return false;
        }

        private static float TimeToFloat(string time)
        {
            int colonIndex = time.IndexOf(':');
            int hour = Int32.Parse(time.Substring(0, colonIndex));
            int minutes = Int32.Parse(time.Substring(colonIndex + 1, 2));
            float fraction = (float)minutes / 60;
            return hour + fraction;
        }

        public static void RemoveEvent(Event oldEvent, string date)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string statement = "DELETE FROM holtzworthevent WHERE title = @title AND location = @location AND startTime = @startTime AND endTime = @endTime AND attendees = @attendees AND description = @description AND date = @date LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@title", oldEvent.title);
                cmd.Parameters.AddWithValue("@location", oldEvent.location);
                cmd.Parameters.AddWithValue("@startTime", oldEvent.startTime);
                cmd.Parameters.AddWithValue("@endTime", oldEvent.endTime);
                cmd.Parameters.AddWithValue("@attendees", oldEvent.attendees);
                cmd.Parameters.AddWithValue("@description", oldEvent.description);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        public static void UpdateEvent(Event oldEvent, Event newEvent, string date, MainForm parent)
        {
            RemoveEvent(oldEvent, date);
            InsertEvent(newEvent, date, parent);
        }

        public static List<Event> GetDailyEvents(string dateString)
        {
            List<Event> eventList = new List<Event>();
            DataTable table = new DataTable();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string statement = "SELECT * FROM holtzworthevent WHERE date=@myDate";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@myDate", dateString);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                myAdapter.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            foreach (DataRow row in table.Rows)
            {
                string title = row["title"].ToString();
                string location = row["location"].ToString();
                string startTime = row["startTime"].ToString();
                string endTime = row["endTime"].ToString();
                string attendees = row["attendees"].ToString();
                string description = row["description"].ToString();
                Event newEvent = new Event(title, location, startTime, endTime, attendees, description);
                eventList.Add(newEvent);
            }
            table.Dispose();
            return eventList;
        }

        public static List<Event> GetMonthlyEvents(string month, string year)
        {
            List<Event> eventList = new List<Event>();
            DataTable table = new DataTable();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string statement = "SELECT * FROM holtzworthevent WHERE MONTH(date) = @month AND YEAR(date) = @year";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                myAdapter.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            foreach (DataRow row in table.Rows)
            {
                string title = row["title"].ToString();
                string location = row["location"].ToString();
                string startTime = row["startTime"].ToString(); ;
                string endTime = row["endTime"].ToString(); ;
                string attendees = row["attendees"].ToString(); ;
                string description = row["description"].ToString(); ;
                Event newEvent = new Event(title, location, startTime, endTime, attendees, description);
                eventList.Add(newEvent);
            }
            table.Dispose();
            return eventList;
        }
    }
}
