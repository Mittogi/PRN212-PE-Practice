using Repositories.Entities;
using Servicves;

namespace BookManagement_VoThanhPhat
{
    public partial class BookManager : Form
    {
        //Khai báo BookService ở đây dùng trong các hàm của màn hình chính: GetBooks() DeleteBook...
        private BookServices _service = new BookServices();
        public BookManager()
        {
            InitializeComponent();
        }

        public void BookManager_Load(object sender, EventArgs e)
        {
            //Lấy data đổ vào grid
            FillGrid(_service.GetAllBooks());
        }

        private void FillGrid(List<Book> list)
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = list;
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            BookDetail f = new BookDetail();
            f.OpenMode = 1;
            f.SelectedBook = null;
            //f.Show();
            f.ShowDialog(); //Không đóng cửa sổ này không cho quay về

            FillGrid(_service.GetAllBooks());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Kiểm tra coi user đã select dòng chưa thì mới mở màn hình detail
            if (dgvBookList.SelectedRows.Count == 0)
            {
                //Chưa chọn dòng nào
                MessageBox.Show("Please select 1 row to edit", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Thoát hàm sớm
            }
            //CPU chạy đến đây tức là user đã chọn ít nhất 1 dòng
            //Lấy ra dòng đầu tiên user đã chọn [0]
            Book selectedBook = dgvBookList.SelectedRows[0].DataBoundItem as Book;

            BookDetail f = new BookDetail();
            f.OpenMode = 0;
            f.SelectedBook = selectedBook;

            f.ShowDialog();

            FillGrid(_service.GetAllBooks());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Lấy được cái value người dùng nhập vào ô search
            //sau đó gửi cho BookService - sẽ xử lí việc search gần đúng trên tên sách
            //Sau đó BookService trả lại danh sách book thỏa điều kiện Search

            string keyword = txtSearch.Text.Trim().ToLower();
            //Biến keyword thành chữ thường, lát hồi so sánh cuốn sách chữ thường == nhau

            //BookService cần thêm hàm Search(), Update(), Delete()
            List<Book> result = _service.GetAllBooks().Where(b => b.BookName.ToLower().Contains(keyword)).ToList();

            //đổ vào grid
            FillGrid(result);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count == 0)
            {
                //Chưa chọn dòng nào
                MessageBox.Show("Please select 1 row to delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Thoát hàm sớm
            }

            Book selectedBook = dgvBookList.SelectedRows[0].DataBoundItem as Book; 

            //Có muốn xóa
            DialogResult answer = MessageBox.Show("Are you sure to delete", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
                return;

            //Yes, xóa thật
            //Lấy ra cuốn sách sẽ xóa
            _service.DeleteBook(selectedBook);

            //Refresh cái lưới
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _service.GetAllBooks();
        }
    }
}
