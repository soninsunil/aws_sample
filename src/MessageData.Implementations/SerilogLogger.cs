using MessageData.Core.Services;
using Serilog;
using Serilog.Core;
using Serilog.Formatting.Compact;

namespace MessageData.Implementations;

public class SerilogLogger : ILoggingService
{
    private readonly Logger _log;
    private string _traceId;

    public SerilogLogger()
    {
        var log = new LoggerConfiguration()
        .WriteTo.Console(new RenderedCompactJsonFormatter())
        .CreateLogger();
    }

    public void AddTraceId(string traceId)
    {
        _traceId = traceId;
    }

    public void LogInfo(string message)
    {
        _log.ForContext("TraceId", _traceId).Information(message);
    }
}
