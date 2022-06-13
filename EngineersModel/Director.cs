namespace EngineersModel
{
    public class Director : Engineer
    {
        public int DepartmentNumber { get; set; }
        public int NumberOfSubordinateEmployees { get; set; }

        public Director() : base()
        {
            DepartmentNumber = 0;
            NumberOfSubordinateEmployees = 0;
        }

        public void ChangeDepartment(int newDepartment, int newNumberOfSubordinateEmployees)
        {
            DepartmentNumber = newDepartment;
            NumberOfSubordinateEmployees = newNumberOfSubordinateEmployees;
        }

        public void HirePeople(int count)
        {
            NumberOfSubordinateEmployees += count;
        }

        public string GetBonusForLargeNumberOfEmployees()
        {
            if (NumberOfSubordinateEmployees > 50)
            {
                Salary += 10000;
                return "Бонус за большое количество сотрудников успешно получен!";
            }
            return "Неудача! Слишком мало сотрудников для бонуса!";
        }

        public override string ShowInformation()
        {
            return $"Управляющий инженер\r\nПолное имя: {FullName}, \r\nОклад: {Salary}, \r\nПремиальный бонус: {PercentagePremium}, \r\nОпыт работы: {WorkExperience}, \r\n" +
                $"Название отдела управления: {DepartmentNumber}, \r\nКоличество подчинённых: {NumberOfSubordinateEmployees}";
        }
    }
}
