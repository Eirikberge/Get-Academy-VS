namespace StudentStatusApp
{
    internal class Student
    {
        public string Name { get; private set; }
        public StudentStatus Status { get; private set; }

        private List<StudentStatus> _statusList;

        public Student(string name)
        {
            Name = name;
            Status = StudentStatus.HarSøkt;
            _statusList = new List<StudentStatus>();
            _statusList.Add(Status);
        }

        public void ChangeStatus(StudentStatus newStatus)
        {
            if (IsChangeValid(newStatus))
            {
                Status = newStatus;
                _statusList.Add(Status);
            }
            else Console.WriteLine("Ugyldig endring av status");
        }

        public bool IsChangeValid(StudentStatus newStatus)
        {
            if (Status == StudentStatus.HarSøkt)
            {
                return newStatus == StudentStatus.LevertDokumentasjon || newStatus == StudentStatus.IkkeStartet;
            }
            if (Status == StudentStatus.LevertDokumentasjon)
            {
                return newStatus == StudentStatus.FåttTilbud || newStatus == StudentStatus.IkkeStartet;
            }
            if (Status == StudentStatus.FåttTilbud)
            {
                return newStatus == StudentStatus.SignertKontrakt || newStatus == StudentStatus.IkkeStartet;
            }
            if (Status == StudentStatus.SignertKontrakt)
            {
                return newStatus == StudentStatus.Startet || newStatus == StudentStatus.IkkeStartet;
            }
            if (Status == StudentStatus.Startet)
            {
                return newStatus == StudentStatus.Brutt || newStatus == StudentStatus.FullførtIkkeBestått || newStatus == StudentStatus.FullførtogBestått;
            }
            if (Status == StudentStatus.FullførtIkkeBestått)
            {
                return newStatus == StudentStatus.IkkeBeståtIkkeFlereForsøk || newStatus == StudentStatus.FullførtogBestått;
            }
            return false;
        }

        public bool HasStudentHadStatusBefore(StudentStatus newStatus)
        {
            foreach (var oldStatus in _statusList)
            {
                if (newStatus == oldStatus) return true;
            }
            return false;
        }

        //public string GetName()
        //{
        //    return Name;
        //}
    }
}
