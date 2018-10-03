namespace KMSG_exhibition
{
    partial class frmMain
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
            this.picTop = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.wb01 = new System.Windows.Forms.WebBrowser();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.wb02 = new System.Windows.Forms.WebBrowser();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.wb03 = new System.Windows.Forms.WebBrowser();
            this.wb04 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            this.SuspendLayout();
            // 
            // picTop
            // 
            this.picTop.Location = new System.Drawing.Point(742, 3);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(677, 50);
            this.picTop.TabIndex = 0;
            this.picTop.TabStop = false;
            this.picTop.DoubleClick += new System.EventHandler(this.picTop_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // wb01
            // 
            this.wb01.Location = new System.Drawing.Point(6, 29);
            this.wb01.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb01.Name = "wb01";
            this.wb01.Size = new System.Drawing.Size(613, 394);
            this.wb01.TabIndex = 2;
            this.wb01.Url = new System.Uri("http://yspesu.iptime.org", System.UriKind.Absolute);
            this.wb01.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb01_DocumentCompleted);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(556, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // wb02
            // 
            this.wb02.Location = new System.Drawing.Point(6, 480);
            this.wb02.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb02.Name = "wb02";
            this.wb02.Size = new System.Drawing.Size(562, 360);
            this.wb02.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 454);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(603, 20);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 846);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(556, 20);
            this.comboBox3.TabIndex = 7;
            // 
            // wb03
            // 
            this.wb03.Location = new System.Drawing.Point(6, 872);
            this.wb03.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb03.Name = "wb03";
            this.wb03.Size = new System.Drawing.Size(562, 360);
            this.wb03.TabIndex = 6;
            // 
            // wb04
            // 
            this.wb04.Location = new System.Drawing.Point(1443, 3);
            this.wb04.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb04.Name = "wb04";
            this.wb04.Size = new System.Drawing.Size(1364, 1055);
            this.wb04.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3840, 1100);
            this.ControlBox = false;
            this.Controls.Add(this.wb04);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.wb03);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.wb02);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.wb01);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser wb01;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.WebBrowser wb02;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.WebBrowser wb03;
        private System.Windows.Forms.WebBrowser wb04;
    }
}

