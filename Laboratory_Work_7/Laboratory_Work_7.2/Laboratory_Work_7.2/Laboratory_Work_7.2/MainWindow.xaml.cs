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

namespace Laboratory_Work_7._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SolidColorBrush greenBrush = new SolidColorBrush(Colors.Green);
        SolidColorBrush redBrush = new SolidColorBrush(Colors.Red);
        public MainWindow()
        {
            InitializeComponent();
            Num.DataContext = this;
            Date.Content = DateTime.Today.ToString("dd.MM.yyyy");
            Time.Content = DateTime.Now.ToString("H:mm:ss");
        }
        DateTime start;
        bool started = false;
        public int TrolNumber { get; set; }

        private void TrolClick(object sender, RoutedEventArgs e)
        {
            (sender as Button).Background = redBrush;
            if (!started)
            {
                start = DateTime.Now;
                Output.Text = "Первый тролейбус начал работу в " + start.ToString("H:mm:ss") + "\n";
                started = true;
                return;
            }
            else
            {
                Output.Text += (sender as Button).Content.ToString() + " начал работу в " + DateTime.Now.ToString("H:mm:ss") + " через (" + (DateTime.Now - start).ToString("ss") + "с) после начала работы парка\n";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Validation.GetHasError(Num) == true)
            {
                MessageBox.Show("Неправильно введено значение");
                return;
            }
            SP1.Children.Clear();
            SP2.Children.Clear();
            SP3.Children.Clear();
            if (TrolNumber <= 20)
            {
                for (int i = 0; i < TrolNumber; i++)
                {
                    Button btn = new Button() { Content = "Трол. №" + (i + 1), Width = 45, Background = greenBrush };
                    btn.Click += new RoutedEventHandler(TrolClick);
                    SP1.Children.Add(btn);
                }
            }
            else if (TrolNumber > 20 && TrolNumber <= 40)
            {
                for (int i = 0; i < 20; i++)
                {
                    Button btn = new Button() { Content = "Трол. №" + (i + 1), Width = 45, Background = greenBrush};
                    btn.Click += new RoutedEventHandler(TrolClick);
                    SP1.Children.Add(btn);
                }
                for (int i = 20; i < TrolNumber; i++)
                {
                    Button btn = new Button() { Content = "Трол. №" + (i + 1), Width = 45, Background = greenBrush };
                    btn.Click += new RoutedEventHandler(TrolClick);
                    SP2.Children.Add(btn);
                }
            }
            else if (TrolNumber > 40 && TrolNumber <= 60)
            {
                for (int i = 0; i < 20; i++)
                {
                    Button btn = new Button() { Content = "Трол. №" + (i + 1), Width = 45, Background = greenBrush };
                    btn.Click += new RoutedEventHandler(TrolClick);
                    SP1.Children.Add(btn);
                }
                for (int i = 20; i < 40; i++)
                {
                    Button btn = new Button() { Content = "Трол. №" + (i + 1), Width = 45, Background = greenBrush };
                    btn.Click += new RoutedEventHandler(TrolClick);
                    SP2.Children.Add(btn);
                }
                for (int i = 40; i < TrolNumber; i++)
                {
                    Button btn = new Button() { Content = "Трол. №" + (i + 1), Width = 45, Background = greenBrush };
                    btn.Click += new RoutedEventHandler(TrolClick);
                    SP3.Children.Add(btn);
                }
            }
        }

        private void Num_Error(object sender, ValidationErrorEventArgs e)
        {
            if (Validation.GetHasError(Num))
            {
                create.IsEnabled = false;
            }
            else
            {
                create.IsEnabled = true;
            }
        }

     
    }
}
