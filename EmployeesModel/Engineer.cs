using System;

namespace EmployeesModel
{
    public abstract class Engineer : IEmployee
    {
        public string FullName { get; set; }
        public double Salary { get; set; }
        public double PercentagePremium { get; set; }
        public int WorkExperience { get; set; }

        public Engineer()
        {
            FullName = "";
            Salary = 0.0;
            PercentagePremium = 0.0;
            WorkExperience = 0;
        }

        public string GetFinalSalary()
        {
            double finalSalary = Math.Round((Salary + Salary * PercentagePremium / 100), 2);
            return $"Итоговая заработная плата: {finalSalary}";
        }

        public string QualityOfExperience()
        {
            if (WorkExperience > 10)
                return "Сотрудник имеет отличный опыт работы";
            else if (WorkExperience > 3)
                return "Сотрудник имеет средний опыт работы";
            else
                return "Сотрудник является практикантом";
        }

        public abstract string ShowInformation();
    }
}