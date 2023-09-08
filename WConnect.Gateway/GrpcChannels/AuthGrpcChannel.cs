using Grpc.Net.Client;

namespace WConnect.Gateway.GrpcChannels;

public class AuthGrpcChannel: IAuthGrpcChannel
{
    public GrpcChannel GrpcChannel { get; }

    public AuthGrpcChannel(IGrpcChannelFactory grpcChannelFactory)
    {
        GrpcChannel = grpcChannelFactory.Auth();
    }
}