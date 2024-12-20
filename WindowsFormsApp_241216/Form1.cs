using System;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_241216
{
    public partial class Form1 : Form
    {
        int[][] score = new int[3][];
        int[] sub = new int[3];
        int N;
        //int s = -1;
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
            textBox_print.Text = "Initialize score board with input button\r\nPress student num button when you want to get the specific student\r\n";
            textBox_print.Text += "student num : 0 can call all the datas";
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
        private void SaveToCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // CSV의 헤더 작성 (옵션)
                writer.WriteLine("SNUM,English,Math,Korean");

                // 점수 데이터를 CSV로 작성
                for (int i = 1; i <= N; i++) // 학생 번호 1부터 N까지
                {
                    string[] row = new string[4]; // 학생번호 + 3과목
                    row[0] = i.ToString(); // 학생 번호
                    for (int j = 0; j < 3; j++) // 영어, 수학, 국어 점수
                    {
                        row[j + 1] = this.score[j][i].ToString();
                    }
                    writer.WriteLine(string.Join(",", row)); // 쉼표로 구분하여 작성
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            this.N = int.Parse(textBox_input.Text);
            for (int i = 0; i < score.Length; i++)
            {
                this.score[i] = new int[N + 1]; // 각 내부 배열의 크기를 지정
            }
            Random random = new Random();
            for(int i = 1; i <= N; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    int randomNumber = random.Next(0, 100);
                    score[j][i] = randomNumber;
                }
            }
            LoadData();
            string filePath = "C:\\Users\\YUSEOK SON\\source\\repos\\WindowsFormsApp_241216\\WindowsFormsApp_241216\\scores.csv"; // 파일 경로를 적절히 변경하세요.

            // 파일 저장
            try
            {
                SaveToCsv(filePath);
                textBox_print.Text = "CSV 파일이 성공적으로 저장되었습니다: " + filePath;
            }
            catch (Exception ex)
            {
                textBox_print.Text = "파일 저장 중 오류가 발생했습니다: " + ex.Message;
            }
        }
        
        private void Student_num_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox_input.Text);
            textBox_print.Text = "";
            if (num == 0)
            {
                textBox_print.Text += "   영어  수학  국어\r\n";
                for (int i = 1; i <= this.N; i++)
                {
                    textBox_print.Text += (i.ToString()+"  ");
                    for (int j = 0; j < 3; j++)
                    {
                        textBox_print.Text += (this.score[j][i].ToString() + "    ");
                        if (this.score[j][i] < 100  )
                        {
                            textBox_print.Text += "  ";
                        }
                        if (this.score[j][i] < 10)
                        {
                            textBox_print.Text += "  ";
                        }

                    }
                    textBox_print.Text += "\r\n";
                }
            }
            else if(num<=N)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (this.sub[i] == 0) continue;
                    textBox_print.Text += ("학생" + num.ToString() + "의");
                    if (i == 0) textBox_print.Text += "영어";
                    else if (i == 1) textBox_print.Text += "수학";
                    else textBox_print.Text += "국어";
                    textBox_print.Text += ("점수 : " + this.score[i][num].ToString() + "\r\n");
                }
            }
            else
            {
                textBox_print.Text = "Out Of Range!!!";
            }
            
        }
        private void checkBox_english_CheckedChanged(object sender, EventArgs e)
        {
            //textBox_print.Text += "1111\r\n";
            this.sub[0] = (this.sub[0]+1)%2;
        }
        private void checkBox_math_CheckedChanged(object sender, EventArgs e)
        {
            //textBox_print.Text += "2222\r\n";
            this.sub[1] = (this.sub[1] + 1) % 2;
        }
        private void checkBox_korean_CheckedChanged(object sender, EventArgs e)
        {
            //textBox_print.Text += "3333\r\n";
            this.sub[2] = (this.sub[2] + 1) % 2;
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

        private void LoadData()
        {
            // 2차원 배열 생성
            string[,] data = new string[,]
            {
                { "Alice", "30", "서울" },
                { "Bob", "25", "부산" },
                { "Charlie", "35", "대구" }
            };

            // DataGridView 초기화
            dataGridView1.ColumnCount = 4; // 열 수 설정
            dataGridView1.Columns[0].Name = "학생";
            dataGridView1.Columns[1].Name = "영어";
            dataGridView1.Columns[2].Name = "수학";
            dataGridView1.Columns[3].Name = "국어";
            // 배열의 데이터를 DataGridView에 추가
            for (int i = 1; i < N; i++)
            {
                string[] row = new string[4];
                row[0] = i.ToString();
                for (int j = 1; j <= 3; j++)
                {
                    row[j] = this.score[j-1][i].ToString();
                }
                dataGridView1.Rows.Add(row);
            }
        }

    }


}
