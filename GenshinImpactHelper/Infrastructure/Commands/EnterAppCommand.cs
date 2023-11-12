using GenshinImpactHelper.Infrastructure.Commands.Base;
using GenshinImpactHelper.Views.Windows;
using System.Windows;

namespace GenshinImpactHelper.Infrastructure.Commands
{
    internal class EnterAppCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            var mainWindow = Application.Current.MainWindow;
            mainWindow.Hide();
            AppWindow appWindow = new AppWindow();
            appWindow.Show();
        }
    }
}
