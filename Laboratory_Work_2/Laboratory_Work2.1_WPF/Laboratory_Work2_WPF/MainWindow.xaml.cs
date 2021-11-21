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

namespace Laboratory_Work2_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] shape { get; set; }

        private double firstNum { get { return double.Parse(firstTB.Text); } }
        private double secondNum { get { return double.Parse(secondTB.Text); } }

        public MainWindow()
        {
            InitializeComponent();

            shape = new string[] { "окужность", "прямоугольник", "квадрат" };

            DataContext = this;

            firstTB.Text = "0";
            secondTB.Text = "0";
        }

        private void ComBox_DropDownClosed(object sender, EventArgs e)
        {
            

            switch (ComBox.SelectedIndex)
            {
                case 0:
                    Circle circle = new Circle(firstNum);
                    area.Text = circle.Area().ToString();
                    perimetr.Text = circle.Perimetr().ToString();
                    break;

                case 1:
                    Rect rect = new Rect(firstNum, secondNum);
                    area.Text = rect.Area().ToString();
                    perimetr.Text = rect.Perimetr().ToString();
                    break;

                case 2:
                    Square square = new Square(firstNum, secondNum);
                    area.Text = square.Area().ToString();
                    perimetr.Text = square.Perimetr().ToString();
                    break;
            }
        }

        private void firstTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0) || ((e.Text == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString()) && (DS_Count(((TextBox)sender).Text) < 1)));
        }

        public int DS_Count(string s)
        {
            string substr = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString();
            int count = (s.Length - s.Replace(substr, "").Length) / substr.Length;
            return count;
        }

        private void secondTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0) || ((e.Text == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString()) && (DS_Count(((TextBox)sender).Text) < 1)));
        }
    }
}
