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
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Laboratory_Work_4._1_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<events> keyEvents;
        public class events
        {
            public string KeyUp { get; set; }
            public string KeyDown { get; set; }
            public string KeyCode { get; set; }
            public string KeyValue { get; set; }
            public string KeyChar { get; set; }
            public string SystemKey { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            keyEvents = new ObservableCollection<events>();
            Output.ItemsSource = keyEvents;
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            int v = (int)e.Key;
            events ev = new events()
            {
                KeyUp = e.IsUp.ToString(),
                KeyCode = v.ToString(),
                KeyValue = e.Key.ToString(),
                KeyChar = ((char)e.Key).ToString(),
                SystemKey = e.SystemKey.ToString()
            };
            keyEvents.Add(ev);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            int v = (int)e.Key;
            events ev = new events()
            {
                KeyDown = e.IsDown.ToString(),
                KeyCode = v.ToString(),
                KeyValue = e.Key.ToString(),
                KeyChar = ((char)e.Key).ToString(),
                SystemKey = e.SystemKey.ToString()
            };
            keyEvents.Add(ev);
        }
    }
}
