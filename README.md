# Xperience by Kentico - E-Commerce common

[![Kentico Labs](https://img.shields.io/badge/Kentico_Labs-grey?labelColor=orange&logo=data:image/svg+xml;base64,PHN2ZyBjbGFzcz0ic3ZnLWljb24iIHN0eWxlPSJ3aWR0aDogMWVtOyBoZWlnaHQ6IDFlbTt2ZXJ0aWNhbC1hbGlnbjogbWlkZGxlO2ZpbGw6IGN1cnJlbnRDb2xvcjtvdmVyZmxvdzogaGlkZGVuOyIgdmlld0JveD0iMCAwIDEwMjQgMTAyNCIgdmVyc2lvbj0iMS4xIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciPjxwYXRoIGQ9Ik05NTYuMjg4IDgwNC40OEw2NDAgMjc3LjQ0VjY0aDMyYzE3LjYgMCAzMi0xNC40IDMyLTMycy0xNC40LTMyLTMyLTMyaC0zMjBjLTE3LjYgMC0zMiAxNC40LTMyIDMyczE0LjQgMzIgMzIgMzJIMzg0djIxMy40NEw2Ny43MTIgODA0LjQ4Qy00LjczNiA5MjUuMTg0IDUxLjIgMTAyNCAxOTIgMTAyNGg2NDBjMTQwLjggMCAxOTYuNzM2LTk4Ljc1MiAxMjQuMjg4LTIxOS41MnpNMjQxLjAyNCA2NDBMNDQ4IDI5NS4wNFY2NGgxMjh2MjMxLjA0TDc4Mi45NzYgNjQwSDI0MS4wMjR6IiAgLz48L3N2Zz4=)](https://github.com/Kentico/.github/blob/main/SUPPORT.md#labs-limited-support)
[![CI: Build and Test](https://github.com/Kentico/xperience-by-kentico-ecommerce-common/actions/workflows/ci.yml/badge.svg)](https://github.com/Kentico/xperience-by-kentico-ecommerce-common/actions/workflows/ci.yml)

## Description

This repository uses as common code base for specific E-Commerce integrations.
Currently contains one library `Kentico.Xperience.Ecommerce.Common`.

## Library Version Matrix

| Xperience Version | Library Version |
| ----------------- | --------------- |
| >= 29.0.1         | 1.0.0           |

### Dependencies

- [ASP.NET Core 8.0](https://dotnet.microsoft.com/en-us/download)
- [Xperience by Kentico](https://docs.kentico.com/changelog)

## Package Installation

Add the package to your application using the .NET CLI

```powershell
dotnet add package Kentico.Xperience.Ecommerce.Common
```

## Quick Start

The primary reason for this repository is to maintain common functionality for all current and future E-Commerce integrations in one place.
Repository is used as a submodule repo in these projects:
- [Xperience By Kentico E-Commerce](https://github.com/Kentico/xperience-by-kentico-ecommerce)
- [Xperience By Kentico - Shopify](https://github.com/Kentico/xperience-by-kentico-shopify)

Be aware of all breaking changes that may occur in parent projects.

Library `Kentico.Xperience.Ecommerce.Common` covers this domains:
- **ContentItemSynchronization** namespace
  - Common functionality for synchronization of content items

## Full Instructions

View the [Usage Guide](./docs/Usage-Guide.md) for more detailed instructions.

## Contributing

To see the guidelines for Contributing to Kentico open source software, please see [Kentico's `CONTRIBUTING.md`](https://github.com/Kentico/.github/blob/main/CONTRIBUTING.md) for more information and follow the [Kentico's `CODE_OF_CONDUCT`](https://github.com/Kentico/.github/blob/main/CODE_OF_CONDUCT.md).

Instructions and technical details for contributing to **this** project can be found in [Contributing Setup](./docs/Contributing-Setup.md).

## License

Distributed under the MIT License. See [`LICENSE.md`](./LICENSE.md) for more information.

## Support

This contribution has __Kentico Labs limited support__.

See [`SUPPORT.md`](https://github.com/Kentico/.github/blob/main/SUPPORT.md#labs-limited-support) for more information.

For any security issues see [`SECURITY.md`](https://github.com/Kentico/.github/blob/main/SECURITY.md).
