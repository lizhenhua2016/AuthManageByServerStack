// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Auth.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Auth type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Model
{
    using System;

    /// <summary>
    /// The auth.
    /// </summary>
    public class Auth : BaseModel
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        public string AuthName { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        public string AuthDiscription { get; set; }

        /// <summary>
        /// 父级
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public Guid HigherAuthID { get; set; }
    }
}