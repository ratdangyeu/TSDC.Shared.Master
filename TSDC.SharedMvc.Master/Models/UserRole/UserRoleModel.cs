using FluentValidation;

namespace TSDC.SharedMvc.Master.Models
{
    public class UserRoleModel : BaseModel
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public UserRoleModel()
        {

        }
    }

    public class UserRoleValidator : AbstractValidator<UserRoleModel>
    {
        public UserRoleValidator()
        {
            RuleFor(x => x.UserId).NotEmpty()
                .WithMessage("Chưa chọn người dùng");

            RuleFor(x => x.RoleId).NotEmpty()
                .WithMessage("Chưa chọn vai trò");
        }
    }
}
