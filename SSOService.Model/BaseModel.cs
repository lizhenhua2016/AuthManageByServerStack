// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The base model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Model
{
    using System;

    /// <summary>
    /// The base model.
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

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