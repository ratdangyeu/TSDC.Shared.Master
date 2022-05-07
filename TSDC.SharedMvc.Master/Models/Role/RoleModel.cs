using FluentValidation;

namespace TSDC.SharedMvc.Master.Models
{
    public class RoleModel : BaseModel
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public bool Inactive { get; set; }

        public RoleModel()
        {
            Inactive = false;
        }
    }

    public class RoleValidator : AbstractValidator<RoleModel>
    {
        public RoleValidator()
        {
            RuleFor(x => x.Name).NotEmpty()
                .WithMessage("Tên vai trò không được để trống");
        }
    }
}
