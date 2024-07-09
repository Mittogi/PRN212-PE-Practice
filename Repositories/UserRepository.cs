using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository
    {
        private BookManagementDbContext _context;
        //Class này chơi với table UserAccount chứa các object/dòng của class entity tên là User Account
        //Ta không load hết các account, mà ta chỉ cần where cái account có user/pass được gõ từ form login
        //Hoặc trả về null, hoặc trả về object UserAccount full thông tin: id, email, pass, fullname, role

        public UserAccount? GetAccount(string email, string password)
        {
            _context = new BookManagementDbContext();

            return _context.UserAccounts.FirstOrDefault(x => x.Email == email && x.Password == password);
            //Nhận vào từng UserAccount và quyết định xài được UserAccount này hay không được: Đúng email và đúng pass là acc mình cần
            
        }
    }
}
