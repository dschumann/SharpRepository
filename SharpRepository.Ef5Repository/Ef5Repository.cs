﻿using System;
using System.Data.Entity;
using SharpRepository.Repository.Caching;

namespace SharpRepository.Ef5Repository
{
    /// <summary>
    /// Entity Framework repository layer
    /// </summary>
    /// <typeparam name="T">The Entity type</typeparam>
    /// <typeparam name="TKey">The type of the primary key.</typeparam>
    public class Ef5Repository<T, TKey> : Ef5RepositoryBase<T, TKey> where T : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EfRepository&lt;T, TKey&gt;"/> class.
        /// </summary>
        /// <param name="dbContext">The Entity Framework DbContext.</param>
        /// <param name="cachingStrategy">The caching strategy to use.  Defaults to <see cref="NoCachingStrategy&lt;T, TKey&gt;" /></param>
        public Ef5Repository(DbContext dbContext, ICachingStrategy<T, TKey> cachingStrategy = null) : base(dbContext, cachingStrategy)
        {
            if (dbContext == null) throw new ArgumentNullException("dbContext");
        }
    }

    /// <summary>
    /// Entity Framework repository layer
    /// </summary>
    /// <typeparam name="T">The Entity type</typeparam>
    public class Ef5Repository<T> : Ef5RepositoryBase<T, int> where T : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EfRepository&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="dbContext">The Entity Framework DbContext.</param>
        /// <param name="cachingStrategy">The caching strategy to use.  Defaults to <see cref="NoCachingStrategy&lt;T, TKey&gt;" /></param>
        public Ef5Repository(DbContext dbContext, ICachingStrategy<T, int> cachingStrategy = null) : base(dbContext, cachingStrategy)
        {
            if (dbContext == null) throw new ArgumentNullException("dbContext");
        }
    }
}