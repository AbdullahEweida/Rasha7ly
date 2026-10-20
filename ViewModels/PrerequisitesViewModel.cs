namespace Rasha7ly.ViewModels
{
    public class PrerequisitesViewModel
    {
        public string SelectedDepartment { get; set; } = "الرياضيات وعلوم الحاسب";
        public List<CourseSelectionItem> AvailableCourses { get; set; } = new ();
    }
}
