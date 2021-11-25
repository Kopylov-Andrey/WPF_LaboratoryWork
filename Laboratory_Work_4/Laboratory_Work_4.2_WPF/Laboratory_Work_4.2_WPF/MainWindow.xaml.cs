using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Laboratory_Work_4._2_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		int task = 2000; int now = 0; bool check = false;
		private static BackgroundWorker worker;
		public MainWindow()
		{
			InitializeComponent();
			worker = new BackgroundWorker();
			worker.WorkerReportsProgress = true;
			worker.DoWork += new DoWorkEventHandler(BgWork);
			worker.ProgressChanged += worker_ProgressChanged;
			worker.RunWorkerCompleted += worker_RunWorkerCompleted;
			worker.WorkerSupportsCancellation = true;
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			worker.RunWorkerAsync(100);
		}

		void BgWork(object sender, DoWorkEventArgs e)
		{
			if (worker.CancellationPending)
			{
				e.Cancel = true;
				return;
			}

			while (!worker.CancellationPending)
			{
				if (check == false)
				{
					for (int i = now; i < task; i++)
					{
						if (worker.CancellationPending == true)
						{
							e.Cancel = true;
							return;
						}
						now++;
						(sender as BackgroundWorker).ReportProgress(now, i);
						System.Threading.Thread.Sleep(1);
					}
					check = true;
				}
				else if (check == true)
				{
					task = 0;
					for (int i = now; i > task; i--)
					{
						if (worker.CancellationPending == true)
						{
							e.Cancel = true;
							return;
						}
						now--;
						(sender as BackgroundWorker).ReportProgress(now, i);
						System.Threading.Thread.Sleep(1);
					}
				}



			}
		}

		void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			progressBar.Value = now;
			if (e.UserState != null)
				label.Content = e.UserState.ToString();
		}

		void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{

		}

		private void button2_Click(object sender, RoutedEventArgs e)
		{
			worker.CancelAsync();
		}

	}
}
