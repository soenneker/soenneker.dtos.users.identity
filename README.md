[![](https://img.shields.io/nuget/v/soenneker.dtos.users.identity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.users.identity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.users.identity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.users.identity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.users.identity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.users.identity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.users.identity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.users.identity/actions/workflows/codeql.yml)

# Soenneker.Dtos.Users.Identity

A DTO for an external or local sign-in identity: the issuer namespace, the issuer-assigned user identifier, and the sign-in method. It supports both `System.Text.Json` and Newtonsoft.Json.

## Install

```bash
dotnet add package Soenneker.Dtos.Users.Identity
```

## Usage

```csharp
using Soenneker.Dtos.Users.Identity;

var identity = new UserIdentity
{
    Issuer = "contoso.onmicrosoft.com",
    IssuerAssignedId = "alex@example.com",
    SignInType = "emailAddress"
};
```

It serializes as:

```json
{
  "issuer": "contoso.onmicrosoft.com",
  "issuerAssignedId": "alex@example.com",
  "signInType": "emailAddress"
}
```

All three properties are required during initialization. Their exact accepted values and case-sensitivity are defined by the identity provider; the DTO does not normalize domains, validate sign-in types, or confirm that an identity exists.

Treat the tuple of issuer, assigned identifier, and sign-in type as identity data—not proof of authentication. Establish the current user's identity from validated tokens or the platform's authenticated principal rather than trusting a client-supplied DTO.
