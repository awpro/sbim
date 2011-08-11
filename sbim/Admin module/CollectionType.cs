using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sbim.Admin_module
{
    public partial class frmCollectionType : Form
    {
        SBIMEntities inventory = new SBIMEntities();
        public frmCollectionType()
        {
            InitializeComponent();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCTId.Text);
            if (id == 0)
            {
                if (txtCollectionType.Text == "")
                {
                    MessageBox.Show("Please, input collection type.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtCollectionType.Focus();
                }
                else
                {
                    var collectionType = inventory.inventory_collection_type.Where(c => c.name == txtCollectionType.Text).SingleOrDefault();
                    if (collectionType != null)
                    {
                        MessageBox.Show("This activity name already exist.");
                    }
                    else
                    {
                        inventory_collection_type IncollectionType = new inventory_collection_type();
                        IncollectionType.name = txtCollectionType.Text;
                        inventory.AddToinventory_collection_type(IncollectionType);
                        inventory.SaveChanges();

                        this.showCollectionType();
                        txtCollectionType.Clear();
                        txtCollectionType.Focus();
                    }
                }                
            }
            else
            {
                var editCollectionType = inventory.inventory_collection_type.Single(c => c.id == id);
                editCollectionType.name = txtCollectionType.Text;
                inventory.SaveChanges();

                this.showCollectionType();
                txtCollectionType.Clear();
                txtCollectionType.Focus();
            }
        }

        private void frmCollectionType_Load(object sender, EventArgs e)
        {
            this.showCollectionType();
        }

        private void showCollectionType()
        {
            txtCTId.Text = "0";
            var collectionTypeList=inventory.inventory_collection_type.ToList<inventory_collection_type>();
            gridCT.DataSource = collectionTypeList;
            gridCT.Columns[0].HeaderText = "ID";
            gridCT.Columns[0].Width = 50;
            gridCT.Columns[1].HeaderText = "Collection Type";
            gridCT.Columns[1].Width = 155;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCTId.Text);
            if (id == 0)
            {
                MessageBox.Show("Please, select activity to delete.");
            }
            else
            {
                if (MessageBox.Show("Are you sure, do you want to delete this collection type?", "Conferm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deleteCollectionType = inventory.inventory_collection_type.Single(c => c.id == id);
                    inventory.DeleteObject(deleteCollectionType);
                    inventory.SaveChanges();

                    this.showCollectionType();
                    txtCollectionType.Clear();
                    txtCollectionType.Focus();
                }
            }
        }

        private void gridCT_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int count = this.gridCT.RowCount - 1;
            int ind = this.gridCT.SelectedRows[0].Index;
            //if (ind < count)
            //{
            txtCTId.Text = this.gridCT.Rows[ind].Cells[0].Value.ToString();
            txtCollectionType.Text = this.gridCT.Rows[ind].Cells[1].Value.ToString();
            //}
        }
    }
}
