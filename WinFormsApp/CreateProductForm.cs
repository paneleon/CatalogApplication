using CatalogApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class CreateProductForm : Form
    {
        public event EventHandler<ProductEventArgs> CreatedProduct;
        public CreateProductForm()
        {
            InitializeComponent(); 
        }

        private void CreateProductForm_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = Enum.GetValues(typeof(Department));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                Name = txtName.Text,
                Department = (Department)cbCategory.SelectedItem,
                Price = numPrice.Value
            };

            CreatedProduct.Invoke(this, new ProductEventArgs(newProduct));
        } 
    }
}
