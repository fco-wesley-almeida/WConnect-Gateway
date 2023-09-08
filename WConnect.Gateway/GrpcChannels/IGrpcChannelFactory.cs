using Grpc.Net.Client;

namespace WConnect.Gateway.GrpcChannels;

public interface IGrpcChannelFactory
{
    GrpcChannel Auth();
}