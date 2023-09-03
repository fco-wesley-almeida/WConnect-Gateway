using System.ComponentModel.DataAnnotations;

namespace WConnect.Gateway.Models;

public class SignUpResponse
{
    [Required] 
    public required int Id { get; set; }
}