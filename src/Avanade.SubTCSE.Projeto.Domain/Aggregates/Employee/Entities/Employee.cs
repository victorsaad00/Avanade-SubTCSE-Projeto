using System;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Entities {
    public record EmployeeRole : BaseEntity<string> {
        public EmployeeRole(
            string firstName, 
            string surName, 
            DateTime birthday, 
            bool active, 
            decimal salary, 
            int myProperty,
            Aggregates.EmployeeRole.Entities.EmployeeRole employeeRole) 
        {
            FirstName = firstName;
            SurName = surName;
            Birthday = birthday;
            Active = active;
            Salary = salary;
            MyProperty = myProperty;
            EmployeeRole = employeeRole;
        }

        public string FirstName { get; init; }
        public string SurName { get; init; }
        public DateTime Birthday { get; init; }

        public bool Active { get; init; }
        public decimal Salary { get; init; }
        public int MyProperty { get; init; }
        public Aggregates.EmployeeRole.Entities.EmployeeRole EmployeeRole { get; init; }
    }
}
