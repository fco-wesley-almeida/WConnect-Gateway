using WConnect.Gateway.Models;

namespace WConnect.Gateway.Services.Interfaces;

public interface IAuthenticationService
{
    public Task<SignUpResponse> SignUpAsync(SignUpRequest request);
    public Task<SignInResponse> SignInAsync(SignInRequest request);
}