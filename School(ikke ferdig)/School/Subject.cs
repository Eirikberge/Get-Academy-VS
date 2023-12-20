
namespace School
{
    internal class Subject
    {
        public string _name { get; }
        public List<Student> _StudentToSubject;

        public Subject(string name, List<Student> studentToSubject=null)
        {
            _name = name;
            _StudentToSubject = new List<Student>();
        }

    }
}
