namespace EventsSolution
{
    public class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public bool WantsToParticipate { get; set; }

        public Student(string name, string group, bool wantsToParticipate = false)
        {
            Name = name;
            Group = group;
            WantsToParticipate = wantsToParticipate;
        }
    }
}
