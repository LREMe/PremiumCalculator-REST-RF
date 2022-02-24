using Autofac;

namespace PremiumCalculator.API.Infraestructure.AutofacModules
{
    public class ApplicationModule : Autofac.Module
    {
        public string QueriesConnectionString { get; }

        public ApplicationModule(string qconstr)
        {
            QueriesConnectionString = qconstr;

        }


        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<PremiumRolRepository>()
            .As<IPremiumRolRepository>()
            .InstancePerLifetimeScope();
        }
    }
}
