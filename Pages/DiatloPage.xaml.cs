using Microsoft.Data.SqlClient;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Animals.Pages
{
    /// <summary>
    /// Логика взаимодействия для DiatloPage.xaml
    /// </summary>
    public partial class DiatloPage : Page
    {
        public DiatloPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string connectionString = "Server=DANILA\\SQLEXPRESS;Database=Animals;Trusted_Connection=True;Encrypt=false";

            string sqlExpression = "SELECT * FROM Animals Where Name='Дятел'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        string information = Convert.ToString(reader.GetValue(2));

                        Console.WriteLine("{0}\n", information);
                        MessageBox.Show(information);
                    }
                }
                reader.Close();
            }
        }
    }
}
