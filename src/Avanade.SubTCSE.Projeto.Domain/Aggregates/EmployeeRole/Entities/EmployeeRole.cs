namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities {
    public record EmployeeRole {
        public EmployeeRole(string id, string rolename) {
            Id = id;
            RoleName = rolename;
        }
        public string Id { get; set; }

        public string RoleName { get; init; }
    }
}