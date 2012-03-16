using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Rest;

namespace RestClient
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{

		}

		private void GoButton_Click(object sender, RoutedEventArgs e)
		{
			Rest.Rest rest = new Rest.Rest();
			string x = rest.SendHttpGet(this.UrlTextBox.Text);


			this.responseViewer.Content = x;
	//		this.responseViewer.Content = "Hello World, I am a rest response!";
		}

		private void HttpMethodBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			ScrollViewer sv = sender as ScrollViewer;
			string x = sv.Content.ToString();
			Clipboard.SetText(x, TextDataFormat.Text);
		}

		private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			var scrollViewer = sender as ScrollViewer;
			if (scrollViewer != null) e.CanExecute = scrollViewer.Content != null;
		}
	}
}
