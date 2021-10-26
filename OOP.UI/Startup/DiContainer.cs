using Autofac;
using OOP.Data;
using OOP.UI.DataAccess;
using OOP.UI.ViewModel;

namespace OOP.UI.Startup
{
    public class DiContainer
    {
        public IContainer Container()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeViewModel>().AsSelf();
            builder.RegisterType<EmployeeDataAccess>().AsSelf();
            builder.RegisterType<EmployeeDataSource_MockData>().As<IEmployeeDataSource>();

            return builder.Build();

        }
    }
}
