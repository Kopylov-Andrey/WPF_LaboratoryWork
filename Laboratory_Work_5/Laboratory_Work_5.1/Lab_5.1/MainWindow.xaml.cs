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

namespace Lab_5._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(sender is TextBox)
            {
                rb_TextBox.IsChecked = true;
                MessageBox.Show("Событие от TextBox");
            }
            else if (sender is Grid)
            {
                rb_Grid.IsChecked = true;
                MessageBox.Show("Событие выше, в Grid");
            }
            else if (sender is Window)
            {
                rb_Window.IsChecked = true;
                MessageBox.Show("Событие выше, в Window");
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
