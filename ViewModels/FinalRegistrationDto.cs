namespace Rasha7ly.ViewModels
{
    public class FinalRegistrationDto
    {
        // لستة بالمواد اللي الطالب استقر عليها في الجدول
        public List<Models.ScheduleSlot> SelectedCourses { get; set; }

        // إجمالي الساعات المسجلة
        public double TotalRegisteredHours { get; set; }
    }
}