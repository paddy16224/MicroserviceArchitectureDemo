using System;
namespace MicroserviceDemo.Common.Events
{
    public interface IAuthenticatedEvent: IEvent
    {
        Guid UserId { get; set; }
    }
}