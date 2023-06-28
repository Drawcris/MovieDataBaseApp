using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MoviesApp
{
    public partial class RegisterationForm : Form
    {
        public RegisterationForm()
        {
            InitializeComponent();
        }


        private const string connectionString = "Data Source=(local);Initial Catalog=MOVIES;Integrated Security=True";

        private void btnRegister_Click(object sender, EventArgs e)
        {



            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Sprawdź, czy pola nazwy użytkownika i hasła nie są puste
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Wprowadź nazwę użytkownika i hasło.");
                return;
            }

            // Dodaj użytkownika do bazy danych
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Konta (Nazwa, Haslo) VALUES (@Nazwa, @Haslo)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nazwa", username);
                    command.Parameters.AddWithValue("@Haslo", password);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Rejestracja zakończona pomyślnie.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas rejestracji: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

