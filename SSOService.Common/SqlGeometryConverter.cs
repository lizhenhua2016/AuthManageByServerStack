// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SqlGeometryConverter.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the SqlGeometryConverter type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SSOService.Common
{
    using System.Data;
    using ServiceStack.OrmLite;

    /// <summary>
    /// The sql geometry converter.
    /// </summary>
    public class SqlGeometryConverter : OrmLiteConverter
    {
        /// <summary>
        /// Gets the column definition.
        /// </summary>
        public override string ColumnDefinition => "geometry";

        /// <summary>
        /// Gets the db type.
        /// </summary>
        public override DbType DbType => DbType.Object;
    }
}