using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using System.Data.EntityClient;

namespace sbim
{
    public partial class Book : Form
    {
        public SBIMEntities inventory;

        public Book()
        {
            InitializeComponent();
            inventory = new SBIMEntities();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            try 
            {
                this.dgvBook.DataSource = inventory.inventory_book.ToList();

                var illustratorName = from a in inventory.inventory_individual where a.is_illustrator == true select a;
                var authorName = from a in inventory.inventory_individual where a.is_author == true select a;
                var photographerName = from a in inventory.inventory_individual where a.is_photographer == true select a;

                var collectionName = from a in inventory.inventory_collection select a;
                var opName = from a in inventory.inventory_original_publisher select a;
                
                if (illustratorName == null)
                {
                    MessageBox.Show("There is no Individual!.");
                }
                else
                {
                    this.lstIllustrator.DataSource = illustratorName.ToList<inventory_individual>();
                    this.lstIllustrator.DisplayMember = "name";
                    this.lstIllustrator.ValueMember = "id";
                }

                if (authorName == null)
                {
                    MessageBox.Show("There is no Individual!.");
                }
                else
                {
                    this.lstAuthor.DataSource = authorName.ToList<inventory_individual>();
                    this.lstAuthor.DisplayMember = "name";
                    this.lstAuthor.ValueMember = "id";
                }

                if (photographerName == null)
                {
                    MessageBox.Show("There is no Individual!.");
                }
                else
                {
                    this.lstPhotographer.DataSource = photographerName.ToList<inventory_individual>();
                    this.lstPhotographer.DisplayMember = "name";
                    this.lstPhotographer.ValueMember = "id";
                }

                if (collectionName == null)
                {
                    MessageBox.Show("There is no Individual!.");
                }
                else
                {
                    var list_collection = new List<KeyValuePair<string, int>>();
                    list_collection.Add(new KeyValuePair<string, int>("---------------", 0));
                    foreach (inventory_collection cName in collectionName)
                    {
                        list_collection.Add(new KeyValuePair<string, int>(cName.name.ToString(), cName.id));
                    }
                    this.cboCollection.DataSource = list_collection;
                    this.cboCollection.DisplayMember = "Key";
                    this.cboCollection.ValueMember = "Value";
                     
                }

                if (opName == null)
                {
                    MessageBox.Show("There is no Individual!.");
                }
                else
                {
                    var list_op = new List<KeyValuePair<string, int>>();
                    list_op.Add(new KeyValuePair<string, int>("---------------", 0));
                    foreach (inventory_original_publisher op in opName)
                    {
                        list_op.Add(new KeyValuePair<string, int>(op.name.ToString(), op.id));
                    }
                    this.cboPublisher.DataSource = list_op;
                    this.cboPublisher.DisplayMember = "Key";
                    this.cboPublisher.ValueMember = "Value";
                }
            }
            catch (EntitySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBook_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ind = this.dgvBook.SelectedRows[0].Index;
            int bookID = Convert.ToInt16(this.dgvBook.Rows[ind].Cells[0].Value);
            this.txtReference.Text = this.dgvBook.Rows[ind].Cells[1].Value.ToString();
            this.txtTitle.Text = this.dgvBook.Rows[ind].Cells[2].Value.ToString();
            this.txtTitleKH.Text = this.dgvBook.Rows[ind].Cells[3].Value.ToString();
            this.txtPublicPrice.Text = this.dgvBook.Rows[ind].Cells[4].Value.ToString();
            this.txtStockAlert.Text = this.dgvBook.Rows[ind].Cells[5].Value.ToString();

            int collectionID = Convert.ToInt16(this.dgvBook.Rows[ind].Cells[6].Value);
            int opID = Convert.ToInt16(this.dgvBook.Rows[ind].Cells[7].Value);

            // set collection for each book
            this.cboCollection.SelectedValue = collectionID;
            // set publisher for each book
            this.cboPublisher.SelectedValue = opID;


            // set author for each book
            var authorID = from a in inventory.inventory_book_authors where a.inventory_book.id == bookID select a;
            this.lstAuthor.ClearSelected();
            foreach (var aid in authorID)
            {
                this.lstAuthor.SelectedValue = aid.individual_id;
            }

            // set illustrator for each book
            var illustratorID = from a in inventory.inventory_book_illustrators where a.inventory_book.id == bookID select a;
            this.lstIllustrator.ClearSelected();
            foreach (var iid in illustratorID)
            {
                this.lstIllustrator.SelectedValue = iid.individual_id;
            }

            // set photographer for each book
            var photographerID = from a in inventory.inventory_book_photographers select a;
            this.lstPhotographer.ClearSelected();
            foreach (var pid in photographerID)
            {
                if (pid.book_id == bookID)
                {
                    this.lstPhotographer.SelectedValue = pid.individual_id;
                }
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Boolean is_deleted = false;
            if (MessageBox.Show("Are you sure that you want to delete?", "Delete Book", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Int32 selectedRowCount = dgvBook.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {

                        var ind = this.dgvBook.SelectedRows[i].Index;
                        var bookID = Convert.ToInt16(this.dgvBook.Rows[ind].Cells[0].Value);
                        var book = (from a in inventory.inventory_book
                                    .Include("inventory_edition")
                                    .Include("inventory_stock_adjustment")
                                    .Include("inventory_book_authors")
                                    .Include("inventory_book_photographers")
                                    .Include("inventory_book_illustrators")
                                    where a.id == bookID
                                    select a).FirstOrDefault();
                        try
                        {
                            inventory.DeleteObject(book);
                            inventory.SaveChanges();
                            is_deleted = true;
                        }
                        catch (EntitySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    if (is_deleted)
                    {
                        this.dgvBook.DataSource = null;
                        this.dgvBook.DataSource = inventory.inventory_book.ToList();

                        if (selectedRowCount == 1)
                        {
                            MessageBox.Show("1 Book is deleted!", "Delete Book");
                        }
                        else
                        {
                            MessageBox.Show(selectedRowCount + " Book are deleted!", "Delete Book");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Please select book to delete!", "Delete Book");
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newBook();
        }

        private void newBook()
        {
            this.txtTitle.Clear();
            this.txtTitleKH.Clear();
            this.txtPublicPrice.Clear();
            this.txtReference.Clear();
            this.txtStockAlert.Clear();
            this.cboCollection.SelectedValue = 0;
            this.cboPublisher.SelectedValue = 0;

            this.lstAuthor.ClearSelected();
            this.lstIllustrator.ClearSelected();
            this.lstPhotographer.ClearSelected();
        }

        private Boolean checkBook()
        {
            Boolean ok = true;
            string msg = "";
            if (this.txtTitle.Text == "")
            {
                msg = msg + "Please input Book Title!\n";
                ok = false;
            }
            //if (this.txtTitleKH.Text == "")
            //{
            //    msg = msg + "Please input Book Title KH!\n";
            //    ok = false;
            //}
            if (this.txtPublicPrice.Text == "")
            {
                msg = msg + "Please input Public Price!\n";
                ok = false;
            }
            if (this.txtReference.Text == "")
            {
                msg = msg + "Please input Reference!\n";
                ok = false;
            }
            if (this.txtStockAlert.Text == "")
            {
                msg = msg + "Please input Stock Alert!\n";
                ok = false;
            }

            if (ok == false)
            {
                MessageBox.Show(msg,"Book Add");
            }

            return ok;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean is_added = false;
            int bookID;
            
            Boolean ok = checkBook();
            if (!ok)
            {
                return;
            }

            var check_ref = inventory.inventory_book.Where(r => r.reference == this.txtReference.Text).SingleOrDefault();
            if (check_ref != null)
            {
                MessageBox.Show("Reference is duplicated!","Book Add");
                return;
            }

            inventory_book book = new inventory_book();
            book.title = this.txtTitle.Text;
            book.title_kh = this.txtTitleKH.Text;
            book.reference = this.txtReference.Text;
            book.public_price = Convert.ToDecimal(this.txtPublicPrice.Text);
            book.book_stock_alert = Convert.ToInt16(this.txtStockAlert.Text);
            book.collection_id = Convert.ToInt16(this.cboCollection.SelectedValue);
            book.original_publisher_id = Convert.ToInt16(this.cboPublisher.SelectedValue);

            try
            {
                inventory.inventory_book.AddObject(book);
                inventory.SaveChanges();
                bookID = book.id;
                book = null;

                if (bookID > 0)
                {
                    foreach (inventory_individual  illustrator in this.lstIllustrator.SelectedItems)
                    {
                        inventory_book_illustrators illustrators = new inventory_book_illustrators();
                        illustrators.book_id = bookID;
                        illustrators.individual_id = illustrator.id;
                        inventory.inventory_book_illustrators.AddObject(illustrators);
                        inventory.SaveChanges();
                    }

                    foreach (inventory_individual author in this.lstAuthor.SelectedItems)
                    {
                        inventory_book_authors authors = new inventory_book_authors();
                        authors.book_id = bookID;
                        authors.individual_id = author.id;
                        inventory.inventory_book_authors.AddObject(authors);
                        inventory.SaveChanges();
                    }

                    foreach (inventory_individual photographer in this.lstPhotographer.SelectedItems)
                    {
                        inventory_book_photographers photographers = new inventory_book_photographers();
                        photographers.book_id = bookID;
                        photographers.individual_id = photographer.id;
                        inventory.inventory_book_photographers.AddObject(photographers);
                        inventory.SaveChanges();
                    }
                    is_added = true;
                        
                }
            }
            catch (EntitySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (is_added)
            {
                this.dgvBook.DataSource = null;
                this.dgvBook.DataSource = inventory.inventory_book.ToList();
                MessageBox.Show("1 Book is added!", "Book Add");
            }
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            Boolean is_added = false;
            int bookID;

            Boolean ok = checkBook();
            if (!ok)
            {
                return;
            }

            var check_ref = inventory.inventory_book.Where(r => r.reference == this.txtReference.Text).SingleOrDefault();
            if (check_ref != null)
            {
                MessageBox.Show("Reference is duplicated!", "Book Add");
                return;
            }

            inventory_book book = new inventory_book();
            book.title = this.txtTitle.Text;
            book.title_kh = this.txtTitleKH.Text;
            book.reference = this.txtReference.Text;
            book.public_price = Convert.ToDecimal(this.txtPublicPrice.Text);
            book.book_stock_alert = Convert.ToInt16(this.txtStockAlert.Text);
            book.collection_id = Convert.ToInt16(this.cboCollection.SelectedValue);
            book.original_publisher_id = Convert.ToInt16(this.cboPublisher.SelectedValue);

            try
            {
                inventory.inventory_book.AddObject(book);
                inventory.SaveChanges();
                bookID = book.id;
                book = null;

                if (bookID > 0)
                {
                    foreach (inventory_individual illustrator in this.lstIllustrator.SelectedItems)
                    {
                        inventory_book_illustrators illustrators = new inventory_book_illustrators();
                        illustrators.book_id = bookID;
                        illustrators.individual_id = illustrator.id;
                        inventory.inventory_book_illustrators.AddObject(illustrators);
                        inventory.SaveChanges();
                    }

                    foreach (inventory_individual author in this.lstAuthor.SelectedItems)
                    {
                        inventory_book_authors authors = new inventory_book_authors();
                        authors.book_id = bookID;
                        authors.individual_id = author.id;
                        inventory.inventory_book_authors.AddObject(authors);
                        inventory.SaveChanges();
                    }

                    foreach (inventory_individual photographer in this.lstPhotographer.SelectedItems)
                    {
                        inventory_book_photographers photographers = new inventory_book_photographers();
                        photographers.book_id = bookID;
                        photographers.individual_id = photographer.id;
                        inventory.inventory_book_photographers.AddObject(photographers);
                        inventory.SaveChanges();
                    }
                    is_added = true;

                }
            }
            catch (EntitySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (is_added)
            {
                this.dgvBook.DataSource = null;
                this.dgvBook.DataSource = inventory.inventory_book.ToList();
                MessageBox.Show("1 Book is added!", "Book Add");
                newBook();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Boolean is_updated = false;
            if (MessageBox.Show("Are you sure that you want to update?", "Update Book", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            
            Boolean ok = checkBook();
            if (!ok)
            {
                return;
            }


            inventory_book_authors authors = new inventory_book_authors();
            inventory_book_illustrators illustrators = new inventory_book_illustrators();
            inventory_book_photographers photographers = new inventory_book_photographers();

            var ind = this.dgvBook.SelectedRows[0].Index;
            int bookID = Convert.ToInt16(this.dgvBook.Rows[ind].Cells[0].Value);

            inventory_book book = inventory.inventory_book.First(i => i.id == bookID);

            var check_ref = inventory.inventory_book.Where(r => r.reference == this.txtReference.Text).SingleOrDefault();
            if (check_ref != null)
            {
                if (check_ref.reference != book.reference)
                {
                    MessageBox.Show("Reference is duplicated!", "Book Add");
                    return;
                }
            }

            book.title = this.txtTitle.Text;
            book.title_kh = this.txtTitleKH.Text;
            book.reference = this.txtReference.Text;
            book.public_price = Convert.ToDecimal(this.txtPublicPrice.Text);
            book.book_stock_alert = Convert.ToInt16(this.txtStockAlert.Text);
            book.collection_id = Convert.ToInt16(this.cboCollection.SelectedValue);
            book.original_publisher_id = Convert.ToInt16(this.cboPublisher.SelectedValue);

            try
            {
                inventory.SaveChanges();
                is_updated = true;
            }
            catch (EntitySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (is_updated)
            {
                this.dgvBook.DataSource = null;
                this.dgvBook.DataSource = inventory.inventory_book.ToList();
                MessageBox.Show("1 Book is updated!", "Book Update");
            }
        }
            
        
    }
}
