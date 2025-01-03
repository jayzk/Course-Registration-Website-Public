using Blazored.Toast.Services;
using CPSC481_FinalProject.Shared;
using Microsoft.AspNetCore.Components;

namespace CPSC481_FinalProject.Services
{
    public class CourseState : ICourseState
    {

        public event Action OnCourseStateChanged;
        public bool isDefault { get; set; } = true;
        public Dictionary<string, CourseData>? Courses { get; set; }

        public List<CourseData> bookmarkedCourses { get; set; } = new List<CourseData>();

        private IList<CourseData> _selectedCourses { get; set; } = new List<CourseData>();
        public IList<CourseData> selectedCourses
        {
            get => _selectedCourses;
            set
            {
                _selectedCourses = value;
                OnCourseStateChanged?.Invoke();
            }
        }


        public void SetCourses(Dictionary<string, CourseData> map)
        {
            Courses = map;
            OnCourseStateChanged?.Invoke();
        }

        public void HideCourse(string name)
        {
            Courses[name].IsVisible = false;
            OnCourseStateChanged?.Invoke();
        }

        public void ShowCourse(string name)
        {
            Courses[name].IsVisible = true;
            OnCourseStateChanged?.Invoke();
        }

        public void DropEnrolledCourse(string name)
        {
            Courses[name].IsVisible = false;
            Courses[name].Status = 4; //Set course status to DROPPING
            OnCourseStateChanged?.Invoke();
        }

        public void ReAddEnrolledCourse(string name)
        {
            Courses[name].IsVisible = true;
            Courses[name].Status = 3; //Set course status back to ENROLLED
            OnCourseStateChanged?.Invoke();
        }

        public void ChangeWtlstCheck(string name)
        {
            Courses[name].WtlstCheck = !Courses[name].WtlstCheck;
            OnCourseStateChanged?.Invoke();
        }

        public void AddCourse(CourseData course)
        {
            if (!selectedCourses.Contains(course)) //if course is not already added, then add the course to the list
            {
                course.IsVisible = true;
                selectedCourses.Add(course);
                OnCourseStateChanged?.Invoke();
            }
        }

        public void ChangeStatus(int status, string name)
        {
            Courses[name].Status = status;
            if (status == 1 && name.Equals("CPSC 481")) //dropped enrolled course CPSC 481
            {
                Courses[name].Seats = "54/60";
                Courses[name].TutSeats = "54/60";
            }
            else if (status == 1 && name.Equals("ASPH 305")) //dropped waitlisted course ASPH 305
            {
                Courses[name].Waitlist = "0/20";
                Courses[name].TutWaitlist = "0/20";
            }
            else if (status == 3 && name.Equals("CPSC 449")) //enrolling into CPSC 449
            {
                Courses[name].Seats = "57/60";
                Courses[name].TutSeats = "29/30";
            }
            else if (status == 1 && name.Equals("CPSC 449")) //dropping CPSC 449
            {
                Courses[name].Seats = "56/60";
                Courses[name].TutSeats = "28/30";
            }
            else if (status == 1) //drop any other course
            {
                Courses[name].Seats = "55/60";
                Courses[name].TutSeats = "55/60";
            }
            else if(status == 3) //enroll in any course
            {
                Courses[name].Seats = "56/60";
                Courses[name].TutSeats = "56/60";
            }
            else if(status == 2) //waitlist for a course
            {
                Courses[name].TutWaitlist = "1/20";
                Courses[name].Waitlist = "1/20";
            }

            OnCourseStateChanged?.Invoke();
        }

        public void ChangeFormerStatus(int status, string name)
        {
            Courses[name].FormerStatus = status;
            OnCourseStateChanged?.Invoke();
        }

        public void RemoveCourse(CourseData course) 
        {
            selectedCourses.Remove(course);
            course.IsVisible = true;
            OnCourseStateChanged?.Invoke();
        }

        public void ClearSelectedCourses()
        {
            isDefault = !isDefault;
            selectedCourses.Clear();
            _selectedCourses.Clear();
            OnCourseStateChanged?.Invoke();
        }

        public void DefaultSelectedCourses()
        {
            isDefault = !isDefault;
            selectedCourses.Clear();
            _selectedCourses.Clear();

            foreach (var course in Courses)
            {
                if(course.Value.Status == 3)
                {
                    selectedCourses.Add(course.Value);
                }
            }
            OnCourseStateChanged?.Invoke();
        }

        public void ClearNeccesaryCourses()
        {
            if(selectedCourses != null)
            {
                foreach(CourseData course in selectedCourses.ToList())
                {
                    if(course.Status == 1)
                    {
                        selectedCourses.Remove(course);
                        _selectedCourses.Remove(course);
                    }
                }
            }

            //selectedCourses.Clear();
            //selectedCourses = _selectedCourses;

            OnCourseStateChanged?.Invoke();
        }

        public void ForceUpdate()
        {
            OnCourseStateChanged?.Invoke();
        }

        public void AddBookmark(CourseData course)
        {
            course.IsBookmarked = true;
            bookmarkedCourses.Add(course);
            OnCourseStateChanged?.Invoke();
        }

        public void RemoveBookmark(CourseData course)
        {
            course.IsBookmarked = false;
            bookmarkedCourses.Remove(course);
            OnCourseStateChanged?.Invoke();
        }
    }
}
