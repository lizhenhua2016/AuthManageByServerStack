// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUsers.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IUsers type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.IBLL
{
    using System;
    using System.Collections.Generic;

    using SSOService.Model;

    /// <summary>
    /// The i users.
    /// </summary>
    public interface IUsers
    {
        /// <summary>
        /// The create user.
        /// </summary>
        /// <param name="users">
        /// The users.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool CreateUser(Users users);

        /// <summary>
        /// The delete user.
        /// </summary>
        /// <param name="Id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        // ReSharper disable once InconsistentNaming
        bool DeleteUser(Guid Id);

        /// <summary>
        /// The update user.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool UpdateUser();

        /// <summary>
        /// The get users.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        List<Users> GetUsers();

        /// <summary>
        /// The get user.
        /// </summary>
        /// <param name="Id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Users"/>.
        /// </returns>
        // ReSharper disable once InconsistentNaming
        Users GetUser(Guid Id);
    }
}