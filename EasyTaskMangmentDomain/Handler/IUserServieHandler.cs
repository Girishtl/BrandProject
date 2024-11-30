using EasyTaskMangmentDomain.Handler;
using EasyTaskMangmentDomain.Models.DTO;
using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentApplication.Handler
{
    public  interface IUserServieHandler
    { 
        public Task<List<userServiceResponse>> GetUserServiceResponse();

        public Task<int> InsertUserServiceResponse(userServiceCreateRequest userServiceResponse);
        public Task<bool> UpdateUserServiceResponse(userServiceUpdateRequest userServiceResponse);

        public Task<bool> DeleteUserServiceResponse(int id);

    }
}
