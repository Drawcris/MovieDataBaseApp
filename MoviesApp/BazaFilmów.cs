using System.Data.SqlClient;
namespace MoviesApp
{
    public partial class BazaFilm�w : Form
    {
        public BazaFilm�w()
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


            // Wy�wietl potwierdzenie usuni�cia konta
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usun�� konto?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Usu� konto z bazy danych
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
                            MessageBox.Show("Konto zosta�o usuni�te!");
                            
                        }
                        else
                        {
                            MessageBox.Show("Wyst�pi� problem podczas usuwania konta.");
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


