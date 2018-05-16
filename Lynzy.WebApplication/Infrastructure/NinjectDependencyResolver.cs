using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using Lynzy.Domain.Abstract;
using Lynzy.Domain.Entities;
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

        // This method isn't showing up in the text as of p 177.  I added it out of the book 
        // somewhere.
        private static void RegisterServices(IKernel kernel)
        {
            System.Web.Mvc.DependencyResolver.SetResolver(new
                Lynzy.WebUI.Infrastructure.NinjectDependencyResolver(kernel));
        }

        private void AddBindings()
        {
            kernel.Bind<ISongRepository>().To<EFSongRepository>();
            //    Mock<ISongRepository> mock = new Mock<ISongRepository>();
            //    mock.Setup(m => m.Song).Returns
            //      (
            //        new List<SongFiles>
            //        {
            //        new Song { Name = "Football", Price = 25 },
            //        new Song { Name = "Surf board", Price = 179 },
            //        new Song { Name = "Running shoes", Price = 95 }
            //        }
            //      );
            //    kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }
    }
}
