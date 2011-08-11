using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using sbim.Admin_module;

namespace sbim
{
    public partial class main : Form
    {
        //private int childFormNumber = 0;
        public static SBIMEntities inv;

        public main()
        {
            InitializeComponent();
            inv = new SBIMEntities();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createDonationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBook = new Book();
            frmBook.MdiParent = this;
            frmBook.Text = "Book Information";
            frmBook.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.MdiParent = this;
            user.Show();
        }

        private void addUserLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserLevel user_level = new frmUserLevel();
            user_level.MdiParent = this;
            user_level.Show();
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrency currency = new frmCurrency();
            currency.MdiParent = this;
            currency.Show();
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCity city = new frmCity();
            city.MdiParent = this;
            city.Show();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActivity activity = new frmActivity();
            activity.MdiParent = this;
            activity.Show();
        }

        private void collectionTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCollectionType collectionType = new frmCollectionType();
            collectionType.MdiParent = this;
            collectionType.Show();

        }

        private void customerTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerType customerType = new frmCustomerType();
            customerType.MdiParent = this;
            customerType.Show();
        }

        private void customerTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerTag customerTag = new frmCustomerTag();
            customerTag.MdiParent = this;
            customerTag.Show();
        }

        private void originalPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOriginalPublisher originalPublisher = new frmOriginalPublisher();
            originalPublisher.MdiParent = this;
            originalPublisher.Show();
        }

        private void targetReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTargetReader targetReader = new frmTargetReader();
            targetReader.MdiParent = this;
            targetReader.Show();
        }
    }
}
