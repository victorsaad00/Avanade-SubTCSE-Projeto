using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Services {
    public interface IEmployeeService {
        Task<Entities.EmployeeRole> AddEmployee(Entities.EmployeeRole employee);
    }
}
