using System;

static class Appointment
{    
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
       return DateTime.Now > appointmentDate ? true : false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return ((appointmentDate.Hour >= 12) && (appointmentDate.Hour < 18)) ? true : false;
    }

    public static string Description(DateTime appointmentDate)
    {    
        return $"You have an appointment on {appointmentDate.ToString()}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}
