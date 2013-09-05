using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeerBeerAwards.Models
{
    public class Nominee
    {
        public Nominee()
        {
            Awards = 1;
        }

        public int NomineeID { get; set; }

        public string Name { get; set; }

        public int Awards { get; set; }

        public bool IsNominated { get; set; }

        public string[] Nominators { get; set; }
    }
}
