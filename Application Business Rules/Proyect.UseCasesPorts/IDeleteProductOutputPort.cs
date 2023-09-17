namespace Proyect.UseCasesPorts
{
    public interface IDeleteProductOutputPort
    {
        Task Handle(bool status);
    }
}
