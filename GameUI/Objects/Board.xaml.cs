using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using GameUI.Resources;

namespace GameUI.Objects
{
    /// <summary>
    /// Interaction logic for Board.xaml
    /// </summary>
    public partial class Board : Page
    {
        private double hexWidth = 90; // width of a hexagon
        private double hexHeight = 90;
        private double horizontalSpacing;
        private double verticalSpacing;

        public Board()
        {
            InitializeComponent();
            PositionBoard();
            // Calculate height of the hexagon (pointy-topped)
            //horizontalSpacing = Math.Sqrt(3) * hexWidth / 2;
            double hexWidth = 60; // set your desired width
            double verticalSpacing = Math.Sqrt(3) / 2 * hexWidth; // maintain 1:√3 ratio for regular hexagons
            // Calculate spacing
            horizontalSpacing = hexWidth;
            //verticalSpacing = hexHeight;

            // Place hexagons
            CreateHexagonalBoard();
            //TestTileLayout();
        }

        private void PositionBoard()
        {
            // Set the position of the Canvas in the Frame
            Canvas.SetLeft(HexGrid, 100);  // Set position of HexGrid to X=100
            Canvas.SetTop(HexGrid, 600);    // Set position of HexGrid to Y=50
        }

        public void TestTileLayout()
        {
            Console.WriteLine(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "GameUI/Resources/TI4_Bitmaps/"));

            //Tile1.Source = ImageResources.Empty_Space_S;
            //Tile2.Source = ImageResources.Empty_Space_S;
            //Tile3.Source = ImageResources.Empty_Space_S;
            //Tile4.Source = ImageResources.Empty_Space_S;
        }

        private void CreateHexagonalBoard()
        {
            int radius = 3; //Size of the board
            double hexWidth = 45;
            double hexHeight = Math.Sqrt(3) / 2 * hexWidth;

            for (int q = -radius; q <= radius; q++)
            {
                int r1 = Math.Max(-radius, -q - radius);
                int r2 = Math.Min(radius, -q + radius);

                for (int r = r1; r <= r2; r++)
                {
                    double x = hexWidth * 0.70 * q;
                    double y = hexHeight * (r + q / 2.0);

                    CreateHexagon(x, y);
                }
            }
        }

        private void CreateHexagon(double x, double y)
        {
            // Create an Image to represent the hexagon (or use a custom Hexagon Shape)
            Image tile = new Image
            {
                Width = hexWidth,
                Height = hexHeight
            };

            //Insetset
            double clipInset = 0.45; // 5% smaller (adjust as needed)
            double scale = 1.0 - clipInset;
            // Define hexagonal clipping path
            var clip = new PathGeometry(new PathFigureCollection
        {
            new PathFigure(new Point(0, hexHeight/2), new LineSegment[]
            {
                new LineSegment(new Point(0.25*hexWidth    , hexHeight)    , true),
                new LineSegment(new Point(0.75*hexWidth    , hexHeight)    , true),
                new LineSegment(new Point(hexWidth         , hexHeight/2)  , true),
                new LineSegment(new Point(0.75*hexWidth    , 0)            , true),
                new LineSegment(new Point(0.25*hexWidth    , 0)            , true),
            }, true)
        }                                                        );

            // Optionally, set the image source
            tile.Source = ImageResources.Empty_Space_S; // or your own image

            // Set the position using Canvas.Left and Canvas.Top
            tile.SetValue(Canvas.LeftProperty, x);
            tile.SetValue(Canvas.TopProperty, y);

            // Apply scaling centered on the hexagon center
            clip.Transform = new ScaleTransform(clipInset, clipInset, hexWidth / 2, hexHeight / 2);
            tile.Clip = clip;

            // Add the tile to the canvas
            HexGrid.Children.Add(tile);
        }

    }
}



