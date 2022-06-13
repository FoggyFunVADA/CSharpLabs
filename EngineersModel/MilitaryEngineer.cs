using System;

namespace EngineersModel
{
    public class MilitaryEngineer : Engineer
    {
        public string NameOfServicedEquipment { get; set; }
        public int ConditionOfServicedEquipment { get; set; }

        public MilitaryEngineer() : base()
        {
            NameOfServicedEquipment = "";
            ConditionOfServicedEquipment = 100;
        }

        public string SupportOfEquipmentDuringCombat(int theoreticalProbabilityOfDamage)
        {
            if (ConditionOfServicedEquipment != 100)
                return "Техника слишком повреждена для боя! Необходимо провести ремонт!";
            Random rnd = new Random();
            int chance = rnd.Next(1, theoreticalProbabilityOfDamage);
            if (chance >= 0.8 * theoreticalProbabilityOfDamage)
            {
                ConditionOfServicedEquipment = 0;
                return "Провал! Не удалось поддержать состояние техники во время боя! Требуется полный ремонт!";
            }
            else if (chance >= 0.5 * theoreticalProbabilityOfDamage)
            {
                ConditionOfServicedEquipment = 50;
                return "Бой прошёл успешно, требуется незначительный ремонт!";
            }
            else
            {
                return "Бой прошёл успешно! Ремонт не требуется!";
            }
        }

        public string RepairEquipment()
        {
            if (ConditionOfServicedEquipment == 100)
                return "Ремонт техники не требуется!";
            if (ConditionOfServicedEquipment == 50)
            {
                ConditionOfServicedEquipment = 100;
                return "Произведён незначительный ремонт техники!";
            }
            else
            {
                ConditionOfServicedEquipment = 100;
                return "Произведён полный ремонт техники!";
            }
        }

        public override string ShowInformation()
        {
            return $"Военный инженер\r\nПолное имя: {FullName}, \r\nОклад: {Salary}, \r\nПремиальный бонус: {PercentagePremium}, \r\nОпыт работы: {WorkExperience}, \r\n" +
                $"Название обслуживаемого оборудования: {NameOfServicedEquipment}, \r\nСостояние обслуживаемой техники: {ConditionOfServicedEquipment}";
        }
    }
}
