using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class AdminPanelForm : Form
    {
        Functions functions = new Functions();
        ProductCrud productCrud = new ProductCrud();
        UserCrud userCrud = new UserCrud();
        public static int productId = 0;
        public static int userId = 0;
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadAdmin();
        }

        

        public void LoadAdmin()
        {
            
            functions.GetCustomerListToDgv(CustomerDgv);

            functions.GetProductListToDgv(ProductDgv);
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        //Ürün silmek
        private void ProductDeleteBtn_Click(object sender, EventArgs e)
        {
            if (ProductDgv.SelectedRows.Count > 0)
            {
                int selectedProductId = (int)ProductDgv.SelectedRows[0].Cells["Id"].Value;
                bool UpdatedInDatabase = productCrud.UpdateIsDelete(selectedProductId);

                if (UpdatedInDatabase)
                {
                    MessageBox.Show("Product has been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdmin();
                }
                else
                {
                    MessageBox.Show("Product could not be deleted.", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ProductEditBtn_Click(object sender, EventArgs e)
        {
            productId = Convert.ToInt32(ProductDgv.CurrentRow.Cells["Id"].Value);
            EditProductForm editProductForm = new EditProductForm();
            editProductForm.Show();

        }

        private void CustomerAddBtn_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }

        //Müşteri silmek
        private void CustomerDeleteBtn_Click(object sender, EventArgs e)
        {
            if (CustomerDgv.SelectedRows.Count > 0)
            {
                int selectedCustomerId = (int)CustomerDgv.SelectedRows[0].Cells["Id"].Value;
                bool UpdatedInDatabase = userCrud.UpdateIsDelete(selectedCustomerId);

                if (UpdatedInDatabase)
                {
                    MessageBox.Show("Customer has been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdmin();
                }
                else
                {
                    MessageBox.Show("Customer could not be deleted.", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CustomerEditBtn_Click(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(CustomerDgv.CurrentRow.Cells["Id"].Value);
            EditCustomerForm editCustomerForm = new EditCustomerForm(); 
            editCustomerForm.ShowDialog();
        }

        private void ProductDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
