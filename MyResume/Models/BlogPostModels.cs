using MyResume.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Models
{
    public class BlogPostModels
    {
        public string Title { get; private set; }
        public DateTime DatePosted { get; private set; }
        public string Content { get; private set; }
        public Guid ID { get; private set; }
        public List<JobTechnology> TechnologiesConcerned { get; private set; }

        /// <summary>
        /// BlogSportModels constructor
        /// </summary>
        /// <param name="_title">Title</param>
        /// <param name="_content">Content</param>
        /// <param name="_datePosted">Date of posting</param>
        /// <param name="_technologiesConcerned">List of technologies concerned</param>
        public BlogPostModels(string _title, string _content, DateTime _datePosted, List<JobTechnology> _technologiesConcerned)
        {
            this.ID = new Guid();
            this.Title = _title;
            this.Content = _content;
            this.DatePosted = _datePosted;
            this.TechnologiesConcerned = _technologiesConcerned;
        }
    }
}