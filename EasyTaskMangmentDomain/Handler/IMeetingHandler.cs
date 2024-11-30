using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Handler
{
   
        public interface IMeetingHandler
    {
            // Method to get all active leads
            Task<List<MeetingResponse>> GetAllActiveMeet();

            // Method to insert a new lead
            Task<int> InsertMeet(CreateMeetingRequest createUser);

            // Method to update an existing lead
            Task<bool> UpdateMeet(UpdateMeetingRequest updateUserRequest);

        // Method to delete a lead
        public Task<bool> DeleteMeet(int id);
        }
    
}
