using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDateTime = DateTime.Now;
        }

        [Required]
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }

        [Key]
        [Column("Id", Order = 0)]
        public Guid EntityId { get; set; }

        [NotMapped]
        public Guid GetId
        {
            get { return EntityId; }
        }
    }
}
