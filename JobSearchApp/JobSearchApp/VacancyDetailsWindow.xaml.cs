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
    /// Логика взаимодействия для VacancyDetailsWindow.xaml
    /// </summary>
    public partial class VacancyDetailsWindow : Window
    {
        public VacancyDetailsWindow(Vacancy vacancy)
        {
            InitializeComponent();

            Cursor = new Cursor(
                Application.GetResourceStream(
                    new Uri("photo/dog.cur", UriKind.Relative)).Stream);
            // Заполнение информации о вакансии
            companyLogoImage.Source = new BitmapImage(new Uri(vacancy.CompanyLogo, UriKind.Relative)); // Предполагается, что у вас есть изображение логотипа вакансии
            jobTitleTextBlock.Text = vacancy.JobTitle;
            salaryTextBlock.Text = $"${vacancy.Salary:N0}";
            dateAddedTextBlock.Text = vacancy.DateAdded.ToShortDateString();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close(); // Закрываем окно при нажатии на кнопку "Close"
        }
    }
}
