using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DbEmployeeConnection
    {
        // Установка соединения с БД
        string cs = "Server=localhost;database=CourseDb;Integrated Security=SSPI;TrustServerCertificate=True";
        public List<Employee> ReadRecords()
        {            

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Employee> employeeRecords = new List<Employee>();

            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.IdEmployee = Convert.ToInt32(reader["IdEmployee"]);                  //Цтение данных из БД
                employee.Name = reader["Name"].ToString()!;
                employee.Surname = reader["Surname"].ToString()!;
                employee.LastName = reader["LastName"].ToString()!;
                employee.Job = reader["Job"].ToString()!;

                employeeRecords.Add(employee);
            }
            return employeeRecords;                                           //Возврат списка с данными
        }
        public void SetRecords(Employee employee)
        {
            string insertQuery = "INSERT INTO Employees (Name, Surname, LastName, Job) " +
                             "VALUES (@Name, @Surname, @LastName, @Job)";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Добавление параметров
                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@Surname", employee.Surname);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@Job", employee.Job);

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
    public class Employee
    {
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} {LastName}";
        }
    }
}
