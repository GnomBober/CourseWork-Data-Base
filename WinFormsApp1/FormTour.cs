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
    public partial class FormTour : Form
    {
        public FormTour()
        {
            InitializeComponent();

            DbTourConnection dbTourConnection = new DbTourConnection();
            gridTour.DataSource = dbTourConnection.ReadRecords();                                        //Вывод информации в dataGridView
        }

        private void gridTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tourAddB_Click(object sender, EventArgs e)
        {
            if (tourPlaceF is null)
            {
                MessageBox.Show("Введите имя");
            }

            if (tourTypeF is null)
            {
                MessageBox.Show("Введите имя");                                       //проверка полей на заполненность
            }

            if (tourPriceF is null)
            {
                MessageBox.Show("Введите имя");
            }

            Tour tour = new Tour();
            tour.Place = tourPlaceF.Text;
            tour.Type = tourTypeF.Text;
            tour.Price = tourPriceF.Text;

            DbTourConnection dbClientConnection = new DbTourConnection();                        //Добавление элемента в БД
            dbClientConnection.SetRecords(tour);
            gridTour.DataSource = dbClientConnection.ReadRecords();
        }

        private void tourDelB_Click(object sender, EventArgs e)
        {
            if (gridTour.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(gridTour.SelectedRows[0].Cells["IdTour"].Value);                                  //получение Id удаляемого элемента

                // SQL-запрос для удаления данных
                string deleteQuery = "DELETE FROM Tours WHERE IdTour = @IdTour";

                using (SqlConnection connection = new SqlConnection("Server=localhost;database=CourseDb;Integrated Security=SSPI;TrustServerCertificate=True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Добавление параметра для Id
                        command.Parameters.AddWithValue("@IdTour", selectedId);

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
            DbTourConnection dbTourConnection = new DbTourConnection();
            gridTour.DataSource = dbTourConnection.ReadRecords();
        }
    
    }
}
