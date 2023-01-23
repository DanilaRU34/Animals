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
using Microsoft.Data.SqlClient;

namespace Animals.Pages
{
    /// <summary>
    /// Логика взаимодействия для GrizynPage.xaml
    /// </summary>
    public partial class GrizynPage : Page
    {
        public GrizynPage()
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

            string sqlExpression = "SELECT * FROM Animals Where Name='Мышь'";
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string connectionString = "Server=DANILA\\SQLEXPRESS;Database=Animals;Trusted_Connection=True;Encrypt=false";

            string sqlExpression = "SELECT * FROM Animals Where Name='Ондатра'";
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string connectionString = "Server=DANILA\\SQLEXPRESS;Database=Animals;Trusted_Connection=True;Encrypt=false";

            string sqlExpression = "SELECT * FROM Animals Where Name='Бобр'";
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
