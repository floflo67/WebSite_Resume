using MyResume.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Models
{
    public class JobModels
    {
        public string Company { get; private set; }
        public string City { get; private set; }
        public string Title { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Comment { get; private set; }
        public List<JobTechnology> TechnologiesUsed { get; private set; }

        /// <summary>
        /// JobModels constructor
        /// </summary>
        /// <param name="_company">Company name</param>
        /// <param name="_city">City name</param>
        /// <param name="_title">Title</param>
        /// <param name="_comment">Comment</param>
        /// <param name="_startDate">Starting date</param>
        /// <param name="_endDate">Ending date</param>
        /// <param name="_technologiesUsed">List of technologies concerned</param>
        public JobModels(string _company, string _city, string _title, string _comment, DateTime _startDate, DateTime _endDate, List<JobTechnology> _technologiesUsed)
        {
            this.Company = _company;
            this.City = _city;
            this.Title = _title;
            this.StartDate = _startDate;
            this.EndDate = _endDate;
            this.Comment = _comment;
            this.TechnologiesUsed = _technologiesUsed;
        }
    }
}