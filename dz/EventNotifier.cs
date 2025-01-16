using System.Collections.Generic;

namespace EventsSolution
{
    public class EventNotifier
    {
        private List<Person> people;

        public EventNotifier(List<Person> people)
        {
            this.people = people;
        }

        public void Notify(string eventName)
        {
            foreach (var person in people)
            {
                person.RespondToEvent(eventName);
            }
        }
    }
}
