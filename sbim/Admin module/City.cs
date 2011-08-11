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
    public partial class frmCity : Form
    {
        SBIMEntities inventory = new SBIMEntities();
        public frmCity()
        {
            InitializeComponent();
        }

        private void frmCity_Load(object sender, EventArgs e)
        {
            this.showCity();
        }

        private void showCity()
        {
            txtCid.Text = "0";
            //ObjectQuery<inventory_city> city = inventory.inventory_city;
            //gridCity.DataSource = city;
            var citylist = inventory.inventory_city.ToList<inventory_city>();
            gridCity.DataSource = citylist;
            gridCity.Columns[0].HeaderText = "ID";
            gridCity.Columns[0].Width = 50;
            gridCity.Columns[1].HeaderText = "City Name";
            gridCity.Columns[1].Width = 148;
        }

        private void gridCity_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int count = this.gridCity.RowCount - 1;
            int ind = this.gridCity.SelectedRows[0].Index;
            //if (ind < count)
            //{
                txtCid.Text = this.gridCity.Rows[ind].Cells[0].Value.ToString();
                txtCityName.Text = this.gridCity.Rows[ind].Cells[1].Value.ToString();
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCid.Text = "0";
            txtCityName.Clear();
            txtCityName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCid.Text);
            if (id == 0)
            {
                if (txtCityName.Text == "")
                {
                    MessageBox.Show("Please, input city name.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtCityName.Focus();
                }
                else
                {
                    var cityname = inventory.inventory_city.Where(c => c.name == txtCityName.Text).SingleOrDefault();
                    if (cityname != null)
                    {
                        MessageBox.Show("This city name already exist.");
                    }
                    else
                    {
                        inventory_city city = new inventory_city();
                        city.name = txtCityName.Text;
                        inventory.AddToinventory_city(city);
                        inventory.SaveChanges();

                        this.showCity();
                        txtCityName.Clear();
                        txtCityName.Focus();
                    }
                }                
            }
            else
            {
                var editCity = inventory.inventory_city.Single(a => a.id == id);
                editCity.name = txtCityName.Text;
                inventory.SaveChanges();

                this.showCity();
                txtCityName.Clear();
                txtCityName.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCid.Text);
            if (id == 0)
            {
                MessageBox.Show("Please, select city name to delete.");
            }
            else
            {
                if (MessageBox.Show("Are you sure, do you want to delete this city?", "Conferm delete", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deleteCity = inventory.inventory_city.Single(a => a.id == id);
                    inventory.DeleteObject(deleteCity);
                    inventory.SaveChanges();

                    this.showCity();
                    txtCityName.Clear();
                    txtCityName.Focus();
                }
            }
        }
    }
}
