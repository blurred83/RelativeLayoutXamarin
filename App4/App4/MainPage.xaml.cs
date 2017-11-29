using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var employees = new List<Employee>();
            employees.Add(new Employee { DisplayName = "Brian Williams" });
            employees.Add(new Employee { DisplayName = "Mindy Collette" });
            employees.Add(new Employee { DisplayName = "Tami Taylor" });
            employees.Add(new Employee { DisplayName = "Eric Taylor" });            
            employees.Add(new Employee { DisplayName = "Landry Clarke" });
            employees.Add(new Employee { DisplayName = "Vince Howard" });
            
            EmployeeView.ItemsSource = employees;

        }

        private void EmployeeView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            EmployeeView.SelectedItem = null;
        }
    }
    public class Employee
    {
        public string DisplayName { get; set; }
    }
}
