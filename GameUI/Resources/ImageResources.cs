using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace GameUI.Resources
{
    public static class ImageResources
    {
        //URI of images folder
        //public const string ResourceFolder = "C://Users/renal/OneDrive/Pictures/TI4_Bitmaps/";
        public static string ResourceFolder = Path.Combine(GetSolutionPath(), "Resources/TI4_Bitmaps/");

        //Front and back generics of cards
        public const string TechCardBack = "Back_Tech_Card_1.jpg";
        public const string TechCardFront = "space_stars_generic.jpg";
        public const string ActionCardFront = "";
        public const string ActionCardBack = "";
        public const string PlanetCardFront = "";
        public const string PlanetCardBack = "";
        public const string PromissoryCardFront = "";
        public const string PromissoryCardBack = "";

        //Front of strategy cards
        public static BitmapImage Leadership = new(new Uri(ResourceFolder + "Card_Strategy_Leadership.png"));
        public static BitmapImage Diplomacy = new(new Uri(ResourceFolder + "Card_Strategy_Diplomacy.png"));
        public static BitmapImage Politics = new(new Uri(ResourceFolder + "Card_Strategy_Politics.png"));
        public static BitmapImage Construction = new(new Uri(ResourceFolder + "Card_Strategy_Construction.png"));
        public static BitmapImage Trade = new(new Uri(ResourceFolder + "Card_Strategy_Trade.png"));
        public static BitmapImage Warfare = new(new Uri(ResourceFolder + "Card_Strategy_Warfare.png"));
        public static BitmapImage Technology = new(new Uri(ResourceFolder + "Card_Strategy_Technology.png"));
        public static BitmapImage Imperial = new(new Uri(ResourceFolder + "Card_Strategy_Imperial.png"));

        public static string GetSolutionPath()
        {
            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(assemblyPath)) ?? "";
            solutionPath = Path.Combine(solutionPath, @"..\..\");
            return solutionPath;
        }
    }
}
