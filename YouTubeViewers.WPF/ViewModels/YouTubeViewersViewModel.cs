using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YouTubeViewers.WPF.ViewModels
{
    public class YouTubeViewersViewModel : ViewModelBase
    {
        public YoutubeViewersListingViewModel YoutubeViewersListingViewModel { get; }
        public YouTubeViewersDetailsViewModel YouTubeViewersDetailsViewModel { get; }

        public ICommand AddYoTubeViewrsCommand { get; }

        public YouTubeViewersViewModel()
        {
            YoutubeViewersListingViewModel = new YoutubeViewersListingViewModel();
            YouTubeViewersDetailsViewModel = new YouTubeViewersDetailsViewModel();
        }
    }
}
