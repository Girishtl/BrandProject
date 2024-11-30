using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentApplication.Handler
{
    public  interface IUserWorkHandler
    {
        public Task<List<UserWorkResponse>> GetUserServiceResponse();
       
        public Task<int> InsertUserServiceResponse(UserWorkCreateRequest userServiceResponse);
        public Task<bool> UpdateUserServiceResponse(UserWorkUpdateRequest userServiceResponse);

        public Task<bool> DeleteUserServiceResponse(int id);
    }
}
