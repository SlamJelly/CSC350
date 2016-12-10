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

namespace car_rental_practice
{
    public partial class newCustForm : Form
    {
        public newCustForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void newCustForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text, lastName = txtLastName.Text, phoneNumber = txtPhone.Text,
                emailAddress = txtEmail.Text, driversLicense = txtLicense.Text;
            bool under25 = ckbxUnder25.Checked;

            SqlConnection connection = new SqlConnection("Server=tcp:db-project.database.windows.net,1433;Database=db-project;User ID=DBDev;Password=Database1!;TrustServerCertificate=False;Connection Timeout=30;");
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO dbo.CustomerData (CustFirstName, CustLastName, License, Under25, Email) VALUES (@FirstName, @LastName, @License, @Under25, @Email)", connection);
            command.Parameters.Add(new SqlParameter("LastName", lastName));
            command.Parameters.Add(new SqlParameter("FirstName", firstName));
            command.Parameters.Add(new SqlParameter("License", driversLicense));
            command.Parameters.Add(new SqlParameter("Under25", under25));
            command.Parameters.Add(new SqlParameter("Email", emailAddress));

            int temp;
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || txtLicense.Text == "")
                MessageBox.Show("ERROR: Check boxes to make sure they are not empty.");
            else if (!int.TryParse(txtLicense.Text, out temp))
                MessageBox.Show("ERROR: License must be a number.");
            else {
                SqlDataReader rdr = command.ExecuteReader();
                connection.Close();
                this.Close();
            }
        }
    }
}
