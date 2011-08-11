namespace sbim.Admin_module
{
    partial class frmCustomerType
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gridCustomerType = new System.Windows.Forms.DataGridView();
            this.inventorycustomertypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCustomeTypeID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorycustomertypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer type:";
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Location = new System.Drawing.Point(104, 17);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(208, 20);
            this.txtCustomerType.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 53);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(215, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gridCustomerType
            // 
            this.gridCustomerType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomerType.Location = new System.Drawing.Point(27, 115);
            this.gridCustomerType.MultiSelect = false;
            this.gridCustomerType.Name = "gridCustomerType";
            this.gridCustomerType.ReadOnly = true;
            this.gridCustomerType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomerType.Size = new System.Drawing.Size(284, 203);
            this.gridCustomerType.TabIndex = 4;
            this.gridCustomerType.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCustomerType_CellMouseClick);
            // 
            // inventorycustomertypeBindingSource
            // 
            this.inventorycustomertypeBindingSource.DataSource = typeof(sbim.inventory_customer_type);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(119, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCustomeTypeID
            // 
            this.txtCustomeTypeID.Location = new System.Drawing.Point(103, 27);
            this.txtCustomeTypeID.Name = "txtCustomeTypeID";
            this.txtCustomeTypeID.Size = new System.Drawing.Size(208, 20);
            this.txtCustomeTypeID.TabIndex = 6;
            this.txtCustomeTypeID.Visible = false;
            // 
            // frmCustomerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 340);
            this.Controls.Add(this.txtCustomeTypeID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gridCustomerType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCustomerType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCustomerType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Type";
            this.Load += new System.EventHandler(this.frmCustomerType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorycustomertypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView gridCustomerType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource inventorycustomertypeBindingSource;
        private System.Windows.Forms.TextBox txtCustomeTypeID;
    }
}