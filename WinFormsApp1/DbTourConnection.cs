using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DbTourConnection
    {
        string cs = "Server=localhost;database=CourseDb;Integrated Security=SSPI;TrustServerCertificate=True";          //строка подключения к БД

        public List<Tour> ReadRecords()
        {

            // Установка соединения с БД

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Tours", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Tour> tourRecords = new List<Tour>();

            while (reader.Read())
            {
                Tour tour = new Tour();
                tour.IdTour = Convert.ToInt32(reader["IdTour"]);                  //Цтение данных из БД
                tour.Place = reader["Place"].ToString()!;
                tour.Type = reader["Type"].ToString()!;
                tour.Price = reader["Price"].ToString()!;

                tourRecords.Add(tour);
            }
            return tourRecords;                                           //Возврат списка с данными
        }

        public void SetRecords(Tour tour)
        {
            string insertQuery = "INSERT INTO Tours (Place, Type, Price) " +
                             "VALUES (@Place, @Type, @Price)";


            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Добавление параметров
                    command.Parameters.AddWithValue("@Place", tour.Place);
                    command.Parameters.AddWithValue("@Type", tour.Type);
                    command.Parameters.AddWithValue("@Price", tour.Price);

                    // Выполнение запроса
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Данные успешно сохранены в базе данных.");
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при сохранении данных.");
                    }
                }
            }
        }
    }
    public class Tour
    {
        public int IdTour {  get; set; }
        public string Place { get; set;}
        public string Type { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return $"{Place} {Type} {Price}";
        }
    }
}
