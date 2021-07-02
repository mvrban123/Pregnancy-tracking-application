using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using Npgsql;

namespace PreganancyApp
{
    public partial class LoginForm : Form
    {
        #region Methods
        private int checkIfUserExists()
        {
            var query = $"SELECT id FROM app_user WHERE email='{txtLoginName.Text}' AND password='{txtLoginPass.Text}'";
            int id = Convert.ToInt32(dbConnect.Instance.DohvatiVrijednost(query));
            return id;
        }
        #endregion
        public LoginForm()
        {
            InitializeComponent();
        }
        #region formEvents
        private void lblNewUser_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtLoginName.Text) || String.IsNullOrEmpty(txtLoginPass.Text)))
            {
                int user = checkIfUserExists();
                if (user != 0)
                {
                    //MessageBox.Show("Uspješna prijava!");
                    MainForm mainForm = new MainForm(user);
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nepostojeći korisnik!");
                }
            }
            else
            {
                MessageBox.Show("Nisu popunjena potrebna polja!");
            }
        }
        #endregion
    }
}
