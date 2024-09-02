using System;

public interface IEmployee
{
    static int NurseId = 1;
    static int DoctorId = 1;

    public int GenerateEmployeeId();
    public void RemovePastAppointments();
    public void UpdateSchedule();
    public void printSchedule();
}