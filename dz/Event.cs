using System;
using System.Collections.Generic;

namespace EventsSolution
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<Student> Participants { get; set; } = new List<Student>();

        public Event(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
    }
}
