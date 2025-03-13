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

namespace GameUI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        SetupImage();
    }

    public void SetupImage()
    {
        // Create the image element.
        //Image simpleImage = new Image();
        TestImage1.Width = 200;
        TestImage1.Margin = new Thickness(5);

        // Create source.
        BitmapImage bi = new BitmapImage();
        // BitmapImage.UriSource must be in a BeginInit/EndInit block.
        bi.BeginInit();
        bi.UriSource = new Uri("C://Users/renal/OneDrive/Pictures/TI4_Bitmaps/JolnarCardBackTI3.jpg", UriKind.Absolute);
        bi.EndInit();
        // Set the image source.
        TestImage1.Source = bi;
        
    }
}