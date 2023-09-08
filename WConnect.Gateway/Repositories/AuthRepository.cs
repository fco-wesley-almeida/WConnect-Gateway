using Google.Protobuf;
using Grpc.Net.Client;
using WConnect.Gateway.Models;
using WConnect.Gateway.Repositories.Interfaces;
using static WConnect.Gateway.SignIn;
using static WConnect.Gateway.SignUp;

namespace WConnect.Gateway.Repositories;

public class AuthRepository: IAuthRepository
{
    private readonly GrpcChannel _channel;

    public AuthRepository(GrpcChannel channel)
    {
        _channel = channel;
    }

    public async Task<SignUpGrpcResponse> SignUpAsync(SignUpGrpcRequest request)
    {
        var client = new SignUpClient(_channel);
        return await client.SignUpAsync(request);
    }
    
    public async Task<SignInGrpcResponse> SignInAsync(SignInGrpcRequest request)
    {
        var client = new SignInClient(_channel);
        return await client.SignInAsync(request);
    }
}