#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace EigenAI.CLI.Commands;

internal static partial class ImagesGenerateImageAsBytesCommandApiCommand
{
    private static readonly ImageGenerationRequestOptionSet ImageGenerationRequestOptionSetOptions = ImageGenerationRequestOptionSet.Create();
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

    public static Command Create()
    {
        var command = new Command(@"generate-image-as-bytes", @"Generate or edit an image.
Generates images from text prompts with JSON requests, or edits images with multipart form uploads depending on the selected model.");
                        command.Options.Add(ImageGenerationRequestOptionSetOptions.Model);
                        command.Options.Add(ImageGenerationRequestOptionSetOptions.Prompt);
                        command.Options.Add(ImageGenerationRequestOptionSetOptions.Seed);
                        command.Options.Add(ImageGenerationRequestOptionSetOptions.Mode);
                        command.Options.Add(ImageGenerationRequestOptionSetOptions.RealTime);
                        command.Options.Add(ImageGenerationRequestOptionSetOptions.Width);
                        command.Options.Add(ImageGenerationRequestOptionSetOptions.Height);
                        command.Options.Add(ImageGenerationRequestOptionSetOptions.GuidanceScale);
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
                            cancellationToken).ConfigureAwait(false);                        var model = parseResult.GetRequiredValue(ImageGenerationRequestOptionSetOptions.Model);
                        var prompt = parseResult.GetRequiredValue(ImageGenerationRequestOptionSetOptions.Prompt);
                        var seed = CliRuntime.WasSpecified(parseResult, ImageGenerationRequestOptionSetOptions.Seed) ? parseResult.GetValue(ImageGenerationRequestOptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var mode = CliRuntime.WasSpecified(parseResult, ImageGenerationRequestOptionSetOptions.Mode) ? parseResult.GetValue(ImageGenerationRequestOptionSetOptions.Mode) : (__requestBase is { } __ModeBaseValue ? __ModeBaseValue.Mode : default);
                        var realTime = CliRuntime.WasSpecified(parseResult, ImageGenerationRequestOptionSetOptions.RealTime) ? parseResult.GetValue(ImageGenerationRequestOptionSetOptions.RealTime) : (__requestBase is { } __RealTimeBaseValue ? __RealTimeBaseValue.RealTime : default);
                        var width = CliRuntime.WasSpecified(parseResult, ImageGenerationRequestOptionSetOptions.Width) ? parseResult.GetValue(ImageGenerationRequestOptionSetOptions.Width) : (__requestBase is { } __WidthBaseValue ? __WidthBaseValue.Width : default);
                        var height = CliRuntime.WasSpecified(parseResult, ImageGenerationRequestOptionSetOptions.Height) ? parseResult.GetValue(ImageGenerationRequestOptionSetOptions.Height) : (__requestBase is { } __HeightBaseValue ? __HeightBaseValue.Height : default);
                        var guidanceScale = CliRuntime.WasSpecified(parseResult, ImageGenerationRequestOptionSetOptions.GuidanceScale) ? parseResult.GetValue(ImageGenerationRequestOptionSetOptions.GuidanceScale) : (__requestBase is { } __GuidanceScaleBaseValue ? __GuidanceScaleBaseValue.GuidanceScale : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GenerateImageAsBytesAsync(
                                    model: model,
                                    prompt: prompt,
                                    seed: seed,
                                    mode: mode,
                                    realTime: realTime,
                                    width: width,
                                    height: height,
                                    guidanceScale: guidanceScale,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}