using System;   
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DbClientConnection
    {
        string cs = "Server=localhost;database=CourseDb;Integrated Security=SSPI;TrustServerCertificate=True";          //строка подключения к БД

        public List<Client> ReadRecords()
        {

            // Установка соединения с БД

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Clients", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Client> clientRecords = new List<Client>();

            while (reader.Read())
            {
                Client client = new Client();
                client.Id = Convert.ToInt32(reader["Id"]);                  //Цтение данных из БД
                client.Name = reader["Name"].ToString()!;
                client.Surname = reader["Surname"].ToString()!;
                client.LastName = reader["LastName"].ToString()!;
                client.Number = reader["Number"].ToString()!;
                client.mail = reader["mail"].ToString()!;

                clientRecords.Add(client);
            }

            return clientRecords;                                           //Возврат списка с данными
        }
        public void SetRecords(Client client)
        {
            string insertQuery = "INSERT INTO Clients (Name, Surname, LastName, Number, Mail) " +
                             "VALUES (@Name, @Surname, @LastName, @Number, @Mail)";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Добавление параметров
                    command.Parameters.AddWithValue("@Name", client.Name);
                    command.Parameters.AddWithValue("@Surname", client.Surname);
                    command.Parameters.AddWithValue("@LastName", client.LastName);
                    command.Parameters.AddWithValue("@Number", client.Number);
                    command.Parameters.AddWithValue("@mail", client.mail);

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
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public string mail { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} {LastName}";
        }
    }
}
