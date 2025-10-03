using GameUI.Resources;
using GameUI.Visible.Pages;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TI4_GameEngine.Objects;
using static System.Net.Mime.MediaTypeNames;

namespace GameUI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        MainFrame.Navigate(new Page_MainMenu());
        //TestImages();
    }

    //Below commented out code was used to demonstrate and test flipping strategy cards between the "front" and "back" images,
    //and should be architectured into different class objects to be cleaner behavior and code written intuitively.

    //Card card1;
    //bool frontVisible = true;

    //public void TestImages()
    //{
    //    Console.WriteLine(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "GameUI/Resources/TI4_Bitmaps/"));

    //    //Test Card object
    //    Card leadership = new StrategyCard(StrategyTypes.LEADERSHIP) {Front = ImageResources.LeadershipFront,
    //        Back = ImageResources.LeadershipBack,
    //        Name = "Leadership",
    //        action = () => { Console.WriteLine("Leadership Action"); }
    //    };
        
    //    card1 = leadership;
    //    //Card diplomacy = new StrategyCard(StrategyTypes.DIPLOMACY);
    //    //Card politics = new StrategyCard(StrategyTypes.POLITICS);
    //    //Card construction = new StrategyCard(StrategyTypes.CONSTRUCTION);
    //    //Card trade = new StrategyCard(StrategyTypes.TRADE);
    //    //Card warfare = new StrategyCard(StrategyTypes.WARFARE);
    //    //Card technology = new StrategyCard(StrategyTypes.TECHNOLOGY);
    //    //Card imperial = new StrategyCard(StrategyTypes.IMPERIAL);

    //    // Set the image sources.
    //    Card1.Source = leadership.Front;
    //    //Card2.Source = diplomacy.Front;
    //    //Card3.Source = politics.Front;
    //    //Card4.Source = construction.Front;
    //    //Card5.Source = trade.Front;
    //    //Card6.Source = warfare.Front;
    //    //Card7.Source = technology.Front;
    //    //Card8.Source = imperial.Front;

    //}

    //private void Card1_MouseDown(object sender, MouseButtonEventArgs e)
    //{
    //    if (frontVisible)
    //    {
    //        Card1.Source = card1.Back;
    //    }
    //    else
    //    {
    //        Card1.Source = card1.Front;
    //    }
    //    frontVisible = !frontVisible;
    //}

    //private void Change_View(object sender, MouseButtonEventArgs e)
    //{
    //}

    //private void GoToBoard_Click(object sender, RoutedEventArgs e)
    //{
    //    MainFrame.Navigate(new Uri("Objects/Board.xaml", UriKind.Relative));
    //}
}