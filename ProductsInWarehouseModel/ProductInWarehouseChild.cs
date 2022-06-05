using System;

namespace ProductInWarehouseModel
{
    public class ProductInWarehouseChild : ProductInWarehouse
    {
        private int YearOfRelease { get; set; }

        public ProductInWarehouseChild()
        {
            YearOfRelease = 1;
        }

        public ProductInWarehouseChild(string name, double price, int quantity, int yearOfRelease) : base(name, price, quantity)
        {
            YearOfRelease = yearOfRelease;
        }

        public override double Quality()
        {
            return Math.Round(base.Quality() + 0.5 * (2022 - YearOfRelease), 2);
        }

        public override string ShowInformation()
        {
            return base.ShowInformation() + $", \r\nГод выпуска: {YearOfRelease}";
        }
    }
}