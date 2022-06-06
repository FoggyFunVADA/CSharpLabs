namespace EmployeesModel
{
    public interface IEmployee
    {
        string FullName { get; set; }
        string GetFinalSalary();
        string ShowInformation();
    }
}