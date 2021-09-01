using Ninject;
using Ninject.Web.Common.WebHost;
using SBC.Entities;
using SBC.Models;
using SBC.Repositories;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SBC
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected override IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IRepository<CoursesItem>>().To<EFCoursesTestRepository>();
            kernel.Bind<IRepository<TestItem>>().To<EFTestRepository>();
            kernel.Bind<IRepository<QuestionItem>>().To<EFQuestionRepository>();
            kernel.Bind<IRepository<LernenItem>>().To<EFLernenReposytory>();

            return kernel;
        }
    }
}
