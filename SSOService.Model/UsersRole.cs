// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsersRole.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the UsersRole type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Model
{
    using System;

    /// <summary>
    /// The users role.
    /// </summary>
    public class UsersRole : BaseModel
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public Guid UserID { get; set; }

        /// <summary>
        /// Gets or sets the role id.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public Guid RoleID { get; set; }
    }
}