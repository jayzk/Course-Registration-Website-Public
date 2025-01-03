using CPSC481_FinalProject.Shared;
using Microsoft.AspNetCore.Components;

namespace CPSC481_FinalProject.Services
{
    public class termState : ITermState
    {
        public event Action OnTermStateChanged;

        private string _term { get; set; }
        public string term
        {
            get => _term;
            set
            {
                _term = value;
                OnTermStateChanged?.Invoke();
            }
        }

        public void setTermState(string newTerm){
            term = newTerm;
        }

        public string? getTermState(){
            return term;
        }
    }
}
