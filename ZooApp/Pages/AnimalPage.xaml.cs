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
using ZooApp.Models;
using Microsoft.EntityFrameworkCore;



namespace ZooApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AnimalPage.xaml
    /// </summary>
    public partial class AnimalPage : Page
    {

        ZooDbContext _db = new ZooDbContext();
        List<Animal> _animal = new List<Animal>();

        int _studentCout = 0;

        const int FILTER_BY_ADMISSION_YEAR = 1,
                  FILTER_BY_BIRTH_YEAR = 2;

        const int SORT_BY_STUDENT_ID = 0,
                  SORT_BY_LAST_NAME = 1,
                  SORT_BY_FIRST_NAME = 2,
                  SORT_BY_MIDDKE_NAME = 3,
                  SORT_BY_BIRTH_DATE = 4;

        const int ASC_SORT = 0,
                  DESC_SORT = 1;

        int _currentPage = 1,
            _maxPage = 0;

        public AnimalPage()
        {
            InitializeComponent();
            cmbBoxFilterField.SelectedIndex = 0;
            cmbBoxFilterType.SelectedIndex = 0;

            cmbBoxSortField.SelectedIndex = 0;
            cmbBoxSortType.SelectedIndex = 0;

            cmbBoxAnimalCount.SelectedIndex = 0;

            UpdateAnimalList();
        }

        private void txtBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbBoxFilterField_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void cmbBoxFilterType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbBoxSortField_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbBoxSortType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnMarks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnContact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
