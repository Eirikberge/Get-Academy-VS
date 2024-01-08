namespace _2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new StudentStatus("Terje");

            Console.WriteLine($"Navn: {student.Name}, Status: {student.Status}");
            // Navn: Terje, Status: HarSøkt

            student.ChangeStatus(Status.LevertDokumentasjon);

            Console.WriteLine($"Navn: {student.Name}, Status: {student.Status}");
            // Navn: Terje, Status: LevertDokumentasjon

            if (student.HasStudentHadStatusBefore(Status.LevertDokumentasjon))
            {
                Console.WriteLine($"{student.Name} har hatt statusen {student.Status} før");
            }
            //Terje har hatt statusen LevertDokumentasjon tidligere

            student.ChangeStatus(Status.FullførtogBestått);
            // Ugyldig endring av status
        }
    }
}