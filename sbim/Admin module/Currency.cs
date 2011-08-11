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
    public partial class frmCurrency : Form
    {
        SBIMEntities inventory = new SBIMEntities();
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var editCurrency = inventory.inventory_dollarrielrate.Single<inventory_dollarrielrate>(c => c.id == 1);
            editCurrency.rate = Int32.Parse(txtRate.Text);
            inventory.SaveChanges();
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            var currency = inventory.inventory_dollarrielrate.First().rate;
            txtRate.Text = currency.ToString();
        }
    }
}
