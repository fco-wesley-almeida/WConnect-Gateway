using Grpc.Net.Client;

namespace WConnect.Gateway.GrpcChannels;

public interface IAuthGrpcChannel
{
    public GrpcChannel GrpcChannel { get; }   
}