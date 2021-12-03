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
using System.IO;
using System.Windows.Forms;

namespace Lab_6._1
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
       
        private void search(DirectoryInfo directoryInfo, string patern, bool adFolders)
        {
            try
            {
                if (cb_folders.IsChecked == true)
                {
                    foreach (FileInfo file in directoryInfo.GetFiles(patern, SearchOption.AllDirectories))
                    {
                        Output.Items.Add(file.FullName);
                    }
                }
                else
                {
                    foreach (FileInfo file in directoryInfo.GetFiles(patern))
                    {
                        Output.Items.Add(file.FullName);
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            Output.Items.Clear();
            if(tb_location.Text == "")
            {
                System.Windows.MessageBox.Show("Путь к файлу пуст");
            }
            else
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(tb_location.Text);
                if (tb_name.Text == "")
                {
                    string patern = "*";
                    search(directoryInfo, patern, false);
                }
                else
                {
                    try
                    {
                        string patern = tb_name.Text;
                        search(directoryInfo, patern, false);
                    }
                    catch {}
                }
            }
        }

        private void btn_overview_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            tb_location.Text = dialog.SelectedPath;
        }

        private void Output_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //System.Windows.MessageBox.Show(e.Source.ToString());
            string fName = Output.SelectedItem.ToString();
            SecondWindow second = new SecondWindow(fName);
            second.Show();
        }
    }
}
