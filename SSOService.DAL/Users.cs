// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Users.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Users type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.DAL
{
    using System;
    using System.Collections.Generic;

    using SSOService.IDAL;

    /// <summary>
    /// The users.
    /// </summary>
    public class Users : IUser
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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool CreateUser(Model.Users users)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The update user.
        /// </summary>
        /// <param name="users">
        /// The users.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool UpdateUser(Model.Users users)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The delete user.
        /// </summary>
        /// <param name="Id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        // ReSharper disable once InconsistentNaming
        public bool DeleteUser(Guid Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The get users.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public List<Model.Users> GetUsers()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The get user.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public List<Model.Users> GetUser(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}