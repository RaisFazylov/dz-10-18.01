using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EventsSolution
{
    public class EventManager
    {
        private List<Student> students = new List<Student>();
        private const string EventsLogPath = "events_log.txt";

        public void LoadStudents(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                students.Add(new Student(parts[0], parts[1], bool.Parse(parts[2])));
            }
        }

        public void CreateEvent(string name, DateTime date, int requiredParticipantsPerGroup)
        {
            var groupedStudents = students.GroupBy(s => s.Group).ToList();

            if (groupedStudents.Count < 2)
            {
                Console.WriteLine("Необходимо как минимум две группы!");
                return;
            }

            Event newEvent = new Event(name, date);
            SelectParticipants(newEvent, groupedStudents, requiredParticipantsPerGroup);
            SaveEventToFile(newEvent);
        }

        private void SelectParticipants(Event newEvent, List<IGrouping<string, Student>> groupedStudents, int requiredParticipantsPerGroup)
        {
            foreach (var group in groupedStudents)
            {
                var eligibleStudents = group.OrderBy(s => s.WantsToParticipate ? 0 : 1).Take(requiredParticipantsPerGroup).ToList();
                newEvent.Participants.AddRange(eligibleStudents);
            }
        }

        private void SaveEventToFile(Event newEvent)
        {
            using (StreamWriter sw = new StreamWriter(EventsLogPath, true))
            {
                sw.WriteLine($"Дата мероприятия: {newEvent.Date}");
                sw.WriteLine($"Название мероприятия: {newEvent.Name}");
                sw.WriteLine($"Список участников:");

                foreach (var participant in newEvent.Participants)
                {
                    sw.WriteLine($"{participant.Name}, Группа: {participant.Group}");
                }
                sw.WriteLine();
            }

            Console.WriteLine("Информация о мероприятии записана!");
        }
    }
}
