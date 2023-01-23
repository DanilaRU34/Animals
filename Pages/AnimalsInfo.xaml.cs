using Microsoft.Data.SqlClient;
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
using Animals.Models;

namespace Animals.Pages
{
    /// <summary>
    /// Логика взаимодействия для AnimalsInfo.xaml
    /// </summary>
    public partial class AnimalsInfo : Page
    {
        public AnimalsInfo()
        {
            InitializeComponent();

            string connectionString = "Server=DANILA\\SQLEXPRESS;Database=Animals;Trusted_Connection=True;Encrypt=false";

            string sqlExpression = "SELECT * FROM Animals";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    List<Animal> list = new List<Animal>();
                    while (reader.Read()) // построчно считываем данные
                    {
                        Animal n = new Animal();

                        n.Id = Convert.ToInt32(reader.GetValue(0));
                        n.Name = Convert.ToString(reader.GetValue(1));
                        n.Info = Convert.ToString(reader.GetValue(2));
                        n.Photo = Convert.ToString(reader.GetValue(3));

                        list.Add(n);
                    }
                }
                reader.Close();
            }
        }
    }
}
