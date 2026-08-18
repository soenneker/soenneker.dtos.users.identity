using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.Users.Identity;

/// <summary>
/// Identifies an external sign-in identity linked to a user, including its provider, provider-assigned identifier, and authentication method.
/// </summary>
public class UserIdentity
{
    /// <summary>
    /// Identity provider or tenant that issued the sign-in identity, such as <c>contoso.com</c> or <c>facebook.com</c>.
    /// </summary>
    [JsonPropertyName("issuer")]
    [JsonProperty("issuer")]
    public string Issuer { get; set; } = null!;

    /// <summary>
    /// Stable unique user identifier assigned by the identity provider within the issuer's namespace.
    /// </summary>
    [JsonPropertyName("issuerAssignedId")]
    [JsonProperty("issuerAssignedId")]
    public string IssuerAssignedId { get; set; } = null!;

    /// <summary>
    /// Sign-in method represented by the identity, such as <c>emailAddress</c>, <c>userName</c>, or <c>federated</c>.
    /// </summary>
    [JsonPropertyName("signInType")]
    [JsonProperty("signInType")]
    public string SignInType { get; set; } = null!;
}
