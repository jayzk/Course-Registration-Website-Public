using CPSC481_FinalProject.Shared;

namespace CPSC481_FinalProject.Services
{
    public interface ICourseState
    {
        event Action OnCourseStateChanged;

        bool isDefault { get; set; }
        IList<CourseData> selectedCourses { get; set; }
        List<CourseData> bookmarkedCourses { get; set; }
        Dictionary<string, CourseData> Courses { get; set; }

        void SetCourses(Dictionary<string, CourseData> map);

        void HideCourse(string name);
        void ShowCourse(string name);
        void DropEnrolledCourse(string name);
        void ReAddEnrolledCourse(string name);
        void AddCourse(CourseData course);
        void RemoveCourse(CourseData course);
        void ForceUpdate();
        void ChangeStatus(int status, string name);
        void ChangeWtlstCheck(string name);
        void ChangeFormerStatus(int status, string name);

        void ClearSelectedCourses();
        void DefaultSelectedCourses();
        void ClearNeccesaryCourses();

        void AddBookmark(CourseData course);
        void RemoveBookmark(CourseData course);

    }
}
