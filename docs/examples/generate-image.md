# Generate image

Generate an image with an EigenAI image model.

This example assumes `using EigenAI;` is in scope and `apiKey` contains your EigenAI API key.

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