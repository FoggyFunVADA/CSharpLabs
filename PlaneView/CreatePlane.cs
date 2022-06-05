using System;
using System.Windows.Forms;
using PlaneModel;

namespace PlaneView
{
    public partial class CreatePlane : Form
    {
        public CreatePlane()
        {
            InitializeComponent();
        }

        private void PlaneCreate_Click(object sender, EventArgs e)
        {
            string brand = Brand.Text;
            string lengthOfWing = LengthOfWing.Text;
            string wheelDiameter = WheelDiameter.Text;
            string powerOfEngine = PowerOfEngine.Text;

            if (brand == "" || lengthOfWing == "" || wheelDiameter == "" || powerOfEngine == "")
                MessageBox.Show("Необходимо ввести все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (Convert.ToDouble(lengthOfWing) <= 0 || Convert.ToDouble(wheelDiameter) <= 0 || Convert.ToDouble(powerOfEngine) <= 0)
                    throw new InvalidOperationException("Ошибка! Все вещественные поля должны быть > 0");

                Plane plane = new Plane(brand, Convert.ToDouble(lengthOfWing), Convert.ToDouble(wheelDiameter), Convert.ToDouble(powerOfEngine));
                OutputPlane formForOutput = new OutputPlane(plane);
                formForOutput.ShowDialog();
            }
        }
    }
}
