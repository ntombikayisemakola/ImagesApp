using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();
        public string TagName { get; set; } = string.Empty;
    }
}