// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppHost.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the AppHost type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService
{
    using System.Configuration;
    using System.Web.Mvc;

    using Funq;

    using Microsoft.SqlServer.Types;

    using ServiceStack;
    using ServiceStack.Api.Swagger;
    using ServiceStack.Auth;
    using ServiceStack.Caching;
    using ServiceStack.Data;
    using ServiceStack.Logging;
    using ServiceStack.Logging.Log4Net;
    using ServiceStack.Mvc;
    using ServiceStack.OrmLite;

    using SSOService.Common;
    using SSOService.ServiceInterface;

    /// <summary>
    /// The app host.
    /// </summary>
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppHost"/> class. 
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("SSOService", typeof(MyServices).Assembly)
        {
        }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        public override void Configure(Container container)
        {
            this.SetConfig(new HostConfig
            {
                HandlerFactoryPath = "api"
            });
            #region 添加插件
            // Config examples
            // this.Plugins.Add(new PostmanFeature());
            // this.Plugins.Add(new CorsFeature());
            this.Plugins.Add(new SwaggerFeature());

            // Plugins.Add(new AuthFeature(() => new UserSession(),
            // new IAuthProvider[] {
            // new CustomCredentialsAuthProvider(), //HTML Form post of UserName/Password credentials
            // }));
            this.Plugins.Add(new RegistrationFeature());
            LogManager.LogFactory = new Log4NetFactory(configureLog4Net: true);
            ServiceStack.Text.JsConfig.EmitCamelCaseNames = true;
            #endregion 
            #region 添加postgisGeometry置换器，可以直接读取空间字段
            SqlServerDialect.Provider.RegisterConverter<SqlGeometry>(new SqlGeometryConverter());
            var connectionString = ConfigurationManager.ConnectionStrings["AuthCon"].ConnectionString;
            var connFactory = new OrmLiteConnectionFactory(connectionString, SqlServerDialect.Provider);
            container.Register<IDbConnectionFactory>(c => connFactory);

            container.Register<ICacheClient>(new MemoryCacheClient());
            container.Register<ISessionFactory>(c => new SessionFactory(c.Resolve<ICacheClient>()));
            container.Register<IUserAuthRepository>(new OrmLiteAuthRepository(connFactory)
            {
                UseDistinctRoleTables = true
            });
            #endregion
            // Set MVC to use the same Funq IOC as ServiceStack
            ControllerBuilder.Current.SetControllerFactory(new FunqControllerFactory(container));
        }
    }
}