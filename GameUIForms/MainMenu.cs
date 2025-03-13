namespace GameUIForms
{
    public partial class MainMenu : Form
    {
        Bitmap testMap = new CommonEntities.Image().image;

        public MainMenu()
        {
            InitializeComponent();

            Graphics graphics = new();
        }
    }
}
