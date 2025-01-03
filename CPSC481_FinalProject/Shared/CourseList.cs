namespace CPSC481_FinalProject.Shared
{
    public class CourseData
    {
        public int ID { get; set; }

        /* List of possible status IDs:
         * 1 = Enrolling
         * 2 = Waitlisted
         * 3 = Enrolled
         * 4 = Dropping
         */
        public int Status { get; set; } = 1; //Default status set to "Enrolling"
        public string? Number { get; set; }
        public int? PureNumber { get; set; }
        public string? Title { get; set; }
        public string? Seats { get; set; } //do we want to change this to an int?
        public string? Waitlist { get; set; } //do we want to change this to an int?
        public string? TutSeats { get; set; }
        public string? TutWaitlist { get; set; }
        public string? Professor { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public bool? WtlstCheck { get; set; }
        public bool? TimeSelected { get; set; }
        
        // tracks former status of courses
        public int FormerStatus { get; set; } =1;


        //prerequisites and anti-requisites (can change this to a list of courses if we decide to do this)
        public CourseData? Prereq { get; set; }
        public CourseData? Antireq { get; set; }

        //other bits of information
        public string? Color { get; set; }
        public bool IsVisible { get; set; } = true; //By default the course is visible
        public bool? IsBookmarked { get; set; } = false; //By default the course is not bookmarked

        public bool checkedTime1 { get; set; } = true; //By default the first course time is true
        public bool checkedTime2 { get; set; } = false; //By default the alternate course time is false
        public bool isFirstTime { get; set; } = true; //By default we are using the first time
        public bool isBlocked1 { get; set; } = false; //By default the timings are not blocked
        public bool isBlocked2 { get; set; } = false; //By default the timings are not blocked
        public bool checkedWtlst { get; set; } = true; //By default the first course time is true
        public bool alternateLab { get; set; } = false;

    }
    public static class CourseList
    {
        // Key = course name
        // Value = course details
        private static Dictionary<string, CourseData>? Courses { get; set; }

        static CourseList()
        {
            //Prereq courses
            CourseData pc1 = new CourseData()
            {
                ID = 1,
                Number = "SENG 300",
                PureNumber = 300,
                Title = "Introduction to Software Engineering",
                Seats = "55/60",
                Waitlist = "0/20",
                TutSeats = "55/60",
                TutWaitlist = "0/20",
                Professor = "Celia Hudson",
                Location = "EEEL 121",
                Description = @"Introduction to the development and evolution of software. Covers key conceptual foundations as well as key 
                            methods and techniques used in the different phases of the software lifecycle. Emphasis on both technical and 
                            soft skills needed for high quality software and software-based products developed in teams.",
                Color = "#d9b283",
                TimeSelected = true,

                // Notes
                // 1. MWF
                // 2. 10am-10:50am (LEC)
                // 3. 9am-10:50pm (TUT) on Tuesdays
            };

            //Anti-req courses
            CourseData ac1 = new CourseData()
            {
                ID = 2,
                Number = "ASPH 305",
                PureNumber = 305,
                Title = "Introduction to Astrophysics",
                Seats = "60/60",
                Waitlist = "0/20",
                TutSeats = "60/60",
                TutWaitlist = "0/20",
                Professor = "Blake Landry",
                Location = "SCI B 144",
                Description = @"Fundamentals of modern astrophysics including observations and physical interpretation physical phenomena 
                            in the Universe. Topics include the nature of the Sun and stars, galaxies, and the interstellar medium; 
                            distances and motions in the universe; radiation and telescopes; celestial mechanics; stellar evolution.",
                Color = "#deec8a",
                WtlstCheck = true,
                TimeSelected = true,

                // Notes
                // 1. TR
                // 2. 12pm-2:50pm (LEC)
                // 3. 5pm-6:50pm (LAB) Friday (EVERY OTHER WEEK, show functionality)
            };

            //Creating a list of courses
            CourseData c1 = new CourseData
            {
                ID = 3,
                Number = "CPSC 449",
                PureNumber = 449,
                Title = "Programming Paradigms",
                Seats = "56/60",
                Waitlist = "0/20",
                TutSeats = "28/30",
                TutWaitlist = "0/20",
                Professor = "Kelly Oliver",
                Location = "ST 141",
                Description = @"Examination of the basic principles of the major programming language paradigms. 
                            Focus on declarative paradigms such as functional and logic programming. Data types, 
                            control expressions, loops, types of references, lazy evaluation, different interpretation principles, 
                            information hiding.",
                Color = "#afddb9",
                checkedTime2 = true,
                TimeSelected = true,
                alternateLab = false,

                // Notes
                // 1. MWF
                // 2. 12pm-12:50pm (LEC)
                // 3. 9am-12:50pm (TUT) on Thursdays (TIME CONFLICT FOR PERSONAL TIME)

                // Alternate TUT: 2pm-3:50pm on Wednesday (no conflict here)
            };

            CourseData c2 = new CourseData
            {
                ID = 4,
                Status = 3, 
                Number = "CPSC 481",
                PureNumber = 481,
                Title = "Human-Computer Interaction I",
                Seats = "55/60",
                Waitlist = "0/20",
                TutSeats = "55/60",
                TutWaitlist = "0/20",
                Professor = "Blanche Harvey",
                Location = "ENG E 239",
                Description = @"Fundamental theory and practice of the design, implementation, and evaluation of human-computer interfaces. 
                            Topics include: principles of design; methods for evaluating interfaces with or without user involvement; 
                            techniques for prototyping and implementing graphical user interfaces.",
                Prereq = pc1,
                Color = "#ffd29f",
                TimeSelected = true,
                FormerStatus = 3

                // same times as SENG 300 so entire conflict
            };

            CourseData c3 = new CourseData
            {
                ID = 5,
                Number = "CPSC 399",
                PureNumber = 399,
                Title = "Reverse Engineering",
                Seats = "55/60",
                Waitlist = "0/20",
                TutSeats = "55/60",
                TutWaitlist = "0/20",
                Professor = "Mariam Mitchell",
                Location = "MS 527",
                Description = @"Learn the thought processes and techniques required to reverse engineer binary code and data, and 
                            how to apply those across different platforms using a variety of tools. This knowledge is useful across 
                            many domains, including computer security, archaeology, digital humanities, and game studies.",
                Color = "#c688d6",
                TimeSelected = true,

                // Notes
                // 1. MWF
                // 2. 10am-10:50am (LEC)

                // Time conflict with SENG 300 and CPSC 481
            };

            CourseData c4 = new CourseData
            {
                ID = 6,
                Number = "GEOG 280",
                PureNumber = 280,
                Title = "Thinking Spatially in a Digital World",
                Seats = "55/60",
                Waitlist = "0/20",
                TutSeats = "55/60",
                TutWaitlist = "0/20",
                Professor = "Riya Peterson",
                Location = "ENG G 60",
                Description = @"Introduces mapping technologies and digital spatial data for solving geographical problems that focus 
                            on how to collect, manage, analyze, and communicate diverse spatial data. Topics include geographic information 
                            systems (GIS), remote sensing, spatial statistics, geovisualization, cartography, and web mapping..",
                Color = "#7cebf7",
                TimeSelected = true,
                checkedTime2 = true,

                // Notes
                // 1. TR
                // 2. 4pm-5:50pm (LEC)
            };

            CourseData c5 = new CourseData
            {
                ID = 7,
                Number = "ASTR 209",
                PureNumber = 209,
                Title = "Introduction to Astronomy II - The Cosmos",
                Seats = "55/60",
                Waitlist = "0/20",
                TutSeats = "55/60",
                TutWaitlist = "0/20",
                Professor = "Andrew Hess",
                Location = "ST 140",
                Description = @"A comprehensive, descriptive overview of the universe outside the solar system. The electromagnetic spectrum; 
                            stellar spectra; distance determinations. Origin and evolution of stars; white dwarfs, neutron stars and black 
                            holes. The interstellar medium. Dark matter. Galaxies and quasars. The Big Bang. The fate of the universe.",
                Antireq = ac1,
                Color = "#fcb2b2",
                TimeSelected = true,

                // Notes
                // 1. MWF
                // 2. 1pm - 1:50pm (LEC)
            };

            //making a list/map of courses
            Courses = new Dictionary<string, CourseData>()
            {
                {c1.Number, c1},
                {c2.Number, c2},
                {c3.Number, c3},
                {c4.Number, c4},
                {c5.Number, c5},
                {pc1.Number, pc1},
                {ac1.Number, ac1}
            };
        }

        public static List<CourseData> GetList()
        {
            var list = new List<CourseData>();
            foreach (var item in Courses)
            {
                list.Add(item.Value);
            }

            return list;
        }

        public static Dictionary<string, CourseData> GetMap()
        {
            return Courses;
        }

        public static CourseData GetCourse(string name)
        {
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return null;

            return Courses[name];
        }

        public static int GetID(string name)
        {
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return 0;

            return Courses[name].ID;
        }

        public static int GetStatus(string name)
        {
            // notify if inputted course name does not exist
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return 0;

            return Courses[name].Status;
        }

        public static string GetNumber(string name)
        {
            // notify if inputted course name does not exist
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return "Course does not exist!";

            return Courses[name].Number;
        }

        public static string GetTitle(string name)
        {
            // notify if inputted course name does not exist
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return "Course does not exist!";

            return Courses[name].Title;
        }

        public static string GetSeats(string name)
        {
            // notify if inputted course name does not exist
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return "Course does not exist!";

            return Courses[name].Seats;
        }

        public static string GetWaitlist(string name)
        {
            // notify if inputted course name does not exist
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return "Course does not exist!";

            return Courses[name].Waitlist;
        }

        public static string GetProfessor(string name)
        {
            // notify if inputted course name does not exist
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return "Course does not exist!";

            return Courses[name].Professor;
        }

        public static string GetLocation(string name)
        {
            // notify if inputted course name does not exist
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return "Course does not exist!";

            return Courses[name].Location;
        }

        public static string GetDescription(string name)
        {
            // notify if inputted course name does not exist
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return "Course does not exist!";

            return Courses[name].Description;
        }

        public static CourseData GetPrereq(string name)
        {
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return null;

            return Courses[name].Prereq;
        }

        public static CourseData GetAntireq(string name)
        {
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return null;

            return Courses[name].Antireq;
        }

        public static void SetTitle(string name, string newTitle)
        {
            Courses[name].Title = newTitle;
        }

        public static void SetStatus(string name, int newID)
        {
            Courses[name].Status = newID;
        }

        public static bool GetVisibility(string name)
        {
            // not found or invalid name
            if (string.IsNullOrEmpty(name) || !Courses.ContainsKey(name))
                return false;

            return Courses[name].IsVisible;
        }

    }
}

