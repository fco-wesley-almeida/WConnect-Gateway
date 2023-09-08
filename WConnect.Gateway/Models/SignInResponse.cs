namespace WConnect.Gateway.Models;

public class SignInResponse
{
    public string AccessToken { get; init; } = null!;
    public DateTime AccessTokenExpiryTime { get; init; }
    
    public SignInResponse() {}

    public SignInResponse(SignInGrpcResponse grcpResponse)
    {
        AccessToken = grcpResponse.AccessToken;
        AccessTokenExpiryTime = Convert.ToDateTime(grcpResponse.AccessTokenExpiryTime);
    }
}