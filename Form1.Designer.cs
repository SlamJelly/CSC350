namespace car_rental_practice
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1Type = new System.Windows.Forms.ComboBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1ReturnCus = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1PickUp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrintContract = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrintEstimate = new System.Windows.Forms.Button();
            this.txtCostOfRental = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1Type
            // 
            this.comboBox1Type.FormattingEnabled = true;
            this.comboBox1Type.Items.AddRange(new object[] {
            "Full-Size Car",
            "Compact Car",
            "Truck",
            "SUV"});
            this.comboBox1Type.Location = new System.Drawing.Point(277, 173);
            this.comboBox1Type.Name = "comboBox1Type";
            this.comboBox1Type.Size = new System.Drawing.Size(121, 21);
            this.comboBox1Type.TabIndex = 2;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblVehicleType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(277, 140);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(101, 22);
            this.lblVehicleType.TabIndex = 3;
            this.lblVehicleType.Text = "Vehicle Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pick Up Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(31, 65);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(176, 20);
            this.txtCustomerName.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(44, 171);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(33, 20);
            this.txtAge.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Renter\'s Age";
            // 
            // checkBox1ReturnCus
            // 
            this.checkBox1ReturnCus.AutoSize = true;
            this.checkBox1ReturnCus.Location = new System.Drawing.Point(31, 214);
            this.checkBox1ReturnCus.Name = "checkBox1ReturnCus";
            this.checkBox1ReturnCus.Size = new System.Drawing.Size(161, 17);
            this.checkBox1ReturnCus.TabIndex = 12;
            this.checkBox1ReturnCus.Text = "Check if Returning Customer";
            this.checkBox1ReturnCus.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(537, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1PickUp
            // 
            this.dateTimePicker1PickUp.Location = new System.Drawing.Point(248, 65);
            this.dateTimePicker1PickUp.Name = "dateTimePicker1PickUp";
            this.dateTimePicker1PickUp.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1PickUp.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Return Date";
            // 
            // dateTimePicker2ReturnDate
            // 
            this.dateTimePicker2ReturnDate.Location = new System.Drawing.Point(479, 65);
            this.dateTimePicker2ReturnDate.Name = "dateTimePicker2ReturnDate";
            this.dateTimePicker2ReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2ReturnDate.TabIndex = 16;
            // 
            // btnPrintContract
            // 
            this.btnPrintContract.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrintContract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintContract.Location = new System.Drawing.Point(523, 320);
            this.btnPrintContract.Name = "btnPrintContract";
            this.btnPrintContract.Size = new System.Drawing.Size(75, 29);
            this.btnPrintContract.TabIndex = 17;
            this.btnPrintContract.Text = "Print";
            this.btnPrintContract.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Print a Contract";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Search For Vehicle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Print an Estimate";
            // 
            // btnPrintEstimate
            // 
            this.btnPrintEstimate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrintEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintEstimate.Location = new System.Drawing.Point(263, 320);
            this.btnPrintEstimate.Name = "btnPrintEstimate";
            this.btnPrintEstimate.Size = new System.Drawing.Size(75, 29);
            this.btnPrintEstimate.TabIndex = 21;
            this.btnPrintEstimate.Text = "Print";
            this.btnPrintEstimate.UseVisualStyleBackColor = false;
            // 
            // txtCostOfRental
            // 
            this.txtCostOfRental.Location = new System.Drawing.Point(61, 320);
            this.txtCostOfRental.Name = "txtCostOfRental";
            this.txtCostOfRental.Size = new System.Drawing.Size(74, 20);
            this.txtCostOfRental.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cost Of Rental";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(286, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "ACME Rental Co.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(725, 416);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCostOfRental);
            this.Controls.Add(this.btnPrintEstimate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrintContract);
            this.Controls.Add(this.dateTimePicker2ReturnDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1PickUp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.checkBox1ReturnCus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.comboBox1Type);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1Type;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1ReturnCus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1PickUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2ReturnDate;
        private System.Windows.Forms.Button btnPrintContract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrintEstimate;
        private System.Windows.Forms.TextBox txtCostOfRental;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

