using FluentValidation;

namespace TSDC.SharedMvc.Master.Models
{
    public class PermissionRoleModel : BaseModel
    {
        public int PermissionId { get; set; }

        public int RoleId { get; set; }

        public PermissionRoleModel()
        {

        }
    }

    public class PermissionRoleValidator : AbstractValidator<PermissionRoleModel>
    {
        public PermissionRoleValidator()
        {
            RuleFor(x => x.RoleId).NotEmpty()
                .WithMessage("Chưa chọn vai trò");

            RuleFor(x => x.PermissionId).NotEmpty()
                .WithMessage("Chưa chọn quyền");
        }
    }
}
