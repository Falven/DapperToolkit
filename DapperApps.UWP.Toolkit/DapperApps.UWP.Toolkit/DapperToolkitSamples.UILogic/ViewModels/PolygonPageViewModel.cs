using Prism.Windows.AppModel;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;

namespace DapperToolkitSamples.ViewModels
{
    public class PolygonPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly ISessionStateService _sessionStateService;

        public PolygonPageViewModel(INavigationService navigationService, ISessionStateService sessionStateService)
        {
            _navigationService = navigationService;
            _sessionStateService = sessionStateService;
        }
    }
}
