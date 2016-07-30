namespace DD.DemoDesacoplagem.Infra.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}