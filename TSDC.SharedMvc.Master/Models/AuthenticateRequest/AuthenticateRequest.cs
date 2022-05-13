using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace TSDC.SharedMvc.Master.Models
{
    public class AuthenticateRequest
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public string? ReturnUrl { get; set; }

        public AuthenticateRequest()
        {
            RememberMe = false;
        }
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
