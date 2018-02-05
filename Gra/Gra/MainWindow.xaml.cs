using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Gra.View;
using Gra.ViewModel;

namespace Gra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModelLocator.MainWindowHandlerProperty;
            Loaded += MainWindow_Loaded;
            ViewModelLocator.LoginPageHandlerProperty.ClickedButtonEnterGame += OnClickedButtonEnterGame;
        }

        private void OnClickedButtonEnterGame(object o, EventArgs e)
        {
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModelLocator.MainWindowHandlerProperty.SlidedFrame = new LoginPage();
        }
    }
}
