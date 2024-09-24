namespace BTLHSK
{
    partial class FormMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCTHD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSP = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(113, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG QUẦN ÁO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 320);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanvien,
            this.MenuKH,
            this.MenuNCC,
            this.MenuHD,
            this.MenuCTHD,
            this.menuSP});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNhanvien
            // 
            this.menuNhanvien.Name = "menuNhanvien";
            this.menuNhanvien.Size = new System.Drawing.Size(115, 20);
            this.menuNhanvien.Text = "Quản lý nhân viên";
            this.menuNhanvien.Click += new System.EventHandler(this.menuNhanvien_Click);
            // 
            // MenuKH
            // 
            this.MenuKH.Name = "MenuKH";
            this.MenuKH.Size = new System.Drawing.Size(125, 20);
            this.MenuKH.Text = "Quản lý khách hàng";
            // 
            // MenuNCC
            // 
            this.MenuNCC.Name = "MenuNCC";
            this.MenuNCC.Size = new System.Drawing.Size(135, 20);
            this.MenuNCC.Text = "Quản lý nhà cung cấp";
            // 
            // MenuHD
            // 
            this.MenuHD.Name = "MenuHD";
            this.MenuHD.Size = new System.Drawing.Size(107, 20);
            this.MenuHD.Text = "Quản lý hóa đơn";
            // 
            // MenuCTHD
            // 
            this.MenuCTHD.Name = "MenuCTHD";
            this.MenuCTHD.Size = new System.Drawing.Size(146, 20);
            this.MenuCTHD.Text = "Quản lý chi tiết hóa đơn";
            // 
            // menuSP
            // 
            this.menuSP.Name = "menuSP";
            this.menuSP.Size = new System.Drawing.Size(115, 20);
            this.menuSP.Text = "Quản lý sản phẩm";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Quản lý cửa hàng quần áo";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNhanvien;
        private System.Windows.Forms.ToolStripMenuItem MenuKH;
        private System.Windows.Forms.ToolStripMenuItem MenuNCC;
        private System.Windows.Forms.ToolStripMenuItem MenuHD;
        private System.Windows.Forms.ToolStripMenuItem MenuCTHD;
        private System.Windows.Forms.ToolStripMenuItem menuSP;
    }
}