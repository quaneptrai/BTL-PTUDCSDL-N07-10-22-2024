namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            PBpanel = new PictureBox();
            groupBox1 = new GroupBox();
            LBforgotpassword = new Label();
            Blogin = new Button();
            LBpassword = new Label();
            LBusername = new Label();
            TXTpassword = new TextBox();
            TXTusername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PBpanel).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PBpanel
            // 
            PBpanel.Dock = DockStyle.Fill;
            PBpanel.Image = (Image)resources.GetObject("PBpanel.Image");
            PBpanel.Location = new Point(0, 0);
            PBpanel.Name = "PBpanel";
            PBpanel.Size = new Size(831, 450);
            PBpanel.SizeMode = PictureBoxSizeMode.StretchImage;
            PBpanel.TabIndex = 0;
            PBpanel.TabStop = false;
            PBpanel.Click += PBpanel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(LBforgotpassword);
            groupBox1.Controls.Add(Blogin);
            groupBox1.Controls.Add(LBpassword);
            groupBox1.Controls.Add(LBusername);
            groupBox1.Controls.Add(TXTpassword);
            groupBox1.Controls.Add(TXTusername);
            groupBox1.Location = new Point(211, 217);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // LBforgotpassword
            // 
            LBforgotpassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBforgotpassword.AutoSize = true;
            LBforgotpassword.Font = new Font("Segoe UI", 10F);
            LBforgotpassword.ForeColor = SystemColors.HotTrack;
            LBforgotpassword.Location = new Point(163, 179);
            LBforgotpassword.Name = "LBforgotpassword";
            LBforgotpassword.Size = new Size(142, 23);
            LBforgotpassword.TabIndex = 6;
            LBforgotpassword.Text = "Quên mật khẩu ?";
            LBforgotpassword.Click += LBforgotpassword_Click;
            // 
            // Blogin
            // 
            Blogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Blogin.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Blogin.Location = new Point(174, 132);
            Blogin.Name = "Blogin";
            Blogin.Size = new Size(114, 29);
            Blogin.TabIndex = 4;
            Blogin.Text = "Đăng nhập";
            Blogin.UseVisualStyleBackColor = true;
            Blogin.Click += Blogin_Click;
            // 
            // LBpassword
            // 
            LBpassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBpassword.AutoSize = true;
            LBpassword.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBpassword.Location = new Point(27, 103);
            LBpassword.Name = "LBpassword";
            LBpassword.Size = new Size(78, 19);
            LBpassword.TabIndex = 3;
            LBpassword.Text = "Mật khẩu";
            // 
            // LBusername
            // 
            LBusername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBusername.AutoSize = true;
            LBusername.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBusername.Location = new Point(27, 47);
            LBusername.Name = "LBusername";
            LBusername.Size = new Size(81, 19);
            LBusername.TabIndex = 2;
            LBusername.Text = "Tài khoản";
            // 
            // TXTpassword
            // 
            TXTpassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTpassword.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TXTpassword.Location = new Point(115, 99);
            TXTpassword.Name = "TXTpassword";
            TXTpassword.Size = new Size(275, 25);
            TXTpassword.TabIndex = 1;
            // 
            // TXTusername
            // 
            TXTusername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTusername.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TXTusername.Location = new Point(114, 43);
            TXTusername.Name = "TXTusername";
            TXTusername.Size = new Size(275, 25);
            TXTusername.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(831, 450);
            Controls.Add(groupBox1);
            Controls.Add(PBpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Tag = "Đăng Nhập";
            KeyDown += Thoat;
            ((System.ComponentModel.ISupportInitialize)PBpanel).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PBpanel;
        private GroupBox groupBox1;
        private Label LBpassword;
        private Label LBusername;
        private TextBox TXTpassword;
        private TextBox TXTusername;
        private Button Blogin;
        private Label LBforgotpassword;
    }
}
