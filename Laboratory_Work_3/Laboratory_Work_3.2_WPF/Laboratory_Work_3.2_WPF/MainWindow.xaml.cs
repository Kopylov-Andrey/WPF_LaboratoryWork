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


namespace Laboratory_Work_3._2_WPF
{
    

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double firstPointX = 0;
        double firstPointY = 0;
        Polyline polygon = new Polyline();
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (firstPointX == 0 && firstPointY == 0)
            {
                polygon.Stroke = Brushes.Black;
                ContentPanel.Children.Add(polygon);
            }
            else
            {
                polygon.Points.Add(new Point(firstPointX, firstPointY));
            }
        }

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (firstPointX == 0 && firstPointY == 0)
            {
                firstPointX = e.GetPosition(canvas).X;
                firstPointY = e.GetPosition(canvas).Y;
            }
           
            polygon.Points.Add(new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y));
            
        }
    }
}
