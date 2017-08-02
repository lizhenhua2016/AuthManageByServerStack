// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Model
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Gets or sets the program id.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public Guid ProgramID { get; set; }

        /// <summary>
        /// Gets or sets the program name.
        /// </summary>
        public string ProgramName { get; set; }

        /// <summary>
        /// Gets or sets the controller.
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// Gets or sets the action result.
        /// </summary>
        public string ActionResult { get; set; }

        /// <summary>
        /// Gets or sets the program description.
        /// </summary>
        public string ProgramDescription { get; set; }

        /// <summary>
        /// Gets or sets the parent program id.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public Guid ParentProgramID { get; set; }

        /// <summary>
        /// Gets or sets the sequence.
        /// </summary>
        public string Sequence { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// Gets or sets the creator.
        /// </summary>
        public Guid Creator { get; set; }

        /// <summary>
        /// Gets or sets the create time.
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
    }
}