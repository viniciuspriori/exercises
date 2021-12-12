using System;

namespace ex_bookingupforbeauty
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new DateTime(1997, 10, 1, 16, 0, 0).ToString();

            var y = Appointment.Schedule(x);
            Console.WriteLine(y);

            Console.WriteLine(Appointment.HasPassed(y));

            Console.WriteLine(Appointment.IsAfternoonAppointment(y));

            System.Console.WriteLine(Appointment.Description(y));
            
            System.Console.WriteLine(Appointment.AnniversaryDate());

            Console.ReadKey();

        }
    }
}
