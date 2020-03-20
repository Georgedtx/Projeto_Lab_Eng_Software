using Ninject;
using Ninject.Modules;

namespace Infra.IoC
{
    public class DependenciesResolve
    {
        private static IKernel _kernel;

        public static void Wire(INinjectModule module)
        {
            _kernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return _kernel.Get<T>();
        }
    }
}
