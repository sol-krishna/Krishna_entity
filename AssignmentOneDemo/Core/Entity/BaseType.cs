using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public abstract class BaseType : BaseEntity
    {
        [ForeignKey(nameof(Constants))]
        public Guid StatusId { get; set; }
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public Constants Constants { get; set; }
    }
}
