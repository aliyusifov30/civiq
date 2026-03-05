


using Civiq.Application.Interfaces.Events;
using Civiq.Domain.Enums;
using Civiq.Domain.Events;
using Civiq.Infrastructure;
using Civiq.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var violations = Enum.GetNames<ViolationType>();

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {

        services.RegisterInfrastructure();
        services.RegisterPersistence();

    })
    .Build();

var eventBus = host.Services.GetService<IEventBus>();

while (true)
{
    var ev = new ViolationDetectedEvent(
        Guid.NewGuid(),
        $"90-AB-{Random.Shared.Next(100, 999)}",
        violations[Random.Shared.Next(violations.Length)],
        Guid.NewGuid(),
        DateTime.UtcNow
    );

    await eventBus.Publish(ev);

    await Task.Delay(3000);
}