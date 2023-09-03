using System.ComponentModel.DataAnnotations;
using Google.Protobuf;

namespace WConnect.Gateway.Models;

public class SignUpRequest
{
    [Required, MaxLength(100)] 
    public required string Name { get; set; } = null!;
    
    [Required, MinLength(5), MaxLength(20)]
    public required string Login {get;set;} = null!;
    
    [Required, MinLength(5), MaxLength(100)]
    public required string Password {get;set;} = null!;
    
    [Required]
    public required byte[] Photo {get;set;} = null!;

    public SignUpGrpcRequest AsGrpc()
    {
        return new()
        {
            Name = Name,
            Login = Login,
            Password = Password,
            Photo = ByteString.CopyFrom(Photo)
        };
    }
}