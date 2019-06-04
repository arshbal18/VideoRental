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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        public void loadDatabase()
        {
            listView1.Items.Clear();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string NewEntry = "INSERT INTO Customer (FirstName, LastName, Address, Phone) " +
                              "VALUES (@FirstName, @LastName, @Address,  @Phone)";
            SqlConnection Con = new SqlConnection();
            string connectionString =
                @"Data Source=HP-1\SQLEXPRESS;Initial Catalog=MoviesDSED02Assess; Integrated Security=True";
            Con.ConnectionString = connectionString;
            using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {

                newdata.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                newdata.Parameters.AddWithValue("@LastName", txtLastName.Text);
                newdata.Parameters.AddWithValue("@Address", txtAddress.Text);
                newdata.Parameters.AddWithValue("@Phone", txtPhone.Text);
                Con.Open();
                newdata.ExecuteNonQuery();
                //a happy message box
                MessageBox.Show("Data has been Inserted !! ");

            }

            //Run the LoadDatabase method we made earlier to seethe new data.
            loadDatabase();
        }




        private void Customer_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string connectionString = @"Data Source=HP-1\SQLEXPRESS; Initial Catalog=MoviesDSED02Assess;
Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM Customer ORDER by CustID";
                //read in the data with a datareader open the data connection
                SqlCommand Command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    //add each row to the listbox
                    ListViewItem item = new ListViewItem(new[]
                    {
                        reader["CustID"].ToString(), reader["FirstName"].ToString(), reader["Lastname"].ToString(),
                        reader["Address"].ToString(), reader["Phone"].ToString()
                    });
                    listView1.Items.Add(item);
                }

                reader.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatestatement =
                "UPDATE Customer set FirstName=@FirstName, LastName= @LastName, Address=@Address, Phone=@Phone where CustID = @CustID";
            SqlConnection Con = new SqlConnection();
            string connectionString =
                @"Data Source=HP-1\SQLEXPRESS;Initial Catalog=MoviesDSED02Assess; Integrated Security=True";
            Con.ConnectionString = connectionString;
            SqlCommand update = new SqlCommand(updatestatement, Con);
            //create the parameters and pass the data from the textboxes
            update.Parameters.AddWithValue("@CustID", txtCustID.Text);
            update.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            update.Parameters.AddWithValue("@LastName", txtLastName.Text);
            update.Parameters.AddWithValue("@Address", txtAddress.Text);
            update.Parameters.AddWithValue("@Phone", txtPhone.Text);
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
            string DeleteCommand = "Delete Customer where CustID = @CustID";
            SqlCommand DeleteData = new SqlCommand(DeleteCommand, Con);
            DeleteData.Parameters.AddWithValue("@CustID", txtCustID.Text);
            Con.Open();
            DeleteData.ExecuteNonQuery();
            Con.Close();
            loadDatabase();
        }
    }
}
