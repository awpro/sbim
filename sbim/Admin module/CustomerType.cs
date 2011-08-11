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
    public partial class frmCustomerType : Form
    {
        SBIMEntities inventory = new SBIMEntities();
        public frmCustomerType()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomeTypeID.Text = "0";
            txtCustomerType.Clear();
            txtCustomerType.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomeTypeID.Text);
            if (id == 0)
            {
                MessageBox.Show("Please, select customer type to delete.");
            }
            else
            {
                if (MessageBox.Show("Are you sure, do you want to delete this customer type?", "Conferm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deleteCustomerType = inventory.inventory_customer_type.Single(c => c.id == id);
                    inventory.DeleteObject(deleteCustomerType);
                    inventory.SaveChanges();

                    this.ShowCustomerType();
                    txtCustomerType.Clear();
                    txtCustomerType.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomeTypeID.Text);
            if (id == 0)
            {
                if (txtCustomerType.Text == "")
                {
                    MessageBox.Show("Please, input customer type.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtCustomerType.Focus();
                }
                else
                {
                    var customerTypeName = inventory.inventory_customer_type.Where(c => c.name == txtCustomerType.Text).SingleOrDefault();
                    if (customerTypeName != null)
                    {
                        MessageBox.Show("This customer type already exist.");
                    }
                    else
                    {
                        inventory_customer_type customerType = new inventory_customer_type();
                        customerType.name = txtCustomerType.Text;
                        inventory.AddToinventory_customer_type(customerType);
                        inventory.SaveChanges();

                        this.ShowCustomerType();
                        txtCustomerType.Clear();
                        txtCustomerType.Focus();
                    }
                }                
            }
            else
            {
                var editCustomerType = inventory.inventory_customer_type.Single(c => c.id == id);
                editCustomerType.name = txtCustomerType.Text;
                inventory.SaveChanges();

                this.ShowCustomerType();
                txtCustomerType.Clear();
                txtCustomerType.Focus();
            }
        }

        private void frmCustomerType_Load(object sender, EventArgs e)
        {
            this.ShowCustomerType();
        }

        private void ShowCustomerType() {
            txtCustomeTypeID.Text = "0";
            var customerTypeList = inventory.inventory_customer_type.ToList<inventory_customer_type>();
            gridCustomerType.DataSource = customerTypeList;
            gridCustomerType.Columns[0].HeaderText = "ID";
            gridCustomerType.Columns[0].Width = 50;
            gridCustomerType.Columns[1].HeaderText = "Customer Type";
            gridCustomerType.Columns[1].Width = 174;
        }

        private void gridCustomerType_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int count = this.gridCustomerType.RowCount - 1;
            int ind = this.gridCustomerType.SelectedRows[0].Index;
            //if (ind < count)
            //{
            txtCustomeTypeID.Text = this.gridCustomerType.Rows[ind].Cells[0].Value.ToString();
            txtCustomerType.Text = this.gridCustomerType.Rows[ind].Cells[1].Value.ToString();
            //}
        }
    }
}
