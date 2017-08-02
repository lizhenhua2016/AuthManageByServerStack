// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Project.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Project type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Model
{
    using System;

    /// <summary>
    /// The project.
    /// </summary>
    public class Project
    {
       // ReSharper disable once InconsistentNaming

        /// <summary>
        /// Gets or sets the project id.
        /// </summary>
        public Guid ProjectID { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// 项目url
        /// </summary>
        public string ProjectUrl { get; set; }

        /// <summary>
        /// 项目描述
        /// </summary>
        public string ProjectDiscription { get; set; }
    }
}