using System.Collections.ObjectModel;
using DapperToolkitSamples.Models;
using Prism.Commands;
using Prism.Windows.AppModel;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;

namespace DapperToolkitSamples.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly ISessionStateService _sessionStateService;

        private ObservableCollection<Sample> _samples;

        public MainPageViewModel(INavigationService navigationService, ISessionStateService sessionStateService)
        {
            _navigationService = navigationService;
            _sessionStateService = sessionStateService;

            Samples = new ObservableCollection<Sample>
            {
                new Sample("Scroll Events", "Scroll Events",
                    new DelegateCommand(() => _navigationService.Navigate("ScrollEvents", null))),
                new Sample("Polygons", "Polygons",
                    new DelegateCommand(() => _navigationService.Navigate("Polygon", null)))
            };
        }

        public ObservableCollection<Sample> Samples
        {
            get { return _samples; }
            set { SetProperty(ref _samples, value); }
        }
    }
}