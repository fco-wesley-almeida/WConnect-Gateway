using Grpc.Net.Client;

namespace WConnect.Gateway;

public class GrpcChannelFactory
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