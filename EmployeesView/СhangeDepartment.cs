using System;
using System.Windows.Forms;

namespace EmployeesView
{
    public partial class СhangeDepartment : Form
    {
        public string NewDepartment;
        public int NewNumberOfSubordinate;
        public СhangeDepartment()
        {
            InitializeComponent();
            NewDepartment = "";
            NewNumberOfSubordinate = 0;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (DepartmentNew.Text == "" || NumberOfSubordinateNew.Text == "")
                MessageBox.Show("Необходимо ввести все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (Convert.ToInt32(NumberOfSubordinateNew.Text) < 0)
                    throw new InvalidOperationException("Ошибка! Данное поле должно быть >= 0");

                NewDepartment = DepartmentNew.Text;
                NewNumberOfSubordinate = Convert.ToInt32(NumberOfSubordinateNew.Text);

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
