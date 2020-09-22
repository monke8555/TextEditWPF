using System;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace TextEditWPF {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            Splash();
        }
        
        private async void Splash() {
            Storyboard FadeSplashScreen = FindResource("MakeSmaller") as Storyboard;
            FadeSplashScreen.Completed += StartMain;
            await Task.Delay(2000);
            FadeSplashScreen.Begin();
        }

        private void CloseW(object sender, RoutedEventArgs e) {
            Close();
        }
        private void MinimizeW(object sender, RoutedEventArgs e) {
            WindowState = WindowState.Minimized;
        }

        private void StartMain(object sender, EventArgs e) {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
