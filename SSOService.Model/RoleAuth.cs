// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoleAuth.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the RoleAuth type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Model
{
    using System;

    /// <summary>
    /// The role auth.
    /// </summary>
    public class RoleAuth
    {
        // ReSharper disable once InconsistentNaming
        public Guid RoleAuthID { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public Guid RoleID { get; set; }

        /// <summary>
        /// 授权ID
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public Guid AuthID { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Discription { get; set; }
    }
}