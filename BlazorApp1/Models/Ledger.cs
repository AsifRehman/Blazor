using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Ledger
    {
        public int Id { get; set; } 
        public string TType { get; set; }
        public int VocNo { get; set; }
        public int SrNo { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
        public int PartyID { get; set; }
        public string Description { get; set; }
        public int NetDebit { get; set; }
        public int NetCredit { get; set; }
    }
}
