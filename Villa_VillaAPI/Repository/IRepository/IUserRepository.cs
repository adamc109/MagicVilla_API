using MagicVilla_Web.Models.DTO;
using Villa_VillaAPI.Models;
using Villa_VillaAPI.Models.DTO;

namespace Villa_VillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
