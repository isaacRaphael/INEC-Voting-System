using Models;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class VoterRegDTO
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        public PollingUnit PollingUnit { get; set; }

        public Gender Gender { get; set; }


    }
}
