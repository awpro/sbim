namespace sbim.Admin_module
{
    partial class frmCollectionType
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
            this.txtCollectionType = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCTId = new System.Windows.Forms.TextBox();
            this.gridCT = new System.Windows.Forms.DataGridView();
            this.inventorycollectiontypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorycollectiontypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Collection type:";
            // 
            // txtCollectionType
            // 
            this.txtCollectionType.Location = new System.Drawing.Point(114, 26);
            this.txtCollectionType.Name = "txtCollectionType";
            this.txtCollectionType.Size = new System.Drawing.Size(186, 20);
            this.txtCollectionType.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(114, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtCTId
            // 
            this.txtCTId.Location = new System.Drawing.Point(113, 39);
            this.txtCTId.Name = "txtCTId";
            this.txtCTId.Size = new System.Drawing.Size(186, 20);
            this.txtCTId.TabIndex = 6;
            this.txtCTId.Visible = false;
            // 
            // gridCT
            // 
            this.gridCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCT.Location = new System.Drawing.Point(33, 108);
            this.gridCT.MultiSelect = false;
            this.gridCT.Name = "gridCT";
            this.gridCT.ReadOnly = true;
            this.gridCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCT.Size = new System.Drawing.Size(265, 220);
            this.gridCT.TabIndex = 7;
            this.gridCT.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCT_CellMouseClick);
            // 
            // inventorycollectiontypeBindingSource
            // 
            this.inventorycollectiontypeBindingSource.DataSource = typeof(sbim.inventory_collection_type);
            // 
            // frmCollectionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 346);
            this.Controls.Add(this.gridCT);
            this.Controls.Add(this.txtCTId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCollectionType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCollectionType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collection Type";
            this.Load += new System.EventHandler(this.frmCollectionType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorycollectiontypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCollectionType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCTId;
        private System.Windows.Forms.DataGridView gridCT;
        private System.Windows.Forms.BindingSource inventorycollectiontypeBindingSource;
    }
}