using Grpc.Net.Client;
using WConnect.Gateway.GrpcChannels;

namespace WConnect.Gateway;

public class GrpcChannelFactory: IGrpcChannelFactory
{
    private readonly IConfiguration _configuration;

    public GrpcChannelFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public GrpcChannel Auth()
    {
        return GrpcChannel.ForAddress(_configuration["Infra:AuthBaseUrl"]);
    }
}