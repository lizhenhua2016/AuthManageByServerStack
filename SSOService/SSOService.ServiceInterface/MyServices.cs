// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyServices.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the MyServices type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.ServiceInterface
{
    using ServiceStack;

    using SSOService.ServiceModel;

    /// <summary>
    /// The my services.
    /// </summary>
    public class MyServices : Service
    {
        /// <summary>
        /// The any.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }
    }
}