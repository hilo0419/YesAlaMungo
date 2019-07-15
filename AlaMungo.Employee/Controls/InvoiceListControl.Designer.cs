namespace AlaMungo.Employee.Controls
{
    partial class InvoiceListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.BuyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerLoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsBuy = new System.Windows.Forms.BindingSource(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            this.buyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyUsedBooksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerLoginIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubilsherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AllowUserToResizeColumns = false;
            this.dgvInvoice.AllowUserToResizeRows = false;
            this.dgvInvoice.AutoGenerateColumns = false;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuyID,
            this.BuyerLoginID,
            this.Title,
            this.OrderDate,
            this.InvoiceState,
            this.buyIDDataGridViewTextBoxColumn,
            this.buyerIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.subAddressDataGridViewTextBoxColumn,
            this.invoiceStateDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.buyUsedBooksDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.buyerLoginIDDataGridViewTextBoxColumn,
            this.writerDataGridViewTextBoxColumn,
            this.pubilsherDataGridViewTextBoxColumn,
            this.qualityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.imagePathDataGridViewTextBoxColumn});
            this.dgvInvoice.DataSource = this.bdsBuy;
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowTemplate.Height = 23;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(589, 384);
            this.dgvInvoice.TabIndex = 0;
            this.dgvInvoice.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvList_CellFormatting);
            // 
            // BuyID
            // 
            this.BuyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BuyID.DataPropertyName = "BuyID";
            this.BuyID.HeaderText = "배송 번호";
            this.BuyID.Name = "BuyID";
            this.BuyID.ReadOnly = true;
            this.BuyID.Width = 110;
            // 
            // BuyerLoginID
            // 
            this.BuyerLoginID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BuyerLoginID.DataPropertyName = "BuyerLoginID";
            this.BuyerLoginID.HeaderText = "구매자 ID";
            this.BuyerLoginID.Name = "BuyerLoginID";
            this.BuyerLoginID.ReadOnly = true;
            this.BuyerLoginID.Width = 120;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "책 이름";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "구매 일시";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 130;
            // 
            // InvoiceState
            // 
            this.InvoiceState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InvoiceState.DataPropertyName = "InvoiceState";
            this.InvoiceState.HeaderText = "배송 상태";
            this.InvoiceState.Name = "InvoiceState";
            this.InvoiceState.ReadOnly = true;
            this.InvoiceState.Width = 150;
            // 
            // bdsBuy
            // 
            this.bdsBuy.DataSource = typeof(AlaMungo.Data.Buy);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCount.Location = new System.Drawing.Point(0, 372);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(29, 12);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "대기";
            // 
            // buyIDDataGridViewTextBoxColumn
            // 
            this.buyIDDataGridViewTextBoxColumn.DataPropertyName = "BuyID";
            this.buyIDDataGridViewTextBoxColumn.HeaderText = "BuyID";
            this.buyIDDataGridViewTextBoxColumn.Name = "buyIDDataGridViewTextBoxColumn";
            // 
            // buyerIDDataGridViewTextBoxColumn
            // 
            this.buyerIDDataGridViewTextBoxColumn.DataPropertyName = "BuyerID";
            this.buyerIDDataGridViewTextBoxColumn.HeaderText = "BuyerID";
            this.buyerIDDataGridViewTextBoxColumn.Name = "buyerIDDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // subAddressDataGridViewTextBoxColumn
            // 
            this.subAddressDataGridViewTextBoxColumn.DataPropertyName = "SubAddress";
            this.subAddressDataGridViewTextBoxColumn.HeaderText = "SubAddress";
            this.subAddressDataGridViewTextBoxColumn.Name = "subAddressDataGridViewTextBoxColumn";
            // 
            // invoiceStateDataGridViewTextBoxColumn
            // 
            this.invoiceStateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceState";
            this.invoiceStateDataGridViewTextBoxColumn.HeaderText = "InvoiceState";
            this.invoiceStateDataGridViewTextBoxColumn.Name = "invoiceStateDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // buyUsedBooksDataGridViewTextBoxColumn
            // 
            this.buyUsedBooksDataGridViewTextBoxColumn.DataPropertyName = "BuyUsedBooks";
            this.buyUsedBooksDataGridViewTextBoxColumn.HeaderText = "BuyUsedBooks";
            this.buyUsedBooksDataGridViewTextBoxColumn.Name = "buyUsedBooksDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // buyerLoginIDDataGridViewTextBoxColumn
            // 
            this.buyerLoginIDDataGridViewTextBoxColumn.DataPropertyName = "BuyerLoginID";
            this.buyerLoginIDDataGridViewTextBoxColumn.HeaderText = "BuyerLoginID";
            this.buyerLoginIDDataGridViewTextBoxColumn.Name = "buyerLoginIDDataGridViewTextBoxColumn";
            // 
            // writerDataGridViewTextBoxColumn
            // 
            this.writerDataGridViewTextBoxColumn.DataPropertyName = "Writer";
            this.writerDataGridViewTextBoxColumn.HeaderText = "Writer";
            this.writerDataGridViewTextBoxColumn.Name = "writerDataGridViewTextBoxColumn";
            // 
            // pubilsherDataGridViewTextBoxColumn
            // 
            this.pubilsherDataGridViewTextBoxColumn.DataPropertyName = "Pubilsher";
            this.pubilsherDataGridViewTextBoxColumn.HeaderText = "Pubilsher";
            this.pubilsherDataGridViewTextBoxColumn.Name = "pubilsherDataGridViewTextBoxColumn";
            // 
            // qualityDataGridViewTextBoxColumn
            // 
            this.qualityDataGridViewTextBoxColumn.DataPropertyName = "Quality";
            this.qualityDataGridViewTextBoxColumn.HeaderText = "Quality";
            this.qualityDataGridViewTextBoxColumn.Name = "qualityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // imagePathDataGridViewTextBoxColumn
            // 
            this.imagePathDataGridViewTextBoxColumn.DataPropertyName = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.HeaderText = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.Name = "imagePathDataGridViewTextBoxColumn";
            // 
            // InvoiceListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvInvoice);
            this.Name = "InvoiceListControl";
            this.Size = new System.Drawing.Size(589, 384);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.BindingSource bdsBuy;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerLoginID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceState;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyUsedBooksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerLoginIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubilsherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
    }
}
