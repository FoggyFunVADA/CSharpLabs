namespace EmployeesModel
{
    public class Director : Engineer
    {
        public string DepartmentName { get; set; }
        public int NumberOfSubordinateEmployees { get; set; }

        public Director() : base()
        {
            DepartmentName = "";
            NumberOfSubordinateEmployees = 0;
        }

        public void ChangeDepartment(string newDepartment, int newNumberOfSubordinateEmployees)
        {
            DepartmentName = newDepartment;
            NumberOfSubordinateEmployees = newNumberOfSubordinateEmployees;
        }

        public bool GetBonusForLargeNumberOfEmployees()
        {
            if (NumberOfSubordinateEmployees > 50)
            {
                Salary += 10000;
                return true;
            }
            return false;
        }

        public override string ShowInformation() // Для MessageBox
        {
            return $"Полное имя: {FullName}, \r\nОклад: {Salary}, \r\nПремиальный бонус: {PercentagePremium}, \r\nОпыт работы: {WorkExperience}, \r\n" +
                $"Название отдела управления: {DepartmentName}, \r\nКоличество подчинённых: {NumberOfSubordinateEmployees}";
        }

        public override string ToString() // Для ListBox
        {
            return $"Полное имя: {FullName}, Оклад: {Salary}, Премиальный бонус: {PercentagePremium}, Опыт работы: {WorkExperience}, " +
                $"Название отдела управления: {DepartmentName}, Количество подчинённых: {NumberOfSubordinateEmployees};";
        }
    }
}
