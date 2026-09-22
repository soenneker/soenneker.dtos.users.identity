using Soenneker.Tests.Unit;
using System.Text.Json;
using System.Threading.Tasks;

namespace Soenneker.Dtos.Users.Identity.Tests;

public sealed class UserIdentityTests : UnitTest
{
    [Test]
    [Arguments("{}", null, null)]
    [Arguments("{\"issuer\":null,\"signInType\":null}", null, null)]
    [Arguments("{\"signInType\":\"federated\"}", null, "federated")]
    [Arguments("{\"issuer\":\"contoso.com\"}", "contoso.com", null)]
    public async Task Deserialize_accepts_optional_issuer_and_sign_in_type(string json, string? expectedIssuer, string? expectedSignInType)
    {
        UserIdentity identity = JsonSerializer.Deserialize<UserIdentity>(json)!;
        await Assert.That(identity.Issuer).IsEqualTo(expectedIssuer);
        await Assert.That(identity.SignInType).IsEqualTo(expectedSignInType);
        await Assert.That(identity.IssuerAssignedId).IsNull();
    }

    [Test]
    [Arguments("{\"issuer\":\"contoso.com\",\"signInType\":\"federated\"}", null)]
    [Arguments("{\"issuer\":\"contoso.com\",\"signInType\":\"federated\",\"issuerAssignedId\":null}", null)]
    [Arguments("{\"issuer\":\"contoso.com\",\"signInType\":\"federated\",\"issuerAssignedId\":\"user-123\"}", "user-123")]
    public async Task Deserialize_accepts_optional_issuer_assigned_id(string json, string? expectedId)
    {
        UserIdentity identity = JsonSerializer.Deserialize<UserIdentity>(json)!;
        await Assert.That(identity.Issuer).IsEqualTo("contoso.com");
        await Assert.That(identity.SignInType).IsEqualTo("federated");
        await Assert.That(identity.IssuerAssignedId).IsEqualTo(expectedId);
    }
}
