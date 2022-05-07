namespace TSDC.Core.Domain.Master
{
    public class Role : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public bool Inactive { get; set; }

        public IList<PermissionRole>? PermissionRoles { get; set; }

        public IList<UserRole>? UserRoles { get; set; }
    }
}
