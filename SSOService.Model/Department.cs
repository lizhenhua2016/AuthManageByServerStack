// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Department.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Department type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Model
{
    using System;

    /// <summary>
    /// The department.
    /// </summary>
    public class Department : BaseModel
    {
        /// <summary>
        /// Gets or sets the department code.
        /// </summary>
        public string DepartmentCode { get; set; }

        /// <summary>
        /// Gets or sets the department name.
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// Gets or sets the parent dept id.
        /// </summary>
        public Guid ParentDeptId { get; set; }

        /// <summary>
        /// Gets or sets the responsible person.
        /// </summary>
        public string ResponsiblePerson { get; set; }

        /// <summary>
        /// Gets or sets the responsible phone.
        /// </summary>
        public string ResponsiblePhone { get; set; }

        /// <summary>
        /// Gets or sets the department description.
        /// </summary>
        public string DepartmentDescription { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether state.
        /// </summary>
        public bool State { get; set; }
    }
}