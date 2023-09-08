using Grpc.Core;
using WConnect.Gateway.Models;
using WConnect.Gateway.Repositories.Interfaces;
using WConnect.Gateway.Services.Interfaces;

namespace WConnect.Gateway.Services;

public class AuthenticationService: IAuthenticationService
{
    private readonly IAuthenticationRepository _authenticationRepository;

    public AuthenticationService(IAuthenticationRepository authenticationRepository)
    {
        _authenticationRepository = authenticationRepository;
    }

    public async Task<SignUpResponse> SignUpAsync(SignUpRequest request)
    {
        var grpcRequest = request.AsGrpc();
        try
        {
            var response = await _authenticationRepository.SignUpAsync(grpcRequest);
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

    public async Task<SignInResponse> SignInAsync(SignInRequest request)
    {
        var grpcRequest = request.AsGrpc();
        try
        {
            var response = await _authenticationRepository.SignInAsync(grpcRequest);
            return new(response);
        }
        catch (RpcException e)
        {
            throw new BadHttpRequestException(e.Status.Detail, StatusCodes.Status401Unauthorized);
        }
    }
}