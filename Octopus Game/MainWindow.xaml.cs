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

namespace Octopus_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Octopus myOctopus;
        Food myFood;
        
        public MainWindow()
        {
            InitializeComponent();
            drawLines();

            Random randomGenerator = new Random();
            int randomX = randomGenerator.Next(8);
            int randomY = randomGenerator.Next(8);
            myOctopus = new Octopus(randomX, randomY, 8);

            int a = randomGenerator.Next(8);
            int b = randomGenerator.Next(8);
            myFood = new Food(a, b, 8);

            drawOctopus();
            drawFood();


        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.Key == Key.Up)
            {
                myOctopus.moveUp();
            }
            else if (e.Key == Key.Down)
            {
                myOctopus.moveDown();
            }
            else if (e.Key == Key.Left)
            {
                myOctopus.moveLeft();
            }
            else if (e.Key == Key.Right)
            {
                myOctopus.moveRight();
            }

            drawOctopus();
        }

        private void drawOctopus()
        {
            Canvas.SetLeft(OctopusIMG, myOctopus.X * 50);
            Canvas.SetTop(OctopusIMG, myOctopus.Y * 50);
        }

        private void drawFood()
        {
            Canvas.SetLeft(goldfishIMG, myFood.X * 50);
            Canvas.SetTop(goldfishIMG, myFood.Y * 50);
        }

        private void drawLines()
        {
              /* Horizontal Lines
              * X1   Y1   X2   Y2
              * 0    0    400  0
              * 0    50   400  50
              * 0    100  400  100
              * ...
              *  Vertical Lines
              * X1   Y1   X2   Y2
              * 0    0    0    400
              * 50   0    50   400
              * 100  0    100  400
              * ...*/

            for (int y = 0; y <= 400; y += 50)
            {

                Line line = new Line();
                line.X1 = 0;
                line.Y1 = y;
                line.X2 = 400;
                line.Y2 = y;
                line.Stroke = Brushes.Black;

                canvas.Children.Add(line);

            }

            for (int x = 0; x <= 400; x += 50)
            {

                Line line = new Line();
                line.X1 = x;
                line.Y1 = 0;
                line.X2 = x;
                line.Y2 = 400;
                line.Stroke = Brushes.Black;

                canvas.Children.Add(line);

            }

        }
    }
}


