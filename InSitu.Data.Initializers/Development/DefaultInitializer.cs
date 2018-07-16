// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultInitializer.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the DefaultInitializer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Initializers.Development
{
    using System.Data.Entity;

    using InSitu.Data.Contexts;
    using InSitu.Data.Models.CarInformation;

    /// <inheritdoc />
    /// <summary>
    /// The default initializer.
    /// </summary>
    public class DefaultInitializer : DropCreateDatabaseAlways<InSituContext>
    {
        protected override void Seed(InSituContext context)
        {
            Seeder.Initialize(context);
        }
    }
}
