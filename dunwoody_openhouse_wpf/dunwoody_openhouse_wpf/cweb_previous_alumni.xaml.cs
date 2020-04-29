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
using System.Windows.Shapes;
using dunwoody_openhouse_wpf.Models;

namespace dunwoody_openhouse_wpf
{
	/// <summary>
	/// Interaction logic for cweb_previous_alumni.xaml
	/// </summary>
	public partial class cweb_previous_alumni : Window
	{
		ObservableCollection<Student> alumList = new ObservableCollection<Student>()
		{
			new Alumni("Rich Wagner", "rwagner@dunwoody.edu", "Dunwoody College", "200,000 - 230,000", "Spring 1984"),
			new Alumni("Miles Morales", "mmoralies@spiderman.edu", "The World Bank", "100,000 - 150,000", "Fall 2018"),
			new Prospective_Student("Lennox Lewis", "LLewis@bbc.com", "Spring 2020", "Hybrid/Online", 1)
		};

		//Constructor
		public cweb_previous_alumni()
		{
			InitializeComponent();
			this.DataContext = alumList;
			alumni_grid.ItemsSource = alumList;

		}

		private void Exit_Button(object sender, RoutedEventArgs e)
		{
			this.Close();

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{

		}
	}//End of cweb_previous_alumni class


}
