using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JamWithMeSite.Models
{

    /// <summary>
    /// Represents an individual musician.
    /// </summary>
    public class Musician
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Whatever information the user is willing
        /// to provide. ex. (Why they are on the site)
        /// </summary>
        [Required]
        public string Description { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        /// <summary>
        /// The user's musical influences/interests.
        /// </summary>
        public Collection<string> Influences { get; }



    }


}
