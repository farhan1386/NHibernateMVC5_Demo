using NHibernate;
using NHibernate.Cfg;
using System.Web;

namespace NHibernateMVC5_Demo.NHibernateFiles
{
    public class NHibernateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\NHibernateFiles\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            var bookConfigurationFile = HttpContext.Current.Server.MapPath(@"~\NHibernateFiles\Employee.hbm.xml");
            configuration.AddFile(bookConfigurationFile);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}