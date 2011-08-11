using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace sbim.Admin_module
{
    public partial class frmActivity : Form
    {
        SBIMEntities inventory = new SBIMEntities();
      
        public frmActivity()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAId.Text = "0";
            txtActivity.Clear();
            txtActivity.Focus();
        }

        private void frmActivity_Load(object sender, EventArgs e)
        {
            this.showActivity();
        }

        private void gridActivity_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int count = this.gridActivity.RowCount - 1;
            int ind = this.gridActivity.SelectedRows[0].Index;
            //if (ind < count)
            //{
                txtAId.Text = this.gridActivity.Rows[ind].Cells[0].Value.ToString();
                txtActivity.Text = this.gridActivity.Rows[ind].Cells[1].Value.ToString();
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtAId.Text);
            if (id == 0)
            {
                if (txtActivity.Text == "")
                {
                    MessageBox.Show("Please, input acitivity name.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtActivity.Focus();
                }
                else
                {
                    var activityname = inventory.inventory_activity.Where(a => a.name == txtActivity.Text).SingleOrDefault();
                    if (activityname != null)
                    {
                        MessageBox.Show("This activity name already exist.");
                    }
                    else
                    {
                        inventory_activity activity = new inventory_activity();
                        activity.name = txtActivity.Text;
                        inventory.AddToinventory_activity(activity);
                        inventory.SaveChanges();

                        this.showActivity();
                        txtActivity.Clear();
                        txtActivity.Focus();
                    }
                }                                
            }
            else
            {
                var editActivity = inventory.inventory_activity.Single(a => a.id == id);
                editActivity.name = txtActivity.Text;
                inventory.SaveChanges();

                this.showActivity();
                txtActivity.Clear();
                txtActivity.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtAId.Text);
            if (id == 0)
            {
                MessageBox.Show("Please, select activity to delete.");
            }
            else
            {
                if (MessageBox.Show("Are you sure, do you want to delete this activity?", "Conferm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deleteActivity = inventory.inventory_activity.Single(a => a.id == id);
                    inventory.DeleteObject(deleteActivity);
                    inventory.SaveChanges();

                    this.showActivity();
                    txtActivity.Clear();
                    txtActivity.Focus();
                }
            }
        }

        private void showActivity()
        {
            txtAId.Text = "0";
            //ObjectQuery<inventory_activity> listActivity = inventory.inventory_activity;
            //gridActivity.DataSource = listActivity;
            var listActivity = inventory.inventory_activity.ToList<inventory_activity>();
            gridActivity.DataSource = listActivity;
            gridActivity.Columns[0].HeaderText = "ID";
            gridActivity.Columns[0].Width = 50;
            gridActivity.Columns[1].HeaderText = "Activity Name";
            gridActivity.Columns[1].Width = 151;
        }
    }

}
