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

namespace GameUI.Objects
{
    /// <summary>
    /// Interaction logic for StrategyControl.xaml
    /// </summary>
    public partial class StrategyControl : UserControl
    {
        required public string Description;
        required public string CardName;
        required public BitmapImage FrontImage;
        required public BitmapImage BackImage;
        required public Action ActivateAction;
        public StrategyControl()
        {
            InitializeComponent();
        }

        // Double Left Click to activate
        // Left click once to activate with confirmation prompt
        // Right click to view back of card
        // Hold right click for longer description
        // Mouse over for short description

        private void Image_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ActivateAction = StubPerformAction;
            ActivateAction(); // Performs action
        }

        // Below code is for testing purposes and should be replaced by assignment of the class at instantiation
        bool flipped = false;
        private void StubPerformAction()
        {
            if(flipped = !flipped)
            {
                CardImage.Source = BackImage;
            }
            else
            {
                CardImage.Source = FrontImage;
            }
            Console.WriteLine($"Performing action for {CardName}. {Description}");
            // TODO: Flip card between front and back images
        }
    }
}
