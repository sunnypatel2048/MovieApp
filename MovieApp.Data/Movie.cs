﻿using System.ComponentModel.DataAnnotations;

namespace MovieApp.Data
{
    /// <summary>The Movie Class</summary>
    public class Movie
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>Gets or sets the title.</summary>
        /// <value>The title.</value>
        [Required]
        public string? Title { get; set; }

        /// <summary>Gets or sets the year.</summary>
        /// <value>The year.</value>
        public int Year { get; set; }

        /// <summary>Gets or sets the summary.</summary>
        /// <value>The summary.</value>
        public string? Summary { get; set; }

        /// <summary>Gets or sets the actors.</summary>
        /// <value>The actors.</value>
        [MaxLength(3)]
        public List<Actor>? Actors { get; set; }

        /// <summary>Gets or sets the directors.</summary>
        /// <value>The directors.</value>
        [MaxLength(2)]
        public List<Director>? Directors { get; set; } 
    }
    
    /// <summary>The Actor Class</summary>
    public class Actor
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>Gets or sets the full name.</summary>
        /// <value>The full name.</value>
        [Required]
        public string? FullName { get; set; }
    }

    /// <summary>The Director Class</summary>
    public class Director
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>Gets or sets the full name.</summary>
        /// <value>The full name.</value>
        [Required]
        public string? FullName { get; set; }
    }
}