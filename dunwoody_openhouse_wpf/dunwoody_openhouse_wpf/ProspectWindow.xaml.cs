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
    /// Interaction logic for ProspectWindow.xaml
    /// </summary>
    public partial class ProspectWindow : Window
    {
		//Alumni somebody = new Alumni("Rich", "RWagner@dunwoody.edu", "Dunwoody", "200,000 - 230,000", "Spring 1984");
		DataSource source = new DataSource();
		ObservableCollection<Prospective_Student> prospectWindowList = null;
		Prospective_Student aStudent;
		
        public ProspectWindow()
        {
            InitializeComponent();
			prospectWindowList = source.readData();
			prospectEntry_grid.DataContext = prospectWindowList;
			prospectEntry_grid.ItemsSource = prospectWindowList;
		}

		private void Exit_Button(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void Submit_Prospect(object sender, RoutedEventArgs e)
		{
			ComboBoxItem term = (ComboBoxItem)term_start_combo.SelectedItem;
			ComboBoxItem preference = (ComboBoxItem)delivery_preference_combo.SelectedItem;

			aStudent = new Prospective_Student(name_tb.Text, email_tb.Text, term.Content.ToString(), preference.Content.ToString(), 1);
			
			//Adding new student to List
			prospectWindowList.Add(aStudent);

			//Repopulating the datagrid with the addition of a new student
			//prospectEntry_grid.ItemsSource = prospectWindowList;

			//Refresh the data grid
			//prospectEntry_grid.Items.Refresh();

		}
	}
}
