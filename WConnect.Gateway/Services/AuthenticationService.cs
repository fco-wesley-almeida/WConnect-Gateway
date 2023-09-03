using Grpc.Core;
using WConnect.Gateway.Models;
using WConnect.Gateway.Repositories.Interfaces;
using WConnect.Gateway.Services.Interfaces;

namespace WConnect.Gateway.Services;

public class AuthenticationService: IAuthenticationService
{
    private readonly IAuthRepository _authRepository;

    public AuthenticationService(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }

    public async Task<SignUpResponse> SignUpAsync(SignUpRequest request)
    {
        var grpcRequest = request.AsGrpc();
        try
        {
            var response = await _authRepository.SignUpAsync(grpcRequest);
            return new()
            {
                Id = response.Id
            };
        }
        catch (RpcException e)
        {
            throw new BadHttpRequestException(e.Status.Detail, StatusCodes.Status400BadRequest);
        }
    }
}