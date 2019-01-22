using System.Threading.Tasks;

namespace MicroserviceDemo.Common.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
         Task HandleAsync(T command);
    }
}