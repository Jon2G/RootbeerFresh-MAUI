using RootBeerFresh;
using System.Windows.Input;

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class MainPageViewModel : BindableObject
    {
        public ICommand CheckForRootCommand { get; }
        public List<RootItemResult> ItemResults { get; set; }
        public bool IsRooted { get; set; } = false;
        public bool IsNotRooted { get; set; } = false;
        public MainPageViewModel()
        {
            this.CheckForRootCommand = new Command(CheckForRoot);
        }

        private void CheckForRoot()
        {
#if ANDROID
            RootBeer rootBeer = new RootBeer();
            this.ItemResults = rootBeer.GetRootItemResults();
            OnPropertyChanged(nameof(ItemResults));
            this.IsRooted = rootBeer.IsRooted;
            this.IsNotRooted = !rootBeer.IsRooted;
            OnPropertyChanged(nameof(IsRooted));
            OnPropertyChanged(nameof(IsNotRooted));
#endif
        }
    }
}
