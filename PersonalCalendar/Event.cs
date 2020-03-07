using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalCalendar
{
    public class Event
    {
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
    }
}
