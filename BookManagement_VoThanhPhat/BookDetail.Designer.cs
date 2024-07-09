namespace BookManagement_VoThanhPhat
{
    partial class BookDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            cboCategory = new ComboBox();
            btnSave = new Button();
            btnClose = new Button();
            lblBookCategory = new Label();
            lblBookName = new Label();
            txtBookName = new TextBox();
            grbBookInfo = new GroupBox();
            txtDescription = new TextBox();
            dtpPublicationDate = new DateTimePicker();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtAuthor = new TextBox();
            lblAuthor = new Label();
            lblBookQuantity = new Label();
            lblBookPrice = new Label();
            lblPublicationDate = new Label();
            lblBookDescription = new Label();
            txtBookID = new TextBox();
            lblBookID = new Label();
            grbBookInfo.SuspendLayout();
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
            lblHeader.Size = new Size(483, 106);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Book Detail";
            // 
            // cboCategory
            // 
            cboCategory.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(241, 514);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(540, 45);
            cboCategory.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(996, 109);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 63);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(996, 203);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 63);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblBookCategory
            // 
            lblBookCategory.AutoSize = true;
            lblBookCategory.BackColor = Color.Red;
            lblBookCategory.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookCategory.ForeColor = Color.Yellow;
            lblBookCategory.Location = new Point(6, 521);
            lblBookCategory.Name = "lblBookCategory";
            lblBookCategory.Size = new Size(212, 38);
            lblBookCategory.TabIndex = 5;
            lblBookCategory.Text = "Book Category";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = Color.Red;
            lblBookName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(6, 140);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(171, 38);
            lblBookName.TabIndex = 6;
            lblBookName.Text = "Book Name";
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookName.Location = new Point(241, 140);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(571, 43);
            txtBookName.TabIndex = 1;
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(dtpPublicationDate);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblBookQuantity);
            grbBookInfo.Controls.Add(lblBookPrice);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblBookDescription);
            grbBookInfo.Controls.Add(txtBookID);
            grbBookInfo.Controls.Add(lblBookID);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblBookCategory);
            grbBookInfo.Controls.Add(cboCategory);
            grbBookInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbBookInfo.ForeColor = Color.Yellow;
            grbBookInfo.Location = new Point(9, 109);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(961, 571);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = " Book Info ";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(241, 207);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(679, 138);
            txtDescription.TabIndex = 2;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.CustomFormat = "";
            dtpPublicationDate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(241, 361);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(205, 43);
            dtpPublicationDate.TabIndex = 3;
            dtpPublicationDate.Value = new DateTime(2024, 4, 24, 7, 24, 13, 0);
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(686, 410);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(234, 43);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(241, 410);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(245, 43);
            txtQuantity.TabIndex = 4;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthor.Location = new Point(241, 460);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(407, 43);
            txtAuthor.TabIndex = 6;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = Color.Red;
            lblAuthor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.ForeColor = Color.Yellow;
            lblAuthor.Location = new Point(10, 463);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(110, 38);
            lblAuthor.TabIndex = 14;
            lblAuthor.Text = "Author";
            // 
            // lblBookQuantity
            // 
            lblBookQuantity.AutoSize = true;
            lblBookQuantity.BackColor = Color.Red;
            lblBookQuantity.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookQuantity.ForeColor = Color.Yellow;
            lblBookQuantity.Location = new Point(6, 410);
            lblBookQuantity.Name = "lblBookQuantity";
            lblBookQuantity.Size = new Size(208, 38);
            lblBookQuantity.TabIndex = 13;
            lblBookQuantity.Text = "Book Quantity";
            // 
            // lblBookPrice
            // 
            lblBookPrice.AutoSize = true;
            lblBookPrice.BackColor = Color.Red;
            lblBookPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookPrice.ForeColor = Color.Yellow;
            lblBookPrice.Location = new Point(532, 410);
            lblBookPrice.Name = "lblBookPrice";
            lblBookPrice.Size = new Size(157, 38);
            lblBookPrice.TabIndex = 12;
            lblBookPrice.Text = "Book Price";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.BackColor = Color.Red;
            lblPublicationDate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublicationDate.ForeColor = Color.Yellow;
            lblPublicationDate.Location = new Point(6, 366);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(235, 38);
            lblPublicationDate.TabIndex = 11;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.BackColor = Color.Red;
            lblBookDescription.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookDescription.ForeColor = Color.Yellow;
            lblBookDescription.Location = new Point(6, 212);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(243, 38);
            lblBookDescription.TabIndex = 10;
            lblBookDescription.Text = "Book Description";
            // 
            // txtBookID
            // 
            txtBookID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookID.Location = new Point(241, 57);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(170, 43);
            txtBookID.TabIndex = 0;
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.BackColor = Color.Red;
            lblBookID.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookID.ForeColor = Color.Yellow;
            lblBookID.Location = new Point(6, 57);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(123, 38);
            lblBookID.TabIndex = 8;
            lblBookID.Text = "Book ID";
            // 
            // BookDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1167, 692);
            Controls.Add(grbBookInfo);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblHeader);
            Name = "BookDetail";
            Text = "Create | Update Book";
            Load += BookDetail_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private ComboBox cboCategory;
        private Button btnSave;
        private Button btnClose;
        private Label lblBookCategory;
        private Label lblBookName;
        private TextBox txtBookName;
        private GroupBox grbBookInfo;
        private Label lblBookID;
        private Label lblBookDescription;
        private TextBox txtBookID;
        private Label lblPublicationDate;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtAuthor;
        private Label lblAuthor;
        private Label lblBookQuantity;
        private Label lblBookPrice;
        private DateTimePicker dtpPublicationDate;
        private TextBox txtDescription;
    }
}