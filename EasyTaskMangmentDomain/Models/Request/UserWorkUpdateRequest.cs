using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Models.Request
{
    public class UserWorkUpdateRequest
    {
        public int Id { get; set; }
        public string WorkName { get; set; }                  // Maps to "workname" column
        public decimal WorkCost { get; set; }                 // Maps to "workcost" column
        public string WorkDescription { get; set; }           // Maps to "workdescription" column
        public int? ServiceId { get; set; }

        public string ModifiedBy { get; set; }
       
    }
}
