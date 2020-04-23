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

namespace dunwoody_openhouse_wpf
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

		private void Exit_Button(object sender, RoutedEventArgs e)
		{
			
			this.Close();
		}

		private void GoToWebAlumniWindow(object sender, RoutedEventArgs e)
		{
			cweb_previous_alumni cwebAlumniWindow = new cweb_previous_alumni();
			cwebAlumniWindow.Show();
			this.Close();
		}

		private void prospect_btn_click(object sender, RoutedEventArgs e)
		{
			ProspectWindow navigateToProspect = new ProspectWindow();
			navigateToProspect.Show();
			this.Close();
		}
	}
}
