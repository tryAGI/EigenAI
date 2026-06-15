#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace EigenAI.CLI.Commands;

internal static partial class ImagesGenerateImageCommandApiCommand
{
    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Model ID selected from the EigenAI model library.",
        Required = true,
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Text prompt describing what to generate.",
        Required = true,
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"",
    };

    private static Option<global::EigenAI.ImageGenerationRequestMode?> Mode { get; } = new(
        name: @"--mode")
    {
        Description = @"",
    };

    private static Option<bool?> RealTime { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--real-time",
        description: @"");

    private static Option<int?> Width { get; } = new(
        name: @"--width")
    {
        Description = @"",
    };

    private static Option<int?> Height { get; } = new(
        name: @"--height")
    {
        Description = @"",
    };

    private static Option<double?> GuidanceScale { get; } = new(
        name: @"--guidance-scale")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::EigenAI.ImageGenerationResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::EigenAI.ImageGenerationResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"generate-image", @"Generate or edit an image.
Generates images from text prompts with JSON requests, or edits images with multipart form uploads depending on the selected model.");
                        command.Options.Add(Model);
                        command.Options.Add(Prompt);
                        command.Options.Add(Seed);
                        command.Options.Add(Mode);
                        command.Options.Add(RealTime);
                        command.Options.Add(Width);
                        command.Options.Add(Height);
                        command.Options.Add(GuidanceScale);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::EigenAI.ImageGenerationRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::EigenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var mode = CliRuntime.WasSpecified(parseResult, Mode) ? parseResult.GetValue(Mode) : (__requestBase is { } __ModeBaseValue ? __ModeBaseValue.Mode : default);
                        var realTime = CliRuntime.WasSpecified(parseResult, RealTime) ? parseResult.GetValue(RealTime) : (__requestBase is { } __RealTimeBaseValue ? __RealTimeBaseValue.RealTime : default);
                        var width = CliRuntime.WasSpecified(parseResult, Width) ? parseResult.GetValue(Width) : (__requestBase is { } __WidthBaseValue ? __WidthBaseValue.Width : default);
                        var height = CliRuntime.WasSpecified(parseResult, Height) ? parseResult.GetValue(Height) : (__requestBase is { } __HeightBaseValue ? __HeightBaseValue.Height : default);
                        var guidanceScale = CliRuntime.WasSpecified(parseResult, GuidanceScale) ? parseResult.GetValue(GuidanceScale) : (__requestBase is { } __GuidanceScaleBaseValue ? __GuidanceScaleBaseValue.GuidanceScale : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GenerateImageAsync(
                                    model: model,
                                    prompt: prompt,
                                    seed: seed,
                                    mode: mode,
                                    realTime: realTime,
                                    width: width,
                                    height: height,
                                    guidanceScale: guidanceScale,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::EigenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}