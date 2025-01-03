using CPSC481_FinalProject.Shared;

namespace CPSC481_FinalProject.Services
{
    public interface IAdvancedSearchState
    {
        event Action OnAdvancedSearchStateChanged;

        Dictionary<string, advancedSearchData> AdvancedSearches { get; set; }

        IList<advancedSearchData> selectedAdvancedSearchCriteria { get; set; }
    }
}
