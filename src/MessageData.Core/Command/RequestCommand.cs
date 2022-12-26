using MessageData.Core.Services;

namespace MessageData.Core.Command;

public record RequestCommand
{
    public string Name { get; set; }
}

public class RequestCommandHandler
{
    private readonly ILoggingService _loggingService;
    public RequestCommandHandler(ILoggingService loggingService)
    {
        _loggingService = loggingService;
    }

    public async Task Handle(RequestCommand requestCommand)
    {
        _loggingService.LogInfo("Creating service from new request.");
    }
}