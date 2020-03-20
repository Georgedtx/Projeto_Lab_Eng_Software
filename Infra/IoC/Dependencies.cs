using Domain.Interfaces.Uow;
using Infra.UoW;
using Ninject.Modules;

namespace Infra.IoC
{
    public class Dependencies : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }

        public static Dependencies Create()
        {
            return new Dependencies();
        }
    }
}
