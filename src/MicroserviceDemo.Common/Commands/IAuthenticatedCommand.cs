using System;

namespace MicroserviceDemo.Common.Commands
{
    public interface IAuthenticatedCommand: ICommand
    {
         Guid UserId {get;set;}
    }
}