using MyBikesCompany.Business;
using MyBikesCompany.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesCompany.UI
{
    public partial class LoginForm : Form
    {
        private List<Users> listOfUsers = UserSequentialData.Load();

        MainForm Main = new MainForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                char v = '\0';
                txtPassword.PasswordChar = v;
                txtConfirm.PasswordChar = v;
            }else
            {
                txtPassword.PasswordChar = '*';
                txtConfirm.PasswordChar = '*';
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text =  "";
            txtConfirm.Text = "";
            txtPassword.Text = "";
        }

        private void rbLog_CheckedChanged(object sender, EventArgs e)
        {
            statusForm();
        }

        private void rbSign_CheckedChanged(object sender, EventArgs e)
        {
            statusForm();
        }

        private void statusForm()
        {
            if (rbLog.Checked)
            {
                lblConfirm.Hide();
                txtConfirm.Hide();
                cbShow.Location = new System.Drawing.Point(49, 410);
            }else
            {
                lblConfirm.Show();
                txtConfirm.Show();
                cbShow.Location = new System.Drawing.Point(49, 557);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (rbLog.Checked)
            {
                if (txtUser.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please inform an Username and a Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool userfound = false;
                foreach (var user in listOfUsers)
                {
                    if (txtUser.Text == user.Username && txtPassword.Text == user.Password)
                    {
                        userfound = true;
                        this.Hide();
                        Main.ShowDialog();
                        Application.Exit();
                    }
                }
                if (!userfound)
                {
                    MessageBox.Show("Username or password are wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }else
            {
                foreach (var user in listOfUsers)
                {
                    if (txtUser.Text == user.Username)
                    {
                        MessageBox.Show("Username already exist, please provide another username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (txtUser.Text == "" || txtPassword.Text == "" || txtConfirm.Text == "")
                {
                    MessageBox.Show("Please inform Username, password and confirm it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Passwords don't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   return;
                }
                var newUser = new Users();
                newUser.Username = txtUser.Text.Trim();
                newUser.Password = txtPassword.Text.Trim();
                listOfUsers.Add(newUser);
                UserSequentialData.Save(listOfUsers);

                txtUser.Text = "";
                txtPassword.Text = "";
                txtConfirm.Text = "";

                MessageBox.Show("User succesfully created\n(All spaces before and after the text have been eliminated.)", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                btnEnter.PerformClick();
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                btnEnter.PerformClick();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                btnEnter.PerformClick();
            }
        }

        private void txtConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                btnEnter.PerformClick();
            }
        }
    }
}
