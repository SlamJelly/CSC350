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
    public struct car
    {
        public int carID;
        public double purchasePrice, buybackPrice;
    }
    
    public partial class carSearchForm : Form
    {
        char AC = 'N', autoTrans = 'N';
        int numDoors;
        public carSearchForm(bool AC, bool autoTrans, bool insurance, DateTime pickUpDate, DateTime returnDate, string doors)
        {
            InitializeComponent();
            if (AC)
                this.AC = 'Y';
            if (autoTrans)
                this.autoTrans = 'Y';
            numDoors = int.Parse(doors);

        }

        public int ReturnValue1 { get; set; }
        public double ReturnValue2 { get; set; }
        public double ReturnValue3 { get; set; }
        private void dataCarSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            car c = new car();
            c.carID = int.Parse(dataCarSearch.SelectedRows[0].Cells[0].Value.ToString());
            c.purchasePrice = double.Parse(dataCarSearch.SelectedRows[0].Cells[12].Value.ToString());
            c.buybackPrice = double.Parse(dataCarSearch.SelectedRows[0].Cells[13].Value.ToString());
            this.ReturnValue1 = c.carID;
            this.ReturnValue2 = c.purchasePrice;
            this.ReturnValue3 = c.buybackPrice;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void carSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_db_projectDataSet1.CarData' table. You can move, or remove it, as needed.
            //this.carDataTableAdapter.Fill(this._db_projectDataSet1.CarData);
            SqlConnection connection = new SqlConnection("Server=tcp:db-project.database.windows.net,1433;Database=db-project;User ID=DBDev;Password=Database1!;TrustServerCertificate=False;Connection Timeout=30;");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.CarData WHERE AC = @AC AND Automatic = @Automatic AND Doors = @Doors", connection);
            command.Parameters.Add(new SqlParameter("AC", AC));
            command.Parameters.Add(new SqlParameter("Automatic", autoTrans));
            command.Parameters.Add(new SqlParameter("Doors", numDoors));

            using (SqlDataAdapter dadapt = new SqlDataAdapter(command))
            {
                DataTable tempData = new DataTable();
                dadapt.Fill(tempData);
                dataCarSearch.DataSource = tempData;
            }

            connection.Close();
        }
    }
}
