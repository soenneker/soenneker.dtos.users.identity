[![](https://img.shields.io/nuget/v/soenneker.dtos.users.identity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.users.identity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.users.identity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.users.identity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.users.identity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.users.identity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.users.identity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.users.identity/actions/workflows/codeql.yml)

# Soenneker.Dtos.Users.Identity

Identifies an external sign-in identity linked to a user, including its provider, provider-assigned identifier, and authentication method.

## Install

```bash
dotnet add package Soenneker.Dtos.Users.Identity
```

## What you get

- `UserIdentity` — Identifies an external sign-in identity linked to a user, including its provider, provider-assigned identifier, and authentication method.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `UserIdentity.Issuer` | Identity provider or tenant that issued the sign-in identity, such as `contoso.com` or `facebook.com`. | Identity provider or tenant that issued the sign-in identity, such as `contoso.com` or `facebook.com`. |
| `UserIdentity.IssuerAssignedId` | Stable unique user identifier assigned by the identity provider within the issuer's namespace. | Stable unique user identifier assigned by the identity provider within the issuer's namespace. |
| `UserIdentity.SignInType` | Sign-in method represented by the identity, such as `emailAddress`, `userName`, or `federated`. | Sign-in method represented by the identity, such as `emailAddress`, `userName`, or `federated`. |
