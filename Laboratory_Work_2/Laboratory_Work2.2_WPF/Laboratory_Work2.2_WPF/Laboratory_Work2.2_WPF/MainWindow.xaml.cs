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

namespace Laboratory_Work2._2_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double sliderValue;

        public string[] fonts { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            RTB.Document.FontSize = slider.Value + 20;

            fonts = new string[] { "Calibri", "Algerian", "Goudy Stout" };

            DataContext = this;

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderValue = slider.Value;

            RTB.Document.FontSize = sliderValue * 3 + 20;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch (CB.SelectedIndex)
            { 
                case 0:
                    RTB.Selection.ApplyPropertyValue(System.Windows.Controls.RichTextBox.FontFamilyProperty, "Calibri");
                    RTB.Focus();
                         break;

                case 1:
                    RTB.Selection.ApplyPropertyValue(System.Windows.Controls.RichTextBox.FontFamilyProperty, "Algerian");
                    RTB.Focus();
                    break;
                case 2:
                    RTB.Selection.ApplyPropertyValue(System.Windows.Controls.RichTextBox.FontFamilyProperty, "Goudy Stout");
                    RTB.Focus();
                    break;
            }
               
            
                

        }
    }
}
