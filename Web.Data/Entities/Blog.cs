using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("Blogs")]
    public class Blog : DomainEntity<int>, IDateTracking, IHasSeoMetaData, ISwitchable

    {
        public Blog(int id,string name, string image, string content, string discription, string tags, Status status, string seopageTitle, string seoAlias, string seoKeywords, string seoDescription, DateTime dateCreated, DateTime dateModified)
        {
            this.Id = id;
            this.Name = name;
            this.Image = image;
            this.Content = content;
            this.Discription = discription;
            this.Tags = tags;
            this.Status = status;
            this.SeopageTitle = seopageTitle;
            this.SeoAlias = seoAlias;
            this.SeoKeywords = seoKeywords;
            this.SeoDescription = seoDescription;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;

        }
        public Blog(string name, string image, string content, string discription, string tags, Status status, string seopageTitle, string seoAlias, string seoKeywords, string seoDescription, DateTime dateCreated, DateTime dateModified)
        {
            this.Name = name;
            this.Image = image;
            this.Content = content;
            this.Discription = discription;
            this.Tags = tags;
            this.Status = status;
            this.SeopageTitle = seopageTitle;
            this.SeoAlias = seoAlias;
            this.SeoKeywords = seoKeywords;
            this.SeoDescription = seoDescription;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;

        }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        [MaxLength(500)]
        public string Discription { get; set; }
        public string Tags { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<BlogTag> BlogTag { get; set; }
        [MaxLength(256)]
        public string SeopageTitle { get; set; }
        [MaxLength(256)]
        public string SeoAlias { get; set; }
        [MaxLength(256)]
        public string SeoKeywords { get; set; }
        [MaxLength(256)]
        public string SeoDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}