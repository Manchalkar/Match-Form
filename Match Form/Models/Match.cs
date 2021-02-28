using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Match_Form.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string MatchName { get; set; }
        [DataType(DataType.Date)]
        public DateTime MatchDate { get; set; }
        public string TeamOne { get; set; }
        public string TeamTwo { get; set; }
        public String Address { get; set; }
        public String StartTime { get; set; }
    }
}
