using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace GameUI.Visible.Pages
{
    /// <summary>
    /// Interaction logic for Page_MainMenu.xaml
    /// </summary>
    public partial class Page_MainMenu : Page
    {
        public Page_MainMenu()
        {
            InitializeComponent();
        }

        private void StartNewGame_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_StartNewGame());
        }

        private void LoadSavedGame_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_LoadGame());
        }

        private void CreateCustomScenario_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_CustomScenario());
        }

        private void CreateCustomObjects_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_ObjectsEditor());
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_Settings());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
