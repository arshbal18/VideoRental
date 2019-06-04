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
    public partial class Rented : Form
    {
        public Rented()
        {
            InitializeComponent();
        }

        private void lblDateReturned_Click(object sender, EventArgs e)
        {

        }

        private void Rented_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string connectionString = @"Data Source=HP-1\SQLEXPRESS; Initial Catalog=MoviesDSED02Assess;
Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM RentedMovies ORDER by RMID";
                //read in the data with a datareader open the data connection
                SqlCommand Command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    //add each row to the listbox
                    ListViewItem item = new ListViewItem(new[]
                    {
                        reader["RMID"].ToString(), reader["CustIDFK"].ToString(), reader["MovieIDFK"].ToString(),reader["DateRented"].ToString(), reader["DateReturned"].ToString()
                    });
                    listView1.Items.Add(item);
                }

                reader.Close();
            }
        }

        private void txtMoviesId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCustomerId_Click(object sender, EventArgs e)
        {

        }

        private void txtDateRented_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDateRented_Click(object sender, EventArgs e)
        {

        }

        private void lblMovieIDFK_Click(object sender, EventArgs e)
        {

        }
        public void loadDatabase()
        {
            listView1.Items.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string NewEntry = "INSERT INTO RentedMovies (DateRented, DateReturned) " +
                              "VALUES (@DateRented, @DateReturned)";
            SqlConnection Con = new SqlConnection();
            string connectionString =
                @"Data Source=HP-1\SQLEXPRESS;Initial Catalog=MoviesDSED02Assess; Integrated Security=True";
            Con.ConnectionString = connectionString;
            using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {

                newdata.Parameters.AddWithValue("@DateRented", txtDateRented.Text);
                newdata.Parameters.AddWithValue("@DateReturned", txtDateReturned.Text);
                Con.Open();
                newdata.ExecuteNonQuery();
                //a happy message box
                MessageBox.Show("Data has been Inserted !! ");

            }
            //Run the LoadDatabase method we made earlier to seethe new data.
            loadDatabase();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatestatement =
                "UPDATE RentedMovies set MovieIDFK=@MovieIDFK, CustIDFK=@CustIDFK, DateRented=@DateRented, DateReturned=@DateReturned where RMID=@RMID";
            SqlConnection Con = new SqlConnection();
            string connectionString =
                @"Data Source=HP-1\SQLEXPRESS;Initial Catalog=MoviesDSED02Assess; Integrated Security=True";
            Con.ConnectionString = connectionString;
            SqlCommand update = new SqlCommand(updatestatement, Con);
            //create the parameters and pass the data from the textboxes
            update.Parameters.AddWithValue("@RMID", txtRMID.Text);
            update.Parameters.AddWithValue("@MovieIDFK", txtMovieIDFK.Text);
            update.Parameters.AddWithValue("@CustIDFK", txtCustIDFK.Text);
            update.Parameters.AddWithValue("@DateRented", txtDateRented.Text);
            update.Parameters.AddWithValue("@DateReturned", txtDateReturned.Text);
            Con.Open();
            //its NONQueryas data is only going up
            update.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Data has been Update !! ");
            loadDatabase();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=HP-1\SQLEXPRESS;Initial Catalog=MoviesDSED02Assess; Integrated Security=True";
            Con.ConnectionString = connectionString;
            string DeleteCommand = "Delete RentedMovies where RMID = @RMID";
            SqlCommand DeleteData = new SqlCommand(DeleteCommand, Con);
            DeleteData.Parameters.AddWithValue("@RMID", txtRMID.Text);
            Con.Open();
            DeleteData.ExecuteNonQuery();
            Con.Close();
            loadDatabase();
        }
    }
}
