using System;

namespace ProductInWarehouseModel
{
    public class ProductInWarehouse
    {
        private string Name { get; set; }
        private double Price { get; set; }
        private int Quantity { get; set; }

        public ProductInWarehouse()
        {
            Name = "";
            Price = 0.0;
            Quantity = 0;
        }

        public ProductInWarehouse(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public virtual double Quality()
        {
            return Math.Round(Price / (double)Quantity, 2);
        }

        public virtual string ShowInformation()
        {
            return $"Информация о товаре:\r\nНаименование: {Name}, \r\nЦена: {Price}, \r\nКоличество: {Quantity}";
        }
    }
}