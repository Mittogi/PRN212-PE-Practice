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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Gọi UserServices để gửi email/password xuống
            //Đến lượt UserServices lại gọi UserRepo
            //User Where table
            //Nếu thành công trả về gì?
            //Nếu thất bại trả về gì?
            //Thành công trả về full UserAccount oject gồm id, email, pass, fullname, role
            //Không thành công thì trả về null (Nếu ngon không thành công trả về sai pass, email không tồn tại - Thách thức vui hơn)
            //Thành công thêm bước checkrole == 1 admin new form mail
            //Mọi việc đã xong

            //Logic: UI - UserServices - UserRepo - DBContext

            UserServices service = new UserServices();
            UserAccount? account = service.CheckLogin(txtEmail.Text, txtPassword.Text);

            //MessageBox.Show(account.Email + " | " + account.Role);
            if (account == null)
            {
                MessageBox.Show("Invalid credentials. Please check email or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (account.Role != 1)
            {
                MessageBox.Show("You have no permission to access this function", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Ngon thì show main form
            BookManager mainForm = new BookManager();
            mainForm.Show();
            this.Hide();//Tạm ẩn chính mình, làm nền cho Main UI xuất hiện
            //Mình close thì app tắt
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
