#nullable enable

using System.CommandLine;

namespace EigenAI.CLI.Commands;

internal sealed record ImageGenerationRequestOptionSet(
    Option<string> Model,
                     Option<string> Prompt,
                     Option<int?> Seed,
                     Option<global::EigenAI.ImageGenerationRequestMode?> Mode,
                     Option<bool?> RealTime,
                     Option<int?> Width,
                     Option<int?> Height,
                     Option<double?> GuidanceScale)
{
    public static ImageGenerationRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ImageGenerationRequestOptionSet(
                        Model: new Option<string>($"--{normalizedPrefix}model")
                {
                    Description = @"Model ID selected from the EigenAI model library.",
                    Required = true,
                },
                Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"Text prompt describing what to generate.",
                    Required = true,
                },
                Seed: new Option<int?>($"--{normalizedPrefix}seed")
                {
                    Description = @"",
                },
                Mode: new Option<global::EigenAI.ImageGenerationRequestMode?>($"--{normalizedPrefix}mode")
                {
                    Description = @"",
                },
                RealTime: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}real-time", description: @""),
                Width: new Option<int?>($"--{normalizedPrefix}width")
                {
                    Description = @"",
                },
                Height: new Option<int?>($"--{normalizedPrefix}height")
                {
                    Description = @"",
                },
                GuidanceScale: new Option<double?>($"--{normalizedPrefix}guidance-scale")
                {
                    Description = @"",
                }
        );
    }
}