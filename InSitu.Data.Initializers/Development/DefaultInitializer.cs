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
        /// <inheritdoc />
        /// <summary>
        /// The seed.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        protected override void Seed(InSituContext context)
        {
            var brands = new[]
                             {
                                 new Brand { Name = "AUDI" },          new Brand { Name = "MAZDA" },
                                 new Brand { Name = "BMW" },           new Brand { Name = "MAHINDRA" },
                                 new Brand { Name = "CITROEN" },       new Brand { Name = "MERCEDES" },
                                 new Brand { Name = "CHEVROLET" },     new Brand { Name = "MASHIDA" },
                                 new Brand { Name = "DAIHATSU" },      new Brand { Name = "MERCURY" },
                                 new Brand { Name = "DOGGE" },         new Brand { Name = "MITSUBISCHI" },
                                 new Brand { Name = "DONHFEING" },     new Brand { Name = "MACK" },
                                 new Brand { Name = "FORD" },          new Brand { Name = "NISSAN" },
                                 new Brand { Name = "FIAT" },          new Brand { Name = "OPEL" },
                                 new Brand { Name = "FREIGHTLINER" },  new Brand { Name = "PONTIAC" },
                                 new Brand { Name = "GMC" },           new Brand { Name = "PORCH" },
                                 new Brand { Name = "HINO" },          new Brand { Name = "PEUGOT" },
                                 new Brand { Name = "HYUNDAI" },       new Brand { Name = "RENAUÑD" },
                                 new Brand { Name = "HONDA" },         new Brand { Name = "SUZUKI" },
                                 new Brand { Name = "INTERNATIONAL" }, new Brand { Name = "SKODA" },
                                 new Brand { Name = "ISUZU" },         new Brand { Name = "SAN JOHN" },
                                 new Brand { Name = "JMC" },           new Brand { Name = "SUBARU" },
                                 new Brand { Name = "JEEP" },          new Brand { Name = "SEAT" },
                                 new Brand { Name = "KIA" },           new Brand { Name = "SION" },
                                 new Brand { Name = "LINCOL" },        new Brand { Name = "SKODA" },
                                 new Brand { Name = "LEXUS" },         new Brand { Name = "TOYOTA" },
                                 new Brand { Name = "VW" },            new Brand { Name = "VOLVO" }
                             };

            context.Brands.AddRange(brands);
            context.SaveChanges();
        }
    }
}
