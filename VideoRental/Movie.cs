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

namespace VideoRental
{
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        private void Movie_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string connectionString = @"Data Source=HP-1\SQLEXPRESS; Initial Catalog=MoviesDSED02Assess;
Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM Movies ORDER by MovieID";
                //read in the data with a datareader open the data connection
                SqlCommand Command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    //add each row to the listbox
                    ListViewItem item = new ListViewItem(new[]
                    {
                        reader["MovieID"].ToString(), reader["Rating"].ToString(), reader["Title"].ToString(),
                        reader["Year"].ToString(), reader["Rental_Cost"].ToString(), reader["Copies"].ToString(),
                        reader["Plot"].ToString(), reader["Genre"].ToString()

                    });

                    listView1.Items.Add(item);
                }

                reader.Close();

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {

                SqlConnection Con = new SqlConnection();
                string connectionString =
                    @"Data Source=HP-1\SQLEXPRESS;Initial Catalog=MoviesDSED02Assess; Integrated Security=True";
                Con.ConnectionString = connectionString;
                string DeleteCommand = "Delete Movies where MovieID = @MovieID";
                SqlCommand DeleteData = new SqlCommand(DeleteCommand, Con);
                DeleteData.Parameters.AddWithValue("@MovieID", txtMovieId.Text);
                Con.Open();
                DeleteData.ExecuteNonQuery();
                Con.Close();
                loadDatabase();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void loadDatabase()
        {
            listView1.Items.Clear();
        }
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string NewEntry = "INSERT INTO Movies (Rating, Title, Year, Rental_Cost, Copies, Plot, Genre) " +
                              "VALUES (@Rating, @Title,  @Year, @Rental_Cost, @Copies, @Plot, @Genre)";
            SqlConnection Con = new SqlConnection();
            string connectionString =
                @"Data Source=HP-1\SQLEXPRESS;Initial Catalog=MoviesDSED02Assess; Integrated Security=True";
            Con.ConnectionString = connectionString;
            using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {

                
                newdata.Parameters.AddWithValue("@Rating", txtRating.Text);
                newdata.Parameters.AddWithValue("@Title", txtTitle.Text);
                newdata.Parameters.AddWithValue("@Year", txtYear.Text);
                newdata.Parameters.AddWithValue("@Rental_Cost", txtRental_Cost.Text);
                newdata.Parameters.AddWithValue("@Copies", txtCopies.Text);
                newdata.Parameters.AddWithValue("@Plot", txtPlot.Text);
                newdata.Parameters.AddWithValue("@Genre", txtGenre.Text);
                Con.Open();
                newdata.ExecuteNonQuery();
                //a happy message box
                MessageBox.Show("Data has been Inserted !! ");

            }
           loadDatabase();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatestatement =
                "UPDATE Movies set Rating=@Rating, Title= @Title, Year=@Year, Rental_Cost=@Rental_Cost, Copies=@Copies, Plot=@Plot, Genre=@Genre where MovieId = @MovieId";
            SqlConnection Con = new SqlConnection();
            string connectionString =
                @"Data Source=HP-1\SQLEXPRESS;Initial Catalog=MoviesDSED02Assess; Integrated Security=True";
            Con.ConnectionString = connectionString;
            SqlCommand update = new SqlCommand(updatestatement, Con);
            //create the parameters and pass the data from the textboxes
            update.Parameters.AddWithValue("@MovieId", txtMovieId.Text);
            update.Parameters.AddWithValue("@Rating", txtRating.Text);
            update.Parameters.AddWithValue("@Title", txtTitle.Text);
            update.Parameters.AddWithValue("@Year", txtYear.Text);
            update.Parameters.AddWithValue("@Rental_Cost", txtRental_Cost.Text);
            update.Parameters.AddWithValue("@Copies", txtCopies.Text);
            update.Parameters.AddWithValue("@Plot", txtPlot.Text);
            update.Parameters.AddWithValue("@Genre", txtGenre.Text);
            Con.Open();
            //its NONQueryas data is only going up
            update.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Data has been Update !! ");
            loadDatabase();
        }

        private void txtRentedMovies_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGenre_Click(object sender, EventArgs e)
        {

        }
    }
}