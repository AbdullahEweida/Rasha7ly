namespace Rasha7ly.ViewModels
{
    // الـ ViewModel اللي هيتبعت للصفحة الأخيرة (الجدول + الإحصائيات)
    public class DashboardViewModel
    {
        public List<Models.ScheduleSlot> AvailableSchedule { get; set; } = new();

        public string Major1Name { get; set; }
        public double Major1CompulsoryRemaining { get; set; }
        public double Major1ElectiveRemaining { get; set; }

        public string Major2Name { get; set; }
        public double Major2CompulsoryRemaining { get; set; }
        public double Major2ElectiveRemaining { get; set; }

        public double SupportingCompulsoryRemaining { get; set; }
        public double SupportingElectiveRemaining { get; set; }

        public double UnivFacultyCompulsoryRemaining { get; set; }
        public double UnivFacultyElectiveRemaining { get; set; }
    }
}