using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
    /// Логика взаимодействия для windows.xaml
    /// </summary>
    public partial class windows : Window
    {
        public windows()
        {
            InitializeComponent();
            addtable();
        }


        private void addtable()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TBDN17P; Initial Catalog=bibleoDB; Integrated Security=True");
            connection.Open();
            string query = "SELECT * FROM TableBooks;";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable("TableBooks");
            adapter.Fill(table);
            dgbooks.ItemsSource = table.DefaultView;
            connection.Close();
        }
        private string connectionString = "Data Source=DESKTOP-TBDN17P;Initial Catalog=bibleoDB;Integrated Security=True";
        private void AddNewRows(object sender, RoutedEventArgs e)
        {
            if (tbname.Text == "" || tbauthor.Text == "" || tbgenre.Text == "" || tbyears.Text == "" || tbdecs.Text == "")
            {
                MessageBox.Show("Одно или несколько полей не заполнены! Все поля должны содержать значения.", "Ошибка");
            }
            else { 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string query = "INSERT INTO TableBooks  (title, author, genre, datacreate, description) VALUES (@title, @author, @genre, @datacreate, @description)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@title", tbname.Text);
                command.Parameters.AddWithValue("@author", tbauthor.Text);
                command.Parameters.AddWithValue("@genre", tbgenre.Text);
                command.Parameters.AddWithValue("@datacreate", tbyears.Text);
                command.Parameters.AddWithValue("@description", tbdecs.Text);
                command.ExecuteNonQuery();
                addtable();
                tbname.Text = "";
                tbauthor.Text = "";
                tbgenre.Text = "";
                tbyears.Text = "";
                tbdecs.Text = "";
            }
            }
        }
        public int userid = 0;


        private void DeleteSelectedRow(object sender, RoutedEventArgs e)
        {

            // Проверяем роль пользователя перед выполнением операции удаления
            if (dgbooks.SelectedItem == null) // Проверяю, выбрана ли какая-то строка в DataGrid
            {
                MessageBox.Show("Выберите строку.", "Ошибка");
            }

                int selectedId = GetSelectedId();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM TableBooks WHERE idbooks = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", selectedId);
                    command.ExecuteNonQuery();
                    addtable();
                }

            }





        }
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string searchText = tbsearch.Text;
                SearchAndMoveToTop(searchText);
            }
        }
        private void SearchAndMoveToTop(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText) || dgbooks.Items.Count == 0)
                return;

            dgbooks.SelectedItems.Clear(); 

            bool found = false; 

            foreach (var item in dgbooks.Items)
            {
                if (item is DataRowView row)
                {
                    foreach (var cellValue in row.Row.ItemArray)
                    {
                        if (cellValue.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            dgbooks.SelectedItems.Add(row); 
                            found = true; 
                            break;
                        }
                    }
                }
            }

            // АХТУНГ АЧИБКА
            if (!found)
            {
                MessageBoxResult result = MessageBox.Show("Данные не найдены.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    tbsearch.Text = ""; 
                }
            }
        }
        private int GetSelectedId()
        {
            if (dgbooks.SelectedItem != null) // Проверяю, выбрана ли какая-то строка в DataGrid
            {
                DataRowView row = (DataRowView)dgbooks.SelectedItem;
                int selectedId = (int)row["idbooks"];
                return selectedId;
            }
            return -1;
        }
        private void UpdateSelectedRow(object sender, RoutedEventArgs e)
        {
            if (dgbooks.SelectedItem == null) // Проверяю, выбрана ли какая-то строка в DataGrid
            {
                MessageBox.Show("Выберите строку.", "Ошибка");
            }
            if (tbname.Text == ""||  tbauthor.Text == "" || tbgenre.Text == "" || tbyears.Text == "" || tbdecs.Text == "")
            {
                MessageBox.Show("Одно или несколько полей не заполнены! Все поля должны содержать значения.", "Ошибка");
            }
            // Проверяем, что в DataGrid выбрана строка
            if (dgbooks.SelectedItem != null)
            {
                // Получаем уникальный идентификатор выбранной строки
                int selectedId = GetSelectedId();

                // Проверяем, что строка действительно выбрана
                if (selectedId != -1)
                {
                    // Получаем новые значения из текстовых полей
                    string newTitle = tbname.Text;
                    string newAuthor = tbauthor.Text;
                    string newGenre = tbgenre.Text;
                    string newYear = tbyears.Text;
                    string newDescription = tbdecs.Text;

                    // Подключаемся к базе данных и выполняем запрос на обновление строки
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql = "UPDATE tablebooks SET title = @Title, author = @Author, genre = @Genre, datacreate = @Year, description = @Description WHERE idbooks = @Id";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@Id", selectedId);
                            command.Parameters.AddWithValue("@Title", newTitle);
                            command.Parameters.AddWithValue("@Author", newAuthor);
                            command.Parameters.AddWithValue("@Genre", newGenre);
                            command.Parameters.AddWithValue("@Year", newYear);
                            command.Parameters.AddWithValue("@Description", newDescription);
                            command.ExecuteNonQuery();
                            addtable();
                            tbname.Text = "";
                            tbauthor.Text = "";
                            tbgenre.Text = "";
                            tbyears.Text = "";
                            tbdecs.Text = "";
                        }
                    }
                }
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clickexit(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void dgbooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgbooks.SelectedItem != null)
            {
                DataRowView selectedRow = dgbooks.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    tbname.Text = selectedRow["title"].ToString();
                    tbauthor.Text = selectedRow["author"].ToString();
                    tbgenre.Text = selectedRow["genre"].ToString();
                    tbyears.Text = selectedRow["datacreate"].ToString();
                    tbdecs.Text = selectedRow["description"].ToString();
                }
            }
        }
    }
}
