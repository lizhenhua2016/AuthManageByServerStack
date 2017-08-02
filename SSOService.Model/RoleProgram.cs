// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoleProgram.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the RoleProgram type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Model
{
    using System;

    /// <summary>
    /// The role program.
    /// </summary>
    public class RoleProgram : BaseModel
    {
        /// <summary>
        /// Gets or sets the role id.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public Guid RoleID { get; set; }

        /// <summary>
        /// Gets or sets the program id.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public Guid ProgramID { get; set; }
    }
}