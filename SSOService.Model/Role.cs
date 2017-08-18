// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Role.cs" company="abc">
//   lizhenhua
// </copyright>
// <summary>
//   Defines the Role type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Model
{
    using System;

    /// <summary>
    /// The role.
    /// </summary>
    public class Role
    {
        // ReSharper disable once InconsistentNaming

        /// <summary>
        /// Gets or sets the role id.
        /// </summary>
        public Guid RoleID { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        public string RoleDiscription { get; set; }

        /// <summary>
        /// 上级角色
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public Guid ParentRoleID { get; set; }

        /// <summary>
        /// Gets or sets the creator.
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the modifer.
        /// </summary>
        public string Modifer { get; set; }

        /// <summary>
        /// Gets or sets the modify time.
        /// </summary>
        public string ModifyTime { get; set; }

        /// <summary>
        /// Gets or sets the remark.
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether state.
        /// </summary>
        public bool State { get; set; }
    }
}
