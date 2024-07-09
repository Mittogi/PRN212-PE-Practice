using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicves
{
    public class UserServices
    {
        UserRepository _repo = new UserRepository();
        
        public UserAccount? CheckLogin(string email, string password)
        {
            return _repo.GetAccount(email, password);
        }

    }
}
