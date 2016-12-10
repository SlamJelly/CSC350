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
    public partial class lblAC : Form
    {
        public lblAC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_db_projectDataSet.CustomerData' table. You can move, or remove it, as needed.
            //this.customerDataTableAdapter.Fill(this._db_projectDataSet.CustomerData);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCostOfRental_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVehicleType_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text, lastName = txtLastName.Text;

            SqlConnection connection = new SqlConnection("Server=tcp:db-project.database.windows.net,1433;Database=db-project;User ID=DBDev;Password=Database1!;TrustServerCertificate=False;Connection Timeout=30;");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.CustomerData WHERE CustFirstName LIKE @FirstName OR CustLastName LIKE @LastName", connection);
            command.Parameters.Add(new SqlParameter("FirstName", firstName));
            command.Parameters.Add(new SqlParameter("LastName", lastName));

            using (SqlDataAdapter dadapt = new SqlDataAdapter(command))
            {

                DataTable tempData = new DataTable();
                dadapt.Fill(tempData);
                dataCustData.DataSource = tempData;
            }

            connection.Close();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text, lastName = txtLastName.Text;

            SqlConnection connection = new SqlConnection("Server=tcp:db-project.database.windows.net,1433;Database=db-project;User ID=DBDev;Password=Database1!;TrustServerCertificate=False;Connection Timeout=30;");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.CustomerData WHERE CustFirstName LIKE @FirstName OR CustLastName LIKE @LastName", connection);
            command.Parameters.Add(new SqlParameter("LastName", lastName));
            command.Parameters.Add(new SqlParameter("FirstName", firstName));

            using (SqlDataAdapter dadapt = new SqlDataAdapter(command))
            {

                DataTable tempData = new DataTable();
                dadapt.Fill(tempData);
                dataCustData.DataSource = tempData;
            }

            connection.Close();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            newCustForm custForm = new newCustForm();
            custForm.ShowDialog();
        }

        private void btnPrintContract_Click(object sender, EventArgs e)
        {
            agreementForm form = new agreementForm(txtFirstName.Text, txtLastName.Text, dateTimePickerPickUp.Value, dateTimePickerReturnDate.Value, double.Parse(txtCostOfRental.Text));
            var result = form.ShowDialog();
        }

        private void dateTimePickerPickUp_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerPickUp.Value > dateTimePickerReturnDate.Value && dateTimePickerReturnDate.Value.Day != DateTime.Today.Day)
            {
                MessageBox.Show("ERROR: Pick up date must be before return date.");
            }
        }

        private void dateTimePickerReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePickerReturnDate.Value < dateTimePickerPickUp.Value)
            {
                MessageBox.Show("ERROR: Return date must be after pick up date.");
            }
        }

        private void btnCarSearch(object sender, EventArgs e)
        {
            int carID;
            double purchasePrice, buybackPrice;
            if (dateTimePickerPickUp.Value.Day == dateTimePickerReturnDate.Value.Day)
                MessageBox.Show("ERROR: Pick up date and return date must be different.");
            else if (comboNumDoors.SelectedItem == null)
            {
                MessageBox.Show("ERROR: Must choose a number of doors.");
            }
            else {
                carSearchForm form = new carSearchForm(ckbxAC.Checked, CkBxAutoTrans.Checked, ckbxInsurance.Checked, dateTimePickerPickUp.Value, dateTimePickerReturnDate.Value, comboNumDoors.GetItemText(comboNumDoors.SelectedItem));
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    carID = form.ReturnValue1;
                    purchasePrice = form.ReturnValue2;
                    buybackPrice = form.ReturnValue3;
                    double days = (dateTimePickerReturnDate.Value - dateTimePickerPickUp.Value).TotalDays;
                    double costPerDay = (((purchasePrice - buybackPrice) / 750) * days);
                    txtCostOfRental.Text = costPerDay.ToString("N2");

                }
            }
        }

        private void dataCustData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirstName.Text = dataCustData.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dataCustData.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
