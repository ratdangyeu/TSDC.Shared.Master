using FluentValidation;

namespace TSDC.SharedMvc.Master.Models
{
    public class UserModel : BaseModel
    {
        public string Code { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Email { get; set; }

        public string? Phone { get; set; }

        public int? OrganizationId { get; set; }

        public bool Inactive { get; set; }

        public UserModel()
        {
            Inactive = false;
        }
    }

    public class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty()
                .WithMessage("Tên đăng nhập không được để trống");

            RuleFor(x => x.Email).NotEmpty()
                .WithMessage("Địa chỉ hòm thư không được để trống");

            RuleFor(x => x.Password).NotEmpty()
                .WithMessage("Mật khẩu không được để trống");
        }
    }
}
