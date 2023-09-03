using Grpc.Net.Client;

namespace WConnect.Gateway;

public class GrpcChannelFactory
{
    public GrpcChannel Auth()
    {
        return GrpcChannel.ForAddress("http://localhost:5000");
    }
}