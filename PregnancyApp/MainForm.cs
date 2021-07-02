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
    public partial class MainForm : Form
    {
        private int loggedInUser;
        private int pregnancyDurationInWeeksOfCurrentUser;
        private int pregnancyWeek=0;
        #region Methods

        private void BeforeSelectUpdatePregnancyWeek()
        {
            var query = $@"select TRUNC(DATE_PART('day', NOW() - (p.due_date - interval '9months'))/7) as week
                        from pregnancy p where p.user_id_fk = '{loggedInUser}'";
            NpgsqlDataReader dr = dbConnect.Instance.DohvatiDataReader(query);
            while (dr.Read())
            {
                pregnancyDurationInWeeksOfCurrentUser = int.Parse(dr["week"].ToString());
           
            }
            dr.Close();
            query = $@"update pregnancy set pregnancy_status_fk='{pregnancyDurationInWeeksOfCurrentUser}' where user_id_fk='{loggedInUser}'";
            dbConnect.Instance.IzvrsiUpit(query);
        }

        private void GetPregnancyData()
        {
            var query = $@"select p.due_date,p.pregnancy_status_fk from pregnancy p 
                        where p.user_id_fk='{loggedInUser}'";
            NpgsqlDataReader dr = dbConnect.Instance.DohvatiDataReader(query);
            while (dr.Read())
            {
                lblDueDate.Text = DateTime.Parse(dr["due_date"].ToString()).ToString("dd/MM/yyyy");
                lblPregnancyWeek.Text = dr["pregnancy_status_fk"].ToString() + " tjedan trudnoće";
                pregnancyWeek = int.Parse(dr["pregnancy_status_fk"].ToString());
                lblDaysTillDueDate.Text = (280 - (int.Parse(dr["pregnancy_status_fk"].ToString()) * 7)).ToString()+" dana do poroda";
            }
            dr.Close();
            GetPregnancyStatusData();
        }

        private void GetPregnancyStatusData()
        {
            var query = $@"select * from pregnancy_status where id='{pregnancyWeek}'";
            NpgsqlDataReader dr = dbConnect.Instance.DohvatiDataReader(query);
            while (dr.Read())
            {
                lblbabySize.Text = dr["baby_status"].ToString();
                lblMotherCondition.Text = dr["mother_status"].ToString().Replace("/", "\r\n");
            }
            dr.Close();
            pregnancyWeek1.Text = pregnancyWeek.ToString() + ". tjedan";
        }

        #endregion
        public MainForm(int id)
        {
            InitializeComponent();
            loggedInUser = id;
            BeforeSelectUpdatePregnancyWeek();
            GetPregnancyData();
        }
        #region FormEvents
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pregnancyWeek--;
            GetPregnancyStatusData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pregnancyWeek++;
            GetPregnancyStatusData();
        }
        #endregion
    }
}
