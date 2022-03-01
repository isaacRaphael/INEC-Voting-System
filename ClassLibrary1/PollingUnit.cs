using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class PollingUnit : BaseEntity
    {
        public string Unit_No { get; set; }

        [RegularExpression(@"^[A-Z]{3}$")]
        public string  LocalGovernment { get; }
        public ICollection<Voter> Voters { get; set; }
        public string PollingUnitCode { get; set; }

        public PollingUnit(string LGA)
        {
            LocalGovernment = LGA;
            Unit_No = $"{ LocalGovernment }-{ Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6) }";
            PollingUnitCode = Unit_No.Substring(0, 7);
        }

        public PollingUnit(string id, string LGA , string unitNo) : base(id)
        {
            LocalGovernment = LGA;
            Unit_No = unitNo;
            PollingUnitCode = Unit_No.Substring(0, 7);
        }
    }
}


