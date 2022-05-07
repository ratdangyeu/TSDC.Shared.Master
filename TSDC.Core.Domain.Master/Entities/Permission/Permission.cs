namespace TSDC.Core.Domain.Master
{
    public class Permission : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? Route { get; set; }

        public bool Inactive { get; set; }

        public IList<PermissionRole>? PermissionRoles { get; set; }
    }
}
