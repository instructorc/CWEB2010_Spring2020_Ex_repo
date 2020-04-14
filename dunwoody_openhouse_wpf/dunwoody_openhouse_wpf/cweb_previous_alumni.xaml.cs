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
using System.Windows.Shapes;

namespace dunwoody_openhouse_wpf
{
	/// <summary>
	/// Interaction logic for cweb_previous_alumni.xaml
	/// </summary>
	public partial class cweb_previous_alumni : Window
	{
		/**Person person = new Person {
			Name = "Salman", Age = 26,
			
		};**/
		List<Person> personList = new List<Person>() {
			new Person("John", 32),
			new Person("Salman", 26),
			new Person("John", 32),
			new Person("Michael", 12)
		};
		public cweb_previous_alumni()
		{
			InitializeComponent();
			this.DataContext = personList;
			cweb_listbox.ItemsSource = personList;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Exit_Button(object sender, RoutedEventArgs e)
		{
			this.Close();

		}
	}
	public class Person
	{

		private string nameValue;
		public Person()
		{

		}

		public Person(string name, int age)
		{
			nameValue = name;
			ageValue = age;
		}

		public string Name
		{
			get { return nameValue; }
			set { nameValue = value; }
		}

		private double ageValue;

		public double Age
		{
			get { return ageValue; }

			set
			{
				if (value != ageValue)
				{
					ageValue = value;
				}
			}
		}

		public override string ToString()
		{
			return String.Format($"{Name} , {Age}");
		}

	}
}
