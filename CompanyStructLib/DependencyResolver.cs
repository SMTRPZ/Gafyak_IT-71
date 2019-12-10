using Autofac;
using CompanyStructLib.Implementations;
using CompanyStructLib.Interfaces;

namespace CompanyStructLib
{
    public static class DependencyResolver
    {
        public static void RegisterDependencies(this ContainerBuilder builder)
        {
            //builder.RegisterType<HierarchyStrategy>().As<IHierarchyStrategy>();
            //builder.RegisterType<HierarchyStrategy2>().As<IHierarchyStrategy>();
        }
    }
}
