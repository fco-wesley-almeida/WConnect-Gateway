using System.Diagnostics;
using Grpc.Net.Client;
using WConnect.Gateway.GrpcChannels;
using WConnect.Gateway.Repositories;
using WConnect.Gateway.Repositories.Interfaces;
using WConnect.Gateway.Services;
using WConnect.Gateway.Services.Interfaces;

namespace WConnect.Gateway.Configurations;

public static class DependencyInjectionExtension
{
   public static void AddDependencyInjection(this IServiceCollection services)
   {
      services.AddSingleton<IGrpcChannelFactory, GrpcChannelFactory>();
      services.AddSingleton<IAuthGrpcChannel, AuthGrpcChannel>();
      services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
      services.AddScoped<IAuthenticationService, AuthenticationService>();
   }
}