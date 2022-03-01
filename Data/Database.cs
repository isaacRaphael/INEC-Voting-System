using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Database
    {
        public  IList<Voter> VoterTable { get; set; } = new List<Voter>();
        public  IList<Party> PartyTable { get; set; } = new List<Party>();
        public  IList<Candidate> CandidateTable { get; set; }=  new List<Candidate>();
        public  IList<Election> ElectionTable { get; set; } = new List<Election>();
        public  IList<PollingUnit> PollingUnitTable { get; set; } = new List<PollingUnit>();
        
    }
}
