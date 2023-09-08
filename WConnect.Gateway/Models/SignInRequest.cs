using System.ComponentModel.DataAnnotations;

namespace WConnect.Gateway.Models;

public class SignInRequest
{
    [Required]
    public required string Login { get; init; } = null!;

    [Required]
    public required string Password { get; init; } = null!;

    public SignInGrpcRequest AsGrpc()
    {
        return new()
        {
            Login = Login,
            Password = Password
        };
    }
}