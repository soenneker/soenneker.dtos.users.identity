using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.Users.Identity;

/// <summary>
/// Represents a user's sign-in identity, including information about the identity provider and method of authentication.
/// </summary>
public class UserIdentity
{
    /// <summary>
    /// Gets or sets the identity provider that issued the sign-in identity (e.g., "contoso.com" or "facebook.com").
    /// </summary>
    [JsonPropertyName("issuer")]
    [JsonProperty("issuer")]
    public string Issuer { get; set; } = null!;

    /// <summary>
    /// Gets or sets the unique identifier assigned to the user by the identity provider.
    /// </summary>
    [JsonPropertyName("issuerAssignedId")]
    [JsonProperty("issuerAssignedId")]
    public string IssuerAssignedId { get; set; } = null!;

    /// <summary>
    /// Gets or sets the method of sign-in used by the identity (e.g., "emailAddress", "userName", or "federated").
    /// </summary>
    [JsonPropertyName("signInType")]
    [JsonProperty("signInType")]
    public string SignInType { get; set; } = null!;
}