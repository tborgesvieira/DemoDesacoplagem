using DD.DemoDesacoplagem.Infra.Data.UnitOfWork;

namespace DD.DemoDesacoplagem.Application
{
    public class AppService
    {
        private readonly IUnitOfWork _uow;

        public AppService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Commit()
        {
            _uow.Commit();
        }
    }
}