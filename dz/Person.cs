using System.Collections.Generic;

namespace EventsSolution
{
    public class Person
    {
        public string Name { get; set; }
        public List<string> Hobbies { get; set; }

        public Person(string name, List<string> hobbies)
        {
            Name = name;
            Hobbies = hobbies;
        }

        public void RespondToEvent(string eventName)
        {
            if (Hobbies.Contains(eventName))
            {
                System.Console.WriteLine($"{Name} excitedly reacts to the {eventName}!");
            }
        }
    }
}
