using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Models.DTO
{
    public   class UserWorkDetailDTO
    {
        public int Id { get; set; }                           // Maps to "id" column
        public string WorkName { get; set; }                  // Maps to "workname" column
        public decimal WorkCost { get; set; }                 // Maps to "workcost" column
        public string WorkDescription { get; set; }           // Maps to "workdescription" column
        public int? ServiceId { get; set; }                   // Maps to "serviceid" column (nullable if foreign key might be empty)
        public DateTime CreatedDate { get; set; }             // Maps to "createddate" column
        public DateTime? ModifiedDate { get; set; }           // Maps to "modifieddate" column (nullable)
        public string CreatedBy { get; set; }                 // Maps to "createdby" column
        public string ModifiedBy { get; set; }                // Maps to "modifiedby" column
        public string DeletedBy { get; set; }                 // Maps to "deletedby" column
        public DateTime? DeletedDate { get; set; }
    }
}
