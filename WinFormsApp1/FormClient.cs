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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();

            DbClientConnection dbClientConnection = new DbClientConnection();
            gridClient.DataSource = dbClientConnection.ReadRecords();                         //Вывод информации в dataGridView
        }

        private void clientAddB_Click(object sender, EventArgs e)
        {
            if (clientNameF is null)
            {
                MessageBox.Show("Введите имя");
            }

            if (clientSurnameF is null)
            {
                MessageBox.Show("Введите имя");                                       //проверка полей на заполненность
            }

            if (clientNumberF is null)
            {
                MessageBox.Show("Введите имя");
            }

            if (clientMailF is null)
            {
                MessageBox.Show("Введите имя");
            }

            Client client = new Client();
            client.Name = clientNameF.Text;
            client.Surname = clientSurnameF.Text;
            client.LastName = clientLastNameF.Text;
            client.Number = clientNumberF.Text;
            client.mail = clientMailF.Text;

            DbClientConnection dbClientConnection = new DbClientConnection();                        //Добавление элемента в БД
            dbClientConnection.SetRecords(client);
            gridClient.DataSource = dbClientConnection.ReadRecords();
        }

        private void clientDelB_Click(object sender, EventArgs e)
        {
            if (gridClient.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(gridClient.SelectedRows[0].Cells["Id"].Value);                                  //получение Id удаляемого элемента

                // SQL-запрос для удаления данных
                string deleteQuery = "DELETE FROM Clients WHERE Id = @Id";

                using (SqlConnection connection = new SqlConnection("Server=localhost;database=CourseDb;Integrated Security=SSPI;TrustServerCertificate=True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Добавление параметра для Id
                        command.Parameters.AddWithValue("@Id", selectedId);

                        // Выполнение запроса
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

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
                MessageBox.Show("Выберите строку для удаления");
            }

            DbClientConnection dbClientConnecrion = new DbClientConnection();
            gridClient.DataSource = dbClientConnecrion.ReadRecords();
        }

        private void gridClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
