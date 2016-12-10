namespace car_rental_practice
{
    partial class lblAC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblAC));
            this.comboNumDoors = new System.Windows.Forms.ComboBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePickerPickUp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrintContract = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.txtCostOfRental = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblAutoTrans = new System.Windows.Forms.Label();
            this.CkBxAutoTrans = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbxAC = new System.Windows.Forms.CheckBox();
            this.lblOptionalInsurance = new System.Windows.Forms.Label();
            this.ckbxInsurance = new System.Windows.Forms.CheckBox();
            this.dataCustData = new System.Windows.Forms.DataGridView();
            this._db_projectDataSet = new car_rental_practice._db_projectDataSet();
            this.customerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataTableAdapter = new car_rental_practice._db_projectDataSetTableAdapters.CustomerDataTableAdapter();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.under25DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._db_projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboNumDoors
            // 
            this.comboNumDoors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNumDoors.FormattingEnabled = true;
            this.comboNumDoors.Items.AddRange(new object[] {
            "2",
            "4"});
            this.comboNumDoors.Location = new System.Drawing.Point(726, 261);
            this.comboNumDoors.Margin = new System.Windows.Forms.Padding(4);
            this.comboNumDoors.Name = "comboNumDoors";
            this.comboNumDoors.Size = new System.Drawing.Size(96, 24);
            this.comboNumDoors.TabIndex = 2;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblVehicleType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(696, 230);
            this.lblVehicleType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(158, 27);
            this.lblVehicleType.TabIndex = 3;
            this.lblVehicleType.Text = "Number of doors";
            this.lblVehicleType.Click += new System.EventHandler(this.lblVehicleType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(705, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pick Up Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(112, 85);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(161, 22);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(730, 507);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnCarSearch);
            // 
            // dateTimePickerPickUp
            // 
            this.dateTimePickerPickUp.Location = new System.Drawing.Point(644, 80);
            this.dateTimePickerPickUp.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerPickUp.Name = "dateTimePickerPickUp";
            this.dateTimePickerPickUp.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerPickUp.TabIndex = 14;
            this.dateTimePickerPickUp.ValueChanged += new System.EventHandler(this.dateTimePickerPickUp_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(705, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Return Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(643, 138);
            this.dateTimePickerReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerReturnDate.TabIndex = 16;
            this.dateTimePickerReturnDate.ValueChanged += new System.EventHandler(this.dateTimePickerReturnDate_ValueChanged);
            // 
            // btnPrintContract
            // 
            this.btnPrintContract.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrintContract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintContract.Location = new System.Drawing.Point(459, 507);
            this.btnPrintContract.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintContract.Name = "btnPrintContract";
            this.btnPrintContract.Size = new System.Drawing.Size(100, 36);
            this.btnPrintContract.TabIndex = 17;
            this.btnPrintContract.Text = "Print";
            this.btnPrintContract.UseVisualStyleBackColor = false;
            this.btnPrintContract.Click += new System.EventHandler(this.btnPrintContract_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 476);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "Print a Rental Agreement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(696, 476);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "Search For Vehicle";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Location = new System.Drawing.Point(52, 156);
            this.btnNewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(202, 36);
            this.btnNewCustomer.TabIndex = 2;
            this.btnNewCustomer.Text = "NEW CUSTOMER";
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // txtCostOfRental
            // 
            this.txtCostOfRental.Location = new System.Drawing.Point(428, 431);
            this.txtCostOfRental.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostOfRental.Name = "txtCostOfRental";
            this.txtCostOfRental.ReadOnly = true;
            this.txtCostOfRental.Size = new System.Drawing.Size(153, 22);
            this.txtCostOfRental.TabIndex = 22;
            this.txtCostOfRental.TextChanged += new System.EventHandler(this.txtCostOfRental_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 400);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 27);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cost Of Rental";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(381, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "ACME Rental Co.";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(48, 84);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(51, 25);
            this.lblFirst.TabIndex = 25;
            this.lblFirst.Text = "First";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLast.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(49, 121);
            this.lblLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(50, 25);
            this.lblLast.TabIndex = 26;
            this.lblLast.Text = "Last";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(112, 121);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(161, 22);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblAutoTrans
            // 
            this.lblAutoTrans.AutoSize = true;
            this.lblAutoTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAutoTrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAutoTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoTrans.Location = new System.Drawing.Point(384, 138);
            this.lblAutoTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutoTrans.Name = "lblAutoTrans";
            this.lblAutoTrans.Size = new System.Drawing.Size(188, 27);
            this.lblAutoTrans.TabIndex = 29;
            this.lblAutoTrans.Text = "Auto Transmission?";
            // 
            // CkBxAutoTrans
            // 
            this.CkBxAutoTrans.AutoSize = true;
            this.CkBxAutoTrans.Location = new System.Drawing.Point(387, 163);
            this.CkBxAutoTrans.Margin = new System.Windows.Forms.Padding(4);
            this.CkBxAutoTrans.Name = "CkBxAutoTrans";
            this.CkBxAutoTrans.Size = new System.Drawing.Size(194, 21);
            this.CkBxAutoTrans.TabIndex = 30;
            this.CkBxAutoTrans.Text = "Check box for Auto Trans.";
            this.CkBxAutoTrans.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 27);
            this.label4.TabIndex = 31;
            this.label4.Text = "AC?";
            // 
            // ckbxAC
            // 
            this.ckbxAC.AutoSize = true;
            this.ckbxAC.Location = new System.Drawing.Point(417, 97);
            this.ckbxAC.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxAC.Name = "ckbxAC";
            this.ckbxAC.Size = new System.Drawing.Size(138, 21);
            this.ckbxAC.TabIndex = 32;
            this.ckbxAC.Text = "Check box for AC";
            this.ckbxAC.UseVisualStyleBackColor = true;
            // 
            // lblOptionalInsurance
            // 
            this.lblOptionalInsurance.AutoSize = true;
            this.lblOptionalInsurance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOptionalInsurance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOptionalInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionalInsurance.Location = new System.Drawing.Point(696, 340);
            this.lblOptionalInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptionalInsurance.Name = "lblOptionalInsurance";
            this.lblOptionalInsurance.Size = new System.Drawing.Size(189, 27);
            this.lblOptionalInsurance.TabIndex = 35;
            this.lblOptionalInsurance.Text = "Optional Insurance?";
            // 
            // ckbxInsurance
            // 
            this.ckbxInsurance.AutoSize = true;
            this.ckbxInsurance.Location = new System.Drawing.Point(678, 371);
            this.ckbxInsurance.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxInsurance.Name = "ckbxInsurance";
            this.ckbxInsurance.Size = new System.Drawing.Size(239, 21);
            this.ckbxInsurance.TabIndex = 36;
            this.ckbxInsurance.Text = "Check box for Optional Insurance";
            this.ckbxInsurance.UseVisualStyleBackColor = true;
            // 
            // dataCustData
            // 
            this.dataCustData.AllowUserToAddRows = false;
            this.dataCustData.AllowUserToDeleteRows = false;
            this.dataCustData.AutoGenerateColumns = false;
            this.dataCustData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.custFirstNameDataGridViewTextBoxColumn,
            this.custLastNameDataGridViewTextBoxColumn,
            this.licenseDataGridViewTextBoxColumn,
            this.under25DataGridViewCheckBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataCustData.DataSource = this.customerDataBindingSource;
            this.dataCustData.Location = new System.Drawing.Point(12, 209);
            this.dataCustData.Name = "dataCustData";
            this.dataCustData.RowTemplate.Height = 24;
            this.dataCustData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCustData.Size = new System.Drawing.Size(344, 334);
            this.dataCustData.TabIndex = 37;
            this.dataCustData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCustData_CellContentDoubleClick);
            // 
            // _db_projectDataSet
            // 
            this._db_projectDataSet.DataSetName = "_db_projectDataSet";
            this._db_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDataBindingSource
            // 
            this.customerDataBindingSource.DataMember = "CustomerData";
            this.customerDataBindingSource.DataSource = this._db_projectDataSet;
            // 
            // customerDataTableAdapter
            // 
            this.customerDataTableAdapter.ClearBeforeFill = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            // 
            // custFirstNameDataGridViewTextBoxColumn
            // 
            this.custFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CustFirstName";
            this.custFirstNameDataGridViewTextBoxColumn.HeaderText = "CustFirstName";
            this.custFirstNameDataGridViewTextBoxColumn.Name = "custFirstNameDataGridViewTextBoxColumn";
            // 
            // custLastNameDataGridViewTextBoxColumn
            // 
            this.custLastNameDataGridViewTextBoxColumn.DataPropertyName = "CustLastName";
            this.custLastNameDataGridViewTextBoxColumn.HeaderText = "CustLastName";
            this.custLastNameDataGridViewTextBoxColumn.Name = "custLastNameDataGridViewTextBoxColumn";
            // 
            // licenseDataGridViewTextBoxColumn
            // 
            this.licenseDataGridViewTextBoxColumn.DataPropertyName = "License";
            this.licenseDataGridViewTextBoxColumn.HeaderText = "License";
            this.licenseDataGridViewTextBoxColumn.Name = "licenseDataGridViewTextBoxColumn";
            // 
            // under25DataGridViewCheckBoxColumn
            // 
            this.under25DataGridViewCheckBoxColumn.DataPropertyName = "Under25";
            this.under25DataGridViewCheckBoxColumn.HeaderText = "Under25";
            this.under25DataGridViewCheckBoxColumn.Name = "under25DataGridViewCheckBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // lblAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 556);
            this.Controls.Add(this.dataCustData);
            this.Controls.Add(this.ckbxInsurance);
            this.Controls.Add(this.lblOptionalInsurance);
            this.Controls.Add(this.ckbxAC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CkBxAutoTrans);
            this.Controls.Add(this.lblAutoTrans);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCostOfRental);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrintContract);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerPickUp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.comboNumDoors);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "lblAC";
            this.Text = "Form 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._db_projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboNumDoors;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerPickUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.Button btnPrintContract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.TextBox txtCostOfRental;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAutoTrans;
        private System.Windows.Forms.CheckBox CkBxAutoTrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbxAC;
        private System.Windows.Forms.Label lblOptionalInsurance;
        private System.Windows.Forms.CheckBox ckbxInsurance;
        private System.Windows.Forms.DataGridView dataCustData;
        private _db_projectDataSet _db_projectDataSet;
        private System.Windows.Forms.BindingSource customerDataBindingSource;
        private _db_projectDataSetTableAdapters.CustomerDataTableAdapter customerDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn under25DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}

