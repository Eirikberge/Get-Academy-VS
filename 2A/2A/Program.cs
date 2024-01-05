namespace _2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Eirik");

            Console.WriteLine($"Navn: {student.Name}, Status: {student.Status}");
            //Console.WriteLine($"Navn: {student.GetName()}, Status: {student.Status}");

            // Navn: Eirik, Status: HarSøkt

            student.ChangeStatus(StudentStatus.LevertDokumentasjon);

            Console.WriteLine($"Navn: {student.Name}, Status: {student.Status}");
            // Navn: Eirik, Status: LevertDokumentasjon

            if (student.HasStudentHadStatusBefore(StudentStatus.LevertDokumentasjon))
            {
                Console.WriteLine($"Studenten har hatt statusen {student.Status} før");
            }
            //Studenten har hatt statusen LevertDokumentasjon tidligere

            student.ChangeStatus(StudentStatus.FullførtogBestått);
            // Ugyldig endring av status
        }
    }
}