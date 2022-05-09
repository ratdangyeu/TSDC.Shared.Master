namespace TSDC.Core.Domain.Master
{
    public class User : BaseEntity
    {
        public string Code { get; set; }

        public string UserName { get; set; }

        public byte[]? PasswordHash { get; set; }

        public byte[]? PasswordSalt { get; set; }

        public string Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Email { get; set; }

        public string? Phone { get; set; }

        public int? OrganizationId { get; set; }

        public bool Inactive { get; set; }

        public IList<UserRole>? UserRoles { get; set; }

        public Organization? Organization { get; set; }
    }
}
