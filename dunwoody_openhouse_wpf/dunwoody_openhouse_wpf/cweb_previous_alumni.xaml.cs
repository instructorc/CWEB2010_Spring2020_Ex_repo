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
using Newtonsoft.Json;

namespace dunwoody_openhouse_wpf
{
	/// <summary>
	/// Interaction logic for cweb_previous_alumni.xaml
	/// </summary>
	public partial class cweb_previous_alumni : Window
	{
		/**			this.Name = Name;
			this.Email = Email;
			Employer = emp;
			SalaryRange = sal;
			GradYear = gradYear;**/

		static string json = @"[
				{
					'Name': 'Rich Wagner',
					'Email': 'rwagner@dunwoody.edu',
					'Employer': 'Dunwoody College',
					'SalaryRange': '200,00 - 230,000',
					'GradYear': 'Spring 1984'

				},
				{
					'Name': 'Miles Morales',
					'Email': 'mmoralies@spiderman.edu',
					'Employer': 'The World Bank',
					'SalaryRange': '100,00 - 150,000',
					'GradYear': 'Fall 2018'

				},
				{
					'Name': 'Bryan Nelson',
					'Email': 'bnelson@dunwoody.edu',
					'Employer': 'Mortenson Constructions',
					'SalaryRange': '70 - 100,000',
					'GradYear': 'Fall 2012'

				}

		]";
		ObservableCollection<Alumni> alumList = JsonConvert.DeserializeObject<ObservableCollection<Alumni>>(json);

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

		private void search_alumni(object sender, TextChangedEventArgs e)
		{
			if (search_alumni_box.Text != null)
			{
				alumni_grid.ItemsSource = alumList.Where(x => x.Name.ToString().Contains(search_alumni_box.Text));
			}
			else
			{
				alumni_grid.ItemsSource = alumList;
			}
		}

		private void selected_alumni(object sender, SelectionChangedEventArgs e)
		{
			var SelectedAlumni = alumni_grid.SelectedIndex;
			Alumni aAlumni = ((Alumni)alumni_grid.Items[SelectedAlumni]);
			alumni_name_tb.Text = aAlumni.Name;
		}
	}//End of cweb_previous_alumni class


}
