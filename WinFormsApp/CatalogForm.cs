using CatalogApplication;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class CatalogForm : Form
    {
        Catalog catalog = new Catalog();
        public CatalogForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = txtFilePath.Text;
                catalog = DataStore.Load(filePath);
                string filterText = txtFilter.Text;

                if (filterText.Length > 0)
                {
                    dgvCatalog.DataSource = catalog.GetProducts(filterText);
                }
                else
                {
                    dgvCatalog.DataSource = catalog.GetAllProducts();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"File path you provided does not exists or cannot be reached: {txtFilePath.Text}");
            } 
            catch (ArgumentException)
            {
                MessageBox.Show($"File path field cannot be empty.");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show($"File that you provided does not contain any records.");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show($"File path you provided does not exists or cannot be reached: {txtFilePath.Text}");
            }
        }

        private void chAutoSaveTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (chAutoSaveTimer.Checked)
            {
                timerAutoSave.Enabled = true;
                try
                {
                    timerAutoSave.Interval = (int)numTimer.Value;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show($"Specify the time interval for auto saving.");
                }
            }
            else
            {
                timerAutoSave.Enabled = false;
            }
        }

        private void timerAutoSave_Tick(object sender, EventArgs e)
        {
            DataStore.Save(catalog, txtFilePath.Text);
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            using (CreateProductForm newProductForm = new CreateProductForm())
            {
                newProductForm.CreatedProduct += NewProductForm_CreatedProduct;

                if (newProductForm.ShowDialog() == DialogResult.OK)
                {
                }
            }           
        }

        private void NewProductForm_CreatedProduct(object sender, ProductEventArgs e)
        {
            var createdProduct = e.NewProduct;
            catalog.Add(createdProduct);

            dgvCatalog.DataSource = null;
            dgvCatalog.DataSource = catalog.GetAllProducts();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
