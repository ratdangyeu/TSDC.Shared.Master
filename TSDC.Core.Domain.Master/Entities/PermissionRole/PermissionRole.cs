namespace TSDC.Core.Domain.Master
{
    public class PermissionRole : BaseEntity
    {
        public int PermissionId { get; set; }

        public int RoleId { get; set; }

        public Permission? Permission { get; set; }

        public Role? Role { get; set; }
    }
}
