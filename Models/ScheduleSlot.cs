namespace Rasha7ly.Models
{
    public class ScheduleSlot
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string Professor { get; set; }
        public string Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public double CreditHours { get; set; } // عشان الجافاسكريبت يحسب منها
        public string Category { get; set; }    // عشان نعرف دي اختياري ولا إجباري ولا تخدم تخصص

        public string CourseType { get; set; }
    }
}