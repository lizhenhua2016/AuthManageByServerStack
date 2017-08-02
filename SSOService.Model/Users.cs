// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Users.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Users type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Model
{
    using System;

    /// <summary>
    /// The users.
    /// </summary>
    public class Users : BaseModel
    {
        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string PassWord { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 所属部门
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the department name.
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 登录次数
        /// </summary>
        public int? LoginCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether state.
        /// </summary>
        public bool State { get; set; }
    }
}