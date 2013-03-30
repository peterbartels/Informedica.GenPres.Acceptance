using Autofac;
using Informedica.GenPres.Application.IoC;

namespace GenPres.AcceptanceTests
{
    public class BaseAccceptanceTests
    {
        protected IContainer Container;

        public BaseAccceptanceTests()
        {
            var builder = MvcApplication.BuildIoC();
            Container = builder.Build();
        }
    }
}
