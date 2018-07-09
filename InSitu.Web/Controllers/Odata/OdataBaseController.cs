// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OdataBaseController.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the OdataBaseController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Web.Controllers.Odata
{
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Http;

    using InSitu.Data.Repositories;

    using Microsoft.AspNet.OData;

    /// <inheritdoc />
    /// <summary>
    /// OData controller with common actions.
    /// </summary>
    /// <typeparam name="TEntity">The entity.</typeparam>
    /// <typeparam name="TKey">The identifier.</typeparam>
    public abstract class OdataBaseController<TEntity, TKey> : ODataController
        where TEntity : class
    {
        /// <summary>
        /// The repository.
        /// </summary>
        private readonly BaseRepository<TEntity> repository;

        /// <summary>
        /// Gets the entity repository.
        /// </summary>
        protected BaseRepository<TEntity> Repository => this.repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="OdataBaseController{TEntity,TKey}"/> class. 
        /// </summary>
        /// <param name="repository">
        /// The entity repository.
        /// </param>
        protected OdataBaseController(BaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        [EnableQuery]
        public virtual IQueryable<TEntity> Get()
        {
            return this.repository.All();
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="SingleResult"/>.
        /// </returns>
        [EnableQuery]
        public SingleResult<TEntity> Get([FromODataUri] TKey key)
        {
            return SingleResult.Create(this.CreateSingle(key));
        }

        /// <summary>
        /// The put.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <param name="patch">
        /// The patch.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IHttpActionResult> Put([FromODataUri] TKey key, Delta<TEntity> patch)
        {
            this.Validate(patch.GetInstance());

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            TEntity entity = await this.repository.FindAsync(key);
            if (entity == null)
            {
                return this.NotFound();
            }

            patch.Put(entity);

            try
            {
                await this.repository.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.EntityExists(key))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.Updated(entity);
        }

        /// <summary>
        /// The post.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IHttpActionResult> Post(TEntity entity)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.repository.Create(entity);

            try
            {
                await this.repository.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (this.EntityExists(entity))
                {
                    return this.Conflict();
                }
                else
                {
                    throw;
                }
            }

            return this.Created(entity);
        }

        /// <summary>
        /// The patch.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <param name="patch">
        /// The patch.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] TKey key, Delta<TEntity> patch)
        {
            this.Validate(patch.GetInstance());

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            TEntity entity = await this.repository.FindAsync(key);
            if (entity == null)
            {
                return this.NotFound();
            }

            patch.Patch(entity);

            try
            {
                await this.repository.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.EntityExists(key))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.Updated(entity);
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IHttpActionResult> Delete([FromODataUri] TKey key)
        {
            TEntity entity = await this.repository.FindAsync(key);
            if (entity == null)
            {
                return this.NotFound();
            }

            this.repository.Delete(entity);
            await this.repository.SaveChangesAsync();

            return this.StatusCode(HttpStatusCode.NoContent);
        }

        /// <summary>
        /// The create single.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public abstract IQueryable<TEntity> CreateSingle(TKey key);

        /// <summary>
        /// The entity exists.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public abstract bool EntityExists(TKey key);

        /// <summary>
        /// The entity exists.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public abstract bool EntityExists(TEntity entity);
    }
}
