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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class EditProductForm : Form
    {
        Functions functions = new Functions();
        ProductCrud productCrud = new ProductCrud();
        CategoryCrud categoryCrud = new CategoryCrud();
        public EditProductForm()
        {
            InitializeComponent();
        }


        //Ürün Düzenleme
        private void EditProductModalBtn_Click(object sender, EventArgs e)
        {
            int editProductId = AdminPanelForm.productId;
            Product UpdatedProduct = new Product
            {
                Id = editProductId,
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
            UpdatedProduct.Image = ProductImage;


            //Alanları ekleme sonrası boşaltıyor.
           

            //Ürün ekleme bildirimi ve ürünü eklerken kullanılan crud işlemi

            bool addProductResult = productCrud.Update(UpdatedProduct, editProductId);

            if (addProductResult)
            {
                MessageBox.Show("Product has been updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminPanelForm admin = (AdminPanelForm)Application.OpenForms["AdminPanelForm"];
                admin.Close();
                AdminPanelForm admin1 = new AdminPanelForm();
                admin1.Show();


            }
            else
            {
                MessageBox.Show("Product could not be updated", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Seçilen satırdaki ürün bilgilerini forma aktarıyor.
        private void EditProductForm_Load(object sender, EventArgs e)
        {
            functions.GetCategoryListToCb(CategoryCb);
            //adminpanelde selected row ile id si alınnan ürünler
            //productCrud da tanımlanan get by ıd ile idye ilgili ürün geliyor.
            int editProductId = AdminPanelForm.productId;
            var editProduct = productCrud.GetById(editProductId);
            var categoryId=editProduct.CategoryId;

            NameProductTxt.Text += editProduct.Name;
            DescProductTxt.Text += editProduct.Description;
            PriceProductNb.Value += (int)editProduct.Price;
            StockProductNb.Value += editProduct.Stock;
            CategoryCb.SelectedValue = categoryId;
            ProductStatusCb.Checked = editProduct.IsStatus;
            ProductPb.ImageLocation = editProduct.Image;

        }

        private void ProductSelectImgBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(ProductPb);
        }

        private void EditProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }
    }
}
