using System;
using System.Windows.Forms;
using ProductInWarehouseModel;

namespace ProductInWarehouseView
{
    public partial class CreateProducts : Form
    {
        public CreateProducts()
        {
            InitializeComponent();
        }

        private void CreateProductsButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstName.Text, secondName = SecondName.Text;
            string firstPrice = FirstPrice.Text, secondPrice = SecondPrice.Text;
            string firstQuantity = FirstQuantity.Text, secondQuantity = SecondQuantity.Text;
            string secondYearOfRelease = SecondYearOfRelease.Text;

            if (firstName == "" || secondName == "" || firstPrice == "" || secondPrice == "" || firstQuantity == "" 
                || secondQuantity == "" || secondYearOfRelease == "")
                MessageBox.Show("Необходимо ввести все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (Convert.ToInt32(firstQuantity) <= 0 || Convert.ToInt32(secondQuantity) <= 0)
                    throw new InvalidOperationException("Ошибка! Чтобы вычислить качество, количество товара должно быть > 0");

                if (Convert.ToInt32(secondYearOfRelease) < 1 || Convert.ToInt32(secondYearOfRelease) > 2022)
                    throw new InvalidOperationException("Ошибка! Значение года выпуска товара должно быть >= 1 и <= 2022!");

                ProductInWarehouse firstProduct = new ProductInWarehouse(firstName, Convert.ToDouble(firstPrice), Convert.ToInt32(firstQuantity));

                ProductInWarehouseChild secondProduct = new ProductInWarehouseChild(secondName, Convert.ToDouble(secondPrice),
                    Convert.ToInt32(secondQuantity), Convert.ToInt32(secondYearOfRelease));

                OutputProducts formForOutput = new OutputProducts(firstProduct, secondProduct);
                formForOutput.ShowDialog();
            }
        }
    }
}
