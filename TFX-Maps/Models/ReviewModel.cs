using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TFX_Maps.Models
{
    public class ReviewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime ReviewDate { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public string Author { get; set; }
        public string AuthorEmail { get; set; } = null;
        public Uri DownloadUrl { get; set; } = null;
        public Uri HomepageUrl { get; set; } = null;
        public int Score { get; set; }
        public double UserRating { get; set; }
        public int UserVotes { get; set; }
        public int Architecture { get; set; }
        public int Layout { get; set; }
        public int Funness { get; set; }
        public int Originality { get; set; }
        public int Balance { get; set; }
        public string Review { get; set; }
        public string Reviewer { get; set; }

    }
}