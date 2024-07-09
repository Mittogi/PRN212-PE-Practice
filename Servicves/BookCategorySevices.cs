using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Entities;

namespace Servicves
{
    public class BookCategorySevices
    {
        private BookCategoryRepository _repo = new BookCategoryRepository();

        public List<BookCategory> GetAllBookCategories()
        {
            return _repo.GetBookCategories();
        }
    }
}
