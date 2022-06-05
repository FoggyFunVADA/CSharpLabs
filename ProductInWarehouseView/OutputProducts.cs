using System;
using System.Windows.Forms;
using ProductInWarehouseModel;

namespace ProductInWarehouseView
{
    public partial class OutputProducts : Form
    {
        private ProductInWarehouse FirstProduct;
        private ProductInWarehouseChild SecondProduct;
        public OutputProducts(ProductInWarehouse firstProduct, ProductInWarehouseChild secondProduct)
        {
            FirstProduct = firstProduct;
            SecondProduct = secondProduct;
            InitializeComponent();
        }

        private void GetQuality_Click(object sender, EventArgs e)
        {
            FirstQuality.Text = FirstProduct.Quality().ToString();
            SecondQuality.Text = SecondProduct.Quality().ToString();
        }

        private void Output_Click(object sender, EventArgs e)
        {
            FirstInfo.Text = FirstProduct.ShowInformation();
            SecondInfo.Text = SecondProduct.ShowInformation();
        }
    }
}
