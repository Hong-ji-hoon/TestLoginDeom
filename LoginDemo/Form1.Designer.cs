namespace LoginDemo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.titlelb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idlb = new System.Windows.Forms.Label();
            this.pwlb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(95, 170);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(116, 39);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // titlelb
            // 
            this.titlelb.AutoSize = true;
            this.titlelb.Location = new System.Drawing.Point(127, 30);
            this.titlelb.Name = "titlelb";
            this.titlelb.Size = new System.Drawing.Size(45, 12);
            this.titlelb.TabIndex = 1;
            this.titlelb.Text = "LogOut";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pwlb);
            this.panel1.Controls.Add(this.idlb);
            this.panel1.Controls.Add(this.titlelb);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(201, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 230);
            this.panel1.TabIndex = 2;
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.Location = new System.Drawing.Point(24, 80);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(16, 12);
            this.idlb.TabIndex = 2;
            this.idlb.Text = "ID";
            // 
            // pwlb
            // 
            this.pwlb.AutoSize = true;
            this.pwlb.Location = new System.Drawing.Point(24, 128);
            this.pwlb.Name = "pwlb";
            this.pwlb.Size = new System.Drawing.Size(23, 12);
            this.pwlb.TabIndex = 3;
            this.pwlb.Text = "PW";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 21);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 21);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label titlelb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pwlb;
        private System.Windows.Forms.Label idlb;
    }
}

