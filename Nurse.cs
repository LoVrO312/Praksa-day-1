using System;

public class Nurse : Person, IEmployee
{
    public int NurseId { get; set; }
    public List<Patient> ScheduledPatients { get; set; }

    public Nurse(string? firstName, string? lastName, int oib)
            : base(firstName, lastName, oib)
    {
        NurseId = GenerateEmployeeId();
        ScheduledPatients = new List<Patient>();
    }
    
    public int GenerateEmployeeId()
    {
        return IEmployee.NurseId++;
    }

    public void RemovePastAppointments()
    {
        ScheduledPatients.RemoveAll(patient => patient.NurseCareEnd < DateTime.Now);
    }

    public void UpdateSchedule()
    {
        ScheduledPatients.Sort((p1, p2) => DateTime.Compare(p1.NurseCareStart, p2.NurseCareStart));
    }

    public void PrintSchedule()
    {
        Console.WriteLine("nurse's schedule:");
        Console.WriteLine("Patient FName | Patient LName | start date and time | end date and time");

        UpdateSchedule();

        foreach (var patient in ScheduledPatients)
        {
            Console.WriteLine($"{patient.FirstName}             {patient.LastName}            {patient.NurseCareStart}            {patient.NurseCareEnd}");
        }
    }
}