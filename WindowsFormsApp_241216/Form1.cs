using System;
using System.Windows.Forms;

namespace WindowsFormsApp_241216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] arr = new string[10];
            arr[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            arr[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            arr[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            arr[3]="그 사람의 그림자는 그랬다".Replace("그","이");
            arr[4]="삼성 갤럭시".Insert("삼성 갤럭시".IndexOf("갤"),"애플 ");
            arr[5]="오늘은 왠지 더 배고프다".Remove("오늘은 왠지 더 배고프다".IndexOf("더"),2);
            string[] temp = "이름,나이,전화번호".Split(',');
            int idx = 0;
            foreach(string a in temp)
            {
                arr[6 + idx] = a;
                idx++;
            }
            arr[9]="우리 나라 만세".Substring(3).Replace(" 만세","");
            foreach (string a in arr)
            {
                System.Console.WriteLine(a);
                textBox_print.Text += a;
                textBox_print.Text += "\r\n";
            }
        }

    }
}
