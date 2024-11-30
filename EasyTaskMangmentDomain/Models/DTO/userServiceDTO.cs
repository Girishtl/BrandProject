using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Models.DTO
{
    public class userServiceDTO
    {
        public int Id { get; set; }                           // ID of the service
        public string ServiceName { get; set; }               // Name of the service
        public decimal ServiceCost { get; set; }              // Cost of the service
        public string ServiceDescription { get; set; }         // Description of the service
        public bool IsActive { get; set; }                     // Indicates if the service is active
        public DateTime CreatedDate { get; set; }             // Date the service was created
        public DateTime? ModifiedDate { get; set; }           // Date the service was last modified
        public string CreatedBy { get; set; }                  // User who created the service
        public string ModifiedBy { get; set; }                 // User who last modified the service
        public string DeletedBy { get; set; }                  // User who deleted the service (if applicable)
        public DateTime? DeletedDate { get; set; }
    }
}
