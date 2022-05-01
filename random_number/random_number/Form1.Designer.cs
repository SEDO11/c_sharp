
namespace random_number
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
            this.components = new System.ComponentModel.Container();
            this.btn = new System.Windows.Forms.Button();
            this.printLabel = new System.Windows.Forms.Label();
            this.remainNumber = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_len = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn.AutoSize = true;
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn.Location = new System.Drawing.Point(266, 533);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(169, 85);
            this.btn.TabIndex = 1;
            this.btn.Text = "추첨";
            this.btn.UseMnemonic = false;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // printLabel
            // 
            this.printLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printLabel.AutoSize = true;
            this.printLabel.BackColor = System.Drawing.Color.GreenYellow;
            this.printLabel.Font = new System.Drawing.Font("굴림", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.printLabel.Location = new System.Drawing.Point(110, 61);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(456, 96);
            this.printLabel.TabIndex = 3;
            this.printLabel.Text = "추첨 번호";
            this.printLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.printLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // remainNumber
            // 
            this.remainNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remainNumber.AutoSize = true;
            this.remainNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.remainNumber.Location = new System.Drawing.Point(524, 602);
            this.remainNumber.Name = "remainNumber";
            this.remainNumber.Size = new System.Drawing.Size(65, 12);
            this.remainNumber.TabIndex = 5;
            this.remainNumber.Text = "남은 개수: ";
            this.remainNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textInput
            // 
            this.textInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textInput.Location = new System.Drawing.Point(602, 531);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(70, 21);
            this.textInput.TabIndex = 6;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "번호 개수 입력";
            // 
            // btn_len
            // 
            this.btn_len.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_len.BackColor = System.Drawing.Color.Transparent;
            this.btn_len.Location = new System.Drawing.Point(597, 567);
            this.btn_len.Name = "btn_len";
            this.btn_len.Size = new System.Drawing.Size(75, 23);
            this.btn_len.TabIndex = 8;
            this.btn_len.Text = "입력";
            this.btn_len.UseVisualStyleBackColor = false;
            this.btn_len.Click += new System.EventHandler(this.btn_len_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::random_number.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 661);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("굴림", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(298, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 96);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_len);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.remainNumber);
            this.Controls.Add(this.printLabel);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "숫자 랜덤 뽑기 프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label printLabel;
        private System.Windows.Forms.Label remainNumber;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_len;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

