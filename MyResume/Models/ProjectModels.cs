using MyResume.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Models
{
    public class ProjectModels
    {
        public string Title { get; private set; }
        public string Comment { get; private set; }
        public string LinkGitHub { get; private set; }
        public string Link { get; private set; }
        public List<JobTechnology> TechnologiesUsed { get; private set; }

        /// <summary>
        /// ProjectModels constructor
        /// </summary>
        /// <param name="_title">Title</param>
        /// <param name="_startDate">Starting date</param>
        /// <param name="_endDate">Ending date</param>
        /// <param name="_comment">Comment</param>
        /// <param name="_linkGitHub">Ling to github</param>
        /// <param name="_link">link to website</param>
        /// <param name="_technologiesUsed">List of technologies concerned</param>
        public ProjectModels(string _title, string _comment, string _linkGitHub, string _link, List<JobTechnology> _technologiesUsed)
        {
            this.Title = _title;
            this.Comment = _comment;
            this.LinkGitHub = _linkGitHub;
            this.Link = _link;
            this.TechnologiesUsed = _technologiesUsed;
        }
    }
}