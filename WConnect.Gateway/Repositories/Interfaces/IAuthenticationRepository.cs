namespace WConnect.Gateway.Repositories.Interfaces;

public interface IAuthenticationRepository
{
    Task<SignUpGrpcResponse> SignUpAsync(SignUpGrpcRequest request);
    Task<SignInGrpcResponse> SignInAsync(SignInGrpcRequest request);
}