using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Entities.LinkModels
{
    public class LinkResponse
    {
        public bool HasLinks { get; set; }
        public List<ExpandoObject> ShapedEntities { get; set; }
        public LinkCollectionWrapper<ExpandoObject> LinkedEntities { get; set; }

        public LinkResponse()
        {
            LinkedEntities = new LinkCollectionWrapper<ExpandoObject>();
            ShapedEntities = new List<ExpandoObject>();
        }
    }
}
