using System;

public class Doctor : Person, IEmployee
{
    public int DoctorId { get; set; }
    public List<Patient> ScheduledPatients { get; set; }
    public Doctor(string? firstName, string? lastName, int oib)
            : base(firstName, lastName, oib)
    {
        DoctorId = GenerateEmployeeId();
        ScheduledPatients = new List<Patient>();
    }

    public int GenerateEmployeeId()
    {
        return IEmployee.DoctorId++;
    }

    public void RemovePastAppointments()
    {
        ScheduledPatients.RemoveAll(patient => patient.DoctorAppointmentStart < DateTime.Now);
    }

    public void UpdateSchedule()
    {
        RemovePastAppointments();
        ScheduledPatients.Sort((p1, p2) => DateTime.Compare(p1.DoctorAppointmentStart, p2.DoctorAppointmentStart));
    }

    public void PrintSchedule()
    {
        Console.WriteLine("doctor's schedule:");
        Console.WriteLine("Patient FName | Patient LName | Date and time");

        UpdateSchedule();

        foreach(var patient in ScheduledPatients)
        {
            Console.WriteLine($"{patient.FirstName}             {patient.LastName}            {patient.DoctorAppointmentStart}");
        }
    }

}