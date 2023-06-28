using System.Data;
using System.Data.SqlClient;

namespace MoviesApp
{
    public partial class DodawanieFilmu : Form
    {
        public DodawanieFilmu()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=(local);Initial Catalog=MOVIES;Integrated Security=True";
      
       
        private void DodajFilm_Click(object sender, EventArgs e)
        {
           
           
            int idFilmu = int.Parse(txtIDFilmu.Text);
            string tytul = txtTytul.Text;
            string gatunek = txtGatunek.Text;
            int rok = int.Parse(txtRok.Text);
            string nazwa = Logowanie.zalogowaneKonto;


            
          
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Film (IDFilmu, Tytul, Gatunek, Rok, Nazwa) VALUES (@IDFilmu, @Tytul, @Gatunek, @Rok, @Nazwa)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDFilmu", idFilmu);
                        command.Parameters.AddWithValue("@Tytul", tytul);
                        command.Parameters.AddWithValue("@Gatunek", gatunek);
                        command.Parameters.AddWithValue("@Rok", rok);
                        command.Parameters.AddWithValue("@Nazwa", nazwa);

                        command.ExecuteNonQuery();
                    }

                }



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT IDFilmu, Tytul, Gatunek, Rok, Nazwa FROM Film";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvFilmy.DataSource = dataTable;
                }
            }
        }

        private void DodajDoGridu(object sender, EventArgs e)
        {
                    
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT IDFilmu, Tytul, Gatunek, Rok, Nazwa FROM Film";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvFilmy.DataSource = dataTable;
                }
            }



        }
    

        private void Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Film WHERE IDFilmu = (SELECT MAX(IDFilmu) FROM Film)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvFilmy.DataSource = dataTable;
                }
            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT IDFilmu, Tytul, Gatunek, Rok, Nazwa FROM Film";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvFilmy.DataSource = dataTable;
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT IDFilmu, Tytul, Gatunek, Rok, Nazwa FROM Film";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvFilmy.DataSource = dataTable;
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

