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

namespace Laboratory_Work_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Shape shape;
        private TransformGroup trGoup = new TransformGroup();
        private RotateTransform rotate = new RotateTransform(0);
        private ScaleTransform scale = new ScaleTransform(1,1);
        private TranslateTransform translate = new TranslateTransform(0, 0);

        public MainWindow()
        {
            InitializeComponent();
            trGoup.Children.Add(rotate);
            trGoup.Children.Add(scale);
            trGoup.Children.Add(translate);
        }

        private void RadioButton_Click_Rectangle(object sender, RoutedEventArgs e)
        {
            if (shape != null && shape.RenderTransform != null )
            {
                shape.RenderTransform = null;
                shape = null;
            }

            shape = Rectangle;
            shape.RenderTransform = trGoup;
        }

        private void RadioButton_Click_Elipse(object sender, RoutedEventArgs e)
        {
            if (shape != null && shape.RenderTransform != null)
            {
                shape.RenderTransform = null;
                shape = null;
            }
            shape = Ellipse;
            shape.RenderTransform = trGoup;
        }

        private void RadioButton_Click_Line(object sender, RoutedEventArgs e)
        {
            if (shape != null && shape.RenderTransform != null)
            {
                shape.RenderTransform = null;
                shape = null;
            }
            shape = Line;

            shape.RenderTransform = trGoup;
        }

        private void RadioButton_Click_Polygon(object sender, RoutedEventArgs e)
        {
            if (shape != null && shape.RenderTransform != null)
            {
                shape.RenderTransform = null;
                shape = null;
            }
            shape = Polygon;

            shape.RenderTransform = trGoup;
        }

        private void RadioButton_Click_Image(object sender, RoutedEventArgs e)
        {
            if (shape != null && shape.RenderTransform != null)
            {
                shape.RenderTransform = null;
                shape = null;
            }
            shape = Image;
            shape.RenderTransform = trGoup;
        }

        private void OnValueChangedAngle(object sender, RoutedPropertyChangedEventArgs<double> e)
        {           
           rotate.Angle = SlRotate.Value;
        }

        private void SlCenterX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rotate.CenterX = SlCenterX.Value;
        }

        private void SlCenterY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rotate.CenterY = SlCenterY.Value;
        }

        private void SlScaleY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            scale.ScaleY = SlScaleY.Value;
        }

        private void SlScaleX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            scale.ScaleX = SlScaleX.Value;
        }

        private void SlPositionX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            translate.X = SlPositionX.Value;
        }

        private void SlPositionY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            translate.Y = SlPositionY.Value;
        }
    }
}
