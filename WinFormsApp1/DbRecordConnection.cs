using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DbRecordConnection
    {
        string cs = "Server=localhost;database=CourseDb;Integrated Security=SSPI;TrustServerCertificate=True";          //строка подключения к БД

        public List<Record> ReadRecords()
        {

            // Установка соединения с БД

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Records", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Record> recordRecords = new List<Record>();

            while (reader.Read())
            {
                Record record = new Record();
                record.IdRecord = Convert.ToInt32(reader["IdRecord"]);                  //Цтение данных из БД
                record.IdClient = Convert.ToInt32(reader["IdClient"]);
                record.IdEmployee = Convert.ToInt32(reader["IdEmployee"]); ;
                record.IdTour = Convert.ToInt32(reader["IdTour"]);

                recordRecords.Add(record);
            }
            return recordRecords;                                           //Возврат списка с данными
        }
        public List<ListOut> ReadStringRecords(List<Record> records)
        {
            List<ListOut> listOut = new List<ListOut>();

            foreach (Record record in records)
            {
                ListOut newListOut = new ListOut();

                newListOut.Id = record.IdRecord;

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand($"SELECT Name, Surname, LastName FROM Clients WHERE Id = {record.IdClient}", conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        newListOut.aboutClient = $"{reader["Name"]} {reader["Surname"]} {reader["LastName"]}";
                    }
                }

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand($"SELECT Name, Surname, LastName FROM Employees WHERE IdEmployee = {record.IdEmployee}", conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        newListOut.aboutEmployee = $"{reader["Name"]} {reader["Surname"]} {reader["LastName"]}";
                    }
                }

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand($"SELECT Place, Type, Price FROM Tours WHERE IdTour = {record.IdTour}", conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        newListOut.aboutTour = $"{reader["Place"]} {reader["Type"]} {reader["Price"]}";
                    }
                }
                listOut.Add(newListOut);
            }
            return listOut;
        }

        public void SetRecords(Record record)
        {
            string insertQuery = "INSERT INTO Records (IdClient, IdEmployee, IdTour) " +
                             "VALUES (@IdClient, @IdEmployee, @IdTour)";


            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Добавление параметров
                    command.Parameters.AddWithValue("@IdClient", record.IdClient);
                    command.Parameters.AddWithValue("@IdEmployee", record.IdEmployee);
                    command.Parameters.AddWithValue("@IdTour", record.IdTour);

                    // Выполнение запроса
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Данные успешно сохранены в базе данных.");
                    }
                    else
                    {
                        Console.WriteLine("Произошла ошибка при сохранении данных.");
                    }
                }
            }
        }
    }
    public class Record
    {
        public int IdRecord { get; set; }
        public int IdClient { get; set; }
        public int IdEmployee { get; set; }
        public int IdTour { get; set; }
    }
    public class ListOut
    {
        public int Id { get; set; }
        public string aboutClient { get; set; }
        public string aboutEmployee { get; set; }
        public string aboutTour { get; set; }
    }
}
