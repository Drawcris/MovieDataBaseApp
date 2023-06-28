using System.Data.SqlClient;


namespace MoviesApp
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }


        private const string connectionString = "Data Source=(local);Initial Catalog=MOVIES;Integrated Security=True";

        private void Zarejestruj_Click(object sender, EventArgs e)
        {



            string username = txtUsername.Text;
            string password = txtPassword.Text;

            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Wprowadź nazwę użytkownika i hasło.");
                return;
            }

           
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

        
        private void Close_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

