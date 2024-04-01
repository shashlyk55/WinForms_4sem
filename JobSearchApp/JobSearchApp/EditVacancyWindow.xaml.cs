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

namespace JobSearchApp
{
    public partial class EditVacancyWindow : Window
    {
        public event EventHandler<VacancyEditedEventArgs> VacancyEdited;

        private Vacancy _originalVacancy;
        private Vacancy _editedVacancy;

        public EditVacancyWindow(Vacancy vacancy)
        {
            InitializeComponent();

            Cursor = new Cursor(
                Application.GetResourceStream(
                    new Uri("photo/dog.cur", UriKind.Relative)).Stream);
            // Клонируем выбранную вакансию для редактирования
            _originalVacancy = vacancy;
            _editedVacancy = new Vacancy(vacancy.CompanyLogo, vacancy.JobTitle, vacancy.Salary, vacancy.DateAdded);

            // Заполняем поля формы данными выбранной вакансии
            companyLogoTextBox.Text = _editedVacancy.CompanyLogo;
            jobTitleTextBox.Text = _editedVacancy.JobTitle;
            salaryTextBox.Text = _editedVacancy.Salary.ToString();
            dateAddedDatePicker.SelectedDate = _editedVacancy.DateAdded;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Обновляем данные выбранной вакансии данными из формы 
            _editedVacancy.CompanyLogo = companyLogoTextBox.Text;
            _editedVacancy.JobTitle = jobTitleTextBox.Text;
            int salary;
            if (int.TryParse(salaryTextBox.Text, out salary))
            {
                _editedVacancy.Salary = salary;
            }
            _editedVacancy.DateAdded = dateAddedDatePicker.SelectedDate ?? DateTime.Now;


            // Вызываем событие для сообщения о сохранении изменений
            OnVacancyEdited(_editedVacancy);

            // Закрываем окно
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        // Метод для вызова события VacancyEdited
        protected virtual void OnVacancyEdited(Vacancy editedVacancy)
        {
            VacancyEdited?.Invoke(this, new VacancyEditedEventArgs(editedVacancy));
        }

        public class VacancyEditedEventArgs : EventArgs
        {
            public Vacancy EditedVacancy { get; }

            public VacancyEditedEventArgs(Vacancy editedVacancy)
            {
                EditedVacancy = editedVacancy;
            }
        }
    }
}
