using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace api.Models
{
    public class Image
    {
        public int Id { get; set; }
        public List<Comment> Comments = new List<Comment>();
        public List<Tag> Tags { get; set; } = new List<Tag>();
        public string ImageTitle {get; set; } = string.Empty;
        public string ImageDescription {get; set;} = string.Empty;
        public string ImageUrl {get; set;} = string.Empty;
        public DateTime ImageUploadDate{get; set;} = DateTime.Now;
        public DateTime? ImageDeletedDate{get; set;}
    }
}