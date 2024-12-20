using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_241216
{
    public partial class Form1 : Form
    {
        //bool myChoice = false;
        //bool ans;
        //enum Day{
        //    monday,
        //    tuesday,
        //    wednesday,
        //    thursday,
        //    friday,
        //    saturday,
        //    sunday
        //}
        public Form1()
        {
            InitializeComponent();
            textBox_print.BackColor = Color.White;
            
            #region 옛날코드

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


            //bool myChoice=Button_Click();
            #endregion

        }
        private void Button_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox_input.Text);
            int[] arr = new int[num+1];
            Random random = new Random();
            for(int i = 1; i <= num; i++)
            {
                int randomNumber = random.Next(0, 100);
                arr[i] = randomNumber;
                textBox_print.Text += ("학생" + i.ToString() + "의 점수 : " + randomNumber.ToString() +"\r\n");
            }

        }

        //private void Button_Click(object sender, EventArgs e)
        //{
        //    string str=textBox_input.Text.Trim().ToLower();
        //    this.Day.TryParce();
        //    switch (day)
        //    {
        //        case Day.monday:
        //            textBox_print.Text = "Fuck you Monday";
        //            break;
        //        case Day.tuesday:
        //            textBox_print.Text = "It's chuesday, innit!";
        //            break;
        //        case Day.wednesday:
        //            textBox_print.Text = "Just half passed of the week";
        //            break;
        //        case Day.thursday:
        //            textBox_print.Text = "Tomorrow is Friday";
        //            break;
        //        case Day.friday:
        //            textBox_print.Text = "TGIF";
        //            break;
        //        case Day.saturday:
        //            textBox_print.Text = "HAPPY WEEKEND";
        //            break;
        //        case Day.sunday:
        //            textBox_print.Text = "JJAPAGHETTI YORISA!";
        //            break;
        //        default:
        //            textBox_print.Text = "!!!!WRONG!!!!!WARNING!!!!";
        //            break;
        //    }
        //    return;
        #region hi
        //bool flipCoinResult(bool choice)
        //{
        //    bool result;
        //    Random random = new Random();
        //    int randomNumber = random.Next(0, 10);

        //    SetMsgToTextBox(randomNumber.ToString());

        //    if (randomNumber % 2 == 0)
        //    {
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    if (result == choice)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //void SetMsgToTextBox(string msg)
        //{
        //    textBox_print.Text += "random number : ";
        //    textBox_print.Text += msg;
        //    textBox_print.Text += "\r\n";
        //}

        ////private void Button_Click(object sender, EventArgs e)
        ////{
        ////    int num = int.Parse(textBox_input.Text);

        ////    textBox_print.Text += num.ToString();
        ////    textBox_print.Text += "  0  \r\n";

        ////    if (num % 2 == 0)
        ////    {
        ////        this.myChoice = true;
        ////    }
        ////    else
        ////    {
        ////        this.myChoice = false;
        ////    }
        ////    textBox_print.Text += "  1-1  \r\n";
        ////    textBox_print.Text += this.myChoice.ToString();
        ////    textBox_print.Text += "  1  \r\n";
        ////    this.ans = flipCoinResult(this.myChoice);

        ////    textBox_print.Text += this.ans.ToString();
        ////    textBox_print.Text += "  2  \r\n";
        ////    if (this.ans == false)
        ////    {
        ////        textBox_print.Text += "패배";
        ////    }
        ////    else
        ////    {
        ////        textBox_print.Text += "승리";
        ////    }
        ////}


        ////void add(int[] array)
        ////{
        ////    int a, b;
        ////    a = int.Parse(System.Console.ReadLine());
        ////    b = int.Parse(System.Console.ReadLine());
        ////    array[0] = a / b;
        ////    array[1] = a % b;
        ////}

        //private void radioButton_true_CheckedChanged(object sender, EventArgs e)
        //{
        //    this.myChoice = true;
        //    textBox_print.Text = "my Choice : TRUE\r\n";
        //    this.ans = flipCoinResult(this.myChoice);
        //    if (this.ans == false)
        //    {
        //        textBox_print.Text += "패배";
        //    }
        //    else
        //    {
        //        textBox_print.Text += "승리";
        //    }
        //}

        //private void radioButton_false_CheckedChanged(object sender, EventArgs e)
        //{
        //    this.myChoice = false;
        //    textBox_print.Text = "my Choice : FALSE\r\n";
        //    this.ans = flipCoinResult(this.myChoice);
        //    if (this.ans == false)
        //    {
        //        textBox_print.Text += "패배";
        //    }
        //    else
        //    {
        //        textBox_print.Text += "승리";
        //    }
        //}
        //private void Button_Click(object sender, EventArgs e)
        //{
        //    string str = textBox_input.Text;
        //    textBox_print.Text = "my Choice : ";
        //    textBox_print.Text += str;
        //    textBox_print.Text += "\r\n";
        //    if (str == "FALSE" || str == "false")
        //    {
        //        this.myChoice = false;
        //    }
        //    else if (str == "true" || str == "TRUE")
        //    {
        //        this.myChoice = true;
        //    }
        //    else
        //    {
        //        textBox_print.Text = "Error!!! Check the spelling";
        //        return;
        //    }
        //    this.ans = flipCoinResult(this.myChoice);
        //    if (this.ans == false)
        //    {
        //        textBox_print.Text += "패배";
        //    }
        //    else
        //    {
        //        textBox_print.Text += "승리";
        //    }
        #endregion
    }


}
