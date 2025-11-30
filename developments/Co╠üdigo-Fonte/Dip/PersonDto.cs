using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples.Dip
{
    public class PersonDto
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public DateTime BirthDate { get; set; }
    }
}