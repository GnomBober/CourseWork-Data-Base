using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class FormRecord : Form
    {
        public FormRecord()
        {
            InitializeComponent();

            DbRecordConnection dbRecordConnection = new DbRecordConnection();
            DbClientConnection dbClientConnection = new DbClientConnection();
            DbEmployeeConnection dbEmployeeConnection = new DbEmployeeConnection();
            DbTourConnection dbTourConnection = new DbTourConnection();
            gridRecord.DataSource = dbRecordConnection.ReadStringRecords(dbRecordConnection.ReadRecords());
            clientBox.DataSource = dbClientConnection.ReadRecords();
            employeeBox.DataSource = dbEmployeeConnection.ReadRecords();
            tourBox.DataSource = dbTourConnection.ReadRecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void recToClientB_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            formClient.Show();
        }

        private void recToEmployeeB_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.Show();
        }

        private void recToTourB_Click(object sender, EventArgs e)
        {
            FormTour formTour = new FormTour();
            formTour.Show();
        }

        private void clientBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbClientConnection dbClientConnection = new DbClientConnection();
            DbEmployeeConnection dbEmployeeConnection = new DbEmployeeConnection();
            DbTourConnection dbTourConnection = new DbTourConnection();
            clientBox.DataSource = dbClientConnection.ReadRecords();
            employeeBox.DataSource = dbEmployeeConnection.ReadRecords();
            tourBox.DataSource = dbTourConnection.ReadRecords();
        }

        private void tourDelB_Click(object sender, EventArgs e)
        {
            if (gridRecord.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(gridRecord.SelectedRows[0].Cells["Id"].Value);                                  //получение Id удаляемого элемента

                // SQL-запрос для удаления данных
                string deleteQuery = "DELETE FROM Records WHERE IdRecord = @IdRecord";

                using (SqlConnection connection = new SqlConnection("Server=localhost;database=CourseDb;Integrated Security=SSPI;TrustServerCertificate=True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Добавление параметра для Id
                        command.Parameters.AddWithValue("@IdRecord", selectedId);

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

            DbRecordConnection dbRecordConnecrion = new DbRecordConnection();
            gridRecord.DataSource = dbRecordConnecrion.ReadStringRecords(dbRecordConnecrion.ReadRecords());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            string a = clientBox.SelectedItem.ToString()!;
            string[] clientLastName = a.Split(" ");
            string b = employeeBox.SelectedItem.ToString()!;
            string[] employeeLastName = b.Split(" ");
            string c = tourBox.SelectedItem.ToString()!;
            string[] tourPrice = c.Split(" ");
            string queryC = "SELECT Id FROM Clients WHERE LastName = @LastName";
            string queryE = "SELECT IdEmployee FROM Employees WHERE LastName = @LastName";
            string queryT = "SELECT IdTour FROM Tours WHERE Price = @Price";

            using (SqlConnection connection = new SqlConnection("Server=localhost;database=CourseDb;Integrated Security=SSPI;TrustServerCertificate=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryC, connection))
                {
                    command.Parameters.AddWithValue("@LastName", clientLastName[clientLastName.Count()-1]);

                    // Выполнение запроса и получение результата
                    int idClient = (int)command.ExecuteScalar();
                    record.IdClient = idClient;
                }

                using (SqlCommand command = new SqlCommand(queryE, connection))
                {
                    command.Parameters.AddWithValue("@LastName", employeeLastName[employeeLastName.Count()-1]);

                    // Выполнение запроса и получение результата
                    int idEmployee = (int)command.ExecuteScalar();
                    record.IdEmployee = idEmployee;
                }

                using (SqlCommand command = new SqlCommand(queryT, connection))
                {
                    command.Parameters.AddWithValue("@Price", tourPrice[tourPrice.Count()-1]);

                    // Выполнение запроса и получение результата
                    int idTour = (int)command.ExecuteScalar();
                    record.IdTour = idTour;
                }
                DbRecordConnection dbRecordConnection = new DbRecordConnection();
                dbRecordConnection.SetRecords(record);
                gridRecord.DataSource = dbRecordConnection.ReadStringRecords(dbRecordConnection.ReadRecords());
            }
        }
    }
}
