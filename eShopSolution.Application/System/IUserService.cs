using eShopSolution.ViewModels.System;
using System.Threading.Tasks;

namespace eShopSolution.Application.System
{
    public interface IUserService
    {
        Task<bool> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
    }
}
