namespace sbim
{
    partial class Book
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboCollection = new System.Windows.Forms.ComboBox();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.lstIllustrator = new System.Windows.Forms.ListBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtStockAlert = new System.Windows.Forms.TextBox();
            this.txtTitleKH = new System.Windows.Forms.TextBox();
            this.txtPublicPrice = new System.Windows.Forms.TextBox();
            this.lstAuthor = new System.Windows.Forms.ListBox();
            this.lstPhotographer = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlekhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookstockalertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory_collection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.original_publisher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Collection:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Original publisher: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Illustrators: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reference:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock Alert Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Khmer title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Public price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Authors: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Photographers:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(139, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(261, 22);
            this.txtTitle.TabIndex = 10;
            // 
            // cboCollection
            // 
            this.cboCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCollection.FormattingEnabled = true;
            this.cboCollection.Location = new System.Drawing.Point(139, 56);
            this.cboCollection.Name = "cboCollection";
            this.cboCollection.Size = new System.Drawing.Size(261, 24);
            this.cboCollection.TabIndex = 11;
            // 
            // cboPublisher
            // 
            this.cboPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(139, 89);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(261, 24);
            this.cboPublisher.TabIndex = 12;
            // 
            // lstIllustrator
            // 
            this.lstIllustrator.FormattingEnabled = true;
            this.lstIllustrator.Location = new System.Drawing.Point(139, 123);
            this.lstIllustrator.Name = "lstIllustrator";
            this.lstIllustrator.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstIllustrator.Size = new System.Drawing.Size(261, 95);
            this.lstIllustrator.TabIndex = 13;
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(139, 241);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(261, 22);
            this.txtReference.TabIndex = 14;
            // 
            // txtStockAlert
            // 
            this.txtStockAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockAlert.Location = new System.Drawing.Point(139, 273);
            this.txtStockAlert.Name = "txtStockAlert";
            this.txtStockAlert.Size = new System.Drawing.Size(261, 22);
            this.txtStockAlert.TabIndex = 15;
            // 
            // txtTitleKH
            // 
            this.txtTitleKH.Font = new System.Drawing.Font("Khmer OS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleKH.Location = new System.Drawing.Point(518, 25);
            this.txtTitleKH.Name = "txtTitleKH";
            this.txtTitleKH.Size = new System.Drawing.Size(261, 29);
            this.txtTitleKH.TabIndex = 16;
            // 
            // txtPublicPrice
            // 
            this.txtPublicPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicPrice.Location = new System.Drawing.Point(518, 65);
            this.txtPublicPrice.Name = "txtPublicPrice";
            this.txtPublicPrice.Size = new System.Drawing.Size(261, 22);
            this.txtPublicPrice.TabIndex = 17;
            // 
            // lstAuthor
            // 
            this.lstAuthor.FormattingEnabled = true;
            this.lstAuthor.Location = new System.Drawing.Point(518, 97);
            this.lstAuthor.Name = "lstAuthor";
            this.lstAuthor.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAuthor.Size = new System.Drawing.Size(261, 95);
            this.lstAuthor.TabIndex = 18;
            // 
            // lstPhotographer
            // 
            this.lstPhotographer.FormattingEnabled = true;
            this.lstPhotographer.Location = new System.Drawing.Point(518, 202);
            this.lstPhotographer.Name = "lstPhotographer";
            this.lstPhotographer.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPhotographer.Size = new System.Drawing.Size(261, 95);
            this.lstPhotographer.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 39);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(267, 312);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(117, 39);
            this.btnSaveNew.TabIndex = 21;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(398, 312);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 39);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(529, 312);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 39);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(660, 312);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(117, 39);
            this.btnNew.TabIndex = 24;
            this.btnNew.Text = "New Book";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToOrderColumns = true;
            this.dgvBook.AutoGenerateColumns = false;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.titlekhDataGridViewTextBoxColumn,
            this.publicpriceDataGridViewTextBoxColumn,
            this.bookstockalertDataGridViewTextBoxColumn,
            this.inventory_collection,
            this.original_publisher_id});
            this.dgvBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvBook.DataSource = this.bookBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBook.Location = new System.Drawing.Point(33, 367);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(746, 280);
            this.dgvBook.TabIndex = 25;
            this.dgvBook.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBook_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Book ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 75;
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "Reference";
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            this.referenceDataGridViewTextBoxColumn.ReadOnly = true;
            this.referenceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.referenceDataGridViewTextBoxColumn.Width = 75;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 160;
            // 
            // titlekhDataGridViewTextBoxColumn
            // 
            this.titlekhDataGridViewTextBoxColumn.DataPropertyName = "title_kh";
            this.titlekhDataGridViewTextBoxColumn.HeaderText = "Khmer Title ";
            this.titlekhDataGridViewTextBoxColumn.Name = "titlekhDataGridViewTextBoxColumn";
            this.titlekhDataGridViewTextBoxColumn.ReadOnly = true;
            this.titlekhDataGridViewTextBoxColumn.Width = 200;
            // 
            // publicpriceDataGridViewTextBoxColumn
            // 
            this.publicpriceDataGridViewTextBoxColumn.DataPropertyName = "public_price";
            this.publicpriceDataGridViewTextBoxColumn.HeaderText = "Public Price";
            this.publicpriceDataGridViewTextBoxColumn.Name = "publicpriceDataGridViewTextBoxColumn";
            this.publicpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookstockalertDataGridViewTextBoxColumn
            // 
            this.bookstockalertDataGridViewTextBoxColumn.DataPropertyName = "book_stock_alert";
            this.bookstockalertDataGridViewTextBoxColumn.HeaderText = "Stock Alert";
            this.bookstockalertDataGridViewTextBoxColumn.Name = "bookstockalertDataGridViewTextBoxColumn";
            this.bookstockalertDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookstockalertDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bookstockalertDataGridViewTextBoxColumn.Width = 90;
            // 
            // inventory_collection
            // 
            this.inventory_collection.DataPropertyName = "collection_id";
            this.inventory_collection.HeaderText = "Collection";
            this.inventory_collection.Name = "inventory_collection";
            this.inventory_collection.ReadOnly = true;
            this.inventory_collection.Visible = false;
            // 
            // original_publisher_id
            // 
            this.original_publisher_id.DataPropertyName = "original_publisher_id";
            this.original_publisher_id.HeaderText = "Original Publisher";
            this.original_publisher_id.Name = "original_publisher_id";
            this.original_publisher_id.ReadOnly = true;
            this.original_publisher_id.Visible = false;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(sbim.inventory_book);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 672);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstPhotographer);
            this.Controls.Add(this.lstAuthor);
            this.Controls.Add(this.txtPublicPrice);
            this.Controls.Add(this.txtTitleKH);
            this.Controls.Add(this.txtStockAlert);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.lstIllustrator);
            this.Controls.Add(this.cboPublisher);
            this.Controls.Add(this.cboCollection);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Information";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboCollection;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.ListBox lstIllustrator;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtStockAlert;
        private System.Windows.Forms.TextBox txtTitleKH;
        private System.Windows.Forms.TextBox txtPublicPrice;
        private System.Windows.Forms.ListBox lstAuthor;
        private System.Windows.Forms.ListBox lstPhotographer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titlekhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookstockalertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory_collection;
        private System.Windows.Forms.DataGridViewTextBoxColumn original_publisher_id;
    }
}