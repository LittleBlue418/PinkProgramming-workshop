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
        public MainWindow()
        {
            InitializeComponent();
            drawLines();
            
        }

        void drawLines()
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


