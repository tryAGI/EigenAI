#nullable enable

using System.CommandLine;

namespace EigenAI.CLI.Commands;

internal static class ImagesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"images", @"Images endpoint commands.");
                         command.Subcommands.Add(ImagesGenerateImageCommandApiCommand.Create());
        return command;
    }
}