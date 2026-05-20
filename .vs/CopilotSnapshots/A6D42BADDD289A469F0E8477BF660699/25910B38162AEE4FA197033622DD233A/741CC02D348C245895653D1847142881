using System;
using System.Collections.Generic;
using System.Text;
using ToDoListApi.Business.Auth;

namespace Business.Services.Abstract
{
    public interface IAuthService 
    {
        Task<string> LoginAsync(string username, string password);
        Task<string> RegisterAsync(RegisterDTO model);
    }
}
