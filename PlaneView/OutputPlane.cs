using System;
using System.Windows.Forms;
using PlaneModel;

namespace PlaneView
{
    public partial class OutputPlane : Form
    {
        private Plane Plane;
        public OutputPlane(Plane plane)
        {
            InitializeComponent();
            Plane = plane;
        }

        private void SetRoute_Click(object sender, EventArgs e)
        {
            if (Route.Text == "")
                MessageBox.Show("Необходимо ввести маршрут!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Plane.SetRoute(Route.Text);
                MessageBox.Show("Маршрут успешно задан!", "Успех", MessageBoxButtons.OK);
                Route.Text = "";
            }
        }

        private void GetRoute_Click(object sender, EventArgs e)
        {
            string result = Plane.GetRoute();
            if (result == "")
                MessageBox.Show("Маршрут не задан!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Маршрут успешно получен!", "Успех", MessageBoxButtons.OK);
                Route.Text = result;
            }
        }

        private void Fly_Click(object sender, EventArgs e)
        {
            string result = Plane.GetRoute();
            if (result == "")
                MessageBox.Show("Маршрут не задан!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                FlightReport.Text = Plane.Fly();
                MessageBox.Show("Самолёт успешно полетел!", "Успех", MessageBoxButtons.OK);
                Landing.Enabled = true;
            }
        }

        private void Landing_Click(object sender, EventArgs e)
        {
            FlightReport.Text = Plane.Landing();
            MessageBox.Show("Полёт окончен!", "Успех", MessageBoxButtons.OK);
            Landing.Enabled = false;
        }

        private void GetСharacteristic_Click(object sender, EventArgs e)
        {
            Сharacteristic.Text = Plane.ToString();
        }

        private void ReplaceBrand_Click(object sender, EventArgs e)
        {
            if (Brand.Text == "")
                MessageBox.Show("Значение не введено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Plane.Brand = Brand.Text;
                MessageBox.Show("Значение успешно заменено!", "Успех", MessageBoxButtons.OK);
            }
        }

        private void ReplaceLength_Click(object sender, EventArgs e)
        {
            string lengthOfWingTmp = LengthOfWing.Text;
            if (lengthOfWingTmp == "")
                MessageBox.Show("Значение не введено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (Convert.ToDouble(lengthOfWingTmp) <= 0)
                    throw new InvalidOperationException("Ошибка! Все вещественные поля должны быть > 0");
                Plane.Wing.Length = Convert.ToDouble(lengthOfWingTmp);
                MessageBox.Show("Значение успешно заменено!", "Успех", MessageBoxButtons.OK);
            }
        }

        private void ReplaceDiameter_Click(object sender, EventArgs e)
        {
            string wheelDiameterTmp = WheelDiameter.Text;
            if (wheelDiameterTmp == "")
                MessageBox.Show("Значение не введено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (Convert.ToDouble(wheelDiameterTmp) <= 0)
                    throw new InvalidOperationException("Ошибка! Все вещественные поля должны быть > 0");
                Plane.Chassis.WheelDiameter = Convert.ToDouble(wheelDiameterTmp);
                MessageBox.Show("Значение успешно заменено!", "Успех", MessageBoxButtons.OK);
            }
        }

        private void ReplacePower_Click(object sender, EventArgs e)
        {
            string powerOfEngineTmp = PowerOfEngine.Text;
            if (powerOfEngineTmp == "")
                MessageBox.Show("Значение не введено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (Convert.ToDouble(powerOfEngineTmp) <= 0)
                    throw new InvalidOperationException("Ошибка! Все вещественные поля должны быть > 0");
                Plane.Engine.Power = Convert.ToDouble(powerOfEngineTmp);
                MessageBox.Show("Значение успешно заменено!", "Успех", MessageBoxButtons.OK);
            }
        }
    }
}
