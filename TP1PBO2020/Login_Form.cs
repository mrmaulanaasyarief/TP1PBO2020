using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2020
{
    public partial class Login_Form : Form
    {
        Main main;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Please Enter Username", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please Enter Password", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                User user = new User(tbUsername.Text, tbPassword.Text);
                Login login = new Login();
                if (login.auth(user))
                {
                    if(main == null)
                    {
                        main = new Main();
                        main.FormClosed += main_FormClosed;
                    }

                    tbPassword.Clear();
                    main.Show(this);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            main = null;
            Show();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(null,null);
            }
        }
    }
}
