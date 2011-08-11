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
    public partial class frmUserLevel : Form
    {
        SBIMEntities inventory = new SBIMEntities();
        public frmUserLevel()
        {
            InitializeComponent();
        }

        private void showUserLevel()
        {
            txtULID.Text = "0";
            //ObjectQuery<inventory_activity> listActivity = inventory.inventory_activity;
            //gridActivity.DataSource = listActivity;
            var inventory_user_level = from ul in inventory.inventory_user_level select new {ul.level_id, ul.level_caption };
            gridUserLevel.DataSource = inventory_user_level.ToList();
            gridUserLevel.Columns[0].HeaderText = "ID";
            gridUserLevel.Columns[0].Width = 50;
            gridUserLevel.Columns[1].HeaderText = "User level caption";
            gridUserLevel.Columns[1].Width = 160;
        }

        private void frmUserLevel_Load(object sender, EventArgs e)
        {
            this.showUserLevel();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtULID.Text);
            if (id == 0)
            {
                if (txtULCaption.Text == "")
                {
                    MessageBox.Show("Please, input user level caption.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtULCaption.Focus();
                }
                else
                {
                    var userLevelCaption = inventory.inventory_user_level.Where(ul => ul.level_caption == txtULCaption.Text).SingleOrDefault();
                    if (userLevelCaption != null)
                    {
                        MessageBox.Show("This user level caption already exist.");
                    }
                    else
                    {
                        inventory_user_level userLevel = new inventory_user_level();
                        userLevel.level_caption = txtULCaption.Text;
                        inventory.AddToinventory_user_level(userLevel);
                        inventory.SaveChanges();

                        this.showUserLevel();
                        txtULCaption.Clear();
                        txtULCaption.Focus();
                    }
                }
            }
            else
            {
                var editUserLevel = inventory.inventory_user_level.Single(ul => ul.level_id == id);
                editUserLevel.level_caption = txtULCaption.Text;
                inventory.SaveChanges();

                this.showUserLevel();
                txtULCaption.Clear();
                txtULCaption.Focus();
            }
        }

        private void gridUserLevel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ind = this.gridUserLevel.SelectedRows[0].Index;
            txtULID.Text = this.gridUserLevel.Rows[ind].Cells[0].Value.ToString();
            txtULCaption.Text = this.gridUserLevel.Rows[ind].Cells[1].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtULID.Text = "0";
            txtULCaption.Clear();
            txtULCaption.Focus();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtULID.Text);
            if (id == 0)
            {
                MessageBox.Show("Please, select user level to delete.");
            }
            else
            {
                if (MessageBox.Show("Are you sure, do you want to delete this user level?", "Conferm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deleteUserLevel = inventory.inventory_user_level.Single(ul => ul.level_id == id);
                    inventory.DeleteObject(deleteUserLevel);
                    inventory.SaveChanges();

                    this.showUserLevel();
                    txtULCaption.Clear();
                    txtULCaption.Focus();
                }
            }
        }
    }
}
