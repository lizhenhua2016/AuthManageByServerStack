// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppConfig.cs" company="">
//   
// </copyright>
// <summary>
//   The app config.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Common
{
    using ServiceStack.Configuration;
    using ServiceStack.Text;

    /// <summary>
    /// The app config.
    /// </summary>
    public class AppConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppConfig"/> class.
        /// </summary>
        /// <param name="appSettings">
        /// The app settings.
        /// </param>
        public AppConfig(IAppSettings appSettings)
        {
            this.Env = appSettings.Get<Env>("Env", Env.Dev);
            this.UploadSavePath = appSettings.Get<string>("UploadPath", "Uploads");
            this.VisitUrlPath = appSettings.Get<string>("VisitPath", "Uploads");
            this.SessionTimeout = appSettings.Get<int>("SessionTimeout", 60);
        }

        /// <summary>
        /// Gets the env.
        /// </summary>
        public Env Env { get; private set; }

        /// <summary>
        /// Session过期时间
        /// </summary>
        public int SessionTimeout { get; private set; }

        /// <summary>
        /// 保存上传文件的跟目录，可以是本地目录，也可以是网络路径。
        /// </summary>
        public string UploadSavePath { get; set; }

        /// <summary>
        /// 访问上传文件的路径。可能由于CDN或分布式部署的原因，访问路径可能不一样。
        /// </summary>
        public string VisitUrlPath { get; set; }
    }
}