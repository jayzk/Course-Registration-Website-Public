using System.ComponentModel.DataAnnotations;
namespace CPSC481_FinalProject.Shared
{

    public class advancedSearchData
    {
        public string ID { get; set; }
        public string? SubjectInput { get; set; }

        public string? SubjectInput2 {get; set;}

        public string? ExcludeSubjectInput {get; set;}

        public string? ExcludeSubjectInput2 {get; set;}

        public string? CourseNumSymbolInput { get; set; }
        public int? CourseNumInput { get; set; }
    }

    public static class advancedSearchParamaters
    {
        //There is just one advanced search, doing like this because it is how CourseList works
        private static Dictionary<string, advancedSearchData>? AdvancedSearches { get; set; }

        static advancedSearchParamaters()
        {
        advancedSearchData asd = new advancedSearchData()
            {
                ID = "asd",
                SubjectInput = "",
                SubjectInput2 = "",
                ExcludeSubjectInput = "",
                ExcludeSubjectInput2 = "",
                CourseNumSymbolInput = "eq",
                CourseNumInput = null

            };

            AdvancedSearches = new Dictionary<string, advancedSearchData>()
            {
                {asd.ID, asd}
            };
        }

        public static string? getSubjectInput()
        {
            return AdvancedSearches["asd"].SubjectInput;
        }

        public static string? getSubjectInput2()
        {
            return AdvancedSearches["asd"].SubjectInput2;
        }

        public static string? getExcludeSubjectInput()
        {
            return AdvancedSearches["asd"].ExcludeSubjectInput;
        }

        public static string? getExcludeSubjectInput2()
        {
            return AdvancedSearches["asd"].ExcludeSubjectInput2;
        }

        public static string? getCourseNumSymbolInput()
        {
            return AdvancedSearches["asd"].CourseNumSymbolInput;
        }

        public static int? getCourseNumInput()
        {
            return AdvancedSearches["asd"].CourseNumInput;
        }

        public static void setSubjectInput(string newContent)
        {
            AdvancedSearches["asd"].SubjectInput = newContent;
        }

        public static void setSubjectInput2(string newContent)
        {
            AdvancedSearches["asd"].SubjectInput2 = newContent;
        }

        public static void setExcludeSubjectInput(string newContent)
        {
            AdvancedSearches["asd"].ExcludeSubjectInput = newContent;
        }

        public static void setExcludeSubjectInput2(string newContent)
        {
            AdvancedSearches["asd"].ExcludeSubjectInput2 = newContent;
        }

        public static void setCourseNumSymbolInput(string newContent)
        {
            AdvancedSearches["asd"].CourseNumSymbolInput = newContent;
        }

        public static void setCourseNumInput(int? newContent)
        {
            AdvancedSearches["asd"].CourseNumInput = newContent;
        }
    }
}