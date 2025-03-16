using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace CommonEntities
{
    public static class ImageResources
    {
        //URI of images folder
        public const string ResourceFolder = "C://Users/renal/OneDrive/Pictures/TI4_Bitmaps/";

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
        public static Bitmap Leadership = new(ResourceFolder + "Card_Strategy_Leadership.jpg");
        public static Bitmap Diplomacy = new(ResourceFolder + "Card_Strategy_Diplomacy.jpg");
        public static Bitmap Politics = new(ResourceFolder + "Card_Strategy_Politics.jpg");
        public static Bitmap Construction = new(ResourceFolder + "Card_Strategy_Construction.jpg");
        public static Bitmap Trade = new(ResourceFolder + "Card_Strategy_Trade.jpg");
        public static Bitmap Warfare = new(ResourceFolder + "Card_Strategy_Warfare.jpg");
        public static Bitmap Technology = new(ResourceFolder + "Card_Strategy_Technology.jpg");
        public static Bitmap Imperial = new(ResourceFolder + "Card_Strategy_Imperial.jpg");
        

    }
}
