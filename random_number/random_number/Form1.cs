using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace random_number
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        int n = 0;

        private float gradientStart = 0;

        private float delta = 5f;
        public Form1()
        {
            InitializeComponent();
            list.Add(1);
            label1.Text = "1~n까지 랜덤 출력\n실행 방법\n스페이스바 or 버튼 클릭";

            printLabel.BackColor = Color.Transparent;
            printLabel.Parent = canvasPictureBox;
            label1.BackColor = Color.Transparent;
            label1.Parent = canvasPictureBox;
            label2.BackColor = Color.Transparent;
            label2.Parent = canvasPictureBox;
            remainNumber.BackColor = Color.Transparent;
            remainNumber.Parent = canvasPictureBox;

            #region 무빙 이벤트를 설정한다.
            this.canvasPictureBox.Paint += canvasPictureBox_Paint; 
            this.timer.Tick += timer_Tick;
            #endregion

        }

        public void CreateList(int l) // 지연
        {
            for (int i = 2; i <= l; i++) // 리스트 값 생성
            {
                list.Add(i);
            }
            Shuffle(list);
        }

        public static List<T> Shuffle<T>(List<T> list) // 리스트 값 셔플
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int rnd = random.Next(0, i);
                T temp = list[i];
                list[i] = list[rnd];
                list[rnd] = temp;
            }
            return list;
        }

        public void Delay(int ms) // 지연
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }

        private void btn_Click(object sender, EventArgs e) // 버튼 클릭
        {
            playSimpleSound();
            if (n < list.Count)
            {
                printLabel.Text = "추첨 번호\n" + list[0];
                remainNumber.Text = "남은 개수: " + (list.Count - 1);
                list.RemoveAt(0);
            }
            else
            {
                printLabel.Text = "종료";
                Delay(2000);
                Close();
            }
        }

        private void playSimpleSound() // 소리 재생
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_len_Click(object sender, EventArgs e) // 값 입력
        {
            CreateList(Int32.Parse(textInput.Text));
            textInput.Text = "";
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }

        // 배경 움직임
        private void canvasPictureBox_Paint(object sender, PaintEventArgs e) 
        { 
            int width = this.canvasPictureBox.ClientSize.Width; 
            SetBackgroundImage(e.Graphics, this.gradientStart, this.gradientStart + width); 
            this.gradientStart += this.delta; 
            if (this.gradientStart >= width) 
            { 
                this.gradientStart = 0; 
            } 
            
            using (Font font = new Font("Times New Roman", 32, FontStyle.Bold)) 
            {
                using (StringFormat stringFormat = new StringFormat()) 
                {
                    stringFormat.Alignment = StringAlignment.Center; 
                    stringFormat.LineAlignment = StringAlignment.Center; 
                    e.Graphics.DrawString(
                        "",
                        font, 
                        Brushes.Black, 
                        this.canvasPictureBox.ClientSize.Width / 2, 
                        this.canvasPictureBox.ClientSize.Height / 2, 
                        stringFormat); 
                } 
            } 
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.canvasPictureBox.Refresh();
        }

        private void SetBackgroundImage(Graphics graphics, float minimumX, float maximumX) 
        { 
            using (LinearGradientBrush brush = new LinearGradientBrush(new PointF(minimumX, 0), 
                new PointF(maximumX, 0), Color.Green, Color.Green)) 
            { 
                brush.WrapMode = WrapMode.Tile; 
                ColorBlend colorBlend = new ColorBlend(); 
                colorBlend.Colors = new Color[] 
                { Color.Green, Color.DarkGray, Color.Green }; 
                colorBlend.Positions = new float[] { 0, 0.8f, 1}; 
                brush.InterpolationColors = colorBlend; 
                graphics.FillRectangle(brush, this.canvasPictureBox.ClientRectangle); 
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
