using System.ComponentModel;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lists = new Overview();
            
            while (true)
            {
                var cmd = ShowMenuAndCmd();
                if (cmd == "1") AddStudent(lists);
                if (cmd == "2") AddSubject(lists);
                if (cmd == "3") AddStudentToSubject(lists);
                if (cmd == "4") lists.ShowAll();
            } 
        }

        private static void AddStudentToSubject(Overview lists)
        {
            lists.ShowStudents();
            Console.WriteLine();
            Console.WriteLine("Hvem vil du melde på? Skriv navnet");
            var studentToSubject = Console.ReadLine();
            lists.AddStudentToSubject(studentToSubject);
        }

        private static void AddSubject(Overview lists)
        {
            Console.WriteLine("Skriv inn navnet på faget");
            var subjectName = Console.ReadLine();
            lists.AddSubjectToSchool(subjectName);
        }

        private static void AddStudent(Overview lists)
        {
            Console.WriteLine("Skriv inn navnet på eleven");
            var studentName = Console.ReadLine();
            lists.AddStudentToSchool(studentName);
            Console.WriteLine($"Ønsker du å melde {studentName} på noen fag?");
            Console.WriteLine("1 = Ja");
            Console.WriteLine("2 = Nei");
            var cmdSubject = Console.ReadLine();
            if (cmdSubject == "1")
            {
                Console.WriteLine("Du kan velge mellom:");
                Console.WriteLine();
                lists.ShowSubjects();
                Console.WriteLine();
                Console.WriteLine("Skriv inn faget du vil legge til");
                var cmdSubjectToStudent = Console.ReadLine();
                lists.AddSubjectToStudent(studentName, cmdSubjectToStudent);
            }
            else if (cmdSubject == "2") ShowMenuAndCmd();
        }

        private static string ShowMenuAndCmd()
        {
            Console.Clear();
            Console.WriteLine("Velkommen til Skolen");
            Console.WriteLine();
            Console.WriteLine("Hva ønsker du å gjøre?");
            Console.WriteLine("1 = Legg til elev");
            Console.WriteLine("2 = Legg til fag");
            Console.WriteLine("3 = Melde elev på fag");
            Console.WriteLine("4 = vis all info");

            return Console.ReadLine();
        }
    }
}