// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectCase.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ProjectCase type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Model
{
    using System;

    /// <summary>
    /// The project case.
    /// </summary>
    public class ProjectCase
    {
        // ReSharper disable once InconsistentNaming
        public Guid ProjectCaseID { get; set; }
        
        /// <summary>
        /// 栏目名称
        /// </summary>
        public string CaseName { get; set; }
        
        /// <summary>
        /// 所属项目
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public Guid ProjectID { get; set; }
    }
}