// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BrandsController.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the BrandsController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Web.Controllers.Odata
{
    using System;
    using System.Linq;

    using InSitu.Data.Models.CarInformation;
    using InSitu.Data.Repositories;

    /// <inheritdoc />
    /// <summary>
    /// The brands controller.
    /// </summary>
    public class BrandsController : OdataBaseController<Brand, int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandsController"/> class.
        /// </summary>
        /// <param name="repository">
        /// The repository.
        /// </param>
        public BrandsController(BaseRepository<Brand> repository)
            : base(repository)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// The create single.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Linq.IQueryable" />.
        /// </returns>
        /// <exception cref="T:System.NotImplementedException">
        /// </exception>
        public override IQueryable<Brand> CreateSingle(int key)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// The entity exists.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Boolean" />.
        /// </returns>
        /// <exception cref="T:System.NotImplementedException">
        /// </exception>
        public override bool EntityExists(int key)
        {
            return this.Repository.All().Any(x => x.Id == key);
        }

        /// <summary>
        /// The entity exists.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public override bool EntityExists(Brand entity)
        {
            return this.EntityExists(entity.Id);
        }
    }
}
