using JobSearchApp.Memento;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using static JobSearchApp.AddVacancyWindow;

namespace JobSearchApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Vacancy> _vacancies;
        public ObservableCollection<Vacancy> Vacancies {
            get
            {
                return _vacancies;
            } 
            set
            {
                //this.listBox.ItemsSource = value;
                _vacancies = value;
                OnPropertyChanged("Vacancies");
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        public MainWindow()
        {
            InitializeComponent();
            Cursor = new Cursor(
                Application.GetResourceStream(
                    new Uri("photo/dog.cur", UriKind.Relative)).Stream);

            Uri iconUri = new Uri("photo/icon.ico", UriKind.RelativeOrAbsolute);
            this.Resources["ApplicationIcon"] = new System.Windows.Media.Imaging.BitmapImage(iconUri);


            Vacancies = new ObservableCollection<Vacancy>()
            {
                new Vacancy("photo/pict3.jpg", "Software Engineer", 50000, DateTime.Now),
                new Vacancy("photo/pict4.jpg", "Data Analyst", 45000, DateTime.Now.AddDays(-2)),
                new Vacancy("photo/pict5.jpg", "Web Developer", 55000, DateTime.Now.AddDays(-5))
            };
            DataContext = this;
            this.listBox.DataContext = this;

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic for adding a new vacancy
            AddVacancyWindow addVacancyWindow = new AddVacancyWindow();
            addVacancyWindow.Owner = this;
            addVacancyWindow.VacancyAdded += AddVacancyWindow_VacancyAdded; // Подписываемся на событие
            addVacancyWindow.ShowDialog();
        }

        private void AddVacancyWindow_VacancyAdded(object sender, VacancyAddedEventArgs e)
        {
            // Добавляем новую вакансию в список
            Vacancies.Add(e.NewVacancy);


        }
        /*private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic for editing a selected vacancy
            Vacancy selectedVacancy = listBox.SelectedItem as Vacancy;

            if (selectedVacancy != null)
            {
                // Создаем окно редактирования вакансии
                EditVacancyWindow editVacancyWindow = new EditVacancyWindow(selectedVacancy,this);
                editVacancyWindow.Owner = this;

                // Подписываемся на событие, которое будет вызываться при сохранении изменений
                editVacancyWindow.VacancyEdited += (source, editedArgs) =>
                {
                    // Обновляем данные выбранной вакансии
                    selectedVacancy.CompanyLogo = editedArgs.EditedVacancy.CompanyLogo;
                    selectedVacancy.JobTitle = editedArgs.EditedVacancy.JobTitle;
                    selectedVacancy.Salary = editedArgs.EditedVacancy.Salary;
                    selectedVacancy.DateAdded = editedArgs.EditedVacancy.DateAdded;
                };

                // Открываем окно редактирования
                editVacancyWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a vacancy to edit.", "No Vacancy Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }*/
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранную вакансию из списка
            Vacancy selectedVacancy = listBox.SelectedItem as Vacancy;

            if (selectedVacancy != null)
            {
                // Создаем окно редактирования вакансии
                EditVacancyWindow editVacancyWindow = new EditVacancyWindow(selectedVacancy);
                editVacancyWindow.Owner = this;

                // Подписываемся на событие, которое будет вызываться при сохранении изменений
                editVacancyWindow.VacancyEdited += (source, editedArgs) =>
                {
                    // Находим индекс выбранной вакансии в списке
                    int index = Vacancies.IndexOf(selectedVacancy);
                    if (index != -1)
                    {
                        // Обновляем выбранную вакансию в списке
                        Vacancies[index] = editedArgs.EditedVacancy;

                        // Обновляем ListBox
                        listBox.Items.Refresh();

                    }
                };

                // Открываем окно редактирования
                editVacancyWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a vacancy to edit.", "No Vacancy Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic for deleting a selected vacancy
            Vacancy selectedVacancy = listBox.SelectedItem as Vacancy;

            if (selectedVacancy != null)
            {
                // Подтверждение удаления вакансии
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this vacancy?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);

                // Если пользователь подтвердил удаление
                if (result == MessageBoxResult.Yes)
                {
                    // Удаляем вакансию из списка
                    Vacancies.Remove(selectedVacancy);

                }
            }
            else
            {
                MessageBox.Show("Please select a vacancy to delete.", "No Vacancy Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void ApplySalaryFilter_Click(object sender, RoutedEventArgs e)
        {
            // Получаем минимальную и максимальную зарплату из текстовых полей
            if (int.TryParse(minSalaryTextBox.Text, out int minSalary) && int.TryParse(maxSalaryTextBox.Text, out int maxSalary))
            {
                // Фильтруем список вакансий по диапазону зарплат
                var filteredVacancies = Vacancies.Where(v => v.Salary >= minSalary && v.Salary <= maxSalary);
                listBox.ItemsSource = filteredVacancies;

            }
            else
            {
                MessageBox.Show("Please enter valid salary values.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ApplyJobTypeFilter_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранный тип вакансии из ComboBox
            string selectedJobType = (jobTypeComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Если выбран тип "All", показываем все вакансии
            if (selectedJobType == "All")
            {
                listBox.ItemsSource = Vacancies;
            }
            else
            {
                // Фильтруем список вакансий по выбранному типу
                var filteredVacancies = Vacancies.Where(v => v.JobTitle == selectedJobType);
                listBox.ItemsSource = filteredVacancies;

            }
        }
        private void ApplySort_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранный критерий сортировки из ComboBox
            string selectedSortBy = (sortByComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Выполняем соответствующую сортировку
            switch (selectedSortBy)
            {
                case "Alphabetical Order":
                    listBox.Items.SortDescriptions.Clear();
                    listBox.Items.SortDescriptions.Add(new SortDescription("JobTitle", ListSortDirection.Ascending));
                    break;
                case "Price: Low to High":
                    listBox.Items.SortDescriptions.Clear();
                    listBox.Items.SortDescriptions.Add(new SortDescription("Salary", ListSortDirection.Ascending));
                    break;
                case "Price: High to Low":
                    listBox.Items.SortDescriptions.Clear();
                    listBox.Items.SortDescriptions.Add(new SortDescription("Salary", ListSortDirection.Descending));
                    break;
                case "Date Added: Newest First":
                    listBox.Items.SortDescriptions.Clear();
                    listBox.Items.SortDescriptions.Add(new SortDescription("DateAdded", ListSortDirection.Descending));
                    break;
                case "Date Added: Oldest First":
                    listBox.Items.SortDescriptions.Clear();
                    listBox.Items.SortDescriptions.Add(new SortDescription("DateAdded", ListSortDirection.Ascending));
                    break;

            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст запроса из TextBox
            string searchText = searchTextBox.Text.ToLower();

            // Фильтруем список вакансий по тексту запроса
            var filteredVacancies = Vacancies.Where(v => v.JobTitle.ToLower().Contains(searchText));
            listBox.ItemsSource = filteredVacancies;
        }


        private ObservableCollection<Vacancy> favorites = new ObservableCollection<Vacancy>();

        private void AddToFavoritesButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранную вакансию из списка
            Vacancy selectedVacancy = listBox.SelectedItem as Vacancy;

            if (selectedVacancy != null)
            {
                // Проверяем, не добавлена ли уже вакансия в список избранных
                if (!favorites.Contains(selectedVacancy))
                {
                    // Добавляем вакансию в список избранных
                    favorites.Add(selectedVacancy);
                    MessageBox.Show("Vacancy added to favorites successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("This vacancy is already in favorites!", "Already in Favorites", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a vacancy to add to favorites.", "No Vacancy Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void FavoritesButton_Click(object sender, RoutedEventArgs e)
        {
            // Открываем окно с избранными вакансиями
            FavoritesWindow favoritesWindow = new FavoritesWindow(favorites);
            favoritesWindow.Owner = this;
            favoritesWindow.ShowDialog();
        }

        private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Получаем выбранную вакансию из списка
            Vacancy selectedVacancy = listBox.SelectedItem as Vacancy;

            // Проверяем, что вакансия была выбрана и двойной клик произошел по элементу ListBox
            if (selectedVacancy != null && e.ChangedButton == MouseButton.Left)
            {
                // Открываем окно с полной информацией о выбранной вакансии
                VacancyDetailsWindow vacancyDetailsWindow = new VacancyDetailsWindow(selectedVacancy);
                vacancyDetailsWindow.Owner = this;
                vacancyDetailsWindow.ShowDialog();
            }
        }

        private void EnglishButton_Click(object sender, RoutedEventArgs e)
        {
            // Загружаем ресурсы на английском языке
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("Dictionary\\Eng_Dictionary.xaml", UriKind.Relative);
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dict);
        }

        private void RussianButton_Click(object sender, RoutedEventArgs e)
        {
            // Загружаем ресурсы на русском языке
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("Dictionary\\Ru_Dictionary.xaml", UriKind.Relative);
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dict);
        }

        

    }

    public class Vacancy
    {
        private string _companyLogo;
        private string _jobTitle;
        private int _salary;
        private DateTime _date;
        public string CompanyLogo { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        public DateTime DateAdded { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        public Vacancy(string companyLogo, string jobTitle, int salary, DateTime dateAdded)
        {
            CompanyLogo = companyLogo;
            JobTitle = jobTitle;
            Salary = salary;
            DateAdded = dateAdded;
        }
        
    }
}
