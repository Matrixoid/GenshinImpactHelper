using GenshinImpactHelper.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinImpactHelper.ViewModels
{
    internal class AppWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _title;

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
        #endregion

        public AppWindowViewModel()
        {
            Title = "GenshinImpactHelper";
        }
    }
}
