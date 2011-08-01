using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace sbim
{
    public partial class UserLogin : Form
    {
        private Splash splashScreen;
        private bool done = false;

        public UserLogin()
        {
            InitializeComponent();
            this.Load += new EventHandler(HandleFormLoad);
            this.splashScreen = new Splash();
        }

        private void HandleFormLoad(object sender, EventArgs e)
        {
            this.Hide();

            Thread thread = new Thread(new ThreadStart(this.ShowSplashScreen));
            thread.Start();

            Loading loader = new Loading();
            loader.ProgressChanged += (o, ex) =>
            {
                this.splashScreen.UpdateProgress(ex.Progress);
            };

            loader.LoadingDone += (o, ex) =>
            {
                done = true;
                this.Show();
            };

            loader.DoLoading();
        }



        private void ShowSplashScreen()
        {
            splashScreen.Show();
            while (!done)
            {
                Application.DoEvents();
            }
            splashScreen.Close();
            this.splashScreen.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUser.Text == "admin" && this.txtPass.Text == "123")
            {
                this.Hide();
                main MDIForm = new main();
                MDIForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid User name or Password!");
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtUser.Text == "admin" && this.txtPass.Text == "123")
                {
                    this.Hide();
                    main MDIForm = new main();
                    MDIForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User name or Password!");
                }
            }
        }
    }
}
