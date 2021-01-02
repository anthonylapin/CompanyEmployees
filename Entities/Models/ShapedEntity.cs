using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Entities.Models
{
    public class ShapedEntity
    {
        public ExpandoObject Entity { get; set; }
        public Guid Id { get; set; }

        public ShapedEntity()
        {
            Entity = new ExpandoObject();
        }
    }
}
