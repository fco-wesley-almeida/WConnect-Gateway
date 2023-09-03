namespace WConnect.Gateway.Repositories.Interfaces;

public interface IAuthRepository
{
    Task<SignUpGrpcResponse> SignUpAsync(SignUpGrpcRequest request);
}