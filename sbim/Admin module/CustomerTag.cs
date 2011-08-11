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
    public partial class frmCustomerTag : Form
    {
        SBIMEntities inventory = new SBIMEntities();

        public frmCustomerTag()
        {
            InitializeComponent();
        }

        
        private void frmCustomerTag_Load(object sender, EventArgs e)
        {

            cboParent.Items.Add(new comboboxItem(0, "--------------------------"));
            var parents = from cp in inventory.inventory_customer_tags where cp.parent_id == 0 select cp;
            foreach (var parent in parents)
            {
                cboParent.Items.Add(new comboboxItem(parent.id, parent.name));
            }

            cboParent.SelectedIndex = 0;

            txtTID.Text = "0";
            //var collectionName = from a in inventory.inventory_customer_tags where a.parent_id == 0 select a;
            //var list_collection = new List<KeyValuePair<string, int>>();
            //list_collection.Add(new KeyValuePair<string, int>("---------------", 0));
            //foreach (inventory_customer_tags cName in collectionName)
            //{
            //    list_collection.Add(new KeyValuePair<string, int>(cName.name.ToString(), cName.id));
            //}
            //this.cboParent.DataSource = list_collection;
            //this.cboParent.DisplayMember = "Key";
            //this.cboParent.ValueMember = "Value";

            this.showTreeView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((cboParent.SelectedItem as comboboxItem).value.ToString());
            int id = int.Parse(txtTID.Text);
            if (id == 0)
            {
                if (txtTagName.Text == "")
                {
                    MessageBox.Show("Please, input customer tag name.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtTagName.Focus();
                }
                else
                {
                    var customerTagName = inventory.inventory_customer_tags.Where(t => t.name == txtTagName.Text).SingleOrDefault();
                    if (customerTagName != null)
                    {
                        MessageBox.Show("This customer tag already exist.");
                    }
                    else
                    {
                        inventory_customer_tags customerTag = new inventory_customer_tags();
                        customerTag.name = txtTagName.Text;
                        customerTag.parent_id = Int16.Parse((cboParent.SelectedItem as comboboxItem).value.ToString());
                        inventory.AddToinventory_customer_tags(customerTag);
                        inventory.SaveChanges();

                        this.showTreeView();
                        txtTagName.Clear();
                        txtTagName.Focus();
                        cboParent.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                var editCustomerTag = inventory.inventory_customer_tags.Single(t => t.id == id);
                editCustomerTag.name = txtTagName.Text;
                editCustomerTag.parent_id = Int16.Parse((cboParent.SelectedItem as comboboxItem).value.ToString());
                inventory.SaveChanges();

                this.showTreeView();
                txtTagName.Clear();
                txtTagName.Focus();
                cboParent.SelectedIndex = 0;
            }
            
        }

        private void showTreeView()
        {
            treeView1.Nodes.Clear();
            TreeNode node;
            var customerTags = from ct in inventory.inventory_customer_tags where ct.parent_id == 0 select ct;
            foreach (var customer in customerTags)
            {
                node = treeView1.Nodes.Add(customer.name);
                var subParent = from cts in inventory.inventory_customer_tags where cts.parent_id == customer.id select cts;
                foreach (var subp in subParent)
                {
                    node.Nodes.Add(subp.name);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var ctId = inventory.inventory_customer_tags.Where(c => c.name == e.Node.Text).First<inventory_customer_tags>();
            txtTagName.Text = e.Node.Text;
            txtTID.Text = ctId.id.ToString();
            if (Int16.Parse(ctId.parent_id.ToString()) == 0)
                cboParent.SelectedIndex = 0;
            else
            {
                var tName = inventory.inventory_customer_tags.Where(t => t.id == ctId.parent_id).First().name;
                cboParent.SelectedIndex = cboParent.FindStringExact(tName.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTID.Text = "0";
            cboParent.SelectedIndex = 0;
            txtTagName.Clear();
            txtTagName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtTID.Text);
            if (id == 0)
            {
                MessageBox.Show("Please, select customer tag to delete.");
            }
            else
            {
                if (MessageBox.Show("Are you sure, do you want to delete this customer tag?", "Conferm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deleteCustomerTag = inventory.inventory_customer_tags.Single(t => t.id == id);
                    inventory.DeleteObject(deleteCustomerTag);
                    inventory.SaveChanges();

                    cboParent.SelectedIndex = 0;
                    this.showTreeView();
                    txtTagName.Clear();
                    txtTagName.Focus();
                }
            }
        }

    }

    public class comboboxItem
    {
        public object value { get; set; }
        public string text { get; set; }
        public comboboxItem(int val, string tx)
        {
            this.value = val;
            this.text = tx;
        }

        public override string ToString()
        {
            return this.text;
        }
    }
   
}
