namespace sbim.Admin_module
{
    partial class frmActivity
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
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gridActivity = new System.Windows.Forms.DataGridView();
            this.inventoryactivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryactivityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(108, 14);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(165, 20);
            this.txtActivity.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(193, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 31);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Activity name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 31);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridActivity
            // 
            this.gridActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActivity.Location = new System.Drawing.Point(12, 108);
            this.gridActivity.MultiSelect = false;
            this.gridActivity.Name = "gridActivity";
            this.gridActivity.ReadOnly = true;
            this.gridActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridActivity.Size = new System.Drawing.Size(261, 167);
            this.gridActivity.TabIndex = 16;
            this.gridActivity.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridActivity_CellMouseClick);
            // 
            // inventoryactivityBindingSource
            // 
            this.inventoryactivityBindingSource.DataSource = typeof(sbim.inventory_activity);
            // 
            // txtAId
            // 
            this.txtAId.Location = new System.Drawing.Point(108, 32);
            this.txtAId.Name = "txtAId";
            this.txtAId.Size = new System.Drawing.Size(163, 20);
            this.txtAId.TabIndex = 17;
            this.txtAId.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(108, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 31);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 287);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAId);
            this.Controls.Add(this.gridActivity);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.frmActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryactivityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gridActivity;
        private System.Windows.Forms.BindingSource inventoryactivityBindingSource;
        private System.Windows.Forms.TextBox txtAId;
        private System.Windows.Forms.Button btnDelete;
    }
}