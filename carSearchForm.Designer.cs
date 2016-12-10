namespace car_rental_practice
{
    partial class carSearchForm
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
            this._db_projectDataSet = new car_rental_practice._db_projectDataSet();
            this.customerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataTableAdapter = new car_rental_practice._db_projectDataSetTableAdapters.CustomerDataTableAdapter();
            this.dbprojectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataCarSearch = new System.Windows.Forms.DataGridView();
            this._db_projectDataSet1 = new car_rental_practice._db_projectDataSet1();
            this.carDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDataTableAdapter = new car_rental_practice._db_projectDataSet1TableAdapters.CarDataTableAdapter();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cylindersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automaticDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buybackPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._db_projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCarSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._db_projectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDataBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // dbprojectDataSetBindingSource
            // 
            this.dbprojectDataSetBindingSource.DataSource = this._db_projectDataSet;
            this.dbprojectDataSetBindingSource.Position = 0;
            // 
            // dataCarSearch
            // 
            this.dataCarSearch.AutoGenerateColumns = false;
            this.dataCarSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCarSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIdDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.doorsDataGridViewTextBoxColumn,
            this.cylindersDataGridViewTextBoxColumn,
            this.automaticDataGridViewTextBoxColumn,
            this.aCDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.buybackPriceDataGridViewTextBoxColumn,
            this.rentPriceDataGridViewTextBoxColumn});
            this.dataCarSearch.DataSource = this.carDataBindingSource;
            this.dataCarSearch.Location = new System.Drawing.Point(12, 12);
            this.dataCarSearch.Name = "dataCarSearch";
            this.dataCarSearch.RowTemplate.Height = 24;
            this.dataCarSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCarSearch.Size = new System.Drawing.Size(850, 483);
            this.dataCarSearch.TabIndex = 0;
            this.dataCarSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCarSearch_CellDoubleClick);
            // 
            // _db_projectDataSet1
            // 
            this._db_projectDataSet1.DataSetName = "_db_projectDataSet1";
            this._db_projectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carDataBindingSource
            // 
            this.carDataBindingSource.DataMember = "CarData";
            this.carDataBindingSource.DataSource = this._db_projectDataSet1;
            // 
            // carDataTableAdapter
            // 
            this.carDataTableAdapter.ClearBeforeFill = true;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Division";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // doorsDataGridViewTextBoxColumn
            // 
            this.doorsDataGridViewTextBoxColumn.DataPropertyName = "Doors";
            this.doorsDataGridViewTextBoxColumn.HeaderText = "Doors";
            this.doorsDataGridViewTextBoxColumn.Name = "doorsDataGridViewTextBoxColumn";
            // 
            // cylindersDataGridViewTextBoxColumn
            // 
            this.cylindersDataGridViewTextBoxColumn.DataPropertyName = "Cylinders";
            this.cylindersDataGridViewTextBoxColumn.HeaderText = "Cylinders";
            this.cylindersDataGridViewTextBoxColumn.Name = "cylindersDataGridViewTextBoxColumn";
            // 
            // automaticDataGridViewTextBoxColumn
            // 
            this.automaticDataGridViewTextBoxColumn.DataPropertyName = "Automatic";
            this.automaticDataGridViewTextBoxColumn.HeaderText = "Automatic";
            this.automaticDataGridViewTextBoxColumn.Name = "automaticDataGridViewTextBoxColumn";
            // 
            // aCDataGridViewTextBoxColumn
            // 
            this.aCDataGridViewTextBoxColumn.DataPropertyName = "AC";
            this.aCDataGridViewTextBoxColumn.HeaderText = "AC";
            this.aCDataGridViewTextBoxColumn.Name = "aCDataGridViewTextBoxColumn";
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            // 
            // buybackPriceDataGridViewTextBoxColumn
            // 
            this.buybackPriceDataGridViewTextBoxColumn.DataPropertyName = "BuybackPrice";
            this.buybackPriceDataGridViewTextBoxColumn.HeaderText = "BuybackPrice";
            this.buybackPriceDataGridViewTextBoxColumn.Name = "buybackPriceDataGridViewTextBoxColumn";
            // 
            // rentPriceDataGridViewTextBoxColumn
            // 
            this.rentPriceDataGridViewTextBoxColumn.DataPropertyName = "rentPrice";
            this.rentPriceDataGridViewTextBoxColumn.HeaderText = "rentPrice";
            this.rentPriceDataGridViewTextBoxColumn.Name = "rentPriceDataGridViewTextBoxColumn";
            // 
            // carSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 507);
            this.Controls.Add(this.dataCarSearch);
            this.Name = "carSearchForm";
            this.Text = "carSearchForm";
            this.Load += new System.EventHandler(this.carSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._db_projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCarSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._db_projectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private _db_projectDataSet _db_projectDataSet;
        private System.Windows.Forms.BindingSource customerDataBindingSource;
        private _db_projectDataSetTableAdapters.CustomerDataTableAdapter customerDataTableAdapter;
        private System.Windows.Forms.BindingSource dbprojectDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataCarSearch;
        private _db_projectDataSet1 _db_projectDataSet1;
        private System.Windows.Forms.BindingSource carDataBindingSource;
        private _db_projectDataSet1TableAdapters.CarDataTableAdapter carDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cylindersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn automaticDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buybackPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPriceDataGridViewTextBoxColumn;
    }
}