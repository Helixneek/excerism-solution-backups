static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime scheduleData = DateTime.Parse(appointmentDateDescription);
        return new DateTime(scheduleData.Year, scheduleData.Month, scheduleData.Day, scheduleData.Hour, scheduleData.Minute, scheduleData.Second);
    }

    public static bool HasPassed(DateTime appointmentDate) => (DateTime.Now > appointmentDate);

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18);

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}.";

    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
}
