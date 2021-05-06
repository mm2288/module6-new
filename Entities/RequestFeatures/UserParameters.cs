using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.RequestFeatures
{
    public class UserParameters : RequestParameters
    {
        public UserParameters()
        {
            OrderBy = "name";
        }
        public string SearchTerm { get; set; }
    }
}
