using System.Data.SqlClient;


namespace MoviesApp
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }


        private const string connectionString = "Data Source=(local);Initial Catalog=MOVIES;Integrated Security=True";
        public static string zalogowaneKonto;
        private void Zaloguj_Click(object sender, EventArgs e)
        {
            string nazwa = txtNazwa.Text;
            string haslo = txtHaslo.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Konta WHERE Nazwa=@Nazwa AND Haslo=@Haslo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nazwa", nazwa);
                    command.Parameters.AddWithValue("@Haslo", haslo);

                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        zalogowaneKonto = nazwa; 

                        MessageBox.Show("Zalogowano!");
                    }
                    else
                    {
                        MessageBox.Show("Błędne dane logowania!");
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

