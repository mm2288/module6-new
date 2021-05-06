using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.RequestFeatures
{
    public class OrganizationParameters : RequestParameters
    {
        public string FilterCity { get; set; }
        public string SearchTerm { get; set; }
    }
}
