// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUser.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IUser type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.IDAL
{
    using System;
    using System.Collections.Generic;

    using SSOService.Model;

    /// <summary>
    /// The user.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public interface IUser
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
        /// The update user.
        /// </summary>
        /// <param name="users">
        /// The users.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool UpdateUser(Users users);

        /// <summary>
        /// The delete user.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        // ReSharper disable once InconsistentNaming
        bool DeleteUser(Guid Id);

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
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        List<Users> GetUser(Guid id);
    }
}