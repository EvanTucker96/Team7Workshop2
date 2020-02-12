using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExperts.Forms;
using TravelExperts.Data;
using TravelExperts.Utility;

namespace TravelExperts
{
    public partial class Form1 : Form
    {
        private TravelExpertsDataContext DataContext { get; }

        public Form1()
        {
            InitializeComponent();
            DataContext = new TravelExpertsDataContext();
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            Products form = new Products(DataContext);
            form.Show();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            Packages form = new Packages(DataContext);
            form.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.Username = txtUsername.Text;
            newUser.Password = Util.Encrypt(txtPassword.Text);
            DataContext.Users.InsertOnSubmit(newUser);
            try
            {
                DataContext.SubmitChanges();
            }
            catch
            {
                lblError.Text = "User already exists";
            }           
            lblLogin.Text = "";
            if(lblError.Text != "User already exists")
                lblSuccess.Text = "Registration successful!";
            lblError.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user;

            string username = txtUsername.Text;
            string password = Util.Encrypt(txtPassword.Text);

            var query = from u
                        in DataContext.Users
                        where u.Username == username && u.Password == password
                        select u;

            if (query != null && query.FirstOrDefault() != null)
            {
                user = query.First();
                btnPackages.Enabled = true;
                button_Products.Enabled = true;
                btnLogout.Enabled = true;
                btnLogout.Visible = true;
                lblLogin.Text = "Welcome, " + user.Username + "!";
                lblError.Text = "";
                lblSuccess.Text = "";
                btnLogin.Enabled = false;
                btnLogin.Visible = false;
                btnRegister.Enabled = false;
                btnRegister.Visible = false;
                lblUsername.Visible = false;
                lblPassword.Visible = false;
                txtUsername.Enabled = false;
                txtUsername.Visible = false;
                txtPassword.Visible = false;
                txtPassword.Enabled = false;
            }
            else
            {
                lblSuccess.Text = "";
                lblError.Text = "Invalid credentials";
                txtUsername.Text = "";
                txtPassword.Text = "";
                return;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnPackages.Enabled = false;
            button_Products.Enabled = false;
            btnLogout.Enabled = false;
            btnLogout.Visible = false;
            txtUsername.Text = "";
            txtPassword.Text = "";
            lblLogin.Text = "";
            btnLogin.Enabled = true;
            btnLogin.Visible = true;
            btnRegister.Enabled = true;
            btnRegister.Visible = true;
            lblUsername.Visible = true;
            lblPassword.Visible = true;
            txtUsername.Enabled = true;
            txtUsername.Visible = true;
            txtPassword.Visible = true;
            txtPassword.Enabled = true;
        }
    }
}
