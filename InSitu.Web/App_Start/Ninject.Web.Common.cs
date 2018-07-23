[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(InSitu.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(InSitu.Web.App_Start.NinjectWebCommon), "Stop")]

namespace InSitu.Web.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;
    using InSitu.Data.Contexts;
    using InSitu.Data.Models.CarInformation;
    using InSitu.Data.Models.Person;
    using InSitu.Data.Repositories;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using Ninject.Web.WebApi;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<InSituContext>().ToSelf().InRequestScope();
            kernel.Bind<BaseRepository<Brand>>().To<BrandRepository>().InRequestScope();
            kernel.Bind<BaseRepository<CarModel>>().To<CarModelRepository>().InRequestScope();
            kernel.Bind<BaseRepository<CarType>>().To<CarTypeRepository>().InRequestScope();
            kernel.Bind<BaseRepository<FuelType>>().To<FuelTypeRepository>().InRequestScope();
            kernel.Bind<BaseRepository<PaintType>>().To<PaintTypeRepository>().InRequestScope();
            kernel.Bind<BaseRepository<Size>>().To<SizeRepository>().InRequestScope();
            kernel.Bind<BaseRepository<UseType>>().To<UseTypeRepository>().InRequestScope();
            kernel.Bind<BaseRepository<CarVersion>>().To<CarVersionRepository>().InRequestScope();
            kernel.Bind<BaseRepository<Customer>>().To<CustomerRepository>().InRequestScope();

        }        
    }
}