using CPSC481_FinalProject.Shared;
using Microsoft.AspNetCore.Components;

namespace CPSC481_FinalProject.Services
{
    public class advancedSearchState : IAdvancedSearchState
    {
        public event Action OnAdvancedSearchStateChanged;

        public Dictionary<string, advancedSearchData>? AdvancedSearches { get; set; }

        private IList<advancedSearchData> _selectedAdvancedSearchCriteria { get; set; } = new List<advancedSearchData>();
        public IList<advancedSearchData> selectedAdvancedSearchCriteria
        {
            get => _selectedAdvancedSearchCriteria;
            set
            {
                _selectedAdvancedSearchCriteria = value;
                OnAdvancedSearchStateChanged?.Invoke();
            }
        }
    }
}
