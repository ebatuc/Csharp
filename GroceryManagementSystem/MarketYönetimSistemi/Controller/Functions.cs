using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi.Entity
{
    public class Functions
    {
        UserCrud userCrud = new UserCrud();
        ProductCrud productCrud = new ProductCrud();
        CategoryCrud categoryCrud = new CategoryCrud();
        RoleCrud roleCrud = new RoleCrud();

        //Veritabanından bilgileri almak
        public void GetProductListToDgv(DataGridView productDgv)
        {
            productDgv.DataSource = null;
            productDgv.DataSource = productCrud.GetAll();
            productDgv.Columns["Name"].DisplayIndex = 0;
            productDgv.Columns["Description"].DisplayIndex = 1;
            productDgv.Columns["Price"].DisplayIndex = 2;
            productDgv.Columns["Stock"].DisplayIndex = 3;

            productDgv.Columns["Id"].Visible = false;
            productDgv.Columns["CategoryId"].Visible = false;
            productDgv.Columns["IsDelete"].Visible = false;
            productDgv.Columns["Image"].Visible = false;

        }
        public void GetCustomerListToDgv(DataGridView customerDgv)
        {
            customerDgv.DataSource = null;
            customerDgv.DataSource = userCrud.GetAll();
            customerDgv.Columns["Name"].DisplayIndex = 0;

            customerDgv.Columns["IsDelete"].Visible = false;
            customerDgv.Columns["Id"].Visible = false;
            customerDgv.Columns["Role"].Visible = false;
            customerDgv.Columns["Image"].Visible = false;
            customerDgv.Columns["Description"].Visible = false;
            customerDgv.Columns["RoleId"].Visible = false;

        }
        public void GetCategoryListToCb(ComboBox categoryCb)
        {
            categoryCb.DataSource = categoryCrud.GetAll();
            categoryCb.DisplayMember = "Name";
            categoryCb.ValueMember = "Id";
        }
        public void GetRoleToCb(ComboBox roleCb)
        {
            roleCb.DataSource = roleCrud.GetAll();
            roleCb.DisplayMember = "Name";
            roleCb.ValueMember = "Id";
        }


        //Resim seçmek
        public void UploadPictureBoxImage(PictureBox picture)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = ofd.FileName;
            }


        }

        


    }
}
