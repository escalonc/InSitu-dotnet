// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseRepository.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Provides all methods for CRUD.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;

    using InSitu.Data.Contexts;

    /// <summary>
    /// Provides all methods for CRUD.
    /// </summary>
    /// <typeparam name="TEntity">
    /// The Entity type object.
    /// </typeparam>
    public abstract class BaseRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        protected BaseRepository(
            InSituContext context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        public InSituContext Context { get; protected set; }

        /// <summary>
        /// When is override in a deriver type, returns all the elements in the entity set.
        /// </summary>
        /// <returns>
        /// An <see cref="IQueryable"/> for all the elements in the entity set
        /// </returns>
        public abstract IQueryable<TEntity> All();

        /// <summary>
        /// Filters an entity set of values based on a predicate.
        /// </summary>
        /// <param name="predicate">
        ///     An expression to test each element for a condition.
        /// </param>
        /// <returns>
        /// An <see cref="IQueryable"/> that contains elements from the input sequence that satisfy the condition specified by predicate.
        /// </returns>
        public virtual IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
        {
            return this.All().Where(predicate);
        }

        /// <summary>
        /// Projects each element of a sequence into a new form.
        /// </summary>
        /// <param name="predicate">
        /// A sequence of values to project.
        /// </param>
        /// <typeparam name="TResult">
        /// The type of the elements of source.
        /// </typeparam>
        /// <returns>
        /// An <see cref="IQueryable"/> whose elements are the result of invoking a projection function on each element of source.
        /// </returns>
        public virtual IQueryable<TResult> Project<TResult>(Expression<Func<TEntity, TResult>> predicate)
        {
            return this.All().Select(predicate);
        }

        /// <summary>
        /// Returns the first element of a sequence.
        /// </summary>
        /// <param name="predicate">
        /// An expression to return the first element of a condition.
        /// </param>
        /// <returns>
        /// The first element that satisfies the condition.
        /// </returns>
        public virtual TEntity First(Expression<Func<TEntity, bool>> predicate)
        {
            return this.Filter(predicate).First();
        }

        /// <summary>
        /// Returns the first element of a sequence.
        /// </summary>
        /// <param name="predicate">
        /// An expression to return the first element of a condition.
        /// </param>
        /// <returns>
        /// The first element that satisfies the condition.
        /// </returns>
        public virtual Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return this.Filter(predicate).FirstAsync();
        }

        /// <summary>
        /// Find a entity in database.
        /// </summary>
        /// <param name="keys">
        /// Entity identifier.
        /// </param>
        /// <returns>An entity type.</returns>
        public virtual TEntity Find(params object[] keys)
        {
            return ((DbSet<TEntity>)this.All()).Find(keys);
        }

        /// <summary>
        /// /// Search entities in asynchronous way.
        /// </summary>
        /// <param name="keys">Entity identifier.</param>
        /// <returns>A task of the entity.</returns>
        public virtual Task<TEntity> FindAsync(params object[] keys)
        {
            return this.FindAsync(CancellationToken.None, keys);
        }

        /// <summary>
        /// Search entities in asynchronous way.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="keys">Entity identifier.</param>
        /// <returns>A task of the entity.</returns>
        public virtual Task<TEntity> FindAsync(CancellationToken token, params object[] keys) => 
            ((DbSet<TEntity>)this.All()).FindAsync(token, keys);

        /// <summary>
        /// Returns the first element of the entity set with the specified condition, or a default value if the entity set contains no elements.
        /// </summary>
        /// <param name="predicate">
        /// A function to test each element for a condition.
        /// </param>
        /// <returns>
        /// default value, if the source is empty; otherwise, the first element in source.
        /// </returns>
        public virtual TEntity FirstOrDefault(Func<TEntity, bool> predicate)
        {
            return this.All().FirstOrDefault(predicate);
        }

        /// <summary>
        /// Returns the first element of the entity set with the specified condition, or a default value if the entity set contains no elements.
        /// </summary>
        /// <param name="predicate">
        /// A function to test each element for a condition.
        /// </param>
        /// <returns>
        /// default value, if the source is empty; otherwise, the first element in source.
        /// </returns>
        public virtual Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return this.All().FirstOrDefaultAsync(predicate);
        }

        /// <summary>
        /// Marks the entity as added
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The entity with its state marked as added.
        /// </returns>
        public virtual TEntity Create(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Added;
            return entity;
        }

        /// <summary>
        /// Marks the entity as modified.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The entity with its state marked as modified.
        /// </returns>
        public virtual TEntity Update(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Modified;
            return entity;
        }

        /// <summary>
        /// Marks the entity as deleted.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The entity with its state marked as deleted.
        /// </returns>
        public virtual TEntity Delete(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Deleted;
            return entity;
        }

        /// <summary>
        /// Copy values of new entity to old entity, new entity is marked as detached, and old entity is marked as modified.
        /// </summary>
        /// <param name="oldEntity">
        /// The old entity.
        /// </param>
        /// <param name="newEntity">
        /// The new entity.
        /// </param>
        /// <returns>
        /// The modified entity
        /// </returns>
        public virtual TEntity Update(TEntity oldEntity, TEntity newEntity)
        {
            var newEntry = this.Context.Entry(newEntity);
            newEntry.State = EntityState.Detached;

            var oldEntry = this.Context.Entry(oldEntity);
            oldEntry.State = EntityState.Modified;

            return this.MapNewValuesToOld(oldEntity, newEntity);
        }

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public virtual int SaveChanges()
        {
            return this.Context.SaveChanges();
        }

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public virtual Task<int> SaveChangesAsync()
        {
            return this.Context.SaveChangesAsync();
        }

        /// <summary>
        /// Set the new entity values, to old entity instance that is obtained from the database.
        /// </summary>
        /// <param name="oldEntity">
        /// The old entity.
        /// </param>
        /// <param name="newEntity">
        /// The new entity.
        /// </param>
        /// <returns>
        /// The old entity with its state marked as modified.
        /// </returns>
        protected abstract TEntity MapNewValuesToOld(TEntity oldEntity, TEntity newEntity);
    }
}
