using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Party
    {
        public int Id { get; set; }
        public string PartyName { get; set; }
        public int PartyTypeID { get; set; }

        public override string ToString()
        {
            return $"ID#:{Id.ToString()},PartyName:{PartyName}, PartyTypeID:{PartyTypeID.ToString()}";
        }
    }
}
