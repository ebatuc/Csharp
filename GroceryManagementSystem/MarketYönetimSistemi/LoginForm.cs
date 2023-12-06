using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class LoginForm : Form
    {
        SqlConnection db = new SqlConnection(@"data source=BATUHANC;initial catalog=MarketManageSystem;user id=sa;password=123456789");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {

            db.Open();

            SqlCommand cmd = new SqlCommand("adminLogin", db);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, -1).Value = AdminEmailTxt.Text;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar, -1).Value = AdminPasswordTxt.Text;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show(dr["Name"] + " " + dr["Surname"] + " Hoşgeldin\nAdmin Girişi Yapılmıştır.");
                AdminPanelForm adminPanel = new AdminPanelForm();
                adminPanel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre veya Email");
            }

            db.Close();
        }

        private void UserLoginBtn_Click(object sender, EventArgs e)
        {



            db.Open();

            SqlCommand cmd = new SqlCommand("userLogin", db);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, -1).Value = UserEmailTxt.Text;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar, -1).Value = UserPasswordTxt.Text;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show(dr["Name"] + " " + dr["Surname"] + " Hoşgeldiniz\nMüşteri Girişi Yapılmıştır.");
                CustomerPanelForm customerPanelForm = new CustomerPanelForm();
                customerPanelForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre veya Email");
            }

            db.Close();

        }
    }
}

