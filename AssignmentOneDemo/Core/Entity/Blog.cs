using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Blog : BaseEntity
    {
        [MaxLength(150)]
        public string Url { get; set; }
        public bool IsPublic { get; set; }
        [ForeignKey(nameof(BlogType))]
        public Guid BlogTypeId { get; set; }
        public BlogType BlogType { get; set; }
    }
}
