using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental_practice
{
    public partial class agreementForm : Form
    {
        string firstName, lastName;
        DateTime pickupDate, returnDate;
        double rentalCost;

        private void btnPrintContract_Click(object sender, EventArgs e)
        {
            
        }

        public agreementForm(string firstName, string lastName, DateTime pickupDate, DateTime returnDate, double rentalCost)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;
            this.pickupDate = pickupDate;
            this.returnDate = returnDate;
            this.rentalCost = rentalCost;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtCustomerName.Text = firstName + " " + lastName;
            txtCostOfRental.Text = rentalCost.ToString();
            txtPickUpDate.Text = pickupDate.ToString();
            txtReturnDate.Text = returnDate.ToString();
            txtDate.Text = DateTime.Today.ToString();
        }
    }
}
