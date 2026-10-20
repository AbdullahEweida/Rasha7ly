
namespace Rasha7ly.Models
{
    // كلاس هيقرأ بيانات اللائحة عشان نعرف الساعات والمتطلبات
    public class CourseRequirement
    {
        public string Category { get; set; }     // القسم (رياضيات، علوم حاسب، الخ)
        public string Type { get; set; }         // إجباري ولا اختياري
        public string Code { get; set; }         // الرمز
        public double CreditHours { get; set; }  // الساعات
        public string Prerequisite { get; set; } // السابق
    }
}

