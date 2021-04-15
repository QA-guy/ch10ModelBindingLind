using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all-all";
            string[] filters = FilterString.Split('-');
            SprintId = filters[0];
            //PointValue = filters[1];
            StatusId = filters[1];

        }
        public string FilterString { get; }
        public string SprintId { get; }
        public string PointValue { get; }
        public string StatusId { get; }

        public bool HasSprint => SprintId.ToLower() != "all";
        //public bool HasPoint => PointValue.ToLower() != "all";
        public bool HasStatus => StatusId.ToLower() != "all";

        //public static Dictionary<string, string> PointFilterValues =>
        //    new Dictionary<string, string>
        //    {
        //        {"1","1" },
        //        {"2","2" },
        //        {"3","3" },
        //        {"5","5" },
        //        {"8","8" }
        //    };
        
    }
}
