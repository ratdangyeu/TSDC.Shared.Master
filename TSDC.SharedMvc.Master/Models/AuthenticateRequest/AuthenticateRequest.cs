using FluentValidation;

namespace TSDC.SharedMvc.Master.Models
{
    public class AuthenticateRequest
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }

    public class AuthenticateRequestValidator : AbstractValidator<AuthenticateRequest>
    {
        public AuthenticateRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty()
                .WithMessage("Tên đăng nhập không được để trống");

            RuleFor(x => x.Password).NotEmpty()
                .WithMessage("Mật khẩu không được để trống");
        }
    }
}
