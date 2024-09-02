using System;

public class Patient : Person
{
    public Doctor CaringDoctor;
    public Nurse? CaringNurse;

    public DateTime NurseCareStart;
    public DateTime NurseCareEnd;
    public DateTime DoctorAppointmentStart;

    public Patient(string? firstName, string? lastName, int oib,
                   Doctor caringDoctor)
            : base(firstName, lastName, oib)
    {
        CaringDoctor = caringDoctor;
    }

    public void MakeDoctorsAppointment(DateTime startDate)
    {
        DoctorAppointmentStart = startDate;
        CaringDoctor.ScheduledPatients.Add(this);
    }
    public void AppointNurse(DateTime startDate, DateTime endDate, Nurse nurse)
    {
        NurseCareStart = startDate;
        NurseCareEnd = endDate;
        CaringNurse = nurse;

        nurse.ScheduledPatients.Add(this);
    }

}