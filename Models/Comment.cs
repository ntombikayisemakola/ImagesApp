using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int? ImageId { get; set; }
        public Image? Image{ get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set;} = DateTime.Now;
        public DateTime LastUpdatedOn { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
    }
}