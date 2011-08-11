namespace sbim.Admin_module
{
    partial class frmUserLevel
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtULCaption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelet = new System.Windows.Forms.Button();
            this.gridUserLevel = new System.Windows.Forms.DataGridView();
            this.txtULID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(226, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 33);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtULCaption
            // 
            this.txtULCaption.Location = new System.Drawing.Point(116, 23);
            this.txtULCaption.Name = "txtULCaption";
            this.txtULCaption.Size = new System.Drawing.Size(204, 20);
            this.txtULCaption.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User level caption:";
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(122, 60);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(98, 33);
            this.btnDelet.TabIndex = 8;
            this.btnDelet.Text = "Delete";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // gridUserLevel
            // 
            this.gridUserLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUserLevel.Location = new System.Drawing.Point(21, 101);
            this.gridUserLevel.MultiSelect = false;
            this.gridUserLevel.Name = "gridUserLevel";
            this.gridUserLevel.ReadOnly = true;
            this.gridUserLevel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUserLevel.Size = new System.Drawing.Size(298, 216);
            this.gridUserLevel.TabIndex = 9;
            this.gridUserLevel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridUserLevel_CellMouseClick);
            // 
            // txtULID
            // 
            this.txtULID.Location = new System.Drawing.Point(116, 4);
            this.txtULID.Name = "txtULID";
            this.txtULID.Size = new System.Drawing.Size(204, 20);
            this.txtULID.TabIndex = 10;
            this.txtULID.Visible = false;
            // 
            // frmUserLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 327);
            this.Controls.Add(this.txtULID);
            this.Controls.Add(this.gridUserLevel);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtULCaption);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Level";
            this.Load += new System.EventHandler(this.frmUserLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUserLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtULCaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.DataGridView gridUserLevel;
        private System.Windows.Forms.TextBox txtULID;
    }
}