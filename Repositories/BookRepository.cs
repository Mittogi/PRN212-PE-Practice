using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {
        //class này sẽ cung cấp data cho bên services từ bên table thực sự và nó cũng chịu trách nhiệm nhận data từ service đẩy xuống DB
        //UI -------- BookServices -------BookRepo --------- Book class --------- table thực sự
        //                                Container
        //                                Cabinet
        //Nó cần đến class đặc biệt tự sinh ra hồi nãy tên là:
        //BookManagementDbContext, class này chơi trực tiếp SQL server, tự nó sinh ra câu select, lấy data đập ngược trở lại class book
        private BookManagementDbContext _context; //Lưu ý không new, dùng đến đâu new đến đó!!! CỰC KỲ LƯU Ý!!!!!

        public List<Book> GetBooks()
        {
            //Đây là hàm trả về tất cả các cuốn sách từ table thực sự
            _context = new BookManagementDbContext();
            return _context.Books.ToList(); //select * from
        }

        public void DeleteBook(Book book)
        {
            //Đừng quên new trước khi làm gì với DB context
            _context = new BookManagementDbContext();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public void AddBook(Book book)
        {
            _context = new BookManagementDbContext();//Luôn nhớ new DBContext trước bất kì hành động nào trên table
            _context.Books.Add(book);//mới vào ram
            _context.SaveChanges();//Hàm class Cha DBContext
        } //Bắt ngoại lệ: Trùng PK khi add thêm 1 cuốn sách
          //Chat GPT hỏi: How to capture duplicate primary key exception when create a new Book record in C# using EF Core and DBContext

        public void UpdateBook(Book book)
        {
            _context = new BookManagementDbContext();//Luôn nhớ new DBContext trước bất kì hành động nào trên table
            _context.Books.Update(book);//mới vào ram
            _context.SaveChanges();//Hàm class Cha DBContext
        }
        //Add update đều có thể bị 1 cái exception khác là cột not null
        //Dùng try-catch
        //Và bắt thêm validation ở trên UI - PHẢI CỐ GẮNG LÀM Ở UI - FORM ĐỂ ĐẠT ĐIỂM TỐI ĐA
        //1 vài câu if() trên các control/tag: textbox/dropdown
        //Chat GPT: How to check not null, empty of a textbox in C#
    }
}
