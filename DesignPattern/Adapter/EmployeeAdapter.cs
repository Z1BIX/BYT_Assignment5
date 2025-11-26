namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < employeesArray.employeesArray.GetLength(0); i++)
            {
                var emp = new Employee(
                    int.Parse(employeesArray[i, 0]),
                    employeesArray[i, 1],
                    employeesArray[i, 2],
                    int.Parse(employeesArray[i, 3])
                );

                employees.Add(emp);
            }

            thirdPartyBillingSystem.ProcessSalary(employees);
        }
    }
}
