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
            this.btnReset = new System.Windows.Forms.Button();
            this.lvBook = new System.Windows.Forms.ListView();
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
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Collection:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Original publisher: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Illustrators: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reference:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock Alert Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Khmer title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Public price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Authors: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Photographers:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(139, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(261, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // cboCollection
            // 
            this.cboCollection.FormattingEnabled = true;
            this.cboCollection.Location = new System.Drawing.Point(139, 53);
            this.cboCollection.Name = "cboCollection";
            this.cboCollection.Size = new System.Drawing.Size(261, 21);
            this.cboCollection.TabIndex = 11;
            // 
            // cboPublisher
            // 
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(139, 83);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(261, 21);
            this.cboPublisher.TabIndex = 12;
            // 
            // lstIllustrator
            // 
            this.lstIllustrator.FormattingEnabled = true;
            this.lstIllustrator.Location = new System.Drawing.Point(139, 115);
            this.lstIllustrator.Name = "lstIllustrator";
            this.lstIllustrator.Size = new System.Drawing.Size(261, 95);
            this.lstIllustrator.TabIndex = 13;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(139, 235);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(261, 20);
            this.txtReference.TabIndex = 14;
            // 
            // txtStockAlert
            // 
            this.txtStockAlert.Location = new System.Drawing.Point(139, 265);
            this.txtStockAlert.Name = "txtStockAlert";
            this.txtStockAlert.Size = new System.Drawing.Size(261, 20);
            this.txtStockAlert.TabIndex = 15;
            // 
            // txtTitleKH
            // 
            this.txtTitleKH.Location = new System.Drawing.Point(497, 25);
            this.txtTitleKH.Name = "txtTitleKH";
            this.txtTitleKH.Size = new System.Drawing.Size(261, 20);
            this.txtTitleKH.TabIndex = 16;
            // 
            // txtPublicPrice
            // 
            this.txtPublicPrice.Location = new System.Drawing.Point(497, 53);
            this.txtPublicPrice.Name = "txtPublicPrice";
            this.txtPublicPrice.Size = new System.Drawing.Size(261, 20);
            this.txtPublicPrice.TabIndex = 17;
            // 
            // lstAuthor
            // 
            this.lstAuthor.FormattingEnabled = true;
            this.lstAuthor.Location = new System.Drawing.Point(497, 83);
            this.lstAuthor.Name = "lstAuthor";
            this.lstAuthor.Size = new System.Drawing.Size(261, 95);
            this.lstAuthor.TabIndex = 18;
            // 
            // lstPhotographer
            // 
            this.lstPhotographer.FormattingEnabled = true;
            this.lstPhotographer.Location = new System.Drawing.Point(497, 190);
            this.lstPhotographer.Name = "lstPhotographer";
            this.lstPhotographer.Size = new System.Drawing.Size(261, 95);
            this.lstPhotographer.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(139, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 39);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(264, 306);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(117, 39);
            this.btnSaveNew.TabIndex = 21;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(390, 306);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 39);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(516, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 39);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(641, 306);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 39);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lvBook
            // 
            this.lvBook.Location = new System.Drawing.Point(139, 363);
            this.lvBook.Name = "lvBook";
            this.lvBook.Size = new System.Drawing.Size(619, 281);
            this.lvBook.TabIndex = 25;
            this.lvBook.UseCompatibleStateImageBehavior = false;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 672);
            this.Controls.Add(this.lvBook);
            this.Controls.Add(this.btnReset);
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
            this.Text = "Book Information";
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
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView lvBook;
    }
}