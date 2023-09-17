using Proyect.UseCasesPorts;

namespace Proyect.Presenters
{
    public class DeleteProductPresenter : IDeleteProductOutputPort, IPresenter<Boolean>
    {
        public bool Content { get; private set; }

        public Task Handle(bool response)
        {
            Content = response;
            return Task.CompletedTask;
        }

    }
}
