using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GenshinImpactHelper.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TranslateTransform trans1 = new TranslateTransform();
            trans1.X -= 100;
            amber.RenderTransform = trans1;

            DoubleAnimation amberAnimation = new DoubleAnimation(-100, 0, TimeSpan.FromSeconds(2));
            trans1.BeginAnimation(TranslateTransform.XProperty, amberAnimation);

            TranslateTransform trans2 = new TranslateTransform();
            trans2.X += 160;
            lisa.RenderTransform = trans2;

            DoubleAnimation lisaAnimation = new DoubleAnimation(160, 0, TimeSpan.FromSeconds(2));
            trans2.BeginAnimation(TranslateTransform.XProperty, lisaAnimation);

            TranslateTransform trans3 = new TranslateTransform();
            trans3.Y -= 110;
            logo.RenderTransform = trans3;

            DoubleAnimation logoAnimation = new DoubleAnimation(-110, 0, TimeSpan.FromSeconds(1.5));
            logoAnimation.BeginTime = TimeSpan.FromSeconds(2);
            trans3.BeginAnimation(TranslateTransform.YProperty, logoAnimation);

        }
    }
}
