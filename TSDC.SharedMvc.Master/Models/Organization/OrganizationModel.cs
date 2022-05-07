using FluentValidation;

namespace TSDC.SharedMvc.Master.Models
{
    public class OrganizationModel : BaseModel
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string? Address { get; set; }

        public string? Description { get; set; }

        public string? ParentId { get; set; }

        public string? Path { get; set; }

        public bool Inactive { get; set; }

        public OrganizationModel()
        {
            Inactive = false;
        }
    }

    public class OrganizationValidator : AbstractValidator<OrganizationModel>
    {
        public OrganizationValidator()
        {
            RuleFor(x => x.Name).NotEmpty()
                .WithMessage("Tên đơn vị không được để trống");
        }
    }
}
