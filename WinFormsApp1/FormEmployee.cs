using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();

            DbEmployeeConnection dbEmployeeConnection = new DbEmployeeConnection();
            gridEmployee.DataSource = dbEmployeeConnection.ReadRecords();                                  //Вывод информации в dataGridView
        }

        private void gridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employeeAddB_Click(object sender, EventArgs e)
        {
            if (employeeNameF is null)
            {
                MessageBox.Show("Введите имя");
            }

            if (employeeSurnameF is null)                       //проверка полей на заполненность
            {
                MessageBox.Show("Введите имя");
            }

            if (employeeJobF is null)
            {
                MessageBox.Show("Введите имя");
            }

            Employee employee = new Employee();
            employee.Name = employeeNameF.Text;
            employee.Surname = employeeSurnameF.Text;
            employee.LastName = employeeLastNameF.Text;
            employee.Job = employeeJobF.Text;

            DbEmployeeConnection dbClientConnection = new DbEmployeeConnection();
            dbClientConnection.SetRecords(employee);                                             //Добавление элемента в БД
            gridEmployee.DataSource = dbClientConnection.ReadRecords();                          //Обновление записей в dataGridView
        }

        private void employeeDelB_Click(object sender, EventArgs e)
        {
            if (gridEmployee.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(gridEmployee.SelectedRows[0].Cells["IdEmployee"].Value);                                  //получение Id удаляемого элемента

                // SQL-запрос для удаления данных
                string deleteQuery = "DELETE FROM Employees WHERE IdEmployee = @IdEmployee";

                using (SqlConnection connection = new SqlConnection("Server=localhost;database=CourseDb;Integrated Security=SSPI;TrustServerCertificate=True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Добавление параметра для Id
                        command.Parameters.AddWithValue("@IdEmployee", selectedId);

                        // Выполнение запроса
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Удаление выбранной строки из DataGridView

                            MessageBox.Show("Выбранная строка успешно удалена");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при удалении строки.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Выберите строку для удаления из DataGridView.");
            }
            DbEmployeeConnection dbEmployeeConnection = new DbEmployeeConnection();
            gridEmployee.DataSource = dbEmployeeConnection.ReadRecords();
        }
    }
}
