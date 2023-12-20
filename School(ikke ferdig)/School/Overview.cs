namespace School
{
    internal class Overview
    {

        private List<Student> _students = new List<Student>
        {
            new Student("Eirik"),
            new Student("Martin")

        };

        public List<Student> GetStudent()
        {
            return _students;
        }

        private List<Subject> _subjects = new List<Subject>
        {
            new Subject("Matte"),
            new Subject("Programering"),
            new Subject("Gym"),

        };

        public void ShowSubjects()
        {
            foreach (var subject in _subjects)
            {
                Console.WriteLine(subject._name);
            }
        }

        public void ShowStudents()
        {

            foreach (var student in _students)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void AddStudentToSchool(string name)
        {
            _students.Add(new Student(name));
        }

        //public void AddSubjectToStudent(string subject)
        //{
        //    _students.Add(new Student(subject));
        //}
        public void AddSubjectToStudent(string studentName, string subject)
        {
            var student = _students.Find(s => s.Name == studentName);
            if (student != null)
            {
                student.AddSubject(subject);
            }
            else
            {
                Console.WriteLine($"Feil: Fant ikke studenten med navnet {studentName}");
            }
        }

        public void AddSubjectToSchool(string subjectName)
        {
            _subjects.Add(new Subject(subjectName));
        }

        public void AddStudentToSubject(string studentToSubject)
        {
            _subjects.Add(new Subject(studentToSubject));
        }

        public void ShowStudentsAndSubject()
        {
            foreach (var student in _students)
            {
                Console.WriteLine(student.Name);
                foreach (var subject in student.Subjects)
                {
                    Console.WriteLine($" - {subject}");
                }
                Console.WriteLine(); // For å skille studentene
            }
        } 
        public void ShowAll()
        {
            ShowStudents();
            Console.WriteLine();
            ShowSubjects();
            Console.WriteLine();
            ShowStudentsAndSubject();
            Console.ReadLine();
        }
    }

}