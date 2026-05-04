<div class="docs-hero">
  <h1>EigenAI</h1>
  <p class="docs-hero-lead">Modern .NET SDK for EigenAI generated from the provider's OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/EigenAI/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/EigenAI"></a>
    <a href="https://github.com/tryAGI/EigenAI/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/EigenAI/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/EigenAI/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/EigenAI"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from <a href="src/libs/EigenAI/openapi.yaml">EigenAI's OpenAPI definition</a> so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using EigenAI;

using var client = new EigenAIClient(apiKey);
```

<!-- EXAMPLES:START -->
### Generate image
Generate an image with an EigenAI image model.

```csharp
using var client = new EigenAIClient(apiKey);

var model =
    Environment.GetEnvironmentVariable("EIGENAI_IMAGE_MODEL") is { Length: > 0 } modelValue
        ? modelValue
        : "eigen-image";

var response = await client.GenerateImageAsync(
    model: model,
    prompt: "A clean editorial product photo of a matte ceramic espresso cup.",
    width: 1024,
    height: 1024);

var output = response.ImageBase64 ?? response.ImageUrl ?? response.Url ?? response.Output;
```
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/EigenAI/issues">tryAGI/EigenAI</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/EigenAI/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
