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

        // Default card back image to use if none is specified
        public const string DefaultCardBack = "Back_Card.jpg";
        public static BitmapImage DefaultCardBackImage = new(new Uri(ResourceFolder + DefaultCardBack));    

        //Front and back generics of cards
        public const string TechCardBack = "Back_Tech_Card_1.jpg";
        public const string TechCardFront = "";
        public const string ActionCardFront = "";
        public const string ActionCardBack = "";
        public const string PlanetCardFront = "";
        public const string PlanetCardBack = "";
        public const string PromissoryCardFront = "";
        public const string PromissoryCardBack = "";

        //Front of strategy cards
        public static BitmapImage LeadershipFront = new(new Uri(ResourceFolder + "Card_Strategy_Leadership.png"));
        public static BitmapImage DiplomacyFront = new(new Uri(ResourceFolder + "Card_Strategy_Diplomacy.png"));
        public static BitmapImage PoliticsFront = new(new Uri(ResourceFolder + "Card_Strategy_Politics.png"));
        public static BitmapImage ConstructionFront = new(new Uri(ResourceFolder + "Card_Strategy_Construction.png"));
        public static BitmapImage TradeFront = new(new Uri(ResourceFolder + "Card_Strategy_Trade.png"));
        public static BitmapImage WarfareFront = new(new Uri(ResourceFolder + "Card_Strategy_Warfare.png"));
        public static BitmapImage TechnologyFront = new(new Uri(ResourceFolder + "Card_Strategy_Technology.png"));
        public static BitmapImage ImperialFront = new(new Uri(ResourceFolder + "Card_Strategy_Imperial.png"));

        public static BitmapImage LeadershipBack = new(new Uri(ResourceFolder + "Card_Strategy_Leadership_Back.png"));
        public static BitmapImage DiplomacyBack = new(new Uri(ResourceFolder + "Card_Strategy_Diplomacy_Back.png"));
        public static BitmapImage PoliticsBack = new(new Uri(ResourceFolder + "Card_Strategy_Politics_Back.png"));
        public static BitmapImage ConstructionBack = new(new Uri(ResourceFolder + "Card_Strategy_Construction_Back.png"));
        public static BitmapImage TradeBack = new(new Uri(ResourceFolder + "Card_Strategy_Trade_Back.png"));
        public static BitmapImage WarfareBack = new(new Uri(ResourceFolder + "Card_Strategy_Warfare_Back.png"));
        public static BitmapImage TechnologyBack = new(new Uri(ResourceFolder + "Card_Strategy_Technology_Back.png"));
        public static BitmapImage ImperialBack = new(new Uri(ResourceFolder + "Card_Strategy_Imperial_Back.png"));

        public static string GetSolutionPath()
        {
            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(assemblyPath)) ?? "";
            solutionPath = Path.Combine(solutionPath, @"..\..\"); // Back out of bin/debug/ folder to main directory for consistent resource location
            return solutionPath;
        }
    }
}
