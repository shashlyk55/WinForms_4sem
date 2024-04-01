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
    /// <summary>
    /// Логика взаимодействия для AddVacancyWindow.xaml
    /// </summary>
    public partial class AddVacancyWindow : Window
    {
        public event EventHandler<VacancyAddedEventArgs> VacancyAdded;

        public AddVacancyWindow()
        {
            InitializeComponent();

            Cursor = new Cursor(
                Application.GetResourceStream(
                    new Uri("photo/dog.cur", UriKind.Relative)).Stream);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Добавляем новую вакансию (здесь нужно получить данные из текстовых полей)

            // Создаем новую вакансию
            Vacancy newVacancy = new Vacancy(
                this.Logo_textBox.Text,
                this.JobTitle_textBox.Text,
                Convert.ToInt32(this.Salary_textBox.Text),
                DateTime.Now
                );

            // Вызываем событие для сообщения о добавлении вакансии
            OnVacancyAdded(newVacancy);

            // Закрываем окно
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Метод для вызова события VacancyAdded
        protected virtual void OnVacancyAdded(Vacancy newVacancy)
        {
            VacancyAdded?.Invoke(this, new VacancyAddedEventArgs(newVacancy));
        }

        public class VacancyAddedEventArgs : EventArgs
        {
            public Vacancy NewVacancy { get; }

            public VacancyAddedEventArgs(Vacancy newVacancy)
            {
                NewVacancy = newVacancy;
            }
        }

    }
}
