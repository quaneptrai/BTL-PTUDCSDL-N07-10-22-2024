namespace WinFormsApp1
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            Pmaintrangchu = new Panel();
            Blbaocao = new Button();
            Bcstaikhoan = new Button();
            Bdsgiaovien = new Button();
            Bdshocsinh = new Button();
            Pcapquyen = new Panel();
            Bthoikhoabieu = new Button();
            LBsignout = new Label();
            TXTtendangnhap = new TextBox();
            Puserimage = new PictureBox();
            Phienthi = new Panel();
            Pmaintrangchu.SuspendLayout();
            Pcapquyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Puserimage).BeginInit();
            SuspendLayout();
            // 
            // Pmaintrangchu
            // 
            Pmaintrangchu.BackColor = Color.White;
            Pmaintrangchu.Controls.Add(Blbaocao);
            Pmaintrangchu.Controls.Add(Bcstaikhoan);
            Pmaintrangchu.Controls.Add(Bdsgiaovien);
            Pmaintrangchu.Controls.Add(Bdshocsinh);
            Pmaintrangchu.Controls.Add(Pcapquyen);
            Pmaintrangchu.Controls.Add(LBsignout);
            Pmaintrangchu.Controls.Add(TXTtendangnhap);
            Pmaintrangchu.Controls.Add(Puserimage);
            Pmaintrangchu.Location = new Point(2, -1);
            Pmaintrangchu.Name = "Pmaintrangchu";
            Pmaintrangchu.Size = new Size(236, 571);
            Pmaintrangchu.TabIndex = 0;
            Pmaintrangchu.Paint += Pmaintrangchu_Paint;
            // 
            // Blbaocao
            // 
            Blbaocao.BackColor = Color.White;
            Blbaocao.FlatAppearance.BorderSize = 0;
            Blbaocao.FlatStyle = FlatStyle.Flat;
            Blbaocao.ForeColor = Color.Black;
            Blbaocao.Image = (Image)resources.GetObject("Blbaocao.Image");
            Blbaocao.ImageAlign = ContentAlignment.MiddleLeft;
            Blbaocao.Location = new Point(3, 499);
            Blbaocao.Name = "Blbaocao";
            Blbaocao.Size = new Size(212, 69);
            Blbaocao.TabIndex = 7;
            Blbaocao.Text = "              Lập báo cáo";
            Blbaocao.TextAlign = ContentAlignment.MiddleLeft;
            Blbaocao.UseVisualStyleBackColor = false;
            Blbaocao.Click += Blbaocao_Click;
            // 
            // Bcstaikhoan
            // 
            Bcstaikhoan.BackColor = Color.White;
            Bcstaikhoan.FlatAppearance.BorderSize = 0;
            Bcstaikhoan.FlatStyle = FlatStyle.Flat;
            Bcstaikhoan.ForeColor = Color.Black;
            Bcstaikhoan.Image = (Image)resources.GetObject("Bcstaikhoan.Image");
            Bcstaikhoan.ImageAlign = ContentAlignment.MiddleLeft;
            Bcstaikhoan.Location = new Point(3, 410);
            Bcstaikhoan.Name = "Bcstaikhoan";
            Bcstaikhoan.Size = new Size(212, 69);
            Bcstaikhoan.TabIndex = 6;
            Bcstaikhoan.Text = "              Chỉnh sửa tài khoản";
            Bcstaikhoan.TextAlign = ContentAlignment.MiddleLeft;
            Bcstaikhoan.UseVisualStyleBackColor = false;
            Bcstaikhoan.Click += Bcstaikhoan_Click;
            // 
            // Bdsgiaovien
            // 
            Bdsgiaovien.BackColor = Color.White;
            Bdsgiaovien.FlatAppearance.BorderSize = 0;
            Bdsgiaovien.FlatStyle = FlatStyle.Flat;
            Bdsgiaovien.ForeColor = Color.Black;
            Bdsgiaovien.Image = (Image)resources.GetObject("Bdsgiaovien.Image");
            Bdsgiaovien.ImageAlign = ContentAlignment.MiddleLeft;
            Bdsgiaovien.Location = new Point(1, 320);
            Bdsgiaovien.Name = "Bdsgiaovien";
            Bdsgiaovien.Size = new Size(212, 69);
            Bdsgiaovien.TabIndex = 5;
            Bdsgiaovien.Text = "              Danh sách giáo viên ";
            Bdsgiaovien.TextAlign = ContentAlignment.MiddleLeft;
            Bdsgiaovien.UseVisualStyleBackColor = false;
            Bdsgiaovien.Click += Bdsgiaovien_Click;
            // 
            // Bdshocsinh
            // 
            Bdshocsinh.BackColor = Color.White;
            Bdshocsinh.FlatAppearance.BorderSize = 0;
            Bdshocsinh.FlatStyle = FlatStyle.Flat;
            Bdshocsinh.ForeColor = Color.Black;
            Bdshocsinh.Image = (Image)resources.GetObject("Bdshocsinh.Image");
            Bdshocsinh.ImageAlign = ContentAlignment.MiddleLeft;
            Bdshocsinh.Location = new Point(1, 224);
            Bdshocsinh.Name = "Bdshocsinh";
            Bdshocsinh.Size = new Size(229, 69);
            Bdshocsinh.TabIndex = 4;
            Bdshocsinh.Text = "              Danh sách học sinh  ";
            Bdshocsinh.TextAlign = ContentAlignment.MiddleLeft;
            Bdshocsinh.UseVisualStyleBackColor = false;
            Bdshocsinh.Click += Bdshocsinh_Click;
            // 
            // Pcapquyen
            // 
            Pcapquyen.BackColor = Color.FromArgb(45, 45, 45);
            Pcapquyen.Controls.Add(Bthoikhoabieu);
            Pcapquyen.Location = new Point(3, 131);
            Pcapquyen.Name = "Pcapquyen";
            Pcapquyen.Size = new Size(187, 69);
            Pcapquyen.TabIndex = 1;
            // 
            // Bthoikhoabieu
            // 
            Bthoikhoabieu.BackColor = Color.White;
            Bthoikhoabieu.FlatAppearance.BorderSize = 0;
            Bthoikhoabieu.FlatStyle = FlatStyle.Flat;
            Bthoikhoabieu.ForeColor = Color.Black;
            Bthoikhoabieu.Image = (Image)resources.GetObject("Bthoikhoabieu.Image");
            Bthoikhoabieu.ImageAlign = ContentAlignment.MiddleLeft;
            Bthoikhoabieu.Location = new Point(-3, 0);
            Bthoikhoabieu.Name = "Bthoikhoabieu";
            Bthoikhoabieu.Size = new Size(195, 69);
            Bthoikhoabieu.TabIndex = 0;
            Bthoikhoabieu.Text = "              Thời Khóa Biểu";
            Bthoikhoabieu.TextAlign = ContentAlignment.MiddleLeft;
            Bthoikhoabieu.UseVisualStyleBackColor = false;
            Bthoikhoabieu.Click += Bthoikhoabieu_Click;
            // 
            // LBsignout
            // 
            LBsignout.AutoSize = true;
            LBsignout.ForeColor = Color.Blue;
            LBsignout.Location = new Point(111, 68);
            LBsignout.Name = "LBsignout";
            LBsignout.Size = new Size(77, 20);
            LBsignout.TabIndex = 1;
            LBsignout.Text = "Sign Out ?";
            LBsignout.Click += LBsignout_Click;
            // 
            // TXTtendangnhap
            // 
            TXTtendangnhap.BackColor = Color.White;
            TXTtendangnhap.BorderStyle = BorderStyle.None;
            TXTtendangnhap.ForeColor = Color.Black;
            TXTtendangnhap.Location = new Point(96, 25);
            TXTtendangnhap.Name = "TXTtendangnhap";
            TXTtendangnhap.Size = new Size(102, 20);
            TXTtendangnhap.TabIndex = 1;
            TXTtendangnhap.TextAlign = HorizontalAlignment.Center;
            // 
            // Puserimage
            // 
            Puserimage.Image = (Image)resources.GetObject("Puserimage.Image");
            Puserimage.Location = new Point(0, 3);
            Puserimage.Name = "Puserimage";
            Puserimage.Size = new Size(96, 85);
            Puserimage.SizeMode = PictureBoxSizeMode.StretchImage;
            Puserimage.TabIndex = 1;
            Puserimage.TabStop = false;
            // 
            // Phienthi
            // 
            Phienthi.Location = new Point(238, -1);
            Phienthi.Name = "Phienthi";
            Phienthi.Size = new Size(804, 574);
            Phienthi.TabIndex = 1;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1041, 570);
            Controls.Add(Phienthi);
            Controls.Add(Pmaintrangchu);
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChu";
            Load += TrangChu_Load;
            KeyDown += Thoat;
            Pmaintrangchu.ResumeLayout(false);
            Pmaintrangchu.PerformLayout();
            Pcapquyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Puserimage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pmaintrangchu;
        private PictureBox Puserimage;
        private Label LBsignout;
        private TextBox TXTtendangnhap;
        private Button Bthoikhoabieu;
        private Panel Pcapquyen;
        private Button Bdsgiaovien;
        private Button Bdshocsinh;
        private Panel Phienthi;
        private Button Bcstaikhoan;
        private Button Blbaocao;
    }
}