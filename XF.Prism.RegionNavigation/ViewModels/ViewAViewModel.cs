using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Regions;
using Prism.Regions.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XF.Prism.RegionNavigation.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {

        public ViewAViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "View A";         
        }
    }
}
