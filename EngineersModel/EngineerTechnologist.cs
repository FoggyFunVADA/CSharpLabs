using System;

namespace EngineersModel
{
    public class EngineerTechnologist : Engineer
    {
        public string NameOfSpecialization { get; set; }
        public string NameOfProductionProcess { get; set; }

        public EngineerTechnologist() : base()
        {
            NameOfSpecialization = "";
            NameOfProductionProcess = "";
        }

        public string CheckSpecialization()
        {
            if (NameOfProductionProcess != NameOfSpecialization)
                return "Инженер работает не по своей специальности, требуется перевод на другой процесс!";
            return "Инженер работает по специальности, перевод не требуется!";
        }

        public string CheckProduction(int theoreticalProbabilityOfAccident)
        {
            Random rnd = new Random();
            int chance = rnd.Next(1, theoreticalProbabilityOfAccident);
            if (chance >= 0.5 * theoreticalProbabilityOfAccident)
                return "Производство идёт без происшествий! План производства будет выполнен вовремя!";
            return "Производство идёт медленно! Требуются корректировки плана, устранение неполадок!";
        }

        public override string ShowInformation()
        {
            return $"Инженер-технолог\r\nПолное имя: {FullName}, \r\nОклад: {Salary}, \r\nПремиальный бонус: {PercentagePremium}, \r\nОпыт работы: {WorkExperience}, \r\n" +
                 $"Специализация технолога: {NameOfSpecialization}, \r\nНазвание производственного процесса, с которым связан инженер: {NameOfProductionProcess}";
        }
    }
}
