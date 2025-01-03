using CPSC481_FinalProject.Shared;

namespace CPSC481_FinalProject.Services
{
    public interface ITermState
    {
        event Action OnTermStateChanged;

        string term { get; set; }

        void setTermState(string newTerm);

        string getTermState();
    }
}