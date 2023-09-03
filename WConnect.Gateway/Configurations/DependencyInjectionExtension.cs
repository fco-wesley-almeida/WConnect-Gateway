using System.Diagnostics;
using Grpc.Net.Client;
using WConnect.Gateway.Repositories;
using WConnect.Gateway.Repositories.Interfaces;
using WConnect.Gateway.Services;
using WConnect.Gateway.Services.Interfaces;

namespace WConnect.Gateway.Configurations;

public static class DependencyInjectionExtension
{
   public static void AddDependencyInjection(this IServiceCollection services)
   {
      ServiceProvider serviceProvider = services.BuildServiceProvider();
      IConfiguration configuration = serviceProvider.GetService<IConfiguration>()!;
      var grpcChannelFactory = new GrpcChannelFactory(configuration);
      
      services.AddSingleton<GrpcChannel>(_ => grpcChannelFactory.Auth());
      
      services.AddScoped<IAuthRepository, AuthRepository>();
      services.AddScoped<IAuthenticationService, AuthenticationService>();
   }
}