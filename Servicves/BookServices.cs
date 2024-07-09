using Repositories;
using Repositories.Entities;

namespace Servicves
{
    //class này chứa list các cuốn sách lấy từ db để đem lên cái Form
    //Nó cũng chứa các hành động: Lấy 1 cuốn sách đem lên form Edit
    //                            Xóa 1 cuốn
    //                            Update info 1 cuốn
    //                            Add new 1 cuốn
    //FORM/UI --------------- Serice ---------------- Repositories lên xuống DB
    //                        Xử lí Data trong ram
    //                        Trung gian giữa UI và DB
    public class BookServices
    {
        //Chưa có DB, tạm thời Hard-Code - cho sẵn Data tự new
        //Sau này lấy từ DB/Table Lên
        private BookRepository _repo = new BookRepository();
        public List<Book> GetAllBooks()
        {
            //Hàm sẽ trả về all sách từ table Books - sau này sẽ làm     
            return _repo.GetBooks();
        }

        public void DeleteBook(Book book)
        {
            _repo.DeleteBook(book); //Gọi repo delete dùm
        }

        public void AddBook(Book book)
        {
            _repo.AddBook(book);
        }

        public void UpdateBook(Book book) 
        {
            _repo.UpdateBook(book);
        }
    }
}
