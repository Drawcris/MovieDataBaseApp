using System.Data.SqlClient;
namespace MoviesApp
{
    public partial class BazaFilmów : Form
    {
        public BazaFilmów()
        {
            InitializeComponent();
        }
        private const string connectionString = "Data Source=(local);Initial Catalog=MOVIES;Integrated Security=True";
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Zarejestruj_Click(object sender, EventArgs e)
        {
            Rejestracja registerationForm = new Rejestracja();
            registerationForm.ShowDialog();
        }

        private void Zaloguj_Click(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            logowanie.ShowDialog();
        }

        private void DodajFilm_Click(object sender, EventArgs e)
        {
            DodawanieFilmu dodajfilm = new DodawanieFilmu();
            dodajfilm.ShowDialog();
        }     

        private void Delete_Click(object sender, EventArgs e)
        {


            string nazwa = Logowanie.zalogowaneKonto;


            // Wyœwietl potwierdzenie usuniêcia konta
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usun¹æ konto?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Usuñ konto z bazy danych
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Konta WHERE Nazwa = @Nazwa";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nazwa", nazwa);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Konto zosta³o usuniête!");
                            
                        }
                        else
                        {
                            MessageBox.Show("Wyst¹pi³ problem podczas usuwania konta.");
                        }
                    }
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


