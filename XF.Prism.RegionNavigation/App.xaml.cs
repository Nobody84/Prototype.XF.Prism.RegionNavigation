using Prism;
using Prism.Ioc;
using XF.Prism.RegionNavigation.ViewModels;
using XF.Prism.RegionNavigation.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;

namespace XF.Prism.RegionNavigation
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterRegionServices();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

            containerRegistry.RegisterForRegionNavigation<ViewA, ViewAViewModel>("ViewA");
            containerRegistry.RegisterForRegionNavigation<ViewB, ViewBViewModel>("ViewB");
        }
    }
}
