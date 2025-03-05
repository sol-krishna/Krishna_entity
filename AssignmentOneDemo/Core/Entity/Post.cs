using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Post :BaseEntity
    {
        public string Title { get; set; }

        [Column(TypeName = "varchar")]
        public string? Content { get; set; }

        [ForeignKey(nameof(PostType))]
        public Guid PostTypeId { get; set; }

        [ForeignKey(nameof(Blog))]
        public Guid BlogId { get; set; }

        [ForeignKey(nameof(Person))]
        public Guid UserId { get; set; }

        public PostType PostType { get; set; }
        public Blog Blog { get; set; }
        public Person Person { get; set; }
    }
}
