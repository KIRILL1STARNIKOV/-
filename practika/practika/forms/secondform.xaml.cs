using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace practika.forms
{
    /// <summary>
    /// Логика взаимодействия для secondform.xaml
    /// </summary>
    public partial class secondform : Window
    {
        private List<string> bookTitles = new List<string>();
        public secondform()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = @"Data Source=DESKTOP-TBDN17P; Initial Catalog=bibleoDB; Integrated Security=True";
            string sql = "SELECT Title FROM TableBooks";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = reader.GetString(0);
                            bookTitles.Add(title);
                        }
                    }
                }
            }

            lbForDB.ItemsSource = bookTitles; 
        }
        public string authors = "";
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbForDB.SelectedItem != null)
            {
                // Получаем выбранный элемент
                string selectedTitle = lbForDB.SelectedItem.ToString();
                string selectedTitles = lbForDB.SelectedItem.ToString();
                string descriptions = lbForDB.SelectedItem.ToString();
                string author = GetBookAuthor(selectedTitle);


                string date = GetBookDate(selectedTitles); // Получаем дату выпуска книги
                string description = GetBookDescription(descriptions);

                // Отображаем данные о книге в соответствующих элементах управления
                namebooks.Content = selectedTitle; // Отображаем название книги в Label
                aftor.Content = author;
                dsate.Content = date;
                tbDecs.Text = description;

            }
        }

        // Метод для получения автора книги из базы данных
        private string GetBookAuthor(string title)
        {
            string author = "";
            string connectionString = @"Data Source=DESKTOP-TBDN17P; Initial Catalog=bibleoDB; Integrated Security=True";
            string sql = "SELECT Author FROM TableBooks WHERE Title = @Title";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    author = (string)command.ExecuteScalar();
                }
            }

            return author;
        }

        // Метод для получения даты выпуска книги из базы данных
        private string GetBookDate(string title)
        {
            string date = "";
            string connectionString = @"Data Source=DESKTOP-TBDN17P; Initial Catalog=bibleoDB; Integrated Security=True";
            string sql = "SELECT DataCreate FROM TableBooks WHERE Title = @Title";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    date = command.ExecuteScalar()?.ToString();
                }
            }
            return date;
        }

        // Метод для получения описания книги из базы данных
        private string GetBookDescription(string title)
        {
            string description = "";
            string connectionString = @"Data Source=DESKTOP-TBDN17P; Initial Catalog=bibleoDB; Integrated Security=True";
            string sql = "SELECT Description FROM TableBooks WHERE Title = @Title";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    description = command.ExecuteScalar()?.ToString();
                }
            }
            return description;
        }

        private void clickexit(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
