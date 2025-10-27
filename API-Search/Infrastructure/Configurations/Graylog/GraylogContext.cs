using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Sinks.Graylog;

namespace Infrastructure.Configuration
{
    public class GraylogContext
    {        
        public static void Configure(IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration()
                        .WriteTo.Graylog(new GraylogSinkOptions
                        {
                            HostnameOrAddress = configuration.GetValue<string>("Graylog:Host"),
                            Port = Int32.Parse(configuration.GetValue<string>("Graylog:Port")),
                            Facility = configuration.GetValue<string>("Graylog:Facility")
                        })
                        .CreateLogger();
        }        
    }
}
