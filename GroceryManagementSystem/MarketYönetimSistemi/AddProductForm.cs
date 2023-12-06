using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class AddProductForm : Form
    {
        Functions functions = new Functions();
        ProductCrud productCrud = new ProductCrud();

        public AddProductForm()
        {
            InitializeComponent();
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            functions.GetCategoryListToCb(CategoryCb);
        }
        //Form kapanınca ana paneldeki verileri günceller.
        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminPanelForm admin = (AdminPanelForm)Application.OpenForms["AdminPanelForm"];
            admin.LoadAdmin();

        }

        private void ProductSelectImgBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(ProductPb);
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {

            Product product = new Product
            {
                Name = NameProductTxt.Text,
                Description = DescProductTxt.Text,
                Price = (int)PriceProductNb.Value,
                Stock = (int)StockProductNb.Value,
                IsStatus = ProductStatusCb.Checked,
                CategoryId = Convert.ToInt32(CategoryCb.SelectedValue)
            };

            string ProductImage = "";
            string imagePath = @"C:\Users\ebatu\Desktop\Resimler\";
            string defaultImage = "emptyProduct.jpg";

            if (ProductPb.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                ProductPb.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                ProductImage = imagePath + imageName;
            }
            else
            {
                ProductImage = imagePath + defaultImage;
            }
            product.Image = ProductImage;


            //Alanları ekleme sonrası boşaltıyor.
            NameProductTxt.Clear();
            DescProductTxt.Clear();
            PriceProductNb.Value = 0;
            StockProductNb.Value = 0;
            ProductStatusCb.Checked = false;
            ProductPb.Image = null;

            //Ürün ekleme bildirimi
            bool addProductResult = productCrud.Add(product);

            if (addProductResult)
            {
                MessageBox.Show("Product has been added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Product could not added", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CategoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
