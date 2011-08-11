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
    public partial class frmTargetReader : Form
    {
        SBIMEntities inventory = new SBIMEntities();

        public frmTargetReader()
        {
            InitializeComponent();
        }       

        private void frmTargetReader_Load(object sender, EventArgs e)
        {
            this.showTargetReader();
        }

        private void showTargetReader()
        {
            txtTID.Text = "0";
            var tagetReader = inventory.inventory_target_readers.ToList<inventory_target_readers>();
            gridTarget.DataSource = tagetReader;
            gridTarget.Columns[0].HeaderText = "ID";
            gridTarget.Columns[0].Width = 50;
            gridTarget.Columns[1].HeaderText = "Target Reader";
            gridTarget.Columns[1].Width = 170;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTID.Text = "0";
            txtTagetReader.Clear();
            txtTagetReader.Focus();
        }

        private void gridTarget_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int ind = this.gridTarget.SelectedRows[0].Index;
            txtTID.Text = this.gridTarget.Rows[ind].Cells[0].Value.ToString();
            txtTagetReader.Text = this.gridTarget.Rows[ind].Cells[1].Value.ToString();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtTID.Text);
            if (id == 0)
            {
                if (txtTagetReader.Text == "")
                {
                    MessageBox.Show("Please, input target reader name.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtTagetReader.Focus();
                }
                else
                {
                    var targetReaderName = inventory.inventory_target_readers.Where(t => t.name == txtTagetReader.Text).SingleOrDefault();
                    if (targetReaderName != null)
                    {
                        MessageBox.Show("This target reader name already exist.");
                    }
                    else
                    {
                        inventory_target_readers targetReader = new inventory_target_readers();
                        targetReader.name = txtTagetReader.Text;
                        inventory.AddToinventory_target_readers(targetReader);
                        inventory.SaveChanges();

                        this.showTargetReader();
                        txtTagetReader.Clear();
                        txtTagetReader.Focus();
                    }
                }
            }
            else
            {
                var editTargetReader = inventory.inventory_target_readers.Single(t => t.id == id);
                editTargetReader.name = txtTagetReader.Text;
                inventory.SaveChanges();

                this.showTargetReader();
                txtTagetReader.Clear();
                txtTagetReader.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtTID.Text);
            if (id == 0)
            {
                MessageBox.Show("Please, select activity to delete.");
            }
            else
            {
                if (MessageBox.Show("Are you sure, do you want to delete this target reader?", "Conferm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deleteTargetReader = inventory.inventory_target_readers.Single(t => t.id == id);
                    inventory.DeleteObject(deleteTargetReader);
                    inventory.SaveChanges();

                    this.showTargetReader();
                    txtTagetReader.Clear();
                    txtTagetReader.Focus();
                }
            }
        }
    }
}
