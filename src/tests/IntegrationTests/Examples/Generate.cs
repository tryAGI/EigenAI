/*
order: 10
title: Generate image
slug: generate-image

Generate an image with an EigenAI image model.
*/

namespace EigenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateImage()
    {
        using var client = GetAuthenticatedClient();

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

        output.Should().NotBeNullOrWhiteSpace();
    }
}
