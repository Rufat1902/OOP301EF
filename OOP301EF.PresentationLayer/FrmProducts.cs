using OOP301EF.BusinessLayer.Abstract;
using OOP301EF.BusinessLayer.Concrete;
using OOP301EF.DataAccessLayer.Repositories;
using OOP301EF.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP301EF.PresentationLayer
{
    public partial class FrmProducts : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProducts()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductDal());
            _categoryService = new CategoryManager(new EFCategoryDal());
        }

        
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductWithCategory();
            dataGridView1 .DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var deletedValue = _productService.TGetById(id);
            _productService.TDelete(deletedValue);
            MessageBox.Show("The product has been deleted");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.ProductDescription = txtProductDescription.Text;
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);
            product.ProductStock = int.Parse(txtProductStock.Text);
            product.CategoryId = int.Parse(cmbCategoryName.Text);
            _productService.TInsert(product);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var updatedValue = _productService.TGetById(id);
            updatedValue.ProductName = txtProductName.Text;
            updatedValue.ProductDescription = txtProductDescription.Text;
            updatedValue.ProductPrice = decimal.Parse(txtProductPrice.Text);
            updatedValue.CategoryId = int.Parse(cmbCategoryName.Text);
            updatedValue.ProductStock = int.Parse(txtProductStock.Text);
            _productService.TUpdate(updatedValue);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            dataGridView1.DataSource = value;
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbCategoryName.DataSource = values;
            cmbCategoryName.DisplayMember = "CategoryName";
            cmbCategoryName.ValueMember = "CategoryId";
        }
    }
}
