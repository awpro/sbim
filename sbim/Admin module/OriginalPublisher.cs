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
    public partial class frmOriginalPublisher : Form
    {
        SBIMEntities inventory = new SBIMEntities();
        public frmOriginalPublisher()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtOPID.Text = "0";
            txtOriginalPublisher.Clear();
            txtOriginalPublisher.Focus();
        }

        private void frmOriginalPublisher_Load(object sender, EventArgs e)
        {
            this.showOriginalPublisher();
        }

        private void showOriginalPublisher()
        {
            txtOPID.Text = "0";
            
            var originalPublisher=inventory.inventory_original_publisher.ToList<inventory_original_publisher>();
            gridOP.DataSource = originalPublisher;
            gridOP.Columns[0].HeaderText = "ID";
            gridOP.Columns[0].Width = 50;
            gridOP.Columns[1].HeaderText = "Original Publisher";
            gridOP.Columns[1].Width=170;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtOPID.Text);
            if (id == 0)
            {
                if (txtOriginalPublisher.Text == "")
                {
                    MessageBox.Show("Please, input acitivity name.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtOriginalPublisher.Focus();
                }
                else
                {
                    var originalPublisherName = inventory.inventory_original_publisher
                        .Where(o => o.name == txtOriginalPublisher.Text).SingleOrDefault();
                    if (originalPublisherName != null)
                    {
                        MessageBox.Show("This original publisher name already exist.");
                    }
                    else
                    {
                        inventory_original_publisher originalPublisher = new inventory_original_publisher();
                        originalPublisher.name = txtOriginalPublisher.Text;
                        inventory.AddToinventory_original_publisher(originalPublisher);
                        inventory.SaveChanges();

                        this.showOriginalPublisher();
                        txtOriginalPublisher.Clear();
                        txtOriginalPublisher.Focus();
                    }
                }
            }
            else
            {
                var editOriginalPublisher = inventory.inventory_original_publisher.Single(o => o.id == id);
                editOriginalPublisher.name = txtOriginalPublisher.Text;
                inventory.SaveChanges();

                this.showOriginalPublisher();
                txtOriginalPublisher.Clear();
                txtOriginalPublisher.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtOPID.Text);
            if (id == 0)
            {
                MessageBox.Show("Please, select original publisher name to delete.");
            }
            else
            {
                if (MessageBox.Show("Are you sure, do you want to delete this original publisher name?", "Conferm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deleteOriginalPublisher = inventory.inventory_original_publisher.Single(o => o.id == id);
                    inventory.DeleteObject(deleteOriginalPublisher);
                    inventory.SaveChanges();

                    this.showOriginalPublisher();
                    txtOriginalPublisher.Clear();
                    txtOriginalPublisher.Focus();
                }
            }
        }

        private void gridOP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int count = this.gridOP.RowCount - 1;
            int ind = this.gridOP.SelectedRows[0].Index;
            //if (ind < count)
            //{
            txtOPID.Text = this.gridOP.Rows[ind].Cells[0].Value.ToString();
            txtOriginalPublisher.Text = this.gridOP.Rows[ind].Cells[1].Value.ToString();
            //}
        }
    }
}
