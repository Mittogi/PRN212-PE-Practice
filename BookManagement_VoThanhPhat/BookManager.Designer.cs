namespace BookManagement_VoThanhPhat
{
    partial class BookManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            dgvBookList = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            grbSearch = new GroupBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            grbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Red;
            lblHeader.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(597, 106);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(12, 287);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(748, 308);
            dgvBookList.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(811, 287);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(283, 63);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create a book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(811, 369);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(283, 63);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(811, 449);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(283, 63);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(811, 532);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(283, 63);
            btnExit.TabIndex = 4;
            btnExit.Text = "Quit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // grbSearch
            // 
            grbSearch.Controls.Add(txtSearch);
            grbSearch.Controls.Add(btnSearch);
            grbSearch.Controls.Add(lblSearch);
            grbSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbSearch.ForeColor = Color.Yellow;
            grbSearch.Location = new Point(12, 128);
            grbSearch.Name = "grbSearch";
            grbSearch.Size = new Size(1082, 113);
            grbSearch.TabIndex = 0;
            grbSearch.TabStop = false;
            grbSearch.Text = " Search criteria ";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(246, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(447, 51);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(815, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(261, 57);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(6, 43);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(206, 46);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Book Name";
            // 
            // BookManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1110, 607);
            Controls.Add(grbSearch);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgvBookList);
            Controls.Add(lblHeader);
            Name = "BookManager";
            Text = " BookManager";
            Load += BookManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            grbSearch.ResumeLayout(false);
            grbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private DataGridView dgvBookList;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private GroupBox grbSearch;
        private Label lblSearch;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}
