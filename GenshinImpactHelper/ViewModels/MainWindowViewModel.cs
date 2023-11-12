using GenshinImpactHelper.ViewModels.Base;

namespace GenshinImpactHelper.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _title;

        public string Title {
            get => _title;
            set => Set(ref _title, value);
        }
        #endregion

        public MainWindowViewModel()
        {
            Title = "GenshinImpactHelper";
        }
    }
}
