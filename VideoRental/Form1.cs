using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class VideoRental : Form
    {
        public VideoRental()
        {
            InitializeComponent();
        }
        private void btnMovie_Click_1(object sender, EventArgs e)
        {
            Movie f2 = new Movie();
            f2.ShowDialog();
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            Customer f2 = new Customer();
            f2.ShowDialog();
        }

        private void btnRented_Click_1(object sender, EventArgs e)
        {
            Rented f2 = new Rented();
            f2.ShowDialog();
        }
    }
}
