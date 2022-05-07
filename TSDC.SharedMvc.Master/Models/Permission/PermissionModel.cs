using FluentValidation;

namespace TSDC.SharedMvc.Master.Models
{
    public class PermissionModel : BaseModel
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? Route { get; set; }

        public bool Inactive { get; set; }

        public PermissionModel()
        {
            Inactive = false;
        }
    }

    public class PermissionValidator : AbstractValidator<PermissionModel>
    {
        public PermissionValidator()
        {
            RuleFor(x => x.Name).NotEmpty()
                .WithMessage("Tên quyền không được để trống");
        }
    }
}
