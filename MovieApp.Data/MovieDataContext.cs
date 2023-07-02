﻿using Microsoft.EntityFrameworkCore;

namespace MovieApp.Data
{
    /// <summary>The MovieDataContext Class</summary>
    public class MovieDataContext : DbContext
    {
        /// <summary>Initializes a new instance of the <see cref="MovieDataContext" /> class.</summary>
        /// <param name="options">The options.</param>
        public MovieDataContext(DbContextOptions<MovieDataContext> options) : base(options) { }

        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1">DbSet</see> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">
        /// The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.
        /// </param>
        /// <remarks>
        ///   <para>
        /// If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)">UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)</see>)
        /// then this method will not be run. However, it will still run when creating a compiled model.
        /// </para>
        ///   <para>
        /// See <a href="https://aka.ms/efcore-docs-modeling">Modeling entity types and relationships</a> for more information and
        /// examples.
        /// </para>
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        /// <summary>Gets or sets the movies.</summary>
        /// <value>The movies.</value>
        public DbSet<Movie> Movies { get; set; }
        /// <summary>Gets or sets the actors.</summary>
        /// <value>The actors.</value>
        public DbSet<Actor> Actors { get; set; }
    }
}
