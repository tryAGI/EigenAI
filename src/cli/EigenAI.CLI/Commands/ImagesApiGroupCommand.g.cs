#nullable enable

using System.CommandLine;

namespace EigenAI.CLI.Commands;

internal static partial class ImagesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"images", @"Images endpoint commands.");
                         command.Subcommands.Add(ImagesGenerateImageCommandApiCommand.Create());
                         command.Subcommands.Add(ImagesGenerateImageAsBytesCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}