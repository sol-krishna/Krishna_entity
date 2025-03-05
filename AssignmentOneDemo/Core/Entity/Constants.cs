using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Constants : BaseEntity
    {
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"Constant Name: {Name}, Constant Value: {Value}, Constant Id {EntityId}";
        }
    }
}
