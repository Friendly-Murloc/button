using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1313
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button murloc = new Button();               //멀록버튼만듬 ^~^
            murloc.Location = new Point(0, 0);          //좌표설정
            murloc.BackColor = Color.LightSkyBlue;      //이거는 이미지추가하면 필요없는대 일딴 넣어둔다
            murloc.Height = 100;                        //버튼 높이
            murloc.Width = 100;                         //버튼 너비
            //murloc.Image = new Bitmap(@"");           //여기다가 버튼이미지 넣는거임
            this.Controls.Add(murloc);                  //이게 읎으면 님 버튼 생성안댐 이게 이클래스안에 버튼 추가하는건가? 그럴껄
            MessageBox.Show("넌 멀록이야!");            //아 귀찮다..
        }
        public void Form1_Load(object sender, MouseEventArgs e)     //이밴트 표시
        {

        }                         
    }
}
