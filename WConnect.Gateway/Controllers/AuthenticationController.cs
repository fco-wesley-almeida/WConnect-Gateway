using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WConnect.Gateway.Models;
using WConnect.Gateway.Services.Interfaces;

namespace WConnect.Gateway.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthenticationController : ControllerBase
{

    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [AllowAnonymous]
    [HttpPost("Sign-Up")]
    public async Task<ActionResult<SignUpResponse>> SignUpAsync(SignUpRequest request) 
        => Ok(await _authenticationService.SignUpAsync(request));
    
    [AllowAnonymous]
    [HttpPost("Sign-In")]
    public async Task<ActionResult<SignInResponse>> SignInAsync(SignInRequest request) 
        => Ok(await _authenticationService.SignInAsync(request));
}
