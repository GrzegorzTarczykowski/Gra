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
using Gra.ViewModel.PlaygroundHandler;

namespace Gra.View
{
    /// <summary>
    /// Interaction logic for MainPlaygroundPage.xaml
    /// </summary>
    public partial class MainPlaygroundPage : Page
    {
        public MainPlaygroundPage()
        {
            InitializeComponent();
            DataContext = new MainPlaygroundPageHandler();
            Loaded += MainPlaygroundPage_Loaded;
        }

        private void MainPlaygroundPage_Loaded(object sender, RoutedEventArgs e)
        {
            double spaceBetweenFramesInWidth = (this.ActualWidth * 3) / 100;
            double spaceBetweenFramesInHeight = (this.ActualHeight * 3) / 100;
            frameMap.Width = (this.ActualWidth * 71) / 100;
            frameMap.Height = (this.ActualHeight * 69) / 100;
            frameMap.Margin = new Thickness(spaceBetweenFramesInWidth, spaceBetweenFramesInHeight, spaceBetweenFramesInWidth, spaceBetweenFramesInHeight);
            frameCharacterPlace.Width = (this.ActualWidth * 20) / 100;
            frameCharacterPlace.Height = (this.ActualHeight * 69) / 100;
            frameCharacterPlace.Margin = new Thickness(spaceBetweenFramesInWidth, spaceBetweenFramesInHeight, spaceBetweenFramesInWidth, spaceBetweenFramesInHeight);
            frameActionPlace.Width = (this.ActualWidth * 94) / 100;
            frameActionPlace.Height = (this.ActualHeight * 22) / 100;
            frameActionPlace.Margin = new Thickness(spaceBetweenFramesInWidth, spaceBetweenFramesInHeight, spaceBetweenFramesInWidth, spaceBetweenFramesInHeight);
        }
    }
}
