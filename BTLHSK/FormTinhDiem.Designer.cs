namespace BTLHSK
{
    partial class FormTinhDiem
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDG1 = new System.Windows.Forms.Label();
            this.labelDG2 = new System.Windows.Forms.Label();
            this.labelDG3 = new System.Windows.Forms.Label();
            this.textTen = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.buttonTinhDiem = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // labelDG1
            // 
            this.labelDG1.AutoSize = true;
            this.labelDG1.Location = new System.Drawing.Point(113, 84);
            this.labelDG1.Name = "labelDG1";
            this.labelDG1.Size = new System.Drawing.Size(85, 13);
            this.labelDG1.TabIndex = 1;
            this.labelDG1.Text = "Điểm đánh giá 1";
            // 
            // labelDG2
            // 
            this.labelDG2.AutoSize = true;
            this.labelDG2.Location = new System.Drawing.Point(113, 117);
            this.labelDG2.Name = "labelDG2";
            this.labelDG2.Size = new System.Drawing.Size(85, 13);
            this.labelDG2.TabIndex = 2;
            this.labelDG2.Text = "Điểm đánh giá 2";
            // 
            // labelDG3
            // 
            this.labelDG3.AutoSize = true;
            this.labelDG3.Location = new System.Drawing.Point(113, 159);
            this.labelDG3.Name = "labelDG3";
            this.labelDG3.Size = new System.Drawing.Size(85, 13);
            this.labelDG3.TabIndex = 3;
            this.labelDG3.Text = "Điểm đánh giá 3";
            // 
            // textTen
            // 
            this.textTen.Location = new System.Drawing.Point(236, 42);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(100, 20);
            this.textTen.TabIndex = 4;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(236, 77);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 20);
            this.text1.TabIndex = 5;
            this.text1.TextChanged += new System.EventHandler(this.text1_Validating);
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(236, 114);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 20);
            this.text2.TabIndex = 6;
            this.text2.TextChanged += new System.EventHandler(this.text2_TextChanged);
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(236, 156);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(100, 20);
            this.text3.TabIndex = 7;
            this.text3.TextChanged += new System.EventHandler(this.text3_TextChanged);
            // 
            // buttonTinhDiem
            // 
            this.buttonTinhDiem.Location = new System.Drawing.Point(236, 220);
            this.buttonTinhDiem.Name = "buttonTinhDiem";
            this.buttonTinhDiem.Size = new System.Drawing.Size(75, 23);
            this.buttonTinhDiem.TabIndex = 8;
            this.buttonTinhDiem.Text = "Tính điểm";
            this.buttonTinhDiem.UseVisualStyleBackColor = true;
            this.buttonTinhDiem.Click += new System.EventHandler(this.buttonTinhDiem_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(148, 266);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(50, 13);
            this.lblKetQua.TabIndex = 9;
            this.lblKetQua.Text = "Kết quả: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormTinhDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.buttonTinhDiem);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.textTen);
            this.Controls.Add(this.labelDG3);
            this.Controls.Add(this.labelDG2);
            this.Controls.Add(this.labelDG1);
            this.Controls.Add(this.label1);
            this.Name = "FormTinhDiem";
            this.Text = "FormTinhDiem";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDG1;
        private System.Windows.Forms.Label labelDG2;
        private System.Windows.Forms.Label labelDG3;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Button buttonTinhDiem;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}