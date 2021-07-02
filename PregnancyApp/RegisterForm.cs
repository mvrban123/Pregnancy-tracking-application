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
using System.Data.SqlClient;
using Npgsql;

namespace PreganancyApp
{
    public partial class RegisterForm : Form
    {
        #region Methods
        private int checkEmail()
        {
            int id = 0;
            var query = $"SELECT * FROM app_user WHERE email='{txtImeKor.Text}'";
            NpgsqlDataReader dr = dbConnect.Instance.DohvatiDataReader(query);
            while (dr.Read())
            {
               id = int.Parse(dr["id"].ToString());
            }
            dr.Close();
            return id;
            
        }
        private int registerUser()
        {
            if(!(String.IsNullOrEmpty(txtImeKor.Text) && String.IsNullOrEmpty(txtRegPass.Text) && String.IsNullOrEmpty(txtRegPass2.Text) && String.IsNullOrEmpty(txtRegEmail.Text))){
                if (txtRegPass.Text == txtRegPass2.Text)
                {
                    if (checkEmail() == 0)
                    {
                        int userID = GetUserNextVal();
                        //int pregnancyID=

                        var query = $"INSERT INTO app_user(id,name,email,password) VALUES('{userID}','{txtImeKor.Text}','{txtRegEmail.Text}','{txtRegPass.Text}')";
                        dbConnect.Instance.IzvrsiUpit(query);

                        query=$"INSERT INTO pregnancy(baby_name, due_date, user_id_fk) VALUES('', '{dtpTerminPoroda.Value}', {userID})";
                        return dbConnect.Instance.IzvrsiUpit(query);
                    }
                    else
                    {
                        MessageBox.Show("Email je zauzeti!");
                        return 0;
                    }
                }
                else
                {
                    MessageBox.Show("Lozinke se ne poklapaju!");
                    return 0;
                }
            }
            else
            {
                MessageBox.Show("Potrebno se popuniti sva polja!");
                return 0;
            }

        }
        public RegisterForm()
        {
            InitializeComponent();
            SetDateRestriction();
            txtRegEmail.Focus();
        }

        private void btnRegSubmit_Click(object sender, EventArgs e)
        {
            int user = registerUser();
            if (user==1)
            {
                /*
                MessageBox.Show("Uspješna registracija!");
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();*/
                //MessageBox.Show("Uspješna prijava!");
                MainForm mainForm = new MainForm(user);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
        }

        private void SetDateRestriction()
        {
            var currentDate = DateTime.Today;
            dtpTerminPoroda.MaxDate = currentDate.AddMonths(9).AddDays(7);
            dtpTerminPoroda.MinDate = currentDate.AddMonths(-9);
        }

        private int GetUserNextVal()
        {
            var nextVal=0;
            var query = "Select nextval(pg_get_serial_sequence('app_user', 'id')) as new_id;";
            NpgsqlDataReader dr = dbConnect.Instance.DohvatiDataReader(query);
            while (dr.Read())
            {
                nextVal = int.Parse(dr["new_id"].ToString());
            }
            dr.Close();
            return nextVal;
        }

        /*private int GetPregnancyNextVal()
        {
            var nextVal = 0;
            var query = "Select nextval(pg_get_serial_sequence('pregnancy', 'id')) as new_id;";
            NpgsqlDataReader dr = dbConnect.Instance.DohvatiDataReader(query);
            while (dr.Read())
            {
                nextVal = int.Parse(dr["id"].ToString());
            }
            dr.Close();
            return nextVal;
        }*/
        #endregion
    }
}
