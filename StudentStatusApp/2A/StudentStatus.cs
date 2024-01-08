namespace _2A
{
    internal class StudentStatus
    {
        public string Name { get; private set; }
        public Status Status { get; private set; }

        private readonly List <Status> _statusList;

        public StudentStatus(string name)
        {
            Name = name;
            Status = Status.HarSøkt;
            _statusList = new List<Status>();
            _statusList.Add(Status);
        }

        public void ChangeStatus(Status newStatus)
        {
            if (IsChangeValid(newStatus))
            {
                Status = newStatus;
                _statusList.Add(Status);
            }
            else Console.WriteLine("Ugyldig endring av status");
        }

        private bool IsChangeValid(Status newStatus)
        {
            if (Status == Status.HarSøkt)
            {
                return newStatus == Status.LevertDokumentasjon || newStatus == Status.IkkeStartet;
            }
            if (Status == Status.LevertDokumentasjon)
            {
                return newStatus == Status.FåttTilbud || newStatus == Status.IkkeStartet;
            }
            if (Status == Status.FåttTilbud)
            {
                return newStatus == Status.SignertKontrakt || newStatus == Status.IkkeStartet;
            }
            if (Status == Status.SignertKontrakt)
            {
                return newStatus == Status.Startet || newStatus == Status.IkkeStartet;
            }
            if (Status == Status.Startet)
            {
                return newStatus == Status.Brutt || newStatus == Status.FullførtIkkeBestått || newStatus == Status.FullførtogBestått;
            }
            if (Status == Status.FullførtIkkeBestått)
            {
                return newStatus == Status.IkkeBeståtIkkeFlereForsøk || newStatus == Status.FullførtogBestått;
            }
            return false;
        }

        public bool HasStudentHadStatusBefore(Status newStatus)
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
