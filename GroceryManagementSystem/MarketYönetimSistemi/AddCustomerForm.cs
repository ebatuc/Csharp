using MarketYönetimSistemi.Entity.Interface;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketYönetimSistemi.Controller;
using System.Drawing.Imaging;

namespace MarketYönetimSistemi
{
    public partial class AddCustomerForm : Form
    {
        Functions functions = new Functions();
        UserCrud userCrud = new UserCrud();
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            
        }
        private void CustomerSelectImgBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(CustomerPb);
        }
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = CustomerNameTxt.Text,
                Surname = CustomerSurnameTxt.Text,
                Description = CustomerDescTxt.Text,
                Email = CustomerEmailTxt.Text,
                Password = CustomerPasswordTxt.Text,
                IsStatus = CustomerStatusCb.Checked,
                RoleId = 3
            };
            string UserImage = "";
            string imagePath = @"C:\Users\ebatu\Desktop\Resimler\";
            string defaultImage = "defCus.jpg";

            if (CustomerPb.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                CustomerPb.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                UserImage = imagePath + imageName;
            }
            else
            {
                UserImage = imagePath + defaultImage;
            }
            user.Image = UserImage;


            //Alanları ekleme sonrası boşaltıyor.
            CustomerNameTxt.Clear();
            CustomerSurnameTxt.Clear();
            CustomerDescTxt.Clear();
            CustomerEmailTxt.Clear();
            CustomerPasswordTxt.Clear();
            CustomerStatusCb.Checked = false;
            CustomerPb.Image = null;

            //Müşteri ekleme bildirimi
            bool addUser = userCrud.Add(user);

            if (addUser)
            {
                MessageBox.Show("Customer has been added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Customer could not added", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminPanelForm admin = (AdminPanelForm)Application.OpenForms["AdminPanelForm"];
            admin.LoadAdmin();
        }
    }
}
