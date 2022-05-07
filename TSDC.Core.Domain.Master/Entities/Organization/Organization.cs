namespace TSDC.Core.Domain.Master
{
    public class Organization : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string? Address { get; set; }

        public string? Description { get; set; }

        public string? ParentId { get; set; }

        public string? Path { get; set; }

        public bool Inactive { get; set; }

        public IList<User>? Users { get; set; }
    }
}
