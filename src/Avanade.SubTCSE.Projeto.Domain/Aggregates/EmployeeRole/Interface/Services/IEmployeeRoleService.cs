using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interface.Services {
    public interface IEmployeeRoleService {
        public async Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole);

    }
}
