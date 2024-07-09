using Microsoft.VisualBasic;
using Repositories.Entities;
using Servicves;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_VoThanhPhat
{
    public partial class BookDetail : Form
    {
        private BookCategorySevices _cate = new BookCategorySevices();

        public int OpenMode { get; set; } //1: Create | 0: Update
        public Book SelectedBook { get; set; } // dùng để nhận cuốn sách từ bên form Cha gửi sang ở chế độ edit
        public BookDetail()
        {
            InitializeComponent();
        }

        private void BookDetail_Load(object sender, EventArgs e)
        {
            //Làm nhiều việc khi mà hình này được new và show
            //Nếu màn hình này đến từ nút bấm [Create]
            //Nếu màn hình này đến từ nút bấm [Edit]

            //kiểu gì cũng phải đổ Category và danh sách xổ xuống - danh sách Tỉnh, Huyện, Quốc gia ở địa chỉ giao hàng
            //Ta gọi CategoryService class để đưa data

            //<img src=>

            cboCategory.DataSource = _cate.GetAllBookCategories();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";
            //Khi user chọn danh sách xổ 1 dòng nào đó, thì ta lưu lại cái value id vừa được chọn để lát dùng cho table Book -> cột category id
            //Nếu user chọn 1 dòng, thì vào .SelectedValue để lấy đúng cái id user chọn
            if (OpenMode == 1)
            {
                //Để form trống trơn, ngoại trừ combobox cate phải đổ vào bất chấp mode, đã làm ở trên
                //Đổ label cho rõ ràng
                lblHeader.Text = "Tạo mới cuốn sách";
            }
            else
            {
                lblHeader.Text = "Cập nhật cuốn sách";
                //jump đến mã loại sách edit
                //Nếu sách đang là sách trinh thám, id 2, jump đến số 2
                cboCategory.SelectedValue = SelectedBook.BookCategoryId;

                //Biến selectedBook có value
                txtBookID.Enabled = false;//Không cho edit id
                txtBookName.Text = SelectedBook.BookName;
                txtDescription.Text = SelectedBook.Description;
                txtPrice.Text = SelectedBook.Price.ToString();
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtAuthor.Text = SelectedBook.Author.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Ta tạo mới 1 cuốn sách để gửi xuống Services
            //Services gửi xuống Repo
            //Repo lại gọi DBContext
            //new Book có 2 dạng: new mới tinh | Hoặc new dành cho update, new Book() gửi xuống các hàm Services
            Book b = new Book()
            {
                BookId = int.Parse(txtBookID.Text.Trim()),
                BookName = txtBookName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                Price = double.Parse(txtPrice.Text.Trim()),
                Author = txtAuthor.Text.Trim(),
                BookCategoryId = (int)cboCategory.SelectedValue
            };
            //BookId txtBookId có 

            BookServices service = new BookServices();

            if (OpenMode == 1)
            {
                service.AddBook(b);
                MessageBox.Show("Create book successfully", "Create result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                service.UpdateBook(b);
                MessageBox.Show("Update book successfully", "Update result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();//đóng chính mình trở lại form chính và F5

            //Lấy value đã chọn ở combo box và show kiểm tra
            //string selectedCate = cboCategory.SelectedValue.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
