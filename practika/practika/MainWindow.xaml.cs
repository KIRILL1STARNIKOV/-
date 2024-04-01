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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void enter_click(object sender, RoutedEventArgs e)
        {
            string username = tblogin.Text;
            string password = pbpassword.Password;
            int id = 0;

            // Создаем подключение к базе данных
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TBDN17P;Initial Catalog=bibleoDB;Integrated Security=True"))
            {
                // Открываем подключение
                connection.Open();

                string query = "SELECT * FROM TableUsers WHERE login = @Login AND password = @Password;";

                // Создаем объект SqlCommand с запросом и подключением
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Добавляем параметры для логина и пароля
                    command.Parameters.AddWithValue("@Login", username);
                    command.Parameters.AddWithValue("@Password", password);

                    // Создаем объект SqlDataReader для чтения результатов запроса
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Если найдена запись, то авторизация успешна ehf
                        if (reader.Read())
                        {

                            id = reader.GetInt32(0);
                            id = reader.GetInt32(1);

                            // Проверяем роль пользователя
                            if (id == 1)
                            {
                                forms.windows WFB = new forms.windows();
                                WFB.Show();
                            }
                            else if (id == 2)
                            {
                                forms.secondform sf = new forms.secondform();
                                sf.Show();
                            }

                            // Закрываем текущее окно
                            this.Close();


                        }
                        else
                        {
                            MessageBox.Show("Неправильный логин или пароль. Пожалуйста, повторите попытку.");
                        }
                    }
                }

            }
        }


    }
}
