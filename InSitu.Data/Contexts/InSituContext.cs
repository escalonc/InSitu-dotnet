// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InSituContext.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The in situ context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Contexts
{
    using System.Data.Entity;

    /// <inheritdoc />
    /// <summary>
    /// The in situ context.
    /// </summary>
    public class InSituContext : DbContext
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="InSituContext"/> class.
        /// </summary>
        public InSituContext()
            : base("DefultConnection")
        {
        }
    }
}
