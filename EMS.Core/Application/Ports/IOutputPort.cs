namespace EMS.Core.Application.Ports
{
    public interface IOutputPort<in TOutputModel>
    {
        void Success(TOutputModel output);

        void Fail(string message = null);
    }
}
