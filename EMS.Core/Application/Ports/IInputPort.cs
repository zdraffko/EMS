using System.Threading.Tasks;

namespace EMS.Core.Application.Ports
{
    public interface IInputPort<in TInput, out TOutput>
    {
        Task Handle(TInput input, IOutputPort<TOutput> output);
    }
}
