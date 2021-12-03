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

namespace Lab_6._3
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        string FN;
        public SecondWindow(string filename = null)
        {
            InitializeComponent();
            this.Title = filename;
            Output.Text = File.ReadAllText(filename);
            FN = filename;
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            TextWriter txt = new StreamWriter(FN);
            txt.Write(Output.Text);
            txt.Close();
            this.Close();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
