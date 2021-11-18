using System;
namespace attendance.Models
{
    public class Attendance
    {
        public int ID { get; set; }
        public string WorkingDate { get; set; }
        public DateTime ClonkingIn { get; set; }
        public DateTime ClockingOut { get; set; }
        public DateTime BreakeTime { get; set; }
        public DateTime WorkingTime { get; set; }
    }
}
