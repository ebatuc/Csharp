using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class CustomerPanelForm : Form
    {
        Functions functions = new Functions();
        ProductCrud productCrud = new ProductCrud();
        public CustomerPanelForm()
        {
            InitializeComponent();
        }

        private void CustomerPanelForm_Load(object sender, EventArgs e)
        {
            functions.GetProductListToDgv(ProductDgv);
        }
    }
}
