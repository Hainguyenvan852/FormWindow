namespace QLRapPhim
{
    partial class frmAdmin
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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnShowtime = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.ptbAvartar = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvartar)).BeginInit();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.btnStaff);
            this.pnLeft.Controls.Add(this.btnShowtime);
            this.pnLeft.Controls.Add(this.btnFilm);
            this.pnLeft.Controls.Add(this.ptbAvartar);
            this.pnLeft.Controls.Add(this.btnExit);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(200, 553);
            this.pnLeft.TabIndex = 10;
            // 
            // btnShowtime
            // 
            this.btnShowtime.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowtime.Location = new System.Drawing.Point(0, 255);
            this.btnShowtime.Name = "btnShowtime";
            this.btnShowtime.Size = new System.Drawing.Size(200, 38);
            this.btnShowtime.TabIndex = 16;
            this.btnShowtime.Text = "Lịch Chiếu";
            this.btnShowtime.UseVisualStyleBackColor = true;
            // 
            // btnFilm
            // 
            this.btnFilm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilm.Location = new System.Drawing.Point(0, 191);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(200, 38);
            this.btnFilm.TabIndex = 13;
            this.btnFilm.Text = "Danh Sách Phim";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // ptbAvartar
            // 
            this.ptbAvartar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbAvartar.Location = new System.Drawing.Point(0, 0);
            this.ptbAvartar.Name = "ptbAvartar";
            this.ptbAvartar.Size = new System.Drawing.Size(200, 130);
            this.ptbAvartar.TabIndex = 9;
            this.ptbAvartar.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(200, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(752, 130);
            this.pnTop.TabIndex = 11;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(214, 49);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(324, 33);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Rạp Chiếu Phim Skope";
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(200, 130);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(752, 423);
            this.pnMain.TabIndex = 12;
            // 
            // btnStaff
            // 
            this.btnStaff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(0, 321);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(200, 38);
            this.btnStaff.TabIndex = 17;
            this.btnStaff.Text = "Quản Lý Nhân Viên";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 553);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvartar)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.PictureBox ptbAvartar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnShowtime;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnStaff;
    }
}