// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hello.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Hello type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.ServiceModel
{
    using ServiceStack;

    /// <summary>
    /// The hello.
    /// </summary>
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello : IReturn<HelloResponse>
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// The hello response.
    /// </summary>
    public class HelloResponse
    {
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public string Result { get; set; }
    }
}