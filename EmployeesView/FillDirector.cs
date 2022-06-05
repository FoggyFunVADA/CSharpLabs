using System;
using System.Windows.Forms;
using EmployeesModel;

namespace EmployeesView
{
    public partial class FillDirector : Form
    {
        public Director DirectorTmp;
        public FillDirector()
        {
            InitializeComponent();
            DirectorTmp = new Director();
        }

        private void AddOrChange_Click(object sender, EventArgs e)
        {
            string fullName = FullName.Text;
            string salary = Salary.Text;
            string percentagePremium = PercentagePremium.Text;
            string workExperience = WorkExperience.Text;
            string departmentName = DepartmentName.Text;
            string numberOfSubordinate = NumberOfSubordinate.Text;

            if (fullName == "" || salary == "" || percentagePremium == "" || workExperience == "" || departmentName == "" || numberOfSubordinate == "")
                MessageBox.Show("Необходимо ввести все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (Convert.ToDouble(salary) < 0 || Convert.ToDouble(percentagePremium) < 0 || Convert.ToInt32(workExperience) < 0
                    || Convert.ToInt32(numberOfSubordinate) < 0)
                    throw new InvalidOperationException("Ошибка! Все вещественные поля должны быть >= 0");

                DirectorTmp.FullName = fullName;
                DirectorTmp.Salary = Convert.ToDouble(salary);
                DirectorTmp.PercentagePremium = Convert.ToDouble(percentagePremium);
                DirectorTmp.WorkExperience = Convert.ToInt32(workExperience);
                DirectorTmp.DepartmentName = departmentName;
                DirectorTmp.NumberOfSubordinateEmployees = Convert.ToInt32(numberOfSubordinate);

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
