using System.Dynamic;

namespace School
{
    internal class Student
    {
        public string Name { get; }
        public List<string> Subjects { get; }

        public Student(string name, string subject = null)
        {
            Name = name;
            Subjects = new List<string>();
        }
        public void AddSubject(string subject)
        {
            Subjects.Add(subject);
        }

    }

}
