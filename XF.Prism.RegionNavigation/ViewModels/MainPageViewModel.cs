using Prism.Commands;
using Prism.Navigation;
using Prism.Regions;
using Prism.Regions.Navigation;

namespace XF.Prism.RegionNavigation.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private IRegionManager regionManager;
        private string navigationResultMessage;

        public MainPageViewModel(INavigationService navigationService, IRegionManager regionManager)
            : base(navigationService)
        {
            Title = "Main Page";
            this.regionManager = regionManager;
            this.NavigateToMainRegionCommand = new DelegateCommand<string>(this.NavigateToMainRegion);
        }

        public DelegateCommand<string> NavigateToMainRegionCommand { get; private set; }

        public string NavigationResultMessage
        {
            get => navigationResultMessage;
            set => this.SetProperty(ref this.navigationResultMessage, value, nameof(this.NavigationResultMessage));
        }

        private void NavigateToMainRegion(string target)
        {
            this.regionManager.RequestNavigate("MainRegion", target, NavigationCallback, null);
        }

        private void NavigationCallback(IRegionNavigationResult result)
        {
            this.NavigationResultMessage = $"Navigation result: Sucessfull={result.Result}, ErrorMessage={result.Error.Message}";
        }
    }
}
