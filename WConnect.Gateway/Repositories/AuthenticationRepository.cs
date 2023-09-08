using Google.Protobuf;
using Grpc.Net.Client;
using WConnect.Gateway.GrpcChannels;
using WConnect.Gateway.Models;
using WConnect.Gateway.Repositories.Interfaces;
using static WConnect.Gateway.SignIn;
using static WConnect.Gateway.SignUp;

namespace WConnect.Gateway.Repositories;

public class AuthenticationRepository: IAuthenticationRepository
{
    private readonly GrpcChannel _channel;

    public AuthenticationRepository(IAuthGrpcChannel authGrpcChannel)
    {
        _channel = authGrpcChannel.GrpcChannel;
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