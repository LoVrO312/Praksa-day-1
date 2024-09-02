
// nije implementirano do kraja

using System;

int input;
List<Doctor> Doctors;
List<Nurse> Nurses;
List<Patient> Patients;

while (true)
{
    Console.WriteLine("choose operation");
    Console.WriteLine("1 - input doctor");
    Console.WriteLine("2 - input nurse");
    Console.WriteLine("3 - input patient");
    Console.WriteLine("4 - make doctors appointment");
    Console.WriteLine("5 - make nurse appointment");
    Console.WriteLine("6 - print doctor schedule");
    Console.WriteLine("7 - print nurse schedule");

    input = 0;
    while (input == 0)
    {
        Console.Readline();
    }

    Console.Clear();

    switch (input)
    {
        case 1:
            InputDoctor(); break;
        case 2:
            InputNurse(); break;
        case 3:
            InputPatient(); break;
        case 4:
            MakeDoctorsAppointment(); break;
        case 5:
            MakeNurseAppointment(); break;
        case 6:
            PrintDoctorsSchedule(); break
        case 7:
            PrintNurseSchedule(); break;
        default: 
            Console.WriteLine("wrong input"); break;
    }
}

/*
// TESTING
Nurse sestra1 = new Nurse("Ana", "Mana", 193);
Nurse sestra2 = new Nurse("Ana", "Mana", 193);
Doctor doc1 = new Doctor("doktor", "Maric", 32);

Patient pacijent1 = new Patient("Mirko", "Miric", 64, doc1);
Patient pacijent2 = new Patient("Ivan", "Ivanic", 65, doc1);
Patient pacijent3 = new Patient("Jana", "Janic", 66, doc1);
Patient pacijent4 = new Patient("Luka", "Lukic", 67, doc1);

// Assign patients to nurses with appointment times
pacijent1.AppointNurse(DateTime.Now, DateTime.Now.AddHours(1), sestra1);
pacijent2.AppointNurse(DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), sestra1);
pacijent3.AppointNurse(DateTime.Now.AddHours(1), DateTime.Now.AddHours(2), sestra2);
pacijent4.AppointNurse(DateTime.Now.AddHours(3), DateTime.Now.AddHours(4), sestra2);

pacijent1.MakeDoctorsAppointment(DateTime.Now);
pacijent2.MakeDoctorsAppointment(DateTime.Now.AddHours(3));
pacijent3.MakeDoctorsAppointment(DateTime.Now.AddHours(1));
pacijent4.MakeDoctorsAppointment(DateTime.Now.AddHours(2));
pacijent1.MakeDoctorsAppointment(DateTime.Now.AddHours(-3));


doc1.PrintSchedule();
sestra2.PrintSchedule();
*/