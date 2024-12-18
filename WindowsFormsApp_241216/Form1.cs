using System;
using System.Windows.Forms;

namespace WindowsFormsApp_241216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string[] arr = new string[10];
            //arr[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            //arr[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            //arr[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            //arr[3]="그 사람의 그림자는 그랬다".Replace("그","이");
            //arr[4]="삼성 갤럭시".Insert("삼성 갤럭시".IndexOf("갤"),"애플 ");
            //arr[5]="오늘은 왠지 더 배고프다".Remove("오늘은 왠지 더 배고프다".IndexOf("더"),2);
            //string[] temp = "이름,나이,전화번호".Split(',');
            //int idx = 0;
            //foreach(string a in temp)
            //{
            //    arr[6 + idx] = a;
            //    idx++;
            //}
            //arr[9]="우리 나라 만세".Substring(3).Replace(" 만세","");
            //foreach (string a in arr)
            //{
            //    System.Console.WriteLine(a);
            //    textBox_print.Text += a;
            //    textBox_print.Text += "\r\n";
            //}


            //string str = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
            //string[] arr = new string[10];
            //arr[0] = str.Remove(str.IndexOf("-") - 1, 4);
            //arr[1] = str.Substring(0, str.IndexOf("-")-1);
            //arr[2] = str.Substring(str.IndexOf("얼"), 3);
            //arr[3] = str.Substring(str.IndexOf("천"), 3);
            //arr[4] = str.Substring(str.IndexOf("가"), 3);
            //arr[5] = str.Replace(".","").Replace("-","").Replace(" ", ",");
            //foreach (string a in arr)
            //{
            //    System.Console.WriteLine(a);
            //    textBox_print.Text += a;
            //    textBox_print.Text += "\r\n";
            //}

            //int[] arr = new int[2];
            //add(arr);
            //foreach (int a in arr)
            //{
            //    System.Console.WriteLine(a);
            //    textBox_print.Text += (a.ToString());
            //    textBox_print.Text += "\r\n";
            //}
            
            bool ans,myChoice;
            myChoice = false; 
            ans = flipCoinResult(myChoice);
            bool flipCoinResult(bool choice)
            {
                bool result;
                Random random = new Random();
                int randomNumber = random.Next(0, 10);
                textBox_print.Text= randomNumber.ToString();
                textBox_print.Text += "\r\n";
                if (randomNumber % 2 == 0)
                {
                    result=true;
                }
                else
                {
                    result = false;
                }
                if (result==myChoice)
                {
                    return true;
                }
                return false;
            }
            textBox_print.Text += (ans.ToString());


        }
        //void add(int[] array)
        //{
        //    int a, b;
        //    a=int.Parse(System.Console.ReadLine());
        //    b=int.Parse(System.Console.ReadLine());
        //    array[0] = a / b;
        //    array[1] = a % b;
        //} 

    }
}
