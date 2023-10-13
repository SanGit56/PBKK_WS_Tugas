using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PBKK_231014_TaskManager
{
	public partial class MainWindow : Window
	{
		ObservableCollection<Task> tasks = new ObservableCollection<Task>();

		public MainWindow()
		{
			InitializeComponent();
			taskListView.ItemsSource = tasks;
		}

		private void AddTask_Click(object sender, RoutedEventArgs e)
		{
			string taskName = taskTextBox.Text;

			if (!string.IsNullOrEmpty(taskName))
			{
				Task newTask = new Task { TaskName = taskName, TaskStatus = "Dalam Pengerjaan" };

				tasks.Add(newTask);
				taskTextBox.Clear();
			}
		}
	}

}
