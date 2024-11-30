using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Handler
{
   
        public interface ILeadsHandler
        {
            // Method to get all active leads
            Task<List<LeadsResponse>> GetAllActiveLeads();

            // Method to insert a new lead
            Task<int> InsertLeads(CreateLeadRequest createUser);

            // Method to update an existing lead
            Task<bool> UpdateLeads(UpdateLeadRequest updateUserRequest);

            // Method to delete a lead
            Task<bool> DeleteLeads(int id);
        }
    
}
