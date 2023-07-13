using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AccordionTest
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        bool firstCardOpened;

        [ObservableProperty]
        bool secondCardOpened;

        [ObservableProperty]
        bool thirdCardOpened;

        [ObservableProperty]
        bool fourthCardOpened;

        [RelayCommand]
        void CardToggle(string toggleName)
        {
            switch (toggleName)
            {
                case "first":
                    this.FirstCardOpened = !this.FirstCardOpened;
                    break;
                case "second": 
                    this.SecondCardOpened = !this.SecondCardOpened;
                    break;
                case "third":
                    this.ThirdCardOpened = !this.ThirdCardOpened;
                    break;
                case "fourth":
                    this.FourthCardOpened = !this.FourthCardOpened;
                    break;
                default:
                    break;
            }
        }

    }
}
