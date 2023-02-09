using JWT_WebAPI.Models;

namespace JWT_WebAPI.Services
{
    public interface IAuthService
    {
        Task<AuthModel> Registerasync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);

        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
