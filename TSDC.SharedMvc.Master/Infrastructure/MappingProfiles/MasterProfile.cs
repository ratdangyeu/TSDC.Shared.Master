using AutoMapper;
using TSDC.Core.Domain.Master;
using TSDC.SharedMvc.Master.Models;

namespace TSDC.SharedMvc.Master.Infrastructure
{
    public class MasterProfile : Profile
    {
        public MasterProfile()
        {
            #region Organization
            CreateMap<Organization, OrganizationModel>();
            CreateMap<OrganizationModel, Organization>()
                .ForMember(x => x.Users, opt => opt.Ignore());
            #endregion

            #region Permission
            CreateMap<Permission, PermissionModel>();
            CreateMap<PermissionModel, Permission>()
                .ForMember(x => x.PermissionRoles, opt => opt.Ignore());
            #endregion

            #region PermissionRole
            CreateMap<PermissionRole, PermissionRoleModel>();
            CreateMap<PermissionRoleModel, PermissionRole>()
                .ForMember(x => x.Role, opt => opt.Ignore())
                .ForMember(x => x.Permission, opt => opt.Ignore());
            #endregion

            #region Role
            CreateMap<Role, RoleModel>();
            CreateMap<RoleModel, Role>()
                .ForMember(x => x.UserRoles, opt => opt.Ignore())
                .ForMember(x => x.PermissionRoles, opt => opt.Ignore());
            #endregion

            #region User
            CreateMap<User, UserModel>()
                .ForMember(x => x.Password, opt => opt.Ignore());
            CreateMap<UserModel, User>()
                .ForMember(x => x.UserRoles, opt => opt.Ignore())
                .ForMember(x => x.Organization, opt => opt.Ignore())
                .ForMember(x => x.PasswordHash, opt => opt.Ignore())
                .ForMember(x => x.PasswordSalt, opt => opt.Ignore());
            #endregion

            #region UserRole
            CreateMap<UserRole, UserRoleModel>();
            CreateMap<UserRoleModel, UserRole>()
                .ForMember(x => x.Role, opt => opt.Ignore())
                .ForMember(x => x.User, opt => opt.Ignore());
            #endregion
        }
    }
}
