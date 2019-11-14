using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class PeopleViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<Friend> Friends { get; set; }
    }
}