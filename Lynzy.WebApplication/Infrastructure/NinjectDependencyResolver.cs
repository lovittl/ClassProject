using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Lynzy.Domain.Abstract;
using Lynzy.Domain.Concrete;

namespace Lynzy.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private static void RegisterServices(IKernel kernel)
        {
            System.Web.Mvc.DependencyResolver.SetResolver(new
                Lynzy.WebUI.Infrastructure.NinjectDependencyResolver(kernel));
        }

        private void AddBindings()
        {
            kernel.Bind<ISongRepository>().To<EFSongRepository>();
        }
    }
}
