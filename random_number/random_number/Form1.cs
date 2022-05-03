using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace random_number
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        int n = 0; // 리스트 개수 확인 변수
        int m = 0; // 음악 눌렀는지 안눌렀는지 확인 변수

        public Form1()
        {
            InitializeComponent();
            list.Add(1);
            backColorD(); // 배경제거
        }

        #region 툴 배경 제거
        public void backColorD()
        {
            printLabel.BackColor = Color.Transparent;
            printLabel.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            remainNumber.BackColor = Color.Transparent;
            remainNumber.Parent = pictureBox1;
        }
        #endregion

        public void CreateList(int l) // 숫자 출력할 리스트 생성
        {
            for (int i = 2; i <= l; i++) // 리스트 값 생성
            {
                list.Add(i);
            }
            Shuffle(list);
        }

        #region 리스트 셔플
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
        #endregion

        #region 지연 메소드
        public void Delay(int ms)
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
        #endregion

        #region 음원 반복 재생
        [DllImport("winmm.dll", SetLastError = true)] 

        // 볼륨조절 메서드
        private static extern int waveOutSetVolume(IntPtr device, uint volume);
        
        private void music() // 음원 재생 메소드
        {
            waveOutSetVolume(IntPtr.Zero, (uint)0x88888888); // 숫자가 클 수록 소리가 커짐
            SoundPlayer simpleSound = new SoundPlayer(@"c:\music\ost.wav");
            if (m == 0)
            {
                simpleSound.PlayLooping(); // 음악 반복재생
                btn_music.Text = "음악 중지";
                m++;
            }
            else
            {
                simpleSound.Stop(); // 음악 중지
                btn_music.Text = "음악 재생";
                m--;
            }
        }

        #endregion

        #region 버튼 클릭
        private void btn_Click(object sender, EventArgs e) 
        {
            if (n < list.Count)
            {
                label1.Text = "" + list[0];
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
        #endregion

        #region 초기 숫자 범위 지정
        private void btn_len_Click(object sender, EventArgs e)
        {
            CreateList(Int32.Parse(textInput.Text));
            textInput.Enabled = false;
            btn_len.Enabled = false;
        }
        #endregion

        #region 추첨버튼 동적 외형 변경
        private void btn_MouseHover(object sender, EventArgs e)
        {
            btn.BackColor = Color.Orange;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            btn.BackColor = Color.Silver;
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            btn.BackColor = Color.Orange;
        }
        #endregion

        private void btn_music_Click(object sender, EventArgs e) // 음악 재생 버튼
        {
            music();
        }

        #region 필요 없는 메서드
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
